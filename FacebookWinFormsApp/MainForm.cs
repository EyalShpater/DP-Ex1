using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private readonly FaceBookManager r_FacebookManager;
        private const String k_AppID = "1828145884290754";
        private eMenuItem m_SelectedMenuItem;

        public MainForm()
        {
            InitializeComponent();
            r_FacebookManager = new FaceBookManager(k_AppID);
            FacebookService.s_CollectionLimit = 25;
            CustomizeButtons();
            makePictureBoxCircle(pictureBoxProfile);
        }

        private void makePictureBoxCircle(PictureBox i_PictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, i_PictureBox.Width, i_PictureBox.Height);
            i_PictureBox.Region = new Region(path);
        }

        private void CustomizeButtons()
        {
            buttonLogin.Font = new Font("Arial", 12, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.BackColor = Color.DarkGreen;

            // Customize the Logout button
            buttonLogout.Font = new Font("Arial", 12, FontStyle.Bold);
            buttonLogout.ForeColor = Color.White;
            buttonLogout.BackColor = SystemColors.Control;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");//todo ask guy

            if (r_FacebookManager.LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            try
            {
                r_FacebookManager.Login();

                if (string.IsNullOrEmpty(r_FacebookManager.LoginResult.ErrorMessage))
                {
                    buttonLogin.Text = $"Logged in as {r_FacebookManager.LoginResult.LoggedInUser.Name}";
                    buttonLogin.BackColor = Color.LightGreen;
                    pictureBoxProfile.ImageLocation = r_FacebookManager.LoginResult.LoggedInUser.PictureNormalURL;
                    buttonLogin.Enabled = false;
                    buttonLogout.Enabled = true;
                    r_FacebookManager.LoggedInUser = r_FacebookManager.LoginResult.LoggedInUser;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            r_FacebookManager.LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void buttonGeographicProximity_Click(object sender, EventArgs e)
        {
            fetchAndDisplayData();
        }

        private void fetchAndDisplayData()
        {
            //if (r_facebookManager.LoggedInUser != null)
            //{
            //    List<string> friendsName = GetFriendsName();

            //    foreach (string friendName in friendsName)
            //    {
            //        listBoxGeographicProximity.Items.Add(friendName);
            //    }
            //}
        }

        private List<string> GetFriendsName()
        {
            if (r_FacebookManager.LoggedInUser != null)
            {
                List<string> friendsName = GetFriendsName();

                foreach (User friend in r_FacebookManager.LoggedInUser.Friends)
                {
                    friendsName.Add(friend.Name);
                }

                return friendsName;
            }

            return new List<string>();
        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Albums;
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.LoggedInUser.Albums;
        }

        private void pagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Pages;
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.LoggedInUser.LikedPages;
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Groups;
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.LoggedInUser.Groups;
        }

        private void wallPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.WallPosts;
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.LoggedInUser.WallPosts;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_FacebookManager.LoggedInUser.PostStatus(richTextBoxNewPost.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBoxFacebookItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string imageUrl;

            switch (m_SelectedMenuItem)
            {
                case eMenuItem.Albums:
                    Album selectedAlbum = comboBoxFacebookItems.SelectedItem as Album;
                    r_FacebookManager.CurrentViewingAlbum = new AlbumManager(comboBoxFacebookItems.SelectedItem as Album);
                    imageUrl = r_FacebookManager.CurrentViewingAlbum.GetPictureAlbumURL();
                    chartLikesByMonth.Enabled = true;
                    LikesForPhotos.DisplayLikesByMonthBarChart(selectedAlbum, chartLikesByMonth);
                    break;
                case eMenuItem.Pages:
                    imageUrl = (comboBoxFacebookItems.SelectedItem as Page).PictureNormalURL;
                    break;
                case eMenuItem.Groups:
                    imageUrl = (comboBoxFacebookItems.SelectedItem as Group).PictureNormalURL;
                    break;
                //case eMenuItem.WallPosts:
                //    imageUrl = (comboBoxFacebookItems.SelectedItem as w).PictureAlbumURL;
                //    break;
                case eMenuItem.FriendsByMyLocation:
                    imageUrl = (comboBoxFacebookItems.SelectedItem as User).PictureNormalURL;
                    break;
                default:
                    imageUrl = null;    
                    break;
            }

            displaySelectedItem(imageUrl);
        }

        private void displaySelectedItem(string i_ImageUrl)
        {
            if (!string.IsNullOrEmpty(i_ImageUrl))
            {
                pictureBoxFacebookItem.LoadAsync(i_ImageUrl);
            }
            else
            {
                pictureBoxFacebookItem.Image = pictureBoxFacebookItem.ErrorImage;
            }
        }

        private void buttonDownloadAlbum_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderDialog.SelectedPath))
                {
                    MessageBox.Show("Selected path: " + folderDialog.SelectedPath, "Path Selected");
                    r_FacebookManager.CurrentViewingAlbum.DownloadAlbum(folderDialog.SelectedPath);
                    MessageBox.Show("Download has successfully finished!");
                }
                else
                {
                    MessageBox.Show("An Error Has Occured!");
                }
            }

        }

        private void buttonNextPhoto_Click(object sender, EventArgs e)
        {
            displaySelectedItem(r_FacebookManager.CurrentViewingAlbum.GetNextPhotoURL());
        }

        private void buttonPreviousPhoto_Click(object sender, EventArgs e)
        {
            displaySelectedItem(r_FacebookManager.CurrentViewingAlbum.GetPreviousPhotoURL());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxNewPost.Clear();
        }
    }
}

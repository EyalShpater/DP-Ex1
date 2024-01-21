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
        private bool menuExpand = true;
        private StatisticManager m_StatisticManager;

        public MainForm()
        {
            InitializeComponent();
            r_FacebookManager = new FaceBookManager(k_AppID);
            m_StatisticManager = new StatisticManager();
            FacebookService.s_CollectionLimit = 25;
            makePictureBoxCircle(pictureBoxProfile);
        }

        private void makePictureBoxCircle(PictureBox i_PictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, i_PictureBox.Width, i_PictureBox.Height);
            i_PictureBox.Region = new Region(path);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

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
            r_FacebookManager.LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
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
                    ;
                    imageUrl = (comboBoxFacebookItems.SelectedItem as Album).PictureAlbumURL;
                    break;
                case eMenuItem.Pages:
                    imageUrl = (comboBoxFacebookItems.SelectedItem as Page).PictureNormalURL;
                    break;
                case eMenuItem.Groups:
                    imageUrl = (comboBoxFacebookItems.SelectedItem as Group).PictureNormalURL;
                    break;
                default:
                    imageUrl = null;    
                    break;
            }

            displaySelectedItem(imageUrl);
        }

        private void changePostComponentVisibilty(bool i_Visible)
        {
            richTextBoxNewPost.Visible = i_Visible;
            pictureBoxProfile.Visible = i_Visible;
            buttonClear.Visible = i_Visible;
            buttonPost.Visible = i_Visible;
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

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                menu.Width -= 10;
                if (menu.Width <= 80)
                {
                    menuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                menu.Width += 10;
                if (menu.Width >= 170)
                {
                    menuExpand = true;
                    menuTransition.Stop();
                }
            }
        }

        private void buttonHamburger_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void albumsButton_Click(object sender, EventArgs e)
        {
            changeStatisticsComponentsVisibilty(false);
            changeAlbumsDownloadVisibility(true);
            changeChartVisibility(false);
            m_SelectedMenuItem = eMenuItem.Albums;
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.LoggedInUser.Albums;

        }

        private void changeAlbumsDownloadVisibility(bool i_Visible)
        {
            comboBoxFacebookItems.Visible = i_Visible;
            buttonDownloadAlbum.Visible = i_Visible;
            pictureBoxFacebookItem.Visible = i_Visible;
            buttonPreviousPhoto.Visible = i_Visible;
            buttonNextPhoto.Visible = i_Visible;
        }
        private void changeChartVisibility(bool i_Visible)
        {
            chartLikesByMonth.Visible = i_Visible;
        }

        private void pagesButton_Click(object sender, EventArgs e)
        {
            changeStatisticsComponentsVisibilty(false);
            m_SelectedMenuItem = eMenuItem.Pages;
            changeAlbumsDownloadVisibility(true);
            changeChartVisibility(false);
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.LoggedInUser.LikedPages;
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Groups;
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.LoggedInUser.Groups;

            changeStatisticsComponentsVisibilty(false);
            changeAlbumsDownloadVisibility(true);
            changeChartVisibility(false);
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Statistics;
            comboBoxForAlbum.DisplayMember = "Name";
            comboBoxForAlbum.DataSource = r_FacebookManager.LoggedInUser.Albums;

            changeAlbumsDownloadVisibility (false);
            changeChartVisibility(true);
            changeStatisticsComponentsVisibilty(true);
        }

        private void changeStatisticsComponentsVisibilty(bool i_Visible)
        {
            comboBoxForAlbum.Visible = i_Visible;
            mostLikedPictureLabel.Visible = i_Visible;
            mostLikedPic.Visible = i_Visible;
        }

        private void postsButton_Click(object sender, EventArgs e)
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

        private void ComboBoxForAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxForAlbum.SelectedItem is Album selectedAlbum)
            {
                r_FacebookManager.CurrentViewingAlbum = new AlbumManager(selectedAlbum);
                string imageUrl = r_FacebookManager.CurrentViewingAlbum.GetPictureAlbumURL();

                chartLikesByMonth.Enabled = true;
                LikesForPhotos.DisplayLikesByMonthBarChart(selectedAlbum, chartLikesByMonth);

                string mostLikedImageUrl = m_StatisticManager.findTheMostLikedImageInAlbum(r_FacebookManager.CurrentViewingAlbum);

                if (!string.IsNullOrEmpty(mostLikedImageUrl))
                {
                    mostLikedPic.LoadAsync(mostLikedImageUrl);
                }
                else
                {
                    mostLikedPic.Image = mostLikedPic.ErrorImage;
                }
            }
        }

    }
}
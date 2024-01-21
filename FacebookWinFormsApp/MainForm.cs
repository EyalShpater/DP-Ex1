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
using System.Collections.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private readonly FaceBookManager r_FacebookManager;
        private const string k_AppID = "1828145884290754";
        private static readonly eFormControlTag[] sr_DefaultFormComponents = { eFormControlTag.Header, eFormControlTag.Profile, eFormControlTag.Menu };
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
            menu.Enabled = false;
            panelProilePictureAndWritePost.Enabled = false;
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
                    buttonLogin.Text = $"Welcome {r_FacebookManager.LoginResult.LoggedInUser.Name}!";
                    buttonLogin.BackColor = Color.LightGreen;
                    buttonLogin.Image = null;
                    pictureBoxProfile.ImageLocation = r_FacebookManager.LoginResult.LoggedInUser.PictureNormalURL;
                    buttonLogin.Enabled = false;
                    buttonLogout.Enabled = true;
                    menu.Enabled = true;
                    panelProilePictureAndWritePost.Enabled = true;
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

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                string postedStatusId = r_FacebookManager.PostStatus(richTextBoxNewPost.Text);

                MessageBox.Show("Status Posted! ID: " + postedStatusId);
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
                    r_FacebookManager.SetCurrentViewingAlbum(comboBoxFacebookItems.SelectedItem as Album); //todo: to think how to do it better
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
            showMenuItemComponents(eFormControlTag.Pagination, eFormControlTag.Download, 
                eFormControlTag.MainPictureBox, eFormControlTag.MainComboBox, eFormControlTag.SortByComboBox);
            m_SelectedMenuItem = eMenuItem.Albums;
            setAlbumComboBoxes();

            if (comboBoxFacebookItems.Items.Count == 0)
            {
                MessageBox.Show("No albums to show :(");
            }
        }

        private void setAlbumComboBoxes()
        {
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.GetAlbums();

            comboBoxSortBy.DataSource = Enum.GetValues(typeof(eSortOption));
        }

        private void showMenuItemComponents(params eFormControlTag[] i_TagValues)
        {
            List<eFormControlTag> tagValues = new List<eFormControlTag>(i_TagValues);

            tagValues.AddRange(sr_DefaultFormComponents);
            foreach (Control control in Controls)
            {
                if (control.Tag != null && isControlMatchingTag(control.Tag.ToString(), tagValues.ToArray()))
                {
                    control.Visible = true;
                }
                else
                {
                    control.Visible = false;
                }
            }
        }

        private void pagesButton_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Pages;
            showMenuItemComponents(eFormControlTag.MainPictureBox, eFormControlTag.MainComboBox);
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.GetLikedPages();

            if (comboBoxFacebookItems.Items.Count == 0)
            {
                MessageBox.Show("No pages to show :(");
            }
        }

        private void groupsButton_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Groups;
            showMenuItemComponents(eFormControlTag.MainPictureBox, eFormControlTag.MainComboBox);
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_FacebookManager.GetGroups();

            if (comboBoxFacebookItems.Items.Count == 0)
            {
                MessageBox.Show("No groups to show :(");
            }
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.Statistics;
            showMenuItemComponents(eFormControlTag.MainChart, eFormControlTag.TopPictureLabel, 
                eFormControlTag.SmallPictureBox, eFormControlTag.TopCenterComboBox);
            comboBoxForAlbum.DisplayMember = "Name";
            comboBoxForAlbum.DataSource = r_FacebookManager.GetAlbums();
        }

        private void postsButton_Click(object sender, EventArgs e)
        {
            m_SelectedMenuItem = eMenuItem.WallPosts;
            showMenuItemComponents(eFormControlTag.PostsPanel);
            fetchPosts();
        }

        private void comboBoxForAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxForAlbum.SelectedItem is Album selectedAlbum)
            {
                r_FacebookManager.SetCurrentViewingAlbum(selectedAlbum);
                string imageUrl = r_FacebookManager.CurrentViewingAlbum.GetPictureAlbumURL();

                chartLikesByMonth.Enabled = true;
                LikesForPhotos.DisplayLikesByMonthBarChart(selectedAlbum, chartLikesByMonth);

                string mostLikedImageUrl = m_StatisticManager.findTheMostLikedImageInAlbum(selectedAlbum);

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

        private void fetchPosts()
        {
            FacebookObjectCollection<Post> allPosts = r_FacebookManager.GetPosts();

            listBoxPosts.Items.Clear();
            foreach (Post post in allPosts)
            {
                if (post.Message != null)
                {
                    listBoxPosts.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    listBoxPosts.Items.Add(post.Caption);
                }
                else
                {
                    listBoxPosts.Items.Add(string.Format("[{0}]", post.Type));
                }
            }

            if (listBoxPosts.Items.Count == 0)
            {
                MessageBox.Show("No Posts to retrieve :(");
            }
        }

        private void makePictureBoxCircle(PictureBox i_PictureBox)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, i_PictureBox.Width, i_PictureBox.Height);
            i_PictureBox.Region = new Region(path);
        }

        private bool isControlMatchingTag(string i_ControlTag, params eFormControlTag[] i_TagValues)
        {
            bool isMatch = false;

            if (i_ControlTag != null)
            {
                foreach (eFormControlTag tagValue in i_TagValues)
                {
                    if (string.Equals(i_ControlTag, tagValue.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        isMatch = true;
                    }
                }
            }

            return isMatch;
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSortBy.SelectedItem is eSortOption sortOption)
            {
                r_FacebookManager.CurrentViewingAlbum.SortAlbum(sortOption);
          
            } 
        }
    }
}
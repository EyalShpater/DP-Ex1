using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;

namespace BasicFacebookFeatures
{
    public partial class MainForm : Form
    {
        private const string k_AppId = "1828145884290754";
        private const int k_CollectionLimit = 25;
        private readonly FacebookManager r_FacebookManager;
        private static readonly eFormControlTag[] sr_DefaultFormComponents = { eFormControlTag.Header, eFormControlTag.Profile, eFormControlTag.Menu };
        private eMenuItem m_SelectedMenuItem;
        private bool m_IsMenuExpand = true;

        public MainForm()
        {
            InitializeComponent();
            r_FacebookManager = new FacebookManager(k_AppId);
            FacebookService.s_CollectionLimit = k_CollectionLimit;
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
                    buttonLogin.BackColor = Color.LightBlue;
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
                    r_FacebookManager.AlbumManager.DownloadAlbum(folderDialog.SelectedPath);
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
            displaySelectedItem(r_FacebookManager.AlbumManager.GetNextPhotoUrl());
        }

        private void buttonPreviousPhoto_Click(object sender, EventArgs e)
        {
            displaySelectedItem(r_FacebookManager.AlbumManager.GetPreviousPhotoUrl());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBoxNewPost.Clear();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (m_IsMenuExpand)
            {
                menu.Width -= 10;
                if (menu.Width <= 80)
                {
                    m_IsMenuExpand = false;
                    menuTransition.Stop();
                }
            }
            else
            {
                menu.Width += 10;
                if (menu.Width >= 170)
                {
                    m_IsMenuExpand = true;
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
                eFormControlTag.MainPictureBox, eFormControlTag.MainComboBox, eFormControlTag.SortBy);
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
                chartLikesByMonth.Enabled = true;
                displayLikesByMonthBarChart(selectedAlbum, chartLikesByMonth);

                string mostLikedImageUrl = r_FacebookManager.AlbumManager.FindTheMostLikedImageInAlbum(selectedAlbum);

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
                r_FacebookManager.AlbumManager.SortAlbum(sortOption);
          
            } 
        }

        private void displayLikesByMonthBarChart(Album i_Album, Chart io_ChartLikesByMonth)
        {
            io_ChartLikesByMonth.Series.Clear();

            IEnumerable<IGrouping<int, Photo>> groupedPhotos = i_Album.Photos
                .Where(photo => photo.CreatedTime != null)
                .GroupBy(photo => photo.CreatedTime.Value.Month);
            IEnumerable<object> likesByMonth = groupedPhotos
                .Select(group => new { Month = group.Key, TotalLikes = group.Sum(photo => photo.LikedBy.Count) })
                .OrderBy(item => item.Month)
                .ToList();
            Series series = io_ChartLikesByMonth.Series.Add($"{i_Album.Name} - Likes by Month");

            foreach (object dataPoint in likesByMonth)
            {
                int month = (int)dataPoint.GetType().GetProperty("Month").GetValue(dataPoint);
                int totalLikes = (int)dataPoint.GetType().GetProperty("TotalLikes").GetValue(dataPoint);

                series.Points.AddXY(getMonthName(month), totalLikes);
            }

            initialChart(io_ChartLikesByMonth);
        }

        private void initialChart(Chart o_ChartLikes)
        {
            o_ChartLikes.ChartAreas[0].AxisX.Interval = 1;
            o_ChartLikes.ChartAreas[0].AxisY.Title = "Number of Likes";
            o_ChartLikes.ChartAreas[0].AxisX.Title = "Months";
            o_ChartLikes.ChartAreas[0].RecalculateAxesScale();
        }

        private string getMonthName(int i_MonthNumber)
        {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i_MonthNumber);
        }
    }
}
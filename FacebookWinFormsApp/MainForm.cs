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
        private readonly FaceBookManager r_facebookManager;
        private const String k_AppID = "1828145884290754";

        public MainForm()
        {
            InitializeComponent();
            r_facebookManager = new FaceBookManager(k_AppID);
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
            Clipboard.SetText("design.patterns");

            if (r_facebookManager.LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            r_facebookManager.Login();

            if (string.IsNullOrEmpty(r_facebookManager.LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {r_facebookManager.LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = r_facebookManager.LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                r_facebookManager.LoggedInUser = r_facebookManager.LoginResult.LoggedInUser;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            r_facebookManager.LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void listBoxPageLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Page selectedPage = listBoxPageLikes.SelectedItem as Page;
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
            if (r_facebookManager.LoggedInUser != null)
            {
                List<string> friendsName = GetFriendsName();

                foreach (User friend in r_facebookManager.LoggedInUser.Friends)
                {
                    friendsName.Add(friend.Name);
                }

                return friendsName;
            }

            return new List<string>();
        }

        private void albumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_facebookManager.LoggedInUser.Albums;
        }

        private void pagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_facebookManager.LoggedInUser.LikedPages;
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_facebookManager.LoggedInUser.Groups;
        }

        private void wallPostsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxFacebookItems.DisplayMember = "Name";
            comboBoxFacebookItems.DataSource = r_facebookManager.LoggedInUser.WallPosts;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            try
            {
                Status postedStatus = r_facebookManager.LoggedInUser.PostStatus(richTextBoxStatus.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        FacebookWrapper.ObjectModel.User m_LoggedInUser;
        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;

            CustomizeButtons();
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

        FacebookWrapper.LoginResult m_LoginResult;

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("design.patterns");

            if (m_LoginResult == null)
            {
                login();
            }
        }

        private void login()
        {
            m_LoginResult = FacebookService.Login(
                /// (This is Desig Patter's App ID. replace it with your own)
                "1828145884290754",
                /// requested permissions:
                "email",
                "public_profile",
                "user_photos",
                "user_likes",
                "user_gender",
                //"user_show_list",
                "user_friends"
                //"friends_location"
                );

            if (string.IsNullOrEmpty(m_LoginResult.ErrorMessage))
            {
                buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
                buttonLogin.BackColor = Color.LightGreen;
                pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
                buttonLogin.Enabled = false;
                buttonLogout.Enabled = true;
                m_LoggedInUser = m_LoginResult.LoggedInUser;
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            buttonLogout.Enabled = false;
        }

        private void buttonFetchData_Click(object sender, EventArgs e)
        {
            listBoxAlbums.DisplayMember = "Name";
            listBoxAlbums.DataSource = m_LoggedInUser.Albums;
            listBoxPageLikes.DisplayMember = "Name";
            listBoxPageLikes.DataSource = m_LoggedInUser.LikedPages;
            listBoxGroups.DisplayMember = "Name";
            listBoxGroups.DataSource = m_LoggedInUser.Groups;
        }

        private void listBoxPageLikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Page selectedPage = listBoxPageLikes.SelectedItem as Page;
        }

        private void buttonGeographicProximity_Click(object sender, EventArgs e)
        {
            fetchAndDisplayData();
        }

        private void fetchAndDisplayData()
        {
            if (m_LoggedInUser != null)
            {
                List<string> friendsName = GetFriendsName();

                foreach (string friendName in friendsName)
                {
                    listBoxGeographicProximity.Items.Add(friendName);
                }
            }
        }

        private List<string> GetFriendsName()
        {
            if (m_LoggedInUser != null)
            {
                List<string> friendsName = GetFriendsName();

                foreach (User friend in m_LoggedInUser.Friends)
                {
                    friendsName.Add(friend.Name);
                }

                return friendsName;
            }

            return new List<string>();
        }
    }
}

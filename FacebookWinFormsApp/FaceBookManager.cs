using CefSharp.DevTools.Network;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Drawing;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class FaceBookManager
    {
        private readonly String r_AppID;
        public User LoggedInUser { get; set; }
        public LoginResult LoginResult { get; set; }

        public FaceBookManager(String i_AppID)
        {
            r_AppID = i_AppID;
        }

        public void Login()
        {
            LoginResult = FacebookService.Login(
                r_AppID,
                "email",
                "public_profile",
                "user_photos",
                "user_likes",
                "user_gender",
                "user_posts",
                //"group_show_list",
                "user_friends"
                //"friends_location"
                );
        }

        public List<string> GetFriendsName()
        {
            if (LoggedInUser != null)
            {
                List<string> friendsName = GetFriendsName();

                foreach (User friend in LoggedInUser.Friends)
                {
                    friendsName.Add(friend.Name);
                }

                return friendsName;
            }

            return new List<string>();
        }
    }
}

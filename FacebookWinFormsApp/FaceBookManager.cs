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
        private readonly string r_AppID;
        private User m_LoggedInUser;
        public LoginResult LoginResult { get; set; }
        public AlbumManager CurrentViewingAlbum { get; private set; }

        public FaceBookManager(string i_AppID)
        {
            r_AppID = i_AppID;
            CurrentViewingAlbum = new AlbumManager();
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

            if (string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoginResult = null;
                throw new Exception("Failed to login");
            }

            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                m_LoggedInUser = LoginResult.LoggedInUser;
            }
        }

        public List<string> GetFriendsName()
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

        public List<Photo> GetPhotosFromAlbum(Album i_SelectedAlbum)
        {
            if (i_SelectedAlbum != null)
            {
                return i_SelectedAlbum.Photos.ToList();
            }

            return new List<Photo>();
        }

        public string PostStatus(string i_Status)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(i_Status);

            return postedStatus.Id;
        }

        public void SetCurrentViewingAlbum(Album i_Album)
        {
            CurrentViewingAlbum.Album = i_Album;
        }

        public FacebookObjectCollection<Album> GetAlbums()
        {
            return m_LoggedInUser.Albums;
        }

        public FacebookObjectCollection<Page> GetLikedPages()
        {
            return m_LoggedInUser.LikedPages;
        }

        public FacebookObjectCollection<Group> GetGroups() 
        {
            return m_LoggedInUser.Groups;
        }

        public FacebookObjectCollection<Post> GetPosts()
        {
            return m_LoggedInUser.Posts;
        }
    }
}

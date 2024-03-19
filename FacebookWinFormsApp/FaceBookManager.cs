using System;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FacebookManager 
    {
        private readonly string r_AppId;
        private User m_LoggedInUser;
        public LoginResult LoginResult { get; set; }
        public AlbumManager AlbumManager { get; }
        private List<ILoginObserver> m_Observers = new List<ILoginObserver>();

        public FacebookManager(string i_AppId)
        {
            r_AppId = i_AppId;
            AlbumManager = AlbumManager.Instance;
        }

        public void RegisterObserver(ILoginObserver i_Observer)
        {
            m_Observers.Add(i_Observer);
        }

        public void RemoveObserver(ILoginObserver i_Observer)
        {
            m_Observers.Remove(i_Observer);
        }

        private void NotifyObservers(bool i_IsLoggedIn)
        {
            foreach (ILoginObserver observer in m_Observers)
            {
                observer.UpdateLoginStatus(i_IsLoggedIn);
            }
        }

        public void Login()
        {
            LoginResult = FacebookService.Login(
                r_AppId,
                "email",
                "public_profile",
                "user_photos",
                "user_likes",
                "user_gender",
                "user_posts",
                "user_friends");

            if (string.IsNullOrEmpty(LoginResult.AccessToken))
            {
                LoginResult = null;
                throw new Exception("Failed to login");
            }

            if (string.IsNullOrEmpty(LoginResult.ErrorMessage))
            {
                m_LoggedInUser = LoginResult.LoggedInUser;
                NotifyObservers(true);
            }
        }

        public string PostStatus(string i_Status)
        {
            Status postedStatus = m_LoggedInUser.PostStatus(i_Status);

            return postedStatus.Id;
        }

        public void SetCurrentViewingAlbum(Album i_Album)
        {
            AlbumManager.Album = i_Album;
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
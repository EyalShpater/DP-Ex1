using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumManager
    {
        private FacebookObjectCollection<Photo> m_Photos; 
        private Album m_Album;
        private eSortOption m_SortOption = eSortOption.Likes;
        private int m_CurrentImageIndex = 0;

        public Album Album
        {
            get
            {
                return m_Album;
            }
            set
            {
                m_Album = value;
                m_CurrentImageIndex = 0;
                m_Photos = m_Album.Photos;
                SortAlbum(m_SortOption);
            }
        }

        public string GetPictureAlbumUrl()
        {
            return m_Album.PictureAlbumURL;
        }

        public string GetNextPhotoUrl()
        {
            m_CurrentImageIndex = (m_CurrentImageIndex + 1) % m_Album.Photos.Count;

            return m_Photos.ElementAt(m_CurrentImageIndex).PictureNormalURL;
        }

        public string GetPreviousPhotoUrl()
        {
            m_CurrentImageIndex = m_CurrentImageIndex == 0 ?
                m_Album.Photos.Count - 1 : m_CurrentImageIndex - 1;

            return m_Photos.ElementAt(m_CurrentImageIndex).PictureNormalURL;
        }

        public void DownloadAlbum(string i_Path)
        {
            int index = 1;
            string albumPath = Path.Combine(i_Path, m_Album.Name);
            
            Directory.CreateDirectory(albumPath);
            foreach (Photo photo in m_Photos)
            {
                string fileName = $"{index}_{photo.Name}.jpg";

                try
                {
                    downloadPhoto(photo.PictureNormalURL, Path.Combine(albumPath, fileName));
                }
                catch (Exception ignored) 
                {
                    MessageBox.Show(ignored.Message);
                }
            
                index++;
            }
        }

        public void SortAlbum(eSortOption i_SortOption)
        {
            if(i_SortOption != m_SortOption)
            {
                switch(i_SortOption)
                {
                    case eSortOption.Likes:
                        m_Photos.OrderBy(photo => photo.LikedBy.Count);
                        break;
                    case eSortOption.Comments:
                        m_Photos.OrderBy(photo => photo.Comments.Count);
                        break;
                    default:
                        m_Photos.OrderBy(photo => photo.CreatedTime);
                        break;
                }

                m_SortOption = i_SortOption;
                m_CurrentImageIndex = 0;
            }
        }

        public string FindTheMostLikedImageInAlbum(Album i_CurrentViewingAlbum)
        {
            Photo mostLovedPhoto = findMostLovedPhoto(i_CurrentViewingAlbum);
            string mostLovedUrl = string.Empty;

            if (mostLovedPhoto != null)
            {
                mostLovedUrl = mostLovedPhoto.PictureNormalURL;
            }

            return mostLovedUrl;
        }

        private Photo findMostLovedPhoto(Album i_Album)
        {
            return i_Album.Photos
                .Where(photo => photo.LikedBy.Count > 0)
                .OrderByDescending(photo => photo.LikedBy.Count)
                .FirstOrDefault();
        }

        private void downloadPhoto(string i_PhotoUrl, string i_Destination)
        {
            using (WebClient client = new WebClient())
            { 
                client.DownloadFile(i_PhotoUrl, i_Destination);
            }
        }
    }
}

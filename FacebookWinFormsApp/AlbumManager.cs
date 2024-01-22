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
        private eSortOption m_SortOption;
        private int m_CurrentImageIndex;

        public AlbumManager(Album i_Album)
        {
            m_Album = i_Album;
            m_Photos = m_Album.Photos;
            m_CurrentImageIndex = 0;
            m_SortOption = eSortOption.Date;
        }

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
                SortAlbum(m_SortOption);
            }
        }

        public string GetPictureAlbumURL()
        {
            return m_Album.PictureAlbumURL;
        }

        public string GetNextPhotoURL()
        {
            m_CurrentImageIndex = (m_CurrentImageIndex + 1) % m_Album.Photos.Count;

            return m_Photos.ElementAt(m_CurrentImageIndex).PictureNormalURL;
        }

        public string GetPreviousPhotoURL()
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
            switch (i_SortOption)
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

        private void downloadPhoto(string i_PhotoURL, string i_Destination)
        {
            using (WebClient client = new WebClient())
            { 
                client.DownloadFile(i_PhotoURL, i_Destination);
            }
        }
    }
}

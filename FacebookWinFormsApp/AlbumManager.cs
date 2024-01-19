using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class AlbumManager
    {
        private Album m_Album;
        private FacebookObjectCollection<Photo> m_Photos; 
        private int m_CurrentImageIndex;
       
        public AlbumManager(Album i_Album)
        {
            m_Album = i_Album;
            m_Photos = m_Album.Photos;
            m_CurrentImageIndex = 0;
        }


        public string GetNextPhotoURL()
        {
            m_CurrentImageIndex = (m_CurrentImageIndex + 1) % m_Album.Photos.Count;

            return m_Photos.ElementAt(m_CurrentImageIndex).URL;
        }

        public string GetPreviousPhotoURL()
        {
            m_CurrentImageIndex = (m_CurrentImageIndex - 1) % m_Album.Photos.Count;

            return m_Photos.ElementAt(m_CurrentImageIndex).URL;
        }

        public void DownloadAlbum(string i_Path)
        {
            int index = 1;

            foreach (Photo photo in m_Photos)
            {
                string fileName = $"{index}_{photo.Name}.jpg";

                try
                {
                    downloadPhoto(fileName, i_Path);
                }
                catch (Exception ignored) 
                { 

                }
            
                index++;
            }
        }

        public void SortAlbum(eSortOption i_SortOption)
        {
            switch (i_SortOption)
            {
                case eSortOption.ByLikesAmount:
                    m_Photos.OrderBy(photo => photo.LikedBy.Count);
                    break;
                case eSortOption.ByCommentsAmount:
                    m_Photos.OrderBy(photo => photo.Comments.Count); 
                    break;
                default:
                    m_Photos.OrderBy(photo => photo.CreatedTime);
                    break;
            }
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

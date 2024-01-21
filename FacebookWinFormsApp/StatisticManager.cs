using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class StatisticManager
    {
        internal string findTheMostLikedImageInAlbum(Album currentViewingAlbum)
        {
            Photo mostLovedPhoto = findMostLovedPhoto(currentViewingAlbum);

            if (mostLovedPhoto != null)
            {
                return mostLovedPhoto.PictureNormalURL;
            }
            return null;
        }
        private Photo findMostLovedPhoto(Album i_Album)
        {
            return i_Album.Photos
                .Where(photo => photo.LikedBy.Count > 0)
                .OrderByDescending(photo => photo.LikedBy.Count)
                .FirstOrDefault();
        }
    }
}

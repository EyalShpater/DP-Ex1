using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    internal class MostLovedPhoto
    {
        internal static void DisplayMostLovedPhoto(Album io_Album)
        {
            if (io_Album == null)
            {
                throw new ArgumentNullException(nameof(io_Album));
            }

            Photo mostLovedPhoto = findMostLovedPhoto(io_Album);

            if (mostLovedPhoto != null)
            {
                Console.WriteLine($"Most Loved Photo in {io_Album.Name}: {mostLovedPhoto.PictureNormalURL}");
            }
            else
            {
                Console.WriteLine($"No photos found in {io_Album.Name}");
            }
        }

        private static Photo findMostLovedPhoto(Album io_Album)
        {
            return io_Album.Photos
                .Where(photo => photo.LikedBy.Count > 0)
                .OrderByDescending(photo => photo.LikedBy.Count)
                .FirstOrDefault();
        }
    }
}
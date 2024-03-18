using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.SortStrategy
{
    public class SortByComments : ISortStrategy
    {
        public void SortAlbum(Album i_Album)
        {
            i_Album.Photos.OrderBy(photo => photo.Comments.Count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures.SortStrategy
{
    public class SortByCreateTime : ISortStrategy
    {
        public void SortAlbum(Album i_Album)
        {
            i_Album.Photos.OrderBy(photo => photo.CreatedTime);
        }
    }
}

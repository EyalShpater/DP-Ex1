using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public class DownloadAlbumAdapter : IOneParameterThreadAdapter
    {
        public string Path { get; set; }
        public AlbumManager AlbumManager { get; set; }

        public void Invoke()
        {
            AlbumManager.DownloadAlbum(Path);
        }
    }
}

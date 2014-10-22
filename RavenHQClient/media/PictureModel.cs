using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RavenHQClient.media
{
    public partial class PictureModel 
    {
        public string ImageUrl { get; set; }
        public string FullSizeImageUrl { get; set; }
        public string Title { get; set; }
        public string AlternateText { get; set; }

    }
}

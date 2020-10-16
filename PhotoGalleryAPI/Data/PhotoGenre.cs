using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoGalleryAPI.Data
{
    public class PhotoGenre:MinervaDTO.PhotoGenre
    {
        public virtual ICollection<PhotoGallery> Genres { get; set; }
    }
}

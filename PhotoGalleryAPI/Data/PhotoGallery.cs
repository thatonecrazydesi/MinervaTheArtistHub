using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoGalleryAPI.Data
{
    public class PhotoGallery
    {
        public int PhotoID { get; set; }
        public Photo Photo { get; set; }

        public int GenreID { get; set; }

        public PhotoGenre Genre { get; set; }
    }
}

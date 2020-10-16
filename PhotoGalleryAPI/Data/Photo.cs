using MinervaDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoGalleryAPI.Data
{
    public class Photo: MinervaDTO.Photo
    {
        public virtual ICollection<PhotoGallery> Photos { get; set; }

    }
}

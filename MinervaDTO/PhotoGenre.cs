using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MinervaDTO
{
    public class PhotoGenre
    {
        [Key]
        public int PhotoGenreID { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
    }
}

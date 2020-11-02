using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserAuth.Areas.Identity.Data;

namespace UserAuth.Models
{
    public class Photos
    {
        [Key]
        public int PhotoID { get; set; }
        [Required]
        public string PhotoName { get; set; }
        
        [Required]
        public string Description { get; set; }

        [Required]
        public byte[] Image { get; set; }
        public DateTime Timestamp { get; set; }

        [Required]
        public string UserName { get; set; }
        public string UserId { get; set; }
        public virtual MinervaUser MinervaUser { get; set; }

        public Photos()
        {
            Timestamp = DateTime.Now;
        }
    }
}

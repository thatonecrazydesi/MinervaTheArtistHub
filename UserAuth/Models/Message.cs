using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserAuth.Areas.Identity.Data;

namespace UserAuth.Models
{
    public class Message
    {
        [Key]
        public int ChatID { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Text { get; set; }

        public DateTime Timestamp { get; set; }

        public string UserId { get; set; }
        public virtual MinervaUser MinervaUser { get; set; }
    }
}

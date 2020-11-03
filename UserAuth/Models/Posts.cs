using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using UserAuth.Areas.Identity.Data;

namespace UserAuth.Models
{
    public class Posts
    {
        [Key]
        public int PostId { get; set; }
        [Display(Name ="Post Title")]
        public string PostName { get; set; }

        [Display(Name = "Post Description")]
        public string PostDescription { get; set; }

        [Display(Name = "Post Content")]
        public string Content { get; set; }

        public string UserName { get; set; }
        public string UserId { get; set; }
        public virtual MinervaUser MinervaUser { get; set; }
        
        public DateTime TimeStamp { get; set; }

        public Posts()
        {
            TimeStamp = DateTime.Now;
            
        }
    }
}

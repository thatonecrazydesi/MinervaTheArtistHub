using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ForumApp.Models
{
    public class Post
    {
        public int PostID { get; set; }

        [Display(Name ="Post Title")]
        public string PostName { get; set; }

        [Display(Name ="Type")]
        public string PostCategory { get; set; }//will be foreign key (drop down box)

        [Display(Name ="PostContent")]
        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }
        public int UserID { get; set; }//will be foreign key

        public Post()
        {
            TimeStamp = DateTime.Now;//Creates Time stamp
        }
    }
   
}

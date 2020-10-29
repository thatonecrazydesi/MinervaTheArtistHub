using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using UserAuth.Models;

namespace UserAuth.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MinervaUser class
    //Columns will be added to preexisting database upon migration
    public class MinervaUser : IdentityUser
    {
        [Required]
        [PersonalData]
        [Column(TypeName ="varchar(20)")]
        public string FName { get; set; }//controller will provide the parameters: no symbols, no spaces etc.

        [Required]
        [PersonalData]
        [Column(TypeName = "varchar(20)")]
        public string LName { get; set; }//controller will provide the parameters: no symbols, no spaces etc.

        [Required]
        [PersonalData]
        [Column(TypeName = "varchar(20)")]
        public string LocationState { get; set; }

        [Required]
        [PersonalData]
        [Column(TypeName = "varchar(40)")]
        public string LocationCity { get; set; }

        public byte[] ProfileImage { get; set; }

        
        // 1 to many Messages
        public virtual ICollection<ChatRoom> Messages { get; set; }
        
       public MinervaUser()
            {
                Messages = new HashSet<ChatRoom>();
            }
        //1 to many forums

        //1 to many pictures

        







    }
}

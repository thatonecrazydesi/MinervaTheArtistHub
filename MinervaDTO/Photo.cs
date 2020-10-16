using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinervaDTO
{
    public class Photo
    {
        [Key]
        public int PhotoID { get; set; }
        public string PhotoName { get; set; }
        public string PhotoDescription { get; set; }
        
        public string PhotoGenre { get; set; }//foreignKey=>dbo.PhotoGenre
       
        public string UserID { get; set; }//ForeignKey => dbo.UserAuth
        

         
       
    }
}

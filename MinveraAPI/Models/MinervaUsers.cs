using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MinveraAPI.Models
{
    public class MinervaUsers
    {
        [Key]
        public int userId { get; set; }
        [Required]
        [StringLength(100)]
        public string FName { get; set; }
        [Required]
        [StringLength(100)]
        public string LName { get; set; }
        [Required]
        [StringLength(150)]
        public string Email { get; set; }
    }
}

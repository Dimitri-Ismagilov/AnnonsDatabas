using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonsDatabas.Repository.Entities
{
    public class AppUser
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(20)]
        public string Login { get; set; }

        [Required]
        [StringLength(15)]
        public string Password { get; set; }


        public virtual ICollection<Advertisement> Advertisements { get; set; }

    }
}

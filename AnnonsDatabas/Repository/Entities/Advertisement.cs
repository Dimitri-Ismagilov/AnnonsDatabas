using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonsDatabas.Repository.Entities
{
    public class Advertisement
    {
        [Key]
        public int AdvertisementID { get; set; }

        [Required]
        [StringLength(50)]
        public string AdvertisementTitle { get; set; }

        [Required]
        [StringLength(2000)]
        public string AdvertisementDescription { get; set; }

        [Required]
        public decimal Price { get; set; }

        public DateTime PublishedTime { get; set; }

        [Required]
        public int UserID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public virtual AppUser User { get; set; }
        public virtual Category Categorie { get; set; }


    }
}

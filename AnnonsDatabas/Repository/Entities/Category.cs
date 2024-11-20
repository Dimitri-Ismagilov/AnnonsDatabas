using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnonsDatabas.Repository.Entities
{
    public class Category
    {
        [Key]
        [Required]
        public int? CategoryID { get; set; }

        [Required]
        [StringLength(100)]
        public string CategoryName { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }

    }
}

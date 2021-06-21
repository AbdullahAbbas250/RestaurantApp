using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models
{
    public class subCategory
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name = "Sub Category Name")]
        public string name { get; set; }

        [Display(Name = " Category ")]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
       
        public virtual Category category { get; set; }

    }
}

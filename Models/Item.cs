using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models
{
    public class MenuItem
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        public double price { get; set; }
        public string image { get; set; }
        public string description { get; set; }
        public string spicyness { get; set; }
        public enum Espicy { NA=0 , notspicy = 1 , spicy = 2 , veryspicy = 3  }
        public int subCategoryId  { get; set; }
        [ForeignKey("subCategoryId")]
        public subCategory subCategory { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public  Category Category { get; set; }

    }
}

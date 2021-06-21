using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models
{
    public class ShoppingCard
    {
        public ShoppingCard()
        {
            Count = 1;
        }
        [Key]
        public int id { get; set; }
        public string AppUserId  { get; set; }
        [NotMapped]
        [ForeignKey("AppUserId")]
        public virtual AppUser AppUser { get; set; }
     
        public int MenuItemId { get; set; }
        [NotMapped]
        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="Please Enter Value Greater Than 1 ")]
        public int Count  { get; set; }

    }
}

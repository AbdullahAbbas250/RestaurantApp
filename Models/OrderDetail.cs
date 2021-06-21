using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models
{
    public class OrderDetail
    {
        [Key]
        public int id  { get; set; }
      
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual OrderHeader orderHeader { get; set; }
        public int itemId { get; set; }
        [ForeignKey("itemId")]
        public virtual MenuItem MenuItem { get; set; }
        public int count { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }



    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models
{
    public class Coupon
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string CouponType { get; set; }
        public enum ECouponType { percent=0,Doller=1 }
        [Required]
        [Display(Name = "Discount")]
        public double Discount { get; set; }

        [Display(Name ="Minimum Amount")]
        public double minAmount { get; set; }
        //public byte[] picture { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; }

    }
}

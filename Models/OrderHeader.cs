using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models
{
    public class OrderHeader
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string userId { get; set; }
        [ForeignKey("userId")]
        public virtual AppUser appUser { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public double OrderTotal { get; set; }
        [Required]
        [DisplayFormat(DataFormatString ="{0:c}")]
        public double OrderAfterDiscount { get; set; }
        [Required]
        [Display(Name = "PickUp Time")]
        public DateTime PickUpTime { get; set; }
        [NotMapped]
        [Required]
        public DateTime PickUpDate { get; set; }
        [Display(Name = "Coupon Code")]
        public string CouponCode { get; set; }
        public double CouponCodeDiscount { get; set; }
        public string  status { get; set; }
        public string PaymentStatus { get; set; }
        public string  Comment { get; set; }
        [Display(Name = "PickUp Name")]
        public string PickUpName { get; set; }
        [Display(Name = "Phon eNumber")]
        public string  PhoneNumber { get; set; }
        public string TransactionId { get; set; }


    }
}

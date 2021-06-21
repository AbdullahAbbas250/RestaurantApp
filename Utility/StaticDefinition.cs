using QadduraResturant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Utility
{
    public static class StaticDefinition
    {
        public const string ManagerUser           = "Manager";
        public const string KitchenUser           = "Kitchen";
        public const string FrontDeskUser         = "Front Desk";
        public const string CustomerUser          = "Customer";
        public const string ShoppingCartCount     = "ShoppingCartCount";
        public const string SessionCouponCode     = "CouponCode";
                                                  
        public const string statusSubmitted       = "Submitted";
        public const string StatusInProccess      = "Begin Prepared";
        public const string statusReady           = "Ready For Pickup";
        public const string statusCancelled        = "Cancelled";
        public const string statusCompleted       = "Completed";

        public const string PaymentStatusPending  = "Pending";
        public const string PaymentStatusApprove  = "Approve";
        public const string PaymentStatusRejected = "Rejected";





        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;

            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
        public static double DiscountPrice(Coupon coupon , double TotalOrder)
        {
            if (coupon == null)
                return Math.Round(TotalOrder, 2);
            else
            {
               if( coupon.minAmount > TotalOrder)
                {
                    return Math.Round(TotalOrder, 2);
                }
               else
                {
                    if(int.Parse(coupon.CouponType) == (int)Coupon.ECouponType.Doller)
                    {
                        return Math.Round(TotalOrder - coupon.Discount, 2);
                    }
                    else
                    {
                        return Math.Round(TotalOrder - (TotalOrder * (coupon.Discount/100)), 2);
                    }
                }
            }
        }

    }
}

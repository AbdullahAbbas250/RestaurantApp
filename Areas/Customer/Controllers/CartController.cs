using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QadduraResturant.Data;
using QadduraResturant.Models;
using QadduraResturant.Models.ViewModel;
using QadduraResturant.Utility;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
namespace QadduraResturant.Areas.Customer
{
    [Area("Customer")]
    [Authorize]
    public class CartController : Controller
    {
        private readonly ApplicationDbContext db;
        public CartController(ApplicationDbContext db)
        {
            this.db = db;
        }
        [BindProperty]
        public Order_Shopping Order_Shopping { get; set; }

        public IActionResult Index()
        {
            Order_Shopping = new Order_Shopping()
            {
                OrderHeader = new OrderHeader()
            };
            Order_Shopping.OrderHeader.OrderAfterDiscount = 0;
            var CurrentUser = (ClaimsIdentity)User.Identity;
            var claims = CurrentUser.FindFirst(ClaimTypes.NameIdentifier);
            var userId = claims.Value;

            var shoppingCart = db.ShoppingCard.Where(m => m.AppUserId == userId);
            if(shoppingCart !=null)
            {
                Order_Shopping.ShoppingCardList = shoppingCart.ToList();
            }

            foreach (var item in Order_Shopping.ShoppingCardList)
            {
                item.MenuItem = db.MenuItem.FirstOrDefault(m => m.id == item.MenuItemId);
                Order_Shopping.OrderHeader.OrderAfterDiscount += item.MenuItem.price * item.Count;
                Order_Shopping.OrderHeader.OrderAfterDiscount = Math.Round(Order_Shopping.OrderHeader.OrderAfterDiscount , 2);
                item.MenuItem.description = StaticDefinition.ConvertToRawHtml(item.MenuItem.description);
            
                if(item.MenuItem.description.Length > 75)
                {
                    item.MenuItem.description = item.MenuItem.description.Substring(0, 74);
                }
            
            }
            Order_Shopping.OrderHeader.OrderTotal =
                Order_Shopping.OrderHeader.OrderAfterDiscount;
            if(HttpContext.Session.GetString(StaticDefinition.SessionCouponCode) !=null)
            {
                Order_Shopping.OrderHeader.CouponCode = 
                    HttpContext.Session.GetString(StaticDefinition.SessionCouponCode);
                    var CouponFromDatabase = db.Coupon.Where( m => m.name.ToLower() ==
                                                                Order_Shopping
                                                                .OrderHeader.CouponCode
                                                                .ToLower())
                                                                .FirstOrDefault();
                Order_Shopping.OrderHeader.OrderAfterDiscount =
                        StaticDefinition.DiscountPrice(CouponFromDatabase,
                        Order_Shopping.OrderHeader.OrderTotal);
            
            }

            return View(Order_Shopping);
        }
        public IActionResult Summery()
        {
            Order_Shopping = new Order_Shopping()
            {
                OrderHeader = new OrderHeader()
            };
            Order_Shopping.OrderHeader.OrderAfterDiscount = 0;
           
            var CurrentUser = (ClaimsIdentity)User.Identity;
            var claims = CurrentUser.FindFirst(ClaimTypes.NameIdentifier);
            var userId = db.ApplicationUser.Find(claims.Value);

            Order_Shopping.OrderHeader.PickUpName = userId.Name;
            Order_Shopping.OrderHeader.PhoneNumber = userId.PhoneNumber;
            Order_Shopping.OrderHeader.PickUpDate = DateTime.Now;

            var shoppingCart = db.ShoppingCard.Where(m => m.AppUserId == userId.Id);
            if (shoppingCart != null)
            {
                Order_Shopping.ShoppingCardList = shoppingCart.ToList();
            }

            foreach (var item in Order_Shopping.ShoppingCardList)
            {
                item.MenuItem = db.MenuItem.FirstOrDefault(m => m.id == item.MenuItemId);
                Order_Shopping.OrderHeader.OrderAfterDiscount += item.MenuItem.price * item.Count;
                Order_Shopping.OrderHeader.OrderAfterDiscount = 
                    Math.Round(Order_Shopping.OrderHeader.OrderAfterDiscount, 2);

            }
            Order_Shopping.OrderHeader.OrderTotal = 
                Order_Shopping.OrderHeader.OrderAfterDiscount;
            if (HttpContext.Session.GetString(StaticDefinition.SessionCouponCode) != null)
            {
                Order_Shopping.OrderHeader.CouponCode =
                    HttpContext.Session.GetString(StaticDefinition.SessionCouponCode);
                var CouponFromDatabase = db.Coupon.Where(m => m.name.ToLower() ==
                                                           Order_Shopping
                                                           .OrderHeader.CouponCode
                                                           .ToLower())
                                                            .FirstOrDefault();
                Order_Shopping.OrderHeader.OrderAfterDiscount =
                        StaticDefinition.DiscountPrice(CouponFromDatabase,
                        Order_Shopping.OrderHeader.OrderTotal);

            }

            return View(Order_Shopping);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Summery")]
        public async Task<IActionResult> SummeryPost(string stripeToken)
        {
           
            var CurrentUser = (ClaimsIdentity)User.Identity;
            var claims = CurrentUser.FindFirst(ClaimTypes.NameIdentifier);
            //var userId = db.ApplicationUser.Find(claims.Value);

      

            Order_Shopping.ShoppingCardList = await db.ShoppingCard.
                Where(m => m.AppUserId == claims.Value).ToListAsync();
            Order_Shopping.OrderHeader.PaymentStatus = StaticDefinition.PaymentStatusPending;
            Order_Shopping.OrderHeader.OrderDate =DateTime.Now;
            Order_Shopping.OrderHeader.status = StaticDefinition.PaymentStatusPending;
            Order_Shopping.OrderHeader.userId = claims.Value;
            Order_Shopping.OrderHeader.PickUpTime = Convert.ToDateTime(Order_Shopping.
                                                    OrderHeader.PickUpDate.ToShortDateString()
                                                    +" "+
                                                    Order_Shopping.OrderHeader.PickUpTime.
                                                    ToLongTimeString());
            Order_Shopping.OrderHeader.OrderTotal =0;
            
            db.OrderHeaders.Add(Order_Shopping.OrderHeader);
            await db.SaveChangesAsync();


            foreach (var item in Order_Shopping.ShoppingCardList)
            {
                item.MenuItem = db.MenuItem.FirstOrDefault(m => m.id == item.MenuItemId);
                OrderDetail orderDetail = new OrderDetail()
                {
                    itemId = item.MenuItemId,
                    OrderId = Order_Shopping.OrderHeader.id,
                    Description = item.MenuItem.description,
                    Name = item.MenuItem.name,
                    Price = item.MenuItem.price,
                    count = item.Count
                };

                Order_Shopping.OrderHeader.OrderTotal += item.MenuItem.price * item.Count;
                //Order_Shopping.OrderHeader.OrderAfterDiscount =
                //    Math.Round(Order_Shopping.OrderHeader.OrderAfterDiscount, 2);
                db.OrderDetails.Add(orderDetail);

            }


            if (HttpContext.Session.GetString(StaticDefinition.SessionCouponCode) != null)
            {
                Order_Shopping.OrderHeader.CouponCode =
                    HttpContext.Session.GetString(StaticDefinition.SessionCouponCode);
                var CouponFromDatabase = db.Coupon.Where(m => m.name.ToLower() ==
                                                           Order_Shopping
                                                           .OrderHeader.CouponCode
                                                           .ToLower())
                                                            .FirstOrDefault();
                Order_Shopping.OrderHeader.OrderAfterDiscount =
                        StaticDefinition.DiscountPrice(CouponFromDatabase,
                        Order_Shopping.OrderHeader.OrderTotal);

            }
            else
            {
                Order_Shopping.OrderHeader.OrderAfterDiscount =
                    Math.Round( Order_Shopping.OrderHeader.OrderTotal,2);
            }
            Order_Shopping.OrderHeader.CouponCodeDiscount =
                 Order_Shopping.OrderHeader.OrderTotal - Order_Shopping.OrderHeader.OrderAfterDiscount;
            db.ShoppingCard.RemoveRange(Order_Shopping.ShoppingCardList);
            HttpContext.Session.SetInt32(StaticDefinition.ShoppingCartCount, 0);
            await db.SaveChangesAsync();
            var options = new Stripe.ChargeCreateOptions
            {
                Amount = Convert.ToInt32(Order_Shopping.OrderHeader.OrderAfterDiscount * 100) , 
                Currency = "USD" , 
                Description = "Order ID : "+Order_Shopping.OrderHeader.id,
                Source = stripeToken
            };

            var service = new ChargeService();
            Charge charge = service.Create(options);
            if(charge.BalanceTransactionId == null)
            {
                Order_Shopping.OrderHeader.PaymentStatus = StaticDefinition.PaymentStatusRejected;
            }
            else
            {
                Order_Shopping.OrderHeader.TransactionId = charge.BalanceTransactionId; ;
            }
            if(charge.Status.ToLower()=="succeeded")
            {
                Order_Shopping.OrderHeader.PaymentStatus = StaticDefinition.PaymentStatusApprove;
                Order_Shopping.OrderHeader.status = StaticDefinition.statusSubmitted;
            }
            else
            {
                Order_Shopping.OrderHeader.PaymentStatus = StaticDefinition.PaymentStatusRejected;
            }
            await db.SaveChangesAsync();


            // return RedirectToAction("Index" , "Home");
            return RedirectToAction("Confirm", "Order", new { id = Order_Shopping.OrderHeader.id });
        }


        public IActionResult ApplyCoupon()
        {
            if(Order_Shopping.OrderHeader.CouponCode == null)
            {
                Order_Shopping.OrderHeader.CouponCode = "";
            }
            HttpContext.Session.SetString(StaticDefinition.SessionCouponCode, Order_Shopping.OrderHeader.CouponCode);
            return RedirectToAction(nameof(Index));

        }
        public IActionResult RemoveCoupon()
        {
        
            HttpContext.Session.SetString(StaticDefinition.SessionCouponCode, string.Empty);
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Plus(int CartId)
        {
            var shoppingCart = await db.ShoppingCard.FindAsync(CartId);
            shoppingCart.Count += 1;
            await db.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Minus(int CartId)
        {
            var shoppingCart = await db.ShoppingCard.FindAsync(CartId);
            if(shoppingCart.Count > 1)
            {
                shoppingCart.Count -= 1;
                await db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Remove(int CartId)
        {
            var shoppingCart = await db.ShoppingCard.FindAsync(CartId);
             db.ShoppingCard.Remove(shoppingCart);
            await db.SaveChangesAsync();
            var count = db.ShoppingCard.Where(m => m.AppUserId == shoppingCart.AppUserId).ToList().Count;
            HttpContext.Session.SetInt32(StaticDefinition.ShoppingCartCount, count);
            return RedirectToAction(nameof(Index));
        }
    }
}

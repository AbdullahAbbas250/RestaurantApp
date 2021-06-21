using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QadduraResturant.Data;
using QadduraResturant.Models;
using QadduraResturant.Models.ViewModel;
using QadduraResturant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QadduraResturant.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var CurrentUser = (ClaimsIdentity)User.Identity;
            var claim = CurrentUser.FindFirst(ClaimTypes.NameIdentifier); 
            if(claim != null)
            {
                var userId = claim.Value;
                List<ShoppingCard> shopCart = await db.ShoppingCard.Where(m => m.AppUserId == userId).ToListAsync();
                HttpContext.Session.SetInt32(StaticDefinition.ShoppingCartCount, shopCart.Count);
            }
            
            IndexViewModel indexModel = new IndexViewModel()
            {
                Category = await db.Categories.ToListAsync(),
                Coupon = await db.Coupon.ToListAsync(),
                MenuItem = await db.MenuItem.Include(m => m.Category).Include(m => m.subCategory).ToListAsync()
            };
            return View(indexModel);
        }
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Details(int itemid )
        {
            var Item = await db.MenuItem
                .Include(m => m.Category)
                .Include(m => m.subCategory)
                .Where(m => m.id == itemid)
                .FirstOrDefaultAsync();
            ShoppingCard shoppingCard = new ShoppingCard()
            {
                MenuItem = Item,
                MenuItemId = Item.id
            };
            return View(shoppingCard);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(ShoppingCard ShCa_Obj)
        {
            if (ModelState.IsValid)
            {
                // Get Current User 
                var c_dentity = (ClaimsIdentity)User.Identity;
                var claim = c_dentity.FindFirst(ClaimTypes.NameIdentifier);
                ShCa_Obj.AppUserId = claim.Value;

                // Check if Item of Current User Exist Or not 
                var shoppingCartQuery = await db.ShoppingCard
                        .Where(m => m.AppUserId == ShCa_Obj.AppUserId &&
                                   m.MenuItemId == ShCa_Obj.MenuItemId)
                        .FirstOrDefaultAsync();

                if (shoppingCartQuery == null)
                {
                    db.ShoppingCard.Add(ShCa_Obj);
                }
                else
                {
                    shoppingCartQuery.Count += ShCa_Obj.Count; 
                }
                await db.SaveChangesAsync();
                //Get Count of Item  
                var count = db.ShoppingCard
                            .Where(m => m.AppUserId == ShCa_Obj.AppUserId)
                            .ToList().Count;

                // Store Count Of Item To Display it On Shopping Cart Icon
                HttpContext.Session.SetInt32(StaticDefinition.ShoppingCartCount , count);

                return RedirectToAction(nameof(Index));
            }
            else
            {
                var Item = await db.MenuItem
               .Include(m => m.Category)
               .Include(m => m.subCategory)
               .Where(m => m.id == ShCa_Obj.MenuItemId)
               .FirstOrDefaultAsync();
                ShoppingCard shoppingCartObj = new ShoppingCard()
                {
                    MenuItem = Item,
                    MenuItemId = Item.id
                };
                return View(shoppingCartObj);
            }
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QadduraResturant.Data;
using QadduraResturant.Models;
using QadduraResturant.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace QadduraResturant.Areas.Admin.Controllers
{
    [Authorize(Roles = StaticDefinition.ManagerUser)]

    [Area("Admin")]
    public class CouponsController : Controller
    {
        private readonly ApplicationDbContext db;

        public CouponsController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {

            var copons = await db.Coupon.ToListAsync();
            return View(copons);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Coupon Coupon)
        {
            if(ModelState.IsValid)
            {               
                db.Coupon.Add(Coupon);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(Coupon);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await db.Coupon.FindAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Coupon coupon )
        {
            if (ModelState.IsValid)
            {
                db.Coupon.Update(coupon);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(coupon);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await db.Coupon.FindAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var coupon = await db.Coupon.FindAsync(id);
            if (coupon == null)
            {
                return NotFound();
            }
            return View(coupon);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(Coupon coupon)
        {
            db.Coupon.Remove(coupon);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

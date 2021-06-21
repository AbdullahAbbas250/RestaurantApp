using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QadduraResturant.Data;
using QadduraResturant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace QadduraResturant.Areas.Admin.Controllers
{
    [Authorize(Roles = StaticDefinition.ManagerUser)]
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly ApplicationDbContext db;

        public UserController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task <IActionResult> Index()
        {
            // return currrent user that log on now
            var claimIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimIdentity.FindFirst(ClaimTypes.NameIdentifier);
            string userid = claim.Value;

            return View( await db.ApplicationUser.Where(m=>m.Id != userid).ToListAsync());
        }
        public async Task<IActionResult> LockUnLock(string? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            var user = await db.ApplicationUser.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            if(user.LockoutEnd == null || user.LockoutEnd < DateTime.Now)
            {
                user.LockoutEnd = DateTime.Now.AddYears(100);
            }
            else
            {
                user.LockoutEnd = DateTime.Now;
            }
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}

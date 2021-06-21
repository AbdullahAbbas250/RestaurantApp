using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QadduraResturant.Data;
using QadduraResturant.Models;
using QadduraResturant.Models.ViewModel;
using QadduraResturant.Utility;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Areas.Admin.Controllers
{
    [Authorize(Roles = StaticDefinition.ManagerUser)]

    [Area("Admin")]
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext db;
        private readonly IWebHostEnvironment webHostEnvironment;

        [BindProperty]
        public CategrySubCategoryItem ItemViewModel { get; set; }
        public ItemController(ApplicationDbContext db , IWebHostEnvironment WebHostEnvironment)
        {
            this.db = db;
            webHostEnvironment = WebHostEnvironment;
            ItemViewModel = new CategrySubCategoryItem()
            {
                Category = db.Categories.ToList(),
                item = new MenuItem(),
            };
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //var itemsData = (from i in db.items
            //                 join p in db.subCategory
            //                 on i.id equals p.id
            //                 join c in db.Categories
            //                 on p.CategoryId equals c.id
            //                 select new
            //                 {
            //                   ID          = i.id          ,
            //                   Name        = i.name        ,
            //                   price       = i.price       , 
            //                   image       = i.image       , 
            //                   spicyness   = i.spicyness   , 
            //                   subcategory = i.subCategory ,
            //                   category    = c.name
            //                 }).ToList();
            var itemData =await db.MenuItem.Include(a => a.Category).Include(a => a.subCategory).ToListAsync();
            return View(itemData);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(ItemViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Create")]
        public async Task<IActionResult> CreateItem()
        {
            if (ModelState.IsValid)
            {
                string defaultImage = @"\images\21.png";
                var file = HttpContext.Request.Form.Files;
                if (file.Count > 0)
                {
                    string ImageName = DateTime.Now.ToFileTime().ToString() +
                                        Path.GetExtension(file[0].FileName);
                    string imagePath = webHostEnvironment.WebRootPath;
                    FileStream filestream = new FileStream(Path.Combine(imagePath, "images", ImageName), FileMode.Create);
                    file[0].CopyTo(filestream);
                    defaultImage = @"\images\" + ImageName;
                }
                ItemViewModel.item.image = defaultImage;

                db.MenuItem.Add(ItemViewModel.item);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ItemViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var item = db.MenuItem.Include(m => m.Category).
                                   Include(m => m.subCategory).
                                   SingleOrDefault(m => m.id == id);
            if (item == null)
            {
                return NotFound();
            }
            ItemViewModel.item = item;

            ItemViewModel.subcategory = await db.subCategory.
                            Where(m => m.CategoryId == ItemViewModel.item.CategoryId).ToListAsync();
           

            return View(ItemViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Edit")]
        public async Task<IActionResult> EditItem()
        {
            if (ModelState.IsValid)
            {
                var file = HttpContext.Request.Form.Files;
                if (file.Count > 0)
                {
                    string ImageName = DateTime.Now.ToFileTime().ToString() +
                                        Path.GetExtension(file[0].FileName);
                    string imagePath = webHostEnvironment.WebRootPath;
                    FileStream filestream = new FileStream(Path.Combine(imagePath, "images", ImageName), FileMode.Create);
                    file[0].CopyTo(filestream);
                   string defaultImage = @"\images\" + ImageName;
                    ItemViewModel.item.image = defaultImage;

                }

                db.MenuItem.Update(ItemViewModel.item);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ItemViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var item = db.MenuItem.Include(m => m.Category).
                                   Include(m => m.subCategory).
                                   SingleOrDefault(m => m.id == id);
            if (item == null)
            {
                return NotFound();
            }
            ItemViewModel.item = item;

            ItemViewModel.subcategory = await db.subCategory.
                            Where(m => m.CategoryId == ItemViewModel.item.CategoryId).ToListAsync();


            return View(ItemViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var item = db.MenuItem.Include(m => m.Category).
                                   Include(m => m.subCategory).
                                   SingleOrDefault(m => m.id == id);
            if (item == null)
            {
                return NotFound();
            }
            ItemViewModel.item = item;

            ItemViewModel.subcategory = await db.subCategory.
                            Where(m => m.CategoryId == ItemViewModel.item.CategoryId).ToListAsync();


            return View(ItemViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteItem()
        {
                db.MenuItem.Remove(ItemViewModel.item);
                await db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
        }
    }
}
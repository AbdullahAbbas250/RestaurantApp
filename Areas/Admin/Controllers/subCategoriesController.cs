using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QadduraResturant.Data;
using QadduraResturant.Models;
using QadduraResturant.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Areas.Admin.Controllers
{
    [Authorize(Roles = StaticDefinition.ManagerUser)]

    [Area("Admin")]
    public class subCategoriesController : Controller
    {
        private readonly ApplicationDbContext db;
        [TempData]
        public  string statusMessege{ get; set; }

        public subCategoriesController(ApplicationDbContext DB )
        {
            this.db = DB;
        }
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var subCategory = await db.subCategory.Include(m => m.category).ToListAsync();
            return View(subCategory);
        }
        [HttpGet]
        public async Task<ActionResult> Create()
        {
            SubCategAndCategModel SubCatAnCatModel = new SubCategAndCategModel()
            {
                categoryList  = await db.Categories.ToListAsync(),
                subCategory = new subCategory(),
            };
            return View( SubCatAnCatModel );
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(SubCategAndCategModel obj)
        {
            if (ModelState.IsValid)
            {
                /*select subCategory and Category ------*/
                var CheckSubExistOrNot =await db.subCategory
                                            .Include(a => a.category)
                                            .Where(a => a.category.id == obj.subCategory.CategoryId
                                                        && obj.subCategory.name == a.name).ToListAsync();
                if (CheckSubExistOrNot.Count() > 0)
                {
                    statusMessege = "Error : sub category eixst in " + CheckSubExistOrNot.FirstOrDefault().category.name;
                }
                else
                {
                    db.subCategory.Add(obj.subCategory);
                    await db.SaveChangesAsync();
                }
            }

            SubCategAndCategModel SubCatAnCatModelvm = new SubCategAndCategModel()
            {

                categoryList = await db.Categories.ToListAsync(),
                subCategory = obj.subCategory,
                MessgStatus = statusMessege
            };
            return View(SubCatAnCatModelvm);
        }

        [HttpGet]
        public async Task<IActionResult> DisplaySubCategoryOnChange(int id)
        {
            List<subCategory> result = new List<subCategory>();
             result = await db.subCategory
                            .Where(e => e.CategoryId == id).ToListAsync();
            return Json( new SelectList(result,"id","name"));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SubCategAndCategModel model )
        {
            if (ModelState.IsValid)
            {
                /*select subCategory and Category ------*/
                var CheckSubExistOrNot = await db.subCategory
                                            .Include(a => a.category)
                                            .Where(a => a.category.id == model.subCategory.CategoryId
                                                        && model.subCategory.name == a.name
                                                        && model.subCategory.id != a.id).ToListAsync();
                if (CheckSubExistOrNot.Count() > 0)
                {
                    statusMessege = "Error : sub category eixst in " + CheckSubExistOrNot.FirstOrDefault().category.name;
                }
                else
                {
                    db.subCategory.Update(model.subCategory);
                    await db.SaveChangesAsync();
                }
            }
            var errors = ModelState.Values.SelectMany(v => v.Errors);

            SubCategAndCategModel SubCatAnCatModelvm = new SubCategAndCategModel()
            {
                categoryList = await db.Categories.ToListAsync(),
                subCategory = model.subCategory,
                MessgStatus = statusMessege
            };
            return View(SubCatAnCatModelvm);
        }
        [HttpGet]
        public async Task<ActionResult> Edit( int? id )
        {
            if(id == null)
            {
                return NotFound();
            }
            var subCat = await db.subCategory.FindAsync(id);
            if(subCat == null)
            {
                return NotFound();
            }
            SubCategAndCategModel SubCatAnCatEdited = new SubCategAndCategModel()
            {
                categoryList = await db.Categories.ToListAsync(),
                subCategory  = subCat,
            };
            return View(SubCatAnCatEdited);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subCategory = await db.subCategory.Include(e => e.category).Where(e => e.id == id).SingleOrDefaultAsync();
            if (subCategory == null)
            {
                return NotFound();
            }
            return View(subCategory);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(subCategory Obj )
        {
            db.subCategory.Remove(Obj);
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subCategory = await db.subCategory.Include(e => e.category).Where(e => e.id == id).SingleOrDefaultAsync();
            if (subCategory == null)
            {
                return NotFound();
            }
            return View(subCategory);
        }
    }
}

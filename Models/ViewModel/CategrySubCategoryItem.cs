using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models.ViewModel
{
    public class CategrySubCategoryItem
    {
       public IEnumerable<Category> Category { get; set; }
       public IEnumerable<subCategory> subcategory { get; set; }
       public MenuItem item { get; set; }
    }
}

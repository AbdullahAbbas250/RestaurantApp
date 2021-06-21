using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models
{
    public class SubCategAndCategModel
    {
        public IEnumerable<Category> categoryList { get; set; }
        public subCategory subCategory  { get; set; }
        public string      MessgStatus { get; set; }
    }
}

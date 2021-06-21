using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models.ViewModel
{
    public class OrderListVM
    {
        public List<OrderDetailViewModel> Orders { get; set; }
        public Pagination PagingInfo { get; set; }

    }
}

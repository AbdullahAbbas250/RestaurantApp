using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QadduraResturant.Models.ViewModel
{
    public class Order_Shopping
    {
        public List<ShoppingCard> ShoppingCardList { get; set; }
        public OrderHeader OrderHeader  { get; set; }
    }
}

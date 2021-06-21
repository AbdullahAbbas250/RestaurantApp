using Microsoft.AspNetCore.Authorization;
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
using System.Text;
using System.Threading.Tasks;

namespace QadduraResturant.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext db;
        public OrderController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Confirm(int id)
        {
            var CurrentUser = (ClaimsIdentity)User.Identity;
            var claims = CurrentUser.FindFirst(ClaimTypes.NameIdentifier);

            OrderDetailViewModel OrderDetailVM = new OrderDetailViewModel()
            {
                OrderHeader = await db.OrderHeaders.Include(m=>m.appUser)
                            .FirstOrDefaultAsync(m => m.userId == claims.Value && m.id == id),
                OrderDetail = await db.OrderDetails.Where(m=>m.OrderId == id).ToListAsync()
            };
            return View(OrderDetailVM);
        }
        private int pageSize = 3;
        [Authorize]
        public async Task<IActionResult> OrderHistory(int pageNumber = 1 )
        {
            var CurrentUser = (ClaimsIdentity)User.Identity;
            var claims = CurrentUser.FindFirst(ClaimTypes.NameIdentifier);

            //List<OrderDetailViewModel> OrderDetailVMList = new List<OrderDetailViewModel>();
            OrderListVM orderListVM = new OrderListVM()
            {
                Orders = new List<OrderDetailViewModel>(),

            };
            List<OrderHeader> OrderHeaderList =await db.OrderHeaders.
                                            Include(m => m.appUser).
                                            Where(m => m.userId == claims.Value).
                                            ToListAsync();
            foreach (var OrderHeader in OrderHeaderList)
            {
                OrderDetailViewModel OrderDetailVM = new OrderDetailViewModel()
                {
                    OrderHeader = OrderHeader , 
                    OrderDetail = await db.OrderDetails.Where(m=>m.OrderId == OrderHeader.id).ToListAsync()
                };
                orderListVM.Orders.Add(OrderDetailVM);
            }
            var count = orderListVM.Orders.Count;
            orderListVM.Orders = orderListVM.Orders
                                 .OrderByDescending(o => o.OrderHeader.id)
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize).ToList();
            orderListVM.PagingInfo = new Pagination()
            { 
                CurrentPage = pageNumber ,
                RecordsPerPage = pageSize ,
                TotalRecords = count ,
                UrlParam = "/Customer/Order/OrderHistory?pageNumber=:"
            };

            return View(orderListVM);
        }
        public async Task<IActionResult> OrderDetails(int id)
        {
            OrderDetailViewModel OrderDetailVM = new OrderDetailViewModel()
            {
                OrderHeader = await db.OrderHeaders.
                                    Include(m => m.appUser).
                                    FirstOrDefaultAsync(m => m.id == id) , 
                OrderDetail = await db.OrderDetails.
                                    Where(m=>m.OrderId == id).
                                    ToListAsync()
            };
            return PartialView("_IndividualOrderDetail", OrderDetailVM);
        }
        public async Task<IActionResult> GetOrderStatus(int id)
        {
            OrderHeader orderHeader =await  db.OrderHeaders.FindAsync(id);
            return PartialView("_OrderStatus", orderHeader.status);
        }
        [Authorize(Roles =StaticDefinition.ManagerUser + ","+StaticDefinition.KitchenUser)]
        public async Task<IActionResult> ManageOrder()
        {
            List<OrderDetailViewModel> OrderDetailVMList = new List<OrderDetailViewModel>();
          
            List<OrderHeader> OrderHeaderList = await db.OrderHeaders.
                                            Where(m => m.status == StaticDefinition.StatusInProccess
                                            || m.status == StaticDefinition.statusSubmitted).
                                            ToListAsync();
            foreach (var OrderHeader in OrderHeaderList)
            {
                OrderDetailViewModel OrderDetailVM = new OrderDetailViewModel()
                {
                    OrderHeader = OrderHeader,
                    OrderDetail = await db.OrderDetails.Where(m => m.OrderId == OrderHeader.id).ToListAsync()
                };
                OrderDetailVMList.Add(OrderDetailVM);
            }
            return View(OrderDetailVMList.OrderBy(o=>o.OrderHeader.PickUpTime).ToList());
        }
        [Authorize(Roles = StaticDefinition.ManagerUser + "," + StaticDefinition.KitchenUser)]
        public async Task<IActionResult> OrderPrepare(int orderId)
        {
            var orderHeader = await db.OrderHeaders.FindAsync(orderId);
            orderHeader.status = StaticDefinition.StatusInProccess;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(ManageOrder));
        }
        [Authorize(Roles = StaticDefinition.ManagerUser + "," + StaticDefinition.KitchenUser)]
        public async Task<IActionResult> OrderReady(int orderId)
        { 
            var orderHeader = await db.OrderHeaders.FindAsync(orderId);
            orderHeader.status = StaticDefinition.statusReady;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(ManageOrder));
        }
        [Authorize(Roles = StaticDefinition.ManagerUser + "," + StaticDefinition.KitchenUser)]
        public async Task<IActionResult> OrderCancel(int orderId)
        {
            var orderHeader = await db.OrderHeaders.FindAsync(orderId);
            orderHeader.status = StaticDefinition.statusCancelled;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(ManageOrder));
        }

        [Authorize(Roles =StaticDefinition.ManagerUser + "," +StaticDefinition.FrontDeskUser)]
        public async Task<IActionResult> OrderPickup( int pageNumber = 1 , 
                                                      string  SearchName = null , 
                                                      string SearchPhone = null , 
                                                      string SearchEmail = null )
        {
       
            //List<OrderDetailViewModel> OrderDetailVMList = new List<OrderDetailViewModel>();
            OrderListVM orderListVM = new OrderListVM()
            {
                Orders = new List<OrderDetailViewModel>(),

            };
            StringBuilder parameter = new StringBuilder();
            parameter.Append("/Customer/Order/OrderPickup?pageNumber=:");
            parameter.Append("&SearchName");
            if(SearchName != null)
            {
                parameter.Append(SearchName);
            }
            else
            {
                SearchName = "";
            }
            parameter.Append("&SearchPhone");
            if (SearchPhone != null)
            {
                parameter.Append(SearchPhone);
            }
            else
            {
                SearchPhone = "";
            }
            parameter.Append("&SearchEmail");
            if (SearchEmail != null)
            {
                parameter.Append(SearchEmail);
            }
            else
            {
                SearchEmail = "";
            }

            List<OrderHeader> OrderHeaderList = await db.OrderHeaders
                                                .Include(m => m.appUser)
                                                .OrderByDescending(m=>m.OrderDate)
                                                .Where(m => m.status == StaticDefinition.statusReady && 
                                                      m.PickUpName.Contains(SearchName)              && 
                                                      m.PhoneNumber.Contains(SearchPhone)            && 
                                                      m.appUser.Email.Contains(SearchEmail))
                                                .ToListAsync();
            foreach (var OrderHeader in OrderHeaderList)
            {
                OrderDetailViewModel OrderDetailVM = new OrderDetailViewModel()
                {
                    OrderHeader = OrderHeader,
                    OrderDetail = await db.OrderDetails.Where(m => m.OrderId == OrderHeader.id).ToListAsync()
                };
                orderListVM.Orders.Add(OrderDetailVM);
            }
            var count = orderListVM.Orders.Count;
            orderListVM.Orders = orderListVM.Orders
                                 .OrderByDescending(o => o.OrderHeader.id)
                                 .Skip((pageNumber - 1) * pageSize)
                                 .Take(pageSize).ToList();
            orderListVM.PagingInfo = new Pagination()
            {
                CurrentPage = pageNumber,
                RecordsPerPage = pageSize,
                TotalRecords = count,
                UrlParam = parameter.ToString()
            };

            return View(orderListVM);
        }

        [Authorize(Roles = StaticDefinition.ManagerUser + "," + StaticDefinition.FrontDeskUser)]
        [HttpPost]
        public async Task<IActionResult> OrderPicup(int orderId)
        {
            var orderHeader = await db.OrderHeaders.FindAsync(orderId);
            orderHeader.status = StaticDefinition.statusCompleted;
            await db.SaveChangesAsync();
            return RedirectToAction(nameof(OrderPickup));
        }
    }
}

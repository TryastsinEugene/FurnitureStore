using FurnitureStore.Data.Service;
using FurnitureStore.Data.Service.OrderService;
using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Controllers
{
    public class OrdersController : Controller
    {
        private IProductService _productRep;
        private IOrderRepository _orderRep;
        public OrdersController(IProductService productRep, IOrderRepository orderRep)
        {
            _productRep = productRep;
            _orderRep = orderRep;
        }
        public IActionResult Index() => View(_orderRep.GetOrders);
        public IActionResult EditOrder(long id)
        {
            var products = _productRep.AllProducts();
            Order order = id == 0 ? new Order() : _orderRep.GetOrder(id);
            IDictionary<long, OrderLine> lines = order.Lines?.ToDictionary(l => l.ProductId) ?? new Dictionary<long, OrderLine>();
            ViewBag.Lines = products.Select(p => lines.ContainsKey(p.Id) ? lines[p.Id] 
            : new OrderLine
            {
                Product = p,
                Id = p.Id,
                Quantity = 0
            });
            return View(order);
        }
        [HttpPost]
        public IActionResult AddOrUpdateOrder(Order order)
        {
            order.Lines = order.Lines?.Where(o => o.Id > 0 || (o.Id == 0 && o.Quantity > 0)).ToArray();
            if (order.Id == 0)
                _orderRep.AddOrder(order);
            else
                _orderRep.UpdateOrder(order);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult DeleteOrder(Order order)
        {
            _orderRep.DeleteOrder(order);
            return RedirectToAction(nameof(Index));
        }
    }
}

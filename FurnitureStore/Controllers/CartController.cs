using FurnitureStore.Data.Service;
using FurnitureStore.Data.Service.OrderService;
using FurnitureStore.Infrastracture;
using FurnitureStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Controllers
{
    [ViewComponent(Name = "Cart")]
    public class CartController : Controller
    {
        private IProductService _productService;
        private IOrderRepository _orderRepository;
       
        public CartController(IProductService productService, IOrderRepository orderRepository)
        {
            _productService = productService;
            _orderRepository = orderRepository;
            
        }
        public IActionResult Index(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View(GetCart());
        }
        [HttpPost]
        public IActionResult AddToCart(Product product, string returnUrl)
        {
            SaveCart(GetCart().AddItem(product, 1));
            return RedirectToAction(nameof(Index), new { returnUrl });
        }
        [HttpPost]
        public IActionResult RemoveFromCart(long productId, string returnUrl)
        {
            SaveCart(GetCart().RemoveItem(productId));
            return RedirectToAction(nameof(Index), new { returnUrl });
        }
        public IActionResult CreateOrder(bool key)
        {
            if (!key)
            {
                ViewBag.Valid = "Empty";
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }
            return View();
        }
        [HttpPost]
        public IActionResult CreateOrder(Order order)
        {
            
            if (ModelState.IsValid)
            {
                order.Lines = GetCart().Selections.Select(s => new OrderLine
                {
                    ProductId = s.ProductId,
                    Quantity = s.Quantity
                }).ToArray();
                _orderRepository.AddOrder(order);
                SaveCart(new CartEF());
                return RedirectToAction(nameof(Completed));
            }
            else
                return View();
        }

        public IActionResult Completed() => View();

        private void SaveCart(CartEF cart) => HttpContext.Session.SetJson("CartEF", cart);

        public CartEF GetCart() => HttpContext.Session.GetJson<CartEF>("CartEF") ?? new CartEF();
            
        public IViewComponentResult Invoke(ISession session)
        {
            return new ViewViewComponentResult()
            {
                ViewData = new ViewDataDictionary<CartEF>(ViewData, session.GetJson<CartEF>("CartEF"))
            };
        }
    }
}

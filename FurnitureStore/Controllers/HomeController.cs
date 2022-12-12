using FurnitureStore.Data.Service;
using FurnitureStore.Models;
using FurnitureStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Controllers
{
    public class HomeController : Controller
    {
        int PageSize = 1;
        private IProductService _service;
        public HomeController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index() => View();
        public ViewResult Product(string category, int productPage = 1)
           => View(new ProductListViewModel
           {
               Products = _service.AllProducts()
               .Where(p => category == null || p.Category.Name == category)
               .Where(p => p.Active == true)
               .OrderBy(p => p.Id)
               .Skip((productPage - 1) * PageSize)
               .Take(PageSize),
               PagingInfo = new PagingInfo
               {
                   CurrentPage = productPage,
                   ItemsPerPage = PageSize,
                   TotalItems = category == null ? _service.AllProducts().Where(p => p.Active == true).Count()
                   : _service.AllProducts()
                   .Where(p => p.Category.Name == category)
                   .Where(p => p.Active == true)
                   .Count()
               },
               CurrentCategory = category
           });
        public IActionResult ContactUs() => View();
        public IActionResult About() => View();
        public IActionResult Blog() => View();
    }
}

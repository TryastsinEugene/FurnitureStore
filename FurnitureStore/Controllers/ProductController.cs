using FurnitureStore.Data.Service;
using FurnitureStore.Data.Service.CategoryService;
using FurnitureStore.Models;
using FurnitureStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;

namespace FurnitureStore.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _service;
        private ICategoryService _catService;
        public int PageSize = 1;
        public ProductController(IProductService service, ICategoryService catService)
        {
            _service = service;
            _catService = catService;
        }
        public ViewResult Index(string category, int productPage = 1)
        {
            ViewBag.Product = true;
            return View(new ProductListViewModel
               {
                   Products = _service.AllProducts()
                .Where(p => category == null || p.Category.Name == category)
                .OrderBy(p => p.Id)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                   PagingInfo = new PagingInfo
                   {
                       CurrentPage = productPage,
                       ItemsPerPage = PageSize,
                       TotalItems = category == null ? _service.AllProducts().Count()
                    : _service.AllProducts().Where(p => p.Category.Name == category).Count()
                   },
                   CurrentCategory = category
               });
        }
        public IActionResult UpdateDelete(long key)
        {
            ViewBag.Categories = _catService.GetCategories();
            ViewBag.CreateMode = key == 0 ? true : false;
            return View(key == 0 ? new Product() : _service.GetProduct(key));
        }
        [HttpPost]
        public IActionResult UpdateDelete(Product product)
        {
            if (product.Id == 0)
                _service.AddProduct(product);
            else
                _service.UpdateProduct(product);

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Delete(long id)
        {
            _service.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

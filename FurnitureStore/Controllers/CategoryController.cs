using FurnitureStore.Data.Service.CategoryService;
using FurnitureStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            ViewBag.Category = true;
            return View(_service.GetCategories());
        }
        public IActionResult AddCategory() => View();
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _service.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(long key)
        {
            ViewBag.EditId = key;
            return View("Index", _service.GetCategories());
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            _service.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            _service.DeleteCategory(category);
            return RedirectToAction(nameof(Index));
        }
    }
}

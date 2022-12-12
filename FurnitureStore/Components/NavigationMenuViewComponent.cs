using FurnitureStore.Data.Service;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FurnitureStore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IProductService _service;
        public NavigationMenuViewComponent(IProductService service)
        {
            _service = service;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(_service.AllProducts()
                   .Select(x => x.Category)
                   .Distinct()
                   .OrderBy(c => c.Name));
        }
    }
}

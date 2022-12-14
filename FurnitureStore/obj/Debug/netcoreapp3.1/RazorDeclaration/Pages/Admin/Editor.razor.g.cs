// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FurnitureStore.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using FurnitureStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using FurnitureStore.Data.Service.OrderService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using FurnitureStore.Data.Service.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using FurnitureStore.Data.Service.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\_Imports.razor"
using FurnitureStore.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/edit/{id:long}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/products/create")]
    public partial class Editor : OwningComponentBase<FurnitureStore.Data.Service.IProductService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\Editor.razor"
       

    public FurnitureStore.Data.Service.IProductService Repository => Service;
    [Inject]
    public NavigationManager NavManager { get; set; }
    [Inject]
    DataContext Context { get; set; }

    [Parameter]
    public long Id { get; set; } = 0;

    public Product Product { get; set; } = new Product();
    public IDictionary<string, long> Categories { get; set; } = new Dictionary<string, long>();

    protected override void OnParametersSet()
    {
        if (Id != 0)
        {
            Product = Repository.AllProducts().FirstOrDefault(p => p.Id == Id);
        }
            Categories = Context.Categories.ToDictionary(c => c.Name, c => c.Id);
    }

    public void SaveProduct()
    {
        if (Id == 0)
        {
            Repository.AddProduct(Product);
        }
        else
        {
            Repository.SaveProduct(Product);
        }
        NavManager.NavigateTo("/admin/products");
    }

    public string ThemeColor => Id == 0 ? "primary" : "warning";
    public string TitleText => Id == 0 ? "Create" : "Edit";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

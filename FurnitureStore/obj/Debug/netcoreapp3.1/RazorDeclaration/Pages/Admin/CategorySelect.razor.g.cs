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
    public partial class CategorySelect<TValue> : InputBase<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Pages\Admin\CategorySelect.razor"
       

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public IDictionary<string, TValue> Values { get; set; }

    [Parameter]
    public Func<string, TValue> Parser { get; set; }

    protected override bool TryParseValueFromString(string value, out TValue result,
            out string validationErrorMessage)
    {
        try
        {
            result = Parser(value);
            validationErrorMessage = null;
            return true;
        }
        catch
        {
            result = default(TValue);
            validationErrorMessage = "The value is not valid";
            return false;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
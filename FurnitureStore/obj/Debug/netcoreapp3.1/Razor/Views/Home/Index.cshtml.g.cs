#pragma checksum "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45c8bb4b6691781e02d49a30061f7d2821c7dab8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Views\_ViewImports.cshtml"
using FurnitureStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Views\_ViewImports.cshtml"
using FurnitureStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Views\_ViewImports.cshtml"
using FurnitureStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\FurnitureStore\FurnitureStore\Views\_ViewImports.cshtml"
using FurnitureStore.Infrastracture;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45c8bb4b6691781e02d49a30061f7d2821c7dab8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"224a56f0ec0d4e7152365cb8bd976b0a00d71294", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("main_form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap-icons@1.8.3/font/bootstrap-icons.css"">


<section class=""slider_section"">
    <div class=""banner_main"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12 mapimg"">
                    <div class=""text-bg"">
                        <h1>The latest <br> <strong class=""black_bold"">furniture Design</strong><br></h1>
");
            WriteLiteral(@"                    </div>
                </div>
                <div class=""col-xl-6 col-lg-6 col-md-6 col-sm-12"">
                    <div class=""text-img"">
                        <figure><img src=""images/bg.jpg"" /></figure>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>

");
            WriteLiteral(@"<div class=""container"">
    <div id=""myCarousel"" class=""carousel slide banner_Client"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#myCarousel"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#myCarousel"" data-slide-to=""1""></li>
            <li data-target=""#myCarousel"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"">
            <div class=""carousel-item active"">
                <div class=""container"">
                    <div class=""carousel-caption text"">
                        <div class=""row"">
                            <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-12"">
                                <div class=""img_bg"">
                                    <h3>50% DISCOUNT<br> <strong class=""black_nolmal"">the latest collection</strong></h3>
                                </div>
                            </div>
                            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12"">
 ");
            WriteLiteral(@"                               <div class=""img_bg"">
                                    <figure><img src=""images/discount.jpg"" /></figure>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <div class=""container"">
                    <div class=""carousel-caption text"">
                        <div class=""row"">
                            <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-12"">
                                <div class=""img_bg"">
                                    <h3>50% DISCOUNT<br> <strong class=""black_nolmal"">the latest collection</strong></h3>
                                </div>
                            </div>
                            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12"">
                                <div class=""img_bg"">
                                    <figure><img src");
            WriteLiteral(@"=""images/discount.jpg"" /></figure>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""carousel-item"">
                <div class=""container"">
                    <div class=""carousel-caption text"">
                        <div class=""row"">
                            <div class=""col-xl-8 col-lg-8 col-md-8 col-sm-12"">
                                <div class=""img_bg"">
                                    <h3>50% DISCOUNT<br> <strong class=""black_nolmal"">the latest collection</strong></h3>
                                </div>
                            </div>
                            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12"">
                                <div class=""img_bg"">
                                    <figure><img src=""images/discount.jpg"" /></figure>
                                </div>
                            <");
            WriteLiteral("/div>\r\n                        </div>\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<div class=""trending"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-md-8 offset-md-2"">
                <div class=""title"">
                    <h2>Trending <strong class=""black"">Categories</strong></h2>

                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12 margitop"">
                <div class=""trending-box"">
                    <figure><img src=""images/1.jpg"" /></figure>
                    <h3>Outdoor</h3>

                </div>
            </div>
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12"">
                <div class=""trending-box"">
                    <figure><img src=""images/2.jpg"" /></figure>
                    <h3>Living Room</h3>

                </div>
            </div>
            <div class=""col-xl-4 col-lg-4 col-md-4 col-sm-12 margitop"">
                <div class=""trending-box"">
                    <figure><img src=""i");
            WriteLiteral("mages/3.jpg\" /></figure>\r\n                    <h3>Bedroom Lighting</h3>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            WriteLiteral(@"<div class=""brand"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""title"">
                    <h2>Featured <strong class=""black"">Brands</strong></h2>

                </div>
            </div>
        </div>
    </div>
</div>
<div class=""container-fluid"">
    <div class=""brand-bg"">
        <div class=""row"">
            <div class=""col-xl-3 col-lg-3 col-md-6 col-sm-12 margintop"">
                <div class=""brand-box"">
                    <i><img src=""icon/p1.png"" /></i>
                    <h3>Jane Lauren Design Chair</h3>
                    <span>$80.00</span>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-3 col-md-6 col-sm-12 margintop"">
                <div class=""brand-box"">
                    <i><img src=""icon/p2.png"" /></i>
                    <h3>Jane Lauren Design Chair</h3>
                    <span>$80.00</span>
                </div>
            </div>
          ");
            WriteLiteral(@"  <div class=""col-xl-3 col-lg-3 col-md-6 col-sm-12"">
                <div class=""brand-box"">
                    <i><img src=""icon/p3.png"" /></i>
                    <h3>Jane Lauren Design Chair</h3>
                    <span>$80.00</span>
                </div>
            </div>
            <div class=""col-xl-3 col-lg-3 col-md-6 col-sm-12"">
                <div class=""brand-box"">
                    <i><img src=""icon/p4.png"" /></i>
                    <h3>Jane Lauren Design Chair</h3>
                    <span>$80.00</span>
                </div>
            </div>
        </div>
    </div>
</div>
");
            WriteLiteral(@"<div class=""contact"">
    <div class=""container-fluid padddd"">
        <div class=""row"">
            <div class=""col-md-8 offset-md-2"">
                <div class=""title"">
                    <h2>Contact <strong class=""black"">Us</strong></h2>

                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xl-6 col-lg-6 col-md-12 col-sm-12 padddd"">
                <div class=""map_section"">
                    <div id=""map"">
                    </div>
                </div>
            </div>
            <div class=""col-xl-6 col-lg-6 col-md-12 col-sm-12 padddd"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8bb4b6691781e02d49a30061f7d2821c7dab813164", async() => {
                WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
                            <input class=""form-control"" placeholder=""Name"" type=""text"" name=""Name"">
                        </div>
                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
                            <input class=""form-control"" placeholder=""Email"" type=""text"" name=""Email"">
                        </div>
                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
                            <input class=""form-control"" placeholder=""Phone"" type=""text"" name=""Phone"">
                        </div>
                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
                            <textarea class=""textarea"" placeholder=""Message"" type=""text"" name=""Message""></textarea>
                        </div>
                        <div class=""col-xl-12 col-lg-12 col-md-12 col-sm-12"">
                            <button ");
                WriteLiteral("class=\"send\">Send</button>\r\n                        </div>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div style=\"position: fixed; right: 25px; bottom: 65px;\" class=\"text-white\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45c8bb4b6691781e02d49a30061f7d2821c7dab815843", async() => {
                WriteLiteral("\r\n        <i class=\"bi bi-plus-circle\"></i> Update/Delete\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591

using FurnitureStore.Data;
using FurnitureStore.Data.Service;
using FurnitureStore.Data.Service.CategoryService;
using FurnitureStore.Data.Service.OrderService;
using FurnitureStore.Data.Service.ProductService;
using FurnitureStore.Data.Service.WebService;
using FurnitureStore.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("StoreConnection"));
            });

            services.AddDbContext<AppIdentityDbContext>(options => 
                options.UseSqlServer(Configuration["ConnectionStrings:IdentityConnection"]));
            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppIdentityDbContext>();

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IWebServiceRepository, WebServiceRepository>();
            services.AddDistributedSqlServerCache(options => {
                options.ConnectionString = Configuration.GetConnectionString("StoreConnection");
                options.SchemaName = "dbo";
                options.TableName = "SessionData";
            });

            services.AddSession(options =>
            {
                options.Cookie.Name = "FurnitureStore";
                options.IdleTimeout = System.TimeSpan.FromHours(48);
                options.Cookie.HttpOnly = false;
            });
            services.AddRazorPages();
            services.AddDistributedMemoryCache();
            services.AddServerSideBlazor();
            
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("catpage", "{category}/Page{productPage:int}",
                    new { Controller = "Product", action = "Index" });

                endpoints.MapControllerRoute("page", "Page{productPage:int}",
                    new { Controller = "Product", action = "Index", productPage = 1 });

                endpoints.MapControllerRoute("category", "{category}",
                    new { Controller = "Product", action = "Index", productPage = 1 });

                endpoints.MapControllerRoute("pagination","Products/Page{productPage}",
                    new { Controller = "Product", action = "Index", productPage = 1 });

                endpoints.MapControllerRoute("products", "Home/Products{productPage:int}",
                    new { Controller = "Home", action = "Product", productPage = 1 });

                endpoints.MapDefaultControllerRoute();
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/admin/{*catchall}", "/Admin/Index");
                endpoints.MapRazorPages();
            });
            IdentitySeedData.EnsurePopulated(app);
        }
    }
}

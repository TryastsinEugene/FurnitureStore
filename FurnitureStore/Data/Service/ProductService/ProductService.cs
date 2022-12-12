using FurnitureStore.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureStore.Data.Service.ProductService
{
    public class ProductService : IProductService
    {
        private DataContext _context;
        public ProductService(DataContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public IQueryable<Product> AllProducts() => _context.Products.Include(p => p.Category);
        
        public void DeleteProduct(long id)
        {
            _context.Products.Remove(new Product { Id = id });
            _context.SaveChanges();
        }

        public Product GetProduct(long id) => AllProducts().FirstOrDefault(p => p.Id == id);
      
        public void UpdateProduct(Product product)
        {
            Product p = _context.Products.Find(product.Id);
            p.Name = product.Name;
            p.Price = product.Price;
            p.ProductPicture = product.ProductPicture;
            p.Desciption = product.Desciption;
            p.CategoryId = product.CategoryId;
            p.Active = product.Active;

            _context.SaveChanges();
        }
        public void SaveProduct(Product product)
        {
            _context.SaveChanges();
        }
    }
}

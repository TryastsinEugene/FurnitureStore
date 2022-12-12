using FurnitureStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureStore.Data.Service
{
    public interface IProductService
    {
        IQueryable<Product> AllProducts();
        Product GetProduct(long id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(long id);
        void SaveProduct(Product product);
    }
}

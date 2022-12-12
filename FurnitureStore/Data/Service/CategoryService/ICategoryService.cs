using FurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Data.Service.CategoryService
{
    public interface ICategoryService
    {
        IEnumerable<Category> GetCategories();
        Category GetCategory(long id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
    }
}

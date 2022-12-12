using FurnitureStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Data.Service.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private DataContext _context;
        public CategoryService(DataContext context)
        {
            _context = context;
        }
        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }

        public IEnumerable<Category> GetCategories() => _context.Categories;

        public Category GetCategory(long id) => GetCategories().FirstOrDefault(category => category.Id == id);

        public void UpdateCategory(Category category)
        {
            Category cat = GetCategory(category.Id);
            cat.Name = category.Name;
            cat.CategoryPicture = category.CategoryPicture;
            _context.SaveChanges();
        }
    }
}

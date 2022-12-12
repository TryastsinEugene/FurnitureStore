using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.Models
{
    public class Category
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; }
        public string CategoryPicture { get; set; }
        public IEnumerable<Product> Products{ get; set; }
    }
}

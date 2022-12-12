using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FurnitureStore.Models
{
    public class Product
    {
        public long Id { get; set; }
        [Required(ErrorMessage ="Please enter a product name")]
        public string Name { get; set; }
        public string Desciption { get; set; }
        public string ProductPicture { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage ="Please enter a positive price")]
        [Column(TypeName="decimal(8,2)")]
        public decimal Price { get; set; }
        public bool Active { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}


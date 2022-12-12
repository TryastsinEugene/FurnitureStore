using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FurnitureStore.Models
{
    public class Order
    {
       // [BindNever]
        public long Id { get; set; }
        [Required(ErrorMessage ="Please enter your name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Please enter your address")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNumber { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
        [BindNever]
        public IEnumerable<OrderLine> Lines{ get; set; }
    }
}

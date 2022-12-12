using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FurnitureStore.Models
{
    public class CartEF
    {
       private List<OrderLine> selections = new List<OrderLine>();
       public  CartEF AddItem(Product p, int quantity)
        {
            OrderLine line = selections.Where(l => l.ProductId == p.Id).FirstOrDefault();
            if(line != null)
            {
                line.Quantity += quantity;
            }
            else
            {
                selections.Add(new OrderLine
                {
                    ProductId = p.Id,
                    Product = p,
                    Quantity = quantity
                });
            }
            return this;
        }
        public  CartEF RemoveItem(long productId)
        {
            selections.RemoveAll(l => l.ProductId == productId);
            return this;
        }
        public  void Clear() => selections.Clear();
        public IEnumerable<OrderLine> Selections { get => selections; }
    }
}

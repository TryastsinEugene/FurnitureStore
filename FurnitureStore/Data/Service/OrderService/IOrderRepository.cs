using FurnitureStore.Models;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureStore.Data.Service.OrderService
{
    public interface IOrderRepository
    {
        IQueryable<Order> GetOrders { get; }
        Order GetOrder(long id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        void SaveOrder(Order order);
    }
}

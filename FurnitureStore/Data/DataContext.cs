using FurnitureStore.Models;
using Microsoft.EntityFrameworkCore;

namespace FurnitureStore.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Product> Products{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderLine> OrdersLines { get; set; }

    }
}

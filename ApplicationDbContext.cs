using Microsoft.EntityFrameworkCore;
using Tomato.Models;

namespace Tomato
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}

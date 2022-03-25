using Microsoft.EntityFrameworkCore;
using ShoppingSystem.Domain.Entities;

namespace ShoppingSystem.Data.Contexts
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Storage> Storages { get; set; }
    }
}
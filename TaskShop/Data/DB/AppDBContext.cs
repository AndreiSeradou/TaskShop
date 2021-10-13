using Microsoft.EntityFrameworkCore;
using TaskShop.Data.Models;

namespace TaskShop.Data.DB
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Shop> Shop { get; set; }
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Shop>().HasData(
                new Shop[]
                {
                new Shop { Id = 1, Name = "MyShop1", Address = "heryzo", OperatingMode = "my shop" },
                new Shop {Id = 2, Name = "MyShop2", Address = "heryzo", OperatingMode = "my shop" },
                new Shop { Id = 3,Name = "MyShop3", Address = "heryzo", OperatingMode = "my shop" }
                });
            modelBuilder.Entity<Product>().HasData(
               new Product[]
               {
                new Product {Id = 1, Name = "brea11d", Description = "my product" , ShopId = 1},
                new Product {Id = 2, Name = "bread2", Description = "my product" , ShopId = 2},
                new Product {Id = 3, Name = "bread3", Description = "my product" , ShopId = 3}
               });
        }
    }
}

using Microsoft.EntityFrameworkCore;

namespace StoreWeb.Models
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
        : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(
                new Product() { ProductId = 1, ProductName = "Computer", Price = 25450.00 },
                new Product() { ProductId = 4, ProductName = "Monitor", Price = 11600.00 },
                new Product() { ProductId = 2, ProductName = "Keyboard", Price = 2999.99 },
                new Product() { ProductId = 3, ProductName = "Mouse", Price = 2657.85 },
                new Product() { ProductId = 5, ProductName = "Hoparlor", Price = 3999.99 },
                new Product() { ProductId = 6, ProductName = "Printer", Price = 1199.00 }
            );
        }
    }
}
using Microsoft.EntityFrameworkCore;
using ShopOnline.api.Entities;

namespace HubContext.api.Data
{
    public class HubContext: DbContext
    {
        public HubContext(DbContextOptions<HubContext> options) : base(options)
        {

        }
        /*protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            *//*base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                ProductName = "Jean Trousers",
                Description = "This is a pair of trousers for both men and women",
                ImageUrl = "Images/Trousers/jean1.png",
                Price = 100,
                Qty = 100,
                CategoryId = 1
            });
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                ProductName = "Jean Trousers",
                Description = "This is a pair of trousers for both men and women",
                ImageUrl = "Images/Trousers/jean2.png",
                Price = 100,
                Qty = 100,
                CategoryId = 1
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id=1,
                ProductCategoryName = "Jeans"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                ProductCategoryName = "T-Shirt"
            });*//*
        }*/
       public DbSet<Cart> Carts { get; set; }
       public DbSet<CartItem> CartItems { get; set; }
       public DbSet<Product> Products { get; set; }
       public DbSet<ProductCategory> ProductCategory { get; set; }
       public DbSet<User> Users { get; set; }
    }
}
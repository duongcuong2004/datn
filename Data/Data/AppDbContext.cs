using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Voucher> Vouchers { get; set; }
        public DbSet<SlideBanner> slideBanners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Policy> policies { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<AboutUs> aboutUs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1640V9E\\SQLEXPRESS;Database=Website_BeeFashion;Trusted_Connection=True;TrustServerCertificate=True");
        }
    }
}

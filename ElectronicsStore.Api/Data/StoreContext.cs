using ElectronicsStore.Api.Cart.Models;
using ElectronicsStore.Api.Products.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsStore.Api.Data
{
    public class StoreContext : DbContext
    {
        // Cart
        public DbSet<ShopSession> ShopSessions { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        // Products
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GalleryImage> ProductImages { get; set; }

        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        { }
    }
}

using ElectronicsStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsStore.Data
{
    public class StoreContext : DbContext
    {
        // Products
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<GalleryImage> ProductImages { get; set; }
        public DbSet<ProductInventory> ProductInventories { get; set; }

        // Cart
        public DbSet<ShopSession> Sessions { get; set; }
		public DbSet<CartItem> CartItems { get; set; }

        // Order
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

		public StoreContext(DbContextOptions<StoreContext> options) : base(options)
		{ }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Mouse" },
                new Category { Id = 2, Name = "Keyboard" },
                new Category { Id = 3, Name = "Controller" }
                );

            modelBuilder.Entity<ProductInventory>().HasData(
                new ProductInventory { Id = 1, ProductId = 1, Quantity = 34 },
                new ProductInventory { Id = 2, ProductId = 2, Quantity = 36 },
                new ProductInventory { Id = 3, ProductId = 3, Quantity = 25 },
                new ProductInventory { Id = 4, ProductId = 4, Quantity = 35 },
                new ProductInventory { Id = 5, ProductId = 5, Quantity = 22 },
                new ProductInventory { Id = 6, ProductId = 6, Quantity = 18 },
                new ProductInventory { Id = 7, ProductId = 7, Quantity = 25 },
                new ProductInventory { Id = 8, ProductId = 8, Quantity = 15 },
                new ProductInventory { Id = 9, ProductId = 9, Quantity = 21 },
                new ProductInventory { Id = 10, ProductId = 10, Quantity = 23 },
                new ProductInventory { Id = 11, ProductId = 11, Quantity = 46 },
                new ProductInventory { Id = 12, ProductId = 12, Quantity = 34 }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Razer Viper Mini", Description = "Ultra-Lightweight Gaming Mouse with Razer™ Chroma RGB", ThumbnailUri = "images/razer_viper_mini.png", Price = 1500, InventoryId = 1, CategoryId = 1 },
                new Product { Id = 2, Name = "Razer Viper 8KHz", Description = "Ambidextrous Esports Gaming Mouse with 8000Hz Polling Rate", ThumbnailUri = "images/razer_viper.png", Price = 2250, InventoryId = 2, CategoryId = 1 },
                new Product { Id = 3, Name = "Logitech G305", Description = "LIGHTSPEED Wireless Gaming Mouse", ThumbnailUri = "images/logitech_g305.png", Price = 2200, InventoryId = 3, CategoryId = 1 },
                new Product { Id = 4, Name = "Logitech G403", Description = "HERO Gaming Mouse", ThumbnailUri = "images/logitech_g403.png", Price = 2600, InventoryId = 4, CategoryId = 1 },
                new Product { Id = 5, Name = "Logitech G PRO X", Description = "SUPERLIGHT", ThumbnailUri = "images/logitech_g_pro_x.png", Price = 8000, InventoryId = 5, CategoryId = 1 },
                new Product { Id = 6, Name = "Razer DeathAdder V2", Description = "Wired Gaming Mouse with Best-in-class Ergonomics", ThumbnailUri = "images/razer_deathadder_v2.png", Price = 2500, InventoryId = 6, CategoryId = 1 },
                new Product { Id = 7, Name = "Razer Naga V2 Pro", Description = "MMO Wireless Gaming Mouse with HyperScroll Pro Wheel", ThumbnailUri = "images/razer_naga_v2_pro.png", Price = 7000, InventoryId = 7, CategoryId = 1 },
                new Product { Id = 8, Name = "Razer BlackWidow V3 Pro Tenkeyless", Description = "Compact Mechanical keyboard with Razer Chroma RGB", ThumbnailUri = "images/razer_blackwidow_v3_pro_tkl.png", Price = 7690, InventoryId = 8, CategoryId = 2 },
                new Product { Id = 9, Name = "Razer Huntsman Mini", Description = "60% Gaming Keyboard with Razer™ Optical Switch", ThumbnailUri = "images/razer_huntsman_mini.png", Price = 6500, InventoryId = 9, CategoryId = 2 },
                new Product { Id = 10, Name = "Logitech G PRO", Description = "KEYBOARD", ThumbnailUri = "images/logitech_g_pro.png", Price = 5500, InventoryId = 10, CategoryId = 2 },
                new Product { Id = 11, Name = "8BitDo SN30 Pro", Description = "", ThumbnailUri = "images/8bitdo_sn30_pro.png", Price = 1500, InventoryId = 11, CategoryId = 3 },
                new Product { Id = 12, Name = "8BitDo Pro 2", Description = "", ThumbnailUri = "images/8bitdo_pro_2.png", Price = 2000, InventoryId = 12, CategoryId = 3 }
                );
            Console.WriteLine("a");
        }
    }
}

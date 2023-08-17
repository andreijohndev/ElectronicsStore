using ElectronicsStore.Api.Products.Models;

namespace ElectronicsStore.Api.Cart.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int ShopSessionId { get; set; }
        public ShopSession ShopSession { get; set; } = null!;
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(CartItem))]
    public class CartItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = $"The {nameof(ShopSessionId)} field is required")]
        public Guid ShopSessionId { get; set; }

        public ShopSession? Session { get; set; }

        [Required(ErrorMessage = $"The {nameof(ProductId)} field is required")]
        public int ProductId { get; set; }

        public Product? Product { get; set; }

        [Required(ErrorMessage = $"The {nameof(Quantity)} field is required")]
        public int Quantity { get; set; }
    }
}

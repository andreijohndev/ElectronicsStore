using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(OrderItem))]
    public class OrderItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = $"The {nameof(OrderId)} field is required")]
        [ForeignKey(nameof(OrderDetails))]
        public int OrderId { get; set; }

        public required OrderDetails OrderDetails { get; set; }

        [Required(ErrorMessage = $"The {nameof(ProductId)} field is required")]
        public int ProductId { get; set; }

        public required Product Product { get; set; }

        [Required(ErrorMessage = $"The {nameof(Quantity)} field is required")]
        public int Quantity { get; set; }
    }
}

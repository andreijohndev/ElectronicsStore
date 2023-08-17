using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(ProductInventory))]
    public class ProductInventory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = $"The {nameof(Quantity)} field is required")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = $"The {nameof(ProductId)} field is required")]
        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}

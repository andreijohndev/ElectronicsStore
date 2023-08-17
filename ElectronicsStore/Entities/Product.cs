using ElectronicsStore.Pages.Admin;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(Product))]
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = $"The {nameof(Name)} field is required")]
        public required string Name { get; set; }

        [Required(ErrorMessage = $"The {nameof(Description)} field is required")]
        public required string Description { get; set; }

        [RegularExpression(@"^\d+(\.\d{0,2})*$", ErrorMessage = $"The field {nameof(Price)} must be a positive number with maximum two decimals.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required(ErrorMessage = $"The {nameof(ThumbnailUri)} field is required")]
        public required string ThumbnailUri { get; set; }

        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = $"The {nameof(InventoryId)} field is required")]
        [ForeignKey(nameof(ProductInventory))]
        public required int InventoryId { get; set; }

        public ProductInventory ProductInventory { get; set; }

        public ICollection<GalleryImage>? Images { get; set; }
    }
}

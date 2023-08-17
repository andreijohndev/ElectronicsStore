using System.ComponentModel.DataAnnotations;

namespace ElectronicsStore.Api.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }

        [RegularExpression(@"^\d+(\.\d{0,2})*$", ErrorMessage = $"The field {nameof(Price)} must be a positive number with maximum two decimals.")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue)]
        public int InventoryQuantity { get; set; }

        public required string ThumbnailUri { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public ICollection<GalleryImage> Images { get; set; } = new List<GalleryImage>();
    }
}

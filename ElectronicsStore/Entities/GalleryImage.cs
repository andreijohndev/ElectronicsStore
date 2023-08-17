using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(GalleryImage))]
    public class GalleryImage
    {
        public int Id { get; set; }

        [Required(ErrorMessage = $"The {nameof(PictureUri)} field is required")]
        public required string PictureUri { get; set; }

        [Required(ErrorMessage = $"The {nameof(ProductId)} field is required")]
        public required int ProductId { get; set; }

        public required Product Product { get; set; }
    }
}

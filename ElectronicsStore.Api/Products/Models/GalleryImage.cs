namespace ElectronicsStore.Api.Products.Models
{
    public class GalleryImage
    {
        public int Id { get; set; }
        public required string PictureUri { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}

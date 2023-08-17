using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(Category))]
	public class Category
	{
        public int Id { get; set; }

        [Required(ErrorMessage = $"The {nameof(Name)} field is required")]
        public required string Name { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}

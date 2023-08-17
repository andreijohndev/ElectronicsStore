using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(ShopSession))]
    public class ShopSession
    {
        public Guid Id { get; set; }

		[RegularExpression(@"^\d+(\.\d{0,2})*$", ErrorMessage = $"The field {nameof(Total)} must be a positive number with maximum two decimals.")]
		[DataType(DataType.Currency)]
		public decimal Total { get; set; }

        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}

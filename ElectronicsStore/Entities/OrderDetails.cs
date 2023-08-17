using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ElectronicsStore.Entities
{
    [Table(nameof(OrderDetails))]
    public class OrderDetails
    {
        public int Id { get; set; }

        [Required(ErrorMessage = $"The {nameof(ShopSessionId)} field is required")]
        public Guid ShopSessionId { get; set; }

        public required ShopSession Session { get; set; } // TODO: Maybe add support for users

        // TODO: Payment details ID

        [RegularExpression(@"^\d+(\.\d{0,2})*$", ErrorMessage = $"The field {nameof(Total)} must be a positive number with maximum two decimals.")]
        [DataType(DataType.Currency)]
        public decimal Total { get; set; }

        public DateTime OrderDate { get; private set; }

        public ICollection<OrderItem>? OrderItems { get; set; }
    }
}

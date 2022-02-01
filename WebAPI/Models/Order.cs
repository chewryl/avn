using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime OrderPlaced { get; set; }

        public DateTime? OrderFulfilled { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public ICollection<ProductOrder> ProductOrders { get; set; }
    }
}

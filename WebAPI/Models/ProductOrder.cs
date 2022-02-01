using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class ProductOrder
    {
        [Key]
        public int Id { get; set; }

        public int OrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public Product Product { get; set; }
    }
}
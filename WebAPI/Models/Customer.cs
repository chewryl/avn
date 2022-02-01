using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public string FirstName { get; set; }
       
        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? Town { get; set; }

        public string City { get; set; }

        public string? Country { get; set; }

        public string Postcode { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}

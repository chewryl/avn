using Microsoft.EntityFrameworkCore;
using WebAPI.Data;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class CustomerRepository
    {
        private readonly ArmyNavyDbContext _context;

        public CustomerRepository(ArmyNavyDbContext context)
        {
            _context = context;
        }

        public int? GetExistingCustomerId(Customer customer)
        {
            var id = _context.Customers.Where(c =>
                EF.Functions.Like(c.FirstName, customer.FirstName) &&
                EF.Functions.Like(c.LastName, customer.LastName) &&
                EF.Functions.Like(c.Email, customer.Email) &&
                EF.Functions.Like(c.Address1 ?? "", customer.Address1 ?? "") &&
                EF.Functions.Like(c.Address2 ?? "", customer.Address2 ?? "") &&
                EF.Functions.Like(c.Town ?? "", customer.Town ?? "") &&
                EF.Functions.Like(c.City, customer.City) &&
                EF.Functions.Like(c.Country ?? "", customer.Country ?? "") &&
                EF.Functions.Like(c.Postcode, customer.Postcode)
                ).FirstOrDefault()?.Id;

            return id;
        }
    }
}

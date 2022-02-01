using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerRepository _customerRepository;

        private readonly ILogger<CustomerController> _logger;

        public CustomerController(CustomerRepository customerRepository, ILogger<CustomerController> logger)
        {
            _logger = logger;
            _customerRepository = customerRepository;
        }

        [HttpGet]
        [Route("getId")]
        public IActionResult GetCustomerId([FromBody] Customer customer)
        {
            return Ok(_customerRepository.GetExistingCustomerId(customer));
        }
    }
}

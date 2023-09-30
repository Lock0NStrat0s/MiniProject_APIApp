using Microsoft.AspNetCore.Mvc;
using MiniProject_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniProject_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly ILogger<AddressController> _logger;

        public AddressController(ILogger<AddressController> logger)
        {
            _logger = logger;
        }

        // POST api/<AddressController>
        [HttpPost]
        public void Post([FromBody] AddressModel value)
        {
            _logger.LogInformation("Our address is {Address}", value);
        }
    }
}

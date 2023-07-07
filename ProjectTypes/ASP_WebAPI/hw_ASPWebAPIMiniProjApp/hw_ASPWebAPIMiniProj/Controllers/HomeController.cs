using hw_ASPWebAPIMiniProj.Models;
using Microsoft.AspNetCore.Mvc;

namespace hw_ASPWebAPIMiniProj.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpPost("person")]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            // Perform necessary operations to create a person
            // For this example, let's assume we just return the created person as JSON
            return Ok(person);
        }

        [HttpPost("address")]
        public IActionResult CreateAddress([FromBody] Address address)
        {
            // Perform necessary operations to create an address
            // For this example, let's assume we just return the created address as JSON
            return Ok(address);
        }
    }
}

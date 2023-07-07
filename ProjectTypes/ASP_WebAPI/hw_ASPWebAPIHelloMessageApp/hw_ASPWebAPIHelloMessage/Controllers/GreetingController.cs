using Microsoft.AspNetCore.Mvc;

namespace hw_ASPWebAPIHelloMessage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        [HttpGet("{firstName}/{lastName}")]
        public IActionResult GetGreeting(string firstName, string lastName)
        {
            string greeting = $"Hi {firstName} {lastName}";
            return Ok(greeting);
        }
    }
}

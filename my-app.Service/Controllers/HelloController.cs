using Microsoft.AspNetCore.Mvc;

namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        [Route("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }

        [HttpGet]
        [Route("Thank")]
        public IActionResult Thank()
        {
            return Ok("Thanks Rivka");
        }
    }
}

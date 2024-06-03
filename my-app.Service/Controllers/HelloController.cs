using Microsoft.AspNetCore.Mvc;
using HttpClient client = new();

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
          HttpClient client = new ();
           var json =  client.GetStringAsync("https://user4-donet-app.user4-application.cluster.local.svc/hello");
      
 
            return Ok("Thanks Rivka: " + json);
        }
    }
}

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
           HttpClient httpClient = new HttpClient();
           var result = httpClient.GetAsync("https://dotnet-app-user4-user4-application.apps.cluster-5shjw.dynamic.redhatworkshops.io/redhat/redhat");      
           Console.Write(result);
            return Ok("Thanks Rivka aaa: " + result);
        }
    }
}

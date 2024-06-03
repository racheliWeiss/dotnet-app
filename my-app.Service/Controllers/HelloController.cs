using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;


namespace my_app.Service.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public HelloController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        [Route("hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }

        [HttpGet]
        [Route("thank")]
        public async Task<IActionResult> Thank()
        {
           HttpResponseMessage response = await _httpClient.GetAsync("https://dotnet-app-user4-user4-application.apps.cluster-5shjw.dynamic.redhatworkshops.io/redhat/redhat");
            
            if (response != null)
            {
                 string responseBody = await response.Content.ReadAsStringAsync();
                return Ok($"Thanks Rivka aaa: {responseBody}");
            }
            else
            {
                return StatusCode((int)response.StatusCode, "Error fetching data.");
            }
        }
    }
}

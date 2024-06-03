using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

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
           HttpResponseMessage response = await _httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
            
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

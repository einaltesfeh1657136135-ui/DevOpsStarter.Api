using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsStarter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello DevOps");
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevOpsStarter.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        private readonly ILogger<HelloController> _logger;
        private readonly IConfiguration _configuration;

        public HelloController(
            ILogger<HelloController> logger,
            IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }
        [HttpGet]
        public IActionResult Get()
        {
            var appName = _configuration["App:Name"];
            var env = _configuration["App:Environment"];
            _logger.LogInformation("Hello endpoing called form {Environment}", env);

            return Ok($"Hello from {appName} ({env})");
        }
    }
}

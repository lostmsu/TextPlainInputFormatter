using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestTextController : ControllerBase
    {
        private readonly ILogger<TestTextController> _logger;

        public TestTextController(ILogger<TestTextController> logger)
        {
            _logger = logger;
        }

        [HttpPost(Name = "Text")]
        [Consumes("text/plain")]
        public IEnumerable<string> StringConsumer([FromBody] string text)
        {
            return text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Virtual_intelligent_assistant.Services;
using System.Threading.Tasks;

namespace Virtual_intelligent_assistant.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly OllamaService _ollamaService;

        public ChatController(OllamaService ollamaService)
        {
            _ollamaService = ollamaService;
        }

        [HttpPost("ask")]
        public async Task<IActionResult> Ask([FromBody] ChatRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Message))
                return BadRequest("Message cannot be empty.");

            var response = await _ollamaService.GetResponseAsync(request.Message);
            return Ok(new { response });
        }
    }

    public class ChatRequest
    {
        public string Message { get; set; } = string.Empty;
    }
}

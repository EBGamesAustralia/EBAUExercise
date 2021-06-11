using Microsoft.AspNetCore.Mvc;
using EBAUExercise.Services;

namespace EBAUExercise.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly DoWorkService _doWorkService;

        public MessageController(DoWorkService doWorkService)
        {
            _doWorkService = doWorkService;
        }

        [HttpGet("one")]
        public string GetOne()
        {
            return "This is one endpoint.";
        }
		
		[HttpGet("two")]
        public string GetAnother()
        {
            return "This is another endpoint.";
        }
    }
}

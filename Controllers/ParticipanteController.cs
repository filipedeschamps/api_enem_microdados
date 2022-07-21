using Microsoft.AspNetCore.Mvc;

namespace APIEnem.Controllers
{
    [ApiController]
    [Route("api/v1/content/[controller]")]
    public class ParticipanteController : ControllerBase
    {
        [HttpGet("{NúmeroInscrição}")]
        public IActionResult Get()
        {
            return Ok("Ok");
        }
    }
}

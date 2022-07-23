using Microsoft.AspNetCore.Mvc;
using APIEnem.Models.Candidato;

namespace APIEnem.Controllers
{
    [ApiController]
    [Route("api/v1/content/[controller]")]
    public class ParticipanteController : ControllerBase
    {
        [HttpGet("{NúmeroInscrição}")]
        public IActionResult Get()
        {
            return Ok("ok");
        }
    }
}

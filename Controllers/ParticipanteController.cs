using Microsoft.AspNetCore.Mvc;
using APIEnem.Models.Candidato;
using APIEnem.Models.Interfaces;
using System.Data;


namespace APIEnem.Controllers
{
    [ApiController]
    [Route("api/v1/content/[controller]")]
    public class ParticipanteController : ControllerBase
    {
        private readonly IDataParticipante _dataParticipante;

        public ParticipanteController(IDataParticipante dataParticipante)
        {
            this._dataParticipante = dataParticipante;
        }


        [HttpGet("{NúmeroInscrição}")]
        public IActionResult Get(string NúmeroInscrição)
        {
                return Ok(_dataParticipante.BUSCAR_INFORMACOES_DO_PARTICIPANTE(new NúmeroInscrição(NúmeroInscrição)));
        }
    }
}

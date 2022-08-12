using Microsoft.AspNetCore.Mvc;
using APIEnem.Models.Candidato;
using APIEnem.Models.Interfaces;
using Newtonsoft.Json;

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
            try
            {
                string Retorno = _dataParticipante.BUSCAR_INFORMACOES_DO_PARTICIPANTE(new NúmeroInscrição(NúmeroInscrição)).ToString();
                return (Retorno is null) ? NotFound("Não foi possível encontrar o número de inscrição") : Ok(Retorno);
            }
            catch
            {
                return BadRequest("Erro interno da API");
            }
        }
    }
}

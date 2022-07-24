using System.Data;
using APIEnem.Models.Candidato;

namespace APIEnem.Models.Interfaces
{
    public interface IDataParticipante
    {
        Json BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número);
    }
}

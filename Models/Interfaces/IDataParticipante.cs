using System.Data;
using APIEnem.Models.Candidato;

namespace APIEnem.Models.Interfaces
{
    public interface IDataParticipante
    {
        DataTable BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número);
    }
}

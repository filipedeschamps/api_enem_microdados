using MySql.Data.MySqlClient;
using System.Data;
using APIEnem.Models.Interfaces;

namespace APIEnem.Infra.Data.Participante
{
    public class BancoParticipante
    {
        private readonly IDataConnection _conexaoBanco;

        public BancoParticipante(IDataConnection conexaoBanco)
        {
            this._conexaoBanco = conexaoBanco;
        }

        public void BUSCAR_INFORMACOES_DO_PARTICIPANTE()
        {
            
        }
    }
}

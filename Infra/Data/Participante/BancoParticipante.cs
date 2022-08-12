using MySql.Data.MySqlClient;
using System.Data;
using APIEnem.Models.Interfaces;
using APIEnem.Models.Candidato;
using APIEnem.Models.Application;

namespace APIEnem.Infra.Data.Participante
{
    public class BancoParticipante : IDataParticipante
    {
        private readonly IDataConnection _conexaoBanco;

        public BancoParticipante(IDataConnection conexaoBanco)
        {
            this._conexaoBanco = conexaoBanco;
        }

        public async Task<Json> BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número)
        {
            try
            {
                using (MySqlCommand Comando = _conexaoBanco.ConectarBanco().CreateCommand())
                {
                    string querySql = "SELECT * FROM TB_DADOS WHERE NU_INSCRICAO = @NúmeroDeInscrição";
                    Comando.CommandText = querySql;
                    Comando.Parameters.AddWithValue("@NúmeroDeInscrição", Número.ToString());
                    using (DataTable Data = new DataTable())
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Comando))
                        {
                            await dataAdapter.FillAsync(Data);
                        }                        
                        return (Data.Rows.Count > 0) ? 
                            new Json(Data) : throw new Exception("O código do participante inserido não consta no banco de dados.");
                    }
                }
            }
            catch
            {
                throw;
            }
        }
    }
}

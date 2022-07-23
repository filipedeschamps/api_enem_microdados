using MySql.Data.MySqlClient;
using System.Data;
using APIEnem.Models.Interfaces;
using APIEnem.Models.Candidato;

namespace APIEnem.Infra.Data.Participante
{
    public class BancoParticipante : IDataParticipante
    {
        private readonly IDataConnection _conexaoBanco;

        public BancoParticipante(IDataConnection conexaoBanco)
        {
            this._conexaoBanco = conexaoBanco;
        }

        public DataTable BUSCAR_INFORMACOES_DO_PARTICIPANTE(NúmeroInscrição Número)
        {
            try
            {
                using (MySqlCommand Comando = _conexaoBanco.ConectarBanco().CreateCommand())
                {
                    Comando.CommandText = "SELECT * FROM TB_DADOS_ENEM WHERE NU_INSCRICAO = @NúmeroDeInscrição";
                    Comando.Parameters.AddWithValue("@NúmeroDeInscrição", Número.ToString());
                    using (DataTable Data = new DataTable())
                    {
                        using (MySqlDataAdapter dataAdapter = new MySqlDataAdapter(Comando))
                        {
                            dataAdapter.Fill(Data);
                        }

                        if (Data.Rows.Count > 0)
                        {
                            return Data;
                        }
                        else
                        {
                            throw new Exception("O código do participante inserido não consta no banco de dados.");
                        }
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

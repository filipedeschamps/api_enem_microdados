﻿using MySql.Data.MySqlClient;
using APIEnem.Models.Interfaces;

namespace APIEnem.Infra.Data
{
    public class Conexão : IDataConnection
    {
        public MySqlConnection ConectarBanco()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection("" +
                    "server=127.0.0.1;" +
                    "database=forum_artigos;" +
                    "uid=otavio;" +
                    "pwd=1234;" +
                    "port=3306");
                return conexao;
            }
            catch
            {
                throw new Exception("Não foi possível se conectar com o banco de dados");
            }
        }
    }
}

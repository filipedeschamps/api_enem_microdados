using MySql.Data.MySqlClient;

namespace APIEnem.Models.Interfaces
{
    public interface IDataConnection
    {
        MySqlConnection ConectarBanco();
    }
}

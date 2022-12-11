using Biosfera3.Models;
using Npgsql;

namespace Biosfera3.Repository
{
    public class VerificaParametros : IVerificaParametros
    {
        private NpgsqlConnection connection;
        private const string CONNECTION_STRING = "Server=localhost;Database=biosfera3;Port=5432;User Id=postgres;Password=adminWEB123#";
        public VerificaParametros()
        {
            connection = new NpgsqlConnection(CONNECTION_STRING);
            connection.Open();
        }
        public Task GetParametros(string model)
        {
            var local = model;
            string comando = $"SELECT * FROM monitoramento WHERE area = {local};";
            using (var cmd = new NpgsqlCommand(comando, connection))
            {
                var retorno = cmd.ExecuteReaderAsync();
                return retorno;
            }
        }
    }
}

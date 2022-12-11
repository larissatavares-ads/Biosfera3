using Biosfera3.Models;
using Biosfera3.Settings;
using Npgsql;

namespace Biosfera3.Repository
{
    public class CadastroPesquisadorRepo : ICadastroPesquisadorRepo
    {
        private NpgsqlConnection connection;
        private const string CONNECTION_STRING = "Server=localhost;Database=biosfera3;Port=5432;User Id=postgres;Password=adminWEB123#";
        public CadastroPesquisadorRepo()
        {
            connection = new NpgsqlConnection(CONNECTION_STRING);
            connection.Open();
        }
        public async Task SalvarPesquisador(Pesquisador pesquisador)
        {
            string comando = $"INSERT INTO pesquisador (nome) VALUES (@Nome);";
            await using (var cmd = new NpgsqlCommand(comando, connection))
            {
                cmd.Parameters.AddWithValue("nome", pesquisador.Nome);

                await cmd.ExecuteNonQueryAsync();
            }
        }
    }
}

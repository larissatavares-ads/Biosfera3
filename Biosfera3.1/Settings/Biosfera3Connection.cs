using Npgsql;

namespace Biosfera3.Settings
{
    public class Biosfera3Connection
    {
        private NpgsqlConnection connection;

        private const string CONNECTION_STRING = "Server=localhost;Database=biosfera3;Port=5432;User Id=postgres;Password=adminWEB123#";
        public Biosfera3Connection()
        {
            connection = new NpgsqlConnection(CONNECTION_STRING);
            connection.Open();
        }
    }
}

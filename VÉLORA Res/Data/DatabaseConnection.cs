using Microsoft.Data.SqlClient;

namespace VÉLORA_Res.Data
{
    public class DatabaseConnection
    {
        private readonly string _connectionString =
            @"Server=desktop-iqf6kio\joudy;
              Database=veloraresdb;
              Integrated Security=True;
              TrustServerCertificate=True;";

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public bool TestConnection()
        {
            try
            {
                using SqlConnection connection = CreateConnection();
                connection.Open();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
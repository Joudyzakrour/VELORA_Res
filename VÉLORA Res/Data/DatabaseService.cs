using System.Data;
using Microsoft.Data.SqlClient;

namespace VÉLORA_Res.Data
{
    public class DatabaseService
    {
        private readonly DatabaseConnection _databaseConnection;

        public DatabaseService(DatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public DataTable ExecuteQuery(string query)
        {
            using SqlConnection connection =
                _databaseConnection.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            using SqlDataAdapter adapter =
                new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }
    }
}
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class CategoryService
    {
        private readonly DatabaseConnection _database;

        public CategoryService(DatabaseConnection database)
        {
            _database = database;
        }

        public DataTable GetAll()
        {
            const string query = @"
        SELECT
            CategoryID,
            CategoryName,
            Description,
            IsActive
        FROM dbo.Categories
        ORDER BY CategoryID DESC;";

            using SqlConnection connection = _database.CreateConnection();
            using SqlCommand command = new SqlCommand(query, connection);
            using SqlDataAdapter adapter = new SqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        public void Add(Category category)
        {
            const string query = @"
        INSERT INTO dbo.Categories
            (CategoryName, Description, IsActive)
        VALUES
            (@CategoryName, @Description, @IsActive);";

            using SqlConnection connection = _database.CreateConnection();
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 100)
                .Value = category.Name;

            command.Parameters.Add("@Description", SqlDbType.NVarChar, 300)
                .Value = (object?)category.Description ?? DBNull.Value;

            command.Parameters.Add("@IsActive", SqlDbType.Bit)
                .Value = category.IsActive;

            connection.Open();
            command.ExecuteNonQuery();
        }
        public void Update(Category category)
        {
            const string query = @"
        UPDATE dbo.Categories
        SET
            CategoryName = @CategoryName,
            Description = @Description,
            IsActive = @IsActive
        WHERE CategoryID = @CategoryID;";

            using SqlConnection connection = _database.CreateConnection();
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@CategoryID", SqlDbType.Int)
                .Value = category.CategoryID;

            command.Parameters.Add("@CategoryName", SqlDbType.NVarChar, 100)
                .Value = category.Name;

            command.Parameters.Add("@Description", SqlDbType.NVarChar, 300)
                .Value = (object?)category.Description ?? DBNull.Value;

            command.Parameters.Add("@IsActive", SqlDbType.Bit)
                .Value = category.IsActive;

            connection.Open();
            command.ExecuteNonQuery();
        }

        public void Delete(int categoryId)
        {
            const string query = @"
                DELETE FROM dbo.Categories
                WHERE CategoryID = @CategoryID;";

            using SqlConnection connection = _database.CreateConnection();
            using SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.Add("@CategoryID", SqlDbType.Int)
                .Value = categoryId;

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class RestaurantTableService
    {
        private readonly DatabaseConnection _database;


        public RestaurantTableService(DatabaseConnection database)
        {
            _database = database;
        }

        // =========================
        // GET ALL TABLES
        // =========================

        public DataTable GetAll()
        {
            const string query = @"
                SELECT
                    TableID,
                    TableNumber,
                    Capacity,
                    Status
                FROM dbo.RestaurantTables
                ORDER BY TableNumber;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            using SqlDataAdapter adapter =
                new SqlDataAdapter(command);

            DataTable table =
                new DataTable();

            adapter.Fill(table);

            return table;
        }

        // =========================
        // ADD TABLE
        // =========================

        public void Add(RestaurantTable table)
        {
            const string query = @"
                INSERT INTO dbo.RestaurantTables
                (
                    TableNumber,
                    Capacity,
                    Status
                )
                VALUES
                (
                    @TableNumber,
                    @Capacity,
                    @Status
                );";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@TableNumber",
                table.TableNumber);

            command.Parameters.AddWithValue(
                "@Capacity",
                table.Capacity);

            command.Parameters.AddWithValue(
                "@Status",
                table.Status);

            connection.Open();
            command.ExecuteNonQuery();
        }

        // =========================
        // UPDATE TABLE
        // =========================

        public void Update(RestaurantTable table)
        {
            const string query = @"
                UPDATE dbo.RestaurantTables
                SET
                    TableNumber = @TableNumber,
                    Capacity = @Capacity,
                    Status = @Status
                WHERE
                    TableID = @TableID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@TableID",
                table.TableID);

            command.Parameters.AddWithValue(
                "@TableNumber",
                table.TableNumber);

            command.Parameters.AddWithValue(
                "@Capacity",
                table.Capacity);

            command.Parameters.AddWithValue(
                "@Status",
                table.Status);

            connection.Open();
            command.ExecuteNonQuery();
        }

        // =========================
        // DELETE TABLE
        // =========================

        public void Delete(int tableID)
        {
            const string query = @"
                DELETE FROM dbo.RestaurantTables
                WHERE TableID = @TableID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@TableID",
                tableID);

            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
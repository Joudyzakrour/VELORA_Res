 using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class InventoryService
    {
        private readonly DatabaseConnection _database;

        public InventoryService(DatabaseConnection database)
        {
            _database = database;
        }

        // Get all inventory
        public DataTable GetAll()
        {
            const string query = @"
                SELECT
                    InventoryID,
                    ProductID,
                    Quantity,
                    MinimumStock,
                    LastUpdated
                FROM dbo.Inventory
                ORDER BY InventoryID DESC;";

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

        // Add inventory
        public void Add(VÉLORA_Res.Models.Inventory inventory)
        {
            const string query = @"
                INSERT INTO dbo.Inventory
                (
                    ProductID,
                    Quantity,
                    MinimumStock,
                    LastUpdated
                )
                VALUES
                (
                    @ProductID,
                    @Quantity,
                    @MinimumStock,
                    @LastUpdated
                );";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@ProductID",
                SqlDbType.Int).Value =
                inventory.ProductID;

            command.Parameters.Add(
                "@Quantity",
                SqlDbType.Int).Value =
                inventory.Quantity;

            command.Parameters.Add(
                "@MinimumStock",
                SqlDbType.Int).Value =
                inventory.MinimumStock;

            command.Parameters.Add(
                "@LastUpdated",
                SqlDbType.DateTime).Value =
                inventory.LastUpdated;

            connection.Open();

            command.ExecuteNonQuery();
        }

        // Update inventory
        public void Update(VÉLORA_Res.Models. Inventory inventory)
        {
            const string query = @"
                UPDATE dbo.Inventory
                SET
                    ProductID = @ProductID,
                    Quantity = @Quantity,
                    MinimumStock = @MinimumStock,
                    LastUpdated = @LastUpdated
                WHERE InventoryID = @InventoryID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@InventoryID",
                SqlDbType.Int).Value =
                inventory.InventoryID;

            command.Parameters.Add(
                "@ProductID",
                SqlDbType.Int).Value =
                inventory.ProductID;

            command.Parameters.Add(
                "@Quantity",
                SqlDbType.Int).Value =
                inventory.Quantity;

            command.Parameters.Add(
                "@MinimumStock",
                SqlDbType.Int).Value =
                inventory.MinimumStock;

            command.Parameters.Add(
                "@LastUpdated",
                SqlDbType.DateTime).Value =
                inventory.LastUpdated;

            connection.Open();

            command.ExecuteNonQuery();
        }
 // Delete inventory
        public void Delete(int inventoryId)
        {
            const string query = @"
                DELETE FROM dbo.Inventory
                WHERE InventoryID = @InventoryID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@InventoryID",
                SqlDbType.Int).Value =
                inventoryId;

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}
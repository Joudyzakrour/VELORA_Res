using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class OrderDetailService
    {
        private readonly DatabaseConnection _database;

        public OrderDetailService(DatabaseConnection database)
        {
            _database = database;
        }

        public DataTable GetByOrderID(int orderId)
        {
            const string query = @"
        SELECT
            OrderDetailID,
            OrderID,
            ProductID,
            Quantity,
            UnitPrice,
            TotalPrice
        FROM dbo.OrderDetails
        WHERE OrderID = @OrderID
        ORDER BY OrderDetailID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@OrderID",
                SqlDbType.Int).Value =
                orderId;

            using SqlDataAdapter adapter =
                new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public void Add(OrderDetail detail)
        {
            const string query = @"
        INSERT INTO dbo.OrderDetails
        (
            OrderID,
            ProductID,
            Quantity,
            UnitPrice
        )
        VALUES
        (
            @OrderID,
            @ProductID,
            @Quantity,
            @UnitPrice
        );";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@OrderID",
                SqlDbType.Int).Value =
                detail.OrderID;

            command.Parameters.Add(
                "@ProductID",
                SqlDbType.Int).Value =
                detail.ProductID;

            command.Parameters.Add(
                "@Quantity",
                SqlDbType.Int).Value =
                detail.Quantity;

            command.Parameters.Add(
                "@UnitPrice",
                SqlDbType.Decimal).Value =
                detail.UnitPrice;

            connection.Open();

            command.ExecuteNonQuery();
        }
        public void Delete(int orderDetailId)
        {
            const string query = @"
        DELETE FROM dbo.OrderDetails
        WHERE OrderDetailID = @OrderDetailID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@OrderDetailID",
                SqlDbType.Int).Value =
                orderDetailId;

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}
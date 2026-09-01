 using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;

namespace VÉLORA_Res.Services
{
    public class AnalyticsService
    {
        private readonly DatabaseConnection _database;

        public AnalyticsService(DatabaseConnection database)
        {
            _database = database;
        }

        // =========================
        // TOTAL SALES
        // =========================

        public decimal GetTotalSales()
        {
            const string query = @"
                SELECT ISNULL(SUM(TotalAmount), 0)
                FROM dbo.Orders;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToDecimal(
                command.ExecuteScalar());
        }

        // =========================
        // TOTAL ORDERS
        // =========================

        public int GetTotalOrders()
        {
            const string query = @"
                SELECT COUNT(*)
                FROM dbo.Orders;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToInt32(
                command.ExecuteScalar());
        }

        // =========================
        // TOTAL ITEMS SOLD
        // =========================

        public int GetTotalItemsSold()
        {
            const string query = @"
                SELECT ISNULL(SUM(Quantity), 0)
                FROM dbo.OrderDetails;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToInt32(
                command.ExecuteScalar());
        }

        // =========================
        // AVERAGE ORDER
        // =========================

        public decimal GetAverageOrder()
        {
            const string query = @"
                SELECT ISNULL(AVG(TotalAmount), 0)
                FROM dbo.Orders;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToDecimal(
                command.ExecuteScalar());
        }

        // =========================
        // BEST SELLING PRODUCTS
        // =========================

        public DataTable GetBestSellingProducts()
        {
            const string query = @"
                SELECT TOP 5
                    p.ProductName,
                    SUM(od.Quantity) AS QuantitySold,
                    SUM(od.TotalPrice) AS Sales
                FROM dbo.OrderDetails od
                INNER JOIN dbo.Products p
                    ON od.ProductID = p.ProductID
                INNER JOIN dbo.Orders o
                    ON od.OrderID = o.OrderID
                GROUP BY
                    p.ProductName
                ORDER BY
                    QuantitySold DESC;";

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
        // SALES BY DATE
        // =========================
        public DataTable GetSalesByDate()
        {
            const string query = @"
        SELECT
            CONVERT(varchar(10), CAST(OrderDate AS DATE), 103) AS SaleDate,
            SUM(TotalAmount) AS Sales
        FROM dbo.Orders
        GROUP BY
            CAST(OrderDate AS DATE)
        ORDER BY
            CAST(OrderDate AS DATE);";

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
    }
}
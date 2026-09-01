 using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class OrderService
    {
        private readonly DatabaseConnection _database;

        public OrderService(DatabaseConnection database)
        {
            _database = database;
        }

        public DataTable GetAll()
        {
            const string query = @"
SELECT
    o.OrderID,
    c.FullName AS Customer,
    rt.TableNumber AS [Table],
    e.EmployeeID AS Employee,
    o.OrderDate,
    o.Status,
    o.Subtotal,
    o.Discount,
    o.Tax,
    o.TotalAmount
FROM dbo.Orders o
INNER JOIN dbo.Customers c
    ON o.CustomerID = c.CustomerID
INNER JOIN dbo.RestaurantTables rt
    ON o.TableID = rt.TableID
INNER JOIN dbo.Employees e
    ON o.EmployeeID = e.EmployeeID
ORDER BY o.OrderID DESC;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            using SqlDataAdapter adapter =
                new SqlDataAdapter(command);

            DataTable table = new DataTable();

            adapter.Fill(table);

            return table;
        }

        public int Add(Order order)
        {
            const string query = @"
        INSERT INTO dbo.Orders
        (
            CustomerID,
            TableID,
            EmployeeID,
            OrderDate,
            Status,
            Subtotal,
            Discount,
            Tax,
            TotalAmount
        )
        OUTPUT INSERTED.OrderID
        VALUES
        (
            @CustomerID,
            @TableID,
            @EmployeeID,
            @OrderDate,
            @Status,
            @Subtotal,
            @Discount,
            @Tax,
            @TotalAmount
        );";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@CustomerID",
                SqlDbType.Int).Value =
                order.CustomerID;

            command.Parameters.Add(
                "@TableID",
                SqlDbType.Int).Value =
                order.TableID;

            command.Parameters.Add(
                "@EmployeeID",
                SqlDbType.Int).Value =
                order.EmployeeID;

            command.Parameters.Add(
                "@OrderDate",
                SqlDbType.DateTime).Value =
                order.OrderDate;

            command.Parameters.Add(
                "@Status",
                SqlDbType.NVarChar,
                50).Value =
                order.Status;

            command.Parameters.Add(
                "@Subtotal",
                SqlDbType.Decimal).Value =
                order.Subtotal;

            command.Parameters.Add(
                "@Discount",
                SqlDbType.Decimal).Value =
                order.Discount;

            command.Parameters.Add(
                "@Tax",
                SqlDbType.Decimal).Value =
                order.Tax;

            command.Parameters.Add(
                "@TotalAmount",
                SqlDbType.Decimal).Value =
                order.TotalAmount;

            connection.Open();

            return Convert.ToInt32(
                command.ExecuteScalar());
        }
        public void Update(Order order)
        {
            const string query = @"
        UPDATE dbo.Orders
        SET
            CustomerID = @CustomerID,
            TableID = @TableID,
            EmployeeID = @EmployeeID,
            OrderDate = @OrderDate,
            Status = @Status,
            Subtotal = @Subtotal,
            Discount = @Discount,
            Tax = @Tax,
            TotalAmount = @TotalAmount
        WHERE OrderID = @OrderID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);
 command.Parameters.Add(
                "@OrderID",
                SqlDbType.Int).Value =
                order.OrderID;

            command.Parameters.Add(
                "@CustomerID",
                SqlDbType.Int).Value =
                order.CustomerID;

            command.Parameters.Add(
                "@TableID",
                SqlDbType.Int).Value =
                order.TableID;

            command.Parameters.Add(
                "@EmployeeID",
                SqlDbType.Int).Value =
                order.EmployeeID;

            command.Parameters.Add(
                "@OrderDate",
                SqlDbType.DateTime).Value =
                order.OrderDate;

            command.Parameters.Add(
                "@Status",
                SqlDbType.NVarChar,
                50).Value =
                order.Status;

            command.Parameters.Add(
                "@Subtotal",
                SqlDbType.Decimal).Value =
                order.Subtotal;

            command.Parameters.Add(
                "@Discount",
                SqlDbType.Decimal).Value =
                order.Discount;

            command.Parameters.Add(
                "@Tax",
                SqlDbType.Decimal).Value =
                order.Tax;

            command.Parameters.Add(
                "@TotalAmount",
                SqlDbType.Decimal).Value =
                order.TotalAmount;

            connection.Open();

            command.ExecuteNonQuery();
        }

        public void Delete(int orderId)
        {
            const string query = @"
        DELETE FROM dbo.Orders
        WHERE OrderID = @OrderID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@OrderID",
                SqlDbType.Int).Value =
                orderId;

            connection.Open();

            command.ExecuteNonQuery();
        }
        public decimal GetTotalSales()
        {
            const string query = @"
        SELECT ISNULL(SUM(TotalAmount), 0)
        FROM dbo.Orders
        WHERE Status <> 'Cancelled';";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToDecimal(
                command.ExecuteScalar());
        }

        public int GetOrderCount()
        {
            const string query = @"
        SELECT COUNT(*)
        FROM dbo.Orders
        WHERE Status <> 'Cancelled';";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToInt32(
                command.ExecuteScalar());
        }

        public decimal GetNetProfit()
        {
            const string query = @"
        SELECT ISNULL(SUM(
            TotalAmount - Discount
        ), 0)
        FROM dbo.Orders
        WHERE Status <> 'Cancelled';";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToDecimal(
                command.ExecuteScalar());
        }
        public int GetCustomerCount()
        {
            const string query = @"
        SELECT COUNT(*)
        FROM dbo.Customers;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            connection.Open();

            return Convert.ToInt32(
                command.ExecuteScalar());
        }
    }

}
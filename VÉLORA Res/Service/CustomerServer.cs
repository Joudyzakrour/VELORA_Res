 using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class CustomerService
    {
        private readonly DatabaseConnection _database;

        public CustomerService(DatabaseConnection database)
        {
            _database = database;
        }

        public DataTable GetAll()
        {
            const string query = @"
        SELECT
            CustomerID,
            FullName,
            Phone,
            Email,
            CreatedAt
        FROM dbo.Customers
        ORDER BY CustomerID DESC;";

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

        public void Add(Customer customer)
        {
            const string query = @"
        INSERT INTO dbo.Customers
            (FullName, Phone, Email, CreatedAt)
        VALUES
            (@FullName, @Phone, @Email, @CreatedAt);";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@FullName",
                SqlDbType.NVarChar,
                100).Value = customer.FullName;

            command.Parameters.Add(
                "@Phone",
                SqlDbType.NVarChar,
                20).Value =
                (object?)customer.Phone ?? DBNull.Value;

            command.Parameters.Add(
                "@Email",
                SqlDbType.NVarChar,
                150).Value =
                (object?)customer.Email ?? DBNull.Value;

            command.Parameters.Add(
                "@CreatedAt",
                SqlDbType.DateTime).Value =
                customer.CreatedAt;

            connection.Open();

            command.ExecuteNonQuery();
        }

        public void Update(Customer customer)
        {
            const string query = @"
        UPDATE dbo.Customers
        SET
            FullName = @FullName,
            Phone = @Phone,
            Email = @Email
        WHERE CustomerID = @CustomerID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@CustomerID",
                SqlDbType.Int).Value =
                customer.CustomerID;

            command.Parameters.Add(
                "@FullName",
                SqlDbType.NVarChar,
                100).Value =
                customer.FullName;

            command.Parameters.Add(
                "@Phone",
                SqlDbType.NVarChar,
                20).Value =
                (object?)customer.Phone ?? DBNull.Value;

            command.Parameters.Add(
                "@Email",
                SqlDbType.NVarChar,
                150).Value =
                (object?)customer.Email ?? DBNull.Value;

            connection.Open();

            command.ExecuteNonQuery();
        }
        public void Delete(int customerId)
        {
            const string query = @"
                DELETE FROM dbo.Customers
                WHERE CustomerID = @CustomerID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@CustomerID",
                SqlDbType.Int
            ).Value = customerId;

            connection.Open();

            command.ExecuteNonQuery();
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
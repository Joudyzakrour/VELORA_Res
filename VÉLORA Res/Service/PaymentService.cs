 using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class PaymentService
    {
        private readonly DatabaseConnection _database;

        public PaymentService(DatabaseConnection database)
        {
            _database = database;
        }

        // =========================
        // GET ALL PAYMENTS
        // =========================

        public DataTable GetAll()
        {
            const string query = @"
                SELECT
                    PaymentID,
                    OrderID,
                    PaymentDate,
                    Amount,
                    PaymentMethod
                FROM dbo.Payments
                ORDER BY PaymentDate DESC;";

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
        // ADD PAYMENT
        // =========================

        public void Add(Payment payment)
        {
            const string query = @"
                INSERT INTO dbo.Payments
                (
                    OrderID,
                    PaymentDate,
                    Amount,
                    PaymentMethod
                )
                VALUES
                (
                    @OrderID,
                    @PaymentDate,
                    @Amount,
                    @PaymentMethod
                );";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@OrderID",
                payment.OrderID);

            command.Parameters.AddWithValue(
                "@PaymentDate",
                payment.PaymentDate);

            command.Parameters.AddWithValue(
                "@Amount",
                payment.Amount);

            command.Parameters.AddWithValue(
                "@PaymentMethod",
                payment.PaymentMethod);

            connection.Open();

            command.ExecuteNonQuery();
        }

        // =========================
        // UPDATE PAYMENT
        // =========================

        public void Update(Payment payment)
        {
            const string query = @"
                UPDATE dbo.Payments
                SET
                    OrderID = @OrderID,
                    PaymentDate = @PaymentDate,
                    Amount = @Amount,
                    PaymentMethod = @PaymentMethod
                WHERE
                    PaymentID = @PaymentID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@PaymentID",
                payment.PaymentID);

            command.Parameters.AddWithValue(
                "@OrderID",
                payment.OrderID);

            command.Parameters.AddWithValue(
                "@PaymentDate",
                payment.PaymentDate);

            command.Parameters.AddWithValue(
                "@Amount",
                payment.Amount);

            command.Parameters.AddWithValue(
                "@PaymentMethod",
                payment.PaymentMethod);

            connection.Open();

            command.ExecuteNonQuery();
        }

        // =========================
        // DELETE PAYMENT
        // =========================

        public void Delete(int paymentID)
        {
            const string query = @"
                DELETE FROM dbo.Payments
                WHERE PaymentID = @PaymentID;";
 using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@PaymentID",
                paymentID);

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}
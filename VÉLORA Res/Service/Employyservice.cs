 using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class EmployeeService
    {
        private readonly DatabaseConnection _database;

        public EmployeeService(DatabaseConnection database)
        {
            _database = database;
        }

        public DataTable GetAll()
        {
            const string query = @"
                SELECT
                    EmployeeID,
                    FullName,
                    Phone,
                    JobTitle,
                    Salary,
                    IsActive,
                    CreatedAt
                FROM dbo.Employees
                ORDER BY EmployeeID DESC;";

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

        public void Add(Employee employee)
        {
            const string query = @"
                INSERT INTO dbo.Employees
                    (
                        FullName,
                        Phone,
                        JobTitle,
                        Salary,
                        IsActive,
                        CreatedAt
                    )
                VALUES
                    (
                        @FullName,
                        @Phone,
                        @JobTitle,
                        @Salary,
                        @IsActive,
                        @CreatedAt
                    );";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@FullName",
                SqlDbType.NVarChar,
                100).Value =
                employee.FullName;

            command.Parameters.Add(
                "@Phone",
                SqlDbType.NVarChar,
                20).Value =
                (object?)employee.Phone ?? DBNull.Value;

            command.Parameters.Add(
                "@JobTitle",
                SqlDbType.NVarChar,
                50).Value =
                employee.JobTitle;

            SqlParameter salaryParameter =
                command.Parameters.Add(
                    "@Salary",
                    SqlDbType.Decimal);

            salaryParameter.Precision = 10;
            salaryParameter.Scale = 2;
            salaryParameter.Value =
                (object?)employee.Salary ?? DBNull.Value;

            command.Parameters.Add(
                "@IsActive",
                SqlDbType.Bit).Value =
                employee.IsActive;

            command.Parameters.Add(
                "@CreatedAt",
                SqlDbType.DateTime).Value =
                employee.CreatedAt;

            connection.Open();

            command.ExecuteNonQuery();
        }

        public void Update(Employee employee)
        {
            const string query = @"
                UPDATE dbo.Employees
                SET
                    FullName = @FullName,
                    Phone = @Phone,
                    JobTitle = @JobTitle,
                    Salary = @Salary,
                    IsActive = @IsActive
                WHERE EmployeeID = @EmployeeID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@EmployeeID",
                SqlDbType.Int).Value =
                employee.EmployeeID;

            command.Parameters.Add(
                "@FullName",
                SqlDbType.NVarChar,
                100).Value =
                employee.FullName;
 command.Parameters.Add(
                "@Phone",
                SqlDbType.NVarChar,
                20).Value =
                (object?)employee.Phone ?? DBNull.Value;

            command.Parameters.Add(
                "@JobTitle",
                SqlDbType.NVarChar,
                50).Value =
                employee.JobTitle;

            SqlParameter salaryParameter =
                command.Parameters.Add(
                    "@Salary",
                    SqlDbType.Decimal);

            salaryParameter.Precision = 10;
            salaryParameter.Scale = 2;
            salaryParameter.Value =
                (object?)employee.Salary ?? DBNull.Value;

            command.Parameters.Add(
                "@IsActive",
                SqlDbType.Bit).Value =
                employee.IsActive;

            connection.Open();

            command.ExecuteNonQuery();
        }

        public void Delete(int employeeId)
        {
            const string query = @"
                DELETE FROM dbo.Employees
                WHERE EmployeeID = @EmployeeID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.Add(
                "@EmployeeID",
                SqlDbType.Int).Value =
                employeeId;

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}
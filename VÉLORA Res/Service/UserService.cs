 using System;
using System.Data;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;

namespace VÉLORA_Res.Services
{
    public class UserService
    {
        private readonly DatabaseConnection _database;

        public UserService(DatabaseConnection database)
        {
            _database = database;
        }

        // =========================
        // GET ALL USERS
        // =========================

        public DataTable GetAll()
        {
            const string query = @"
                SELECT
                    UserID,
                    EmployeeID,
                    Username,
                    Role,
                    IsActive
                FROM dbo.Users
                ORDER BY Username;";

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
        // FIND USER FOR LOGIN
        // =========================

        public User? Authenticate(
            string username,
            string passwordHash)
        {
            const string query = @"
                SELECT TOP 1
                    UserID,
                    EmployeeID,
                    Username,
                    PasswordHash,
                    Role,
                    IsActive
                FROM dbo.Users
                WHERE
                    Username = @Username
                    AND PasswordHash = @PasswordHash
                    AND IsActive = 1;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@Username",
                username);

            command.Parameters.AddWithValue(
                "@PasswordHash",
                passwordHash);

            connection.Open();

            using SqlDataReader reader =
                command.ExecuteReader();

            if (!reader.Read())
                return null;

            return new User
            {
                UserID =
                    Convert.ToInt32(
                        reader["UserID"]),

                EmployeeID =
                    Convert.ToInt32(
                        reader["EmployeeID"]),

                Username =
                    reader["Username"]
                        .ToString()
                    ?? string.Empty,

                PasswordHash =
                    reader["PasswordHash"]
                        .ToString()
                    ?? string.Empty,

                Role =
                    reader["Role"]
                        .ToString()
                    ?? string.Empty,

                IsActive =
                    Convert.ToBoolean(
                        reader["IsActive"])
            };
        }

        // =========================
        // ADD USER
        // =========================

        public void Add(User user)
        {
            const string query = @"
                INSERT INTO dbo.Users
                (
                    EmployeeID,
                    Username,
                    PasswordHash,
                    Role,
                    IsActive
                )
                VALUES
                (
                    @EmployeeID,
                    @Username,
                    @PasswordHash,
                    @Role,
                    @IsActive
                );";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);
 command.Parameters.AddWithValue(
                "@EmployeeID",
                user.EmployeeID);

            command.Parameters.AddWithValue(
                "@Username",
                user.Username);

            command.Parameters.AddWithValue(
                "@PasswordHash",
                user.PasswordHash);

            command.Parameters.AddWithValue(
                "@Role",
                user.Role);

            command.Parameters.AddWithValue(
                "@IsActive",
                user.IsActive);

            connection.Open();

            command.ExecuteNonQuery();
        }

        // =========================
        // UPDATE USER
        // =========================

        public void Update(User user)
        {
            const string query = @"
                UPDATE dbo.Users
                SET
                    EmployeeID = @EmployeeID,
                    Username = @Username,
                    PasswordHash = @PasswordHash,
                    Role = @Role,
                    IsActive = @IsActive
                WHERE
                    UserID = @UserID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@UserID",
                user.UserID);

            command.Parameters.AddWithValue(
                "@EmployeeID",
                user.EmployeeID);

            command.Parameters.AddWithValue(
                "@Username",
                user.Username);

            command.Parameters.AddWithValue(
                "@PasswordHash",
                user.PasswordHash);

            command.Parameters.AddWithValue(
                "@Role",
                user.Role);

            command.Parameters.AddWithValue(
                "@IsActive",
                user.IsActive);

            connection.Open();

            command.ExecuteNonQuery();
        }

        // =========================
        // DELETE USER
        // =========================

        public void Delete(int userID)
        {
            const string query = @"
                DELETE FROM dbo.Users
                WHERE UserID = @UserID;";

            using SqlConnection connection =
                _database.CreateConnection();

            using SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue(
                "@UserID",
                userID);

            connection.Open();

            command.ExecuteNonQuery();
        }
    }
}
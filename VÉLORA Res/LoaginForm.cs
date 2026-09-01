using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class LoginForm : Form
    {
        private readonly UserService userService;

        public LoginForm()
        {
            InitializeComponent();

            DatabaseConnection database =
                new DatabaseConnection();

            userService =
                new UserService(database);

            ConfigureEvents();
        }

        private void ConfigureEvents()
        {
            btnLogin.Click += btnLogin_Click;

            txtPassword.KeyDown +=
                txtPassword_KeyDown;
        }

        private void btnLogin_Click(
            object? sender,
            EventArgs e)
        {
            Login();
        }

        private void txtPassword_KeyDown(
            object? sender,
            KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Login();
            }
        }

        private void Login()
        {
            string username =
                txtUsername.Text.Trim();

            string password =
                txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Please enter your username.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your password.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();
                return;
            }

            try
            {
                string passwordHash =
                    HashPassword(password);

                User? user =
                    userService.Authenticate(
                        username,
                        passwordHash);

                if (user == null)
                {
                    MessageBox.Show(
                        "Invalid username or password.",
                        "VÉLORA RES",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    txtPassword.SelectAll();
                    txtPassword.Focus();

                    return;
                }

                Form1 dashboard =
    new Form1();

                dashboard.Show();

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Login failed.\n\n" +
                    ex.Message,
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private string HashPassword(
            string password)
        {
            using SHA256 sha256 =
                SHA256.Create();

            byte[] bytes =
                Encoding.UTF8.GetBytes(password);

            byte[] hash =
                sha256.ComputeHash(bytes);

            StringBuilder builder =
                new StringBuilder();

            foreach (byte b in hash)
            {
                builder.Append(
                    b.ToString("x2"));
            }

            return builder.ToString();
        }
    }
}
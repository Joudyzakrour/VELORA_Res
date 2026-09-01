 using System;
using System.Data;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class UsersForm : Form
    {
        private readonly UserService userService;
        private int selectedUserID = 0;

        public UsersForm()
        {
            InitializeComponent();

            DatabaseConnection database =
                new DatabaseConnection();

            userService =
                new UserService(database);

            ConfigureEvents();
            LoadUsers();
        }

        private void ConfigureEvents()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;

            dgvUsers.CellClick += dgvUsers_CellClick;
        }

        // =========================
        // LOAD USERS
        // =========================

        private void LoadUsers()
        {
            try
            {
                DataTable data =
                    userService.GetAll();

                dgvUsers.DataSource = data;

                ConfigureGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load users.\n\n" +
                    ex.Message,
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // GRID
        // =========================

        private void ConfigureGrid()
        {
            if (dgvUsers.Columns.Contains("UserID"))
            {
                dgvUsers.Columns["UserID"]
                    .HeaderText = "ID";
            }

            if (dgvUsers.Columns.Contains("EmployeeID"))
            {
                dgvUsers.Columns["EmployeeID"]
                    .HeaderText = "EMPLOYEE";
            }

            if (dgvUsers.Columns.Contains("Username"))
            {
                dgvUsers.Columns["Username"]
                    .HeaderText = "USERNAME";
            }

            if (dgvUsers.Columns.Contains("Role"))
            {
                dgvUsers.Columns["Role"]
                    .HeaderText = "ROLE";
            }

            if (dgvUsers.Columns.Contains("IsActive"))
            {
                dgvUsers.Columns["IsActive"]
                    .HeaderText = "ACTIVE";
            }
        }

        // =========================
        // ADD
        // =========================

        private void btnAdd_Click(
            object? sender,
            EventArgs e)
        {
            if (!ValidateFields(true))
                return;

            try
            {
                User user =
                    new User
                    {
                        EmployeeID =
                            int.Parse(
                                txtEmployeeID.Text.Trim()),

                        Username =
                            txtUsername.Text.Trim(),

                        PasswordHash =
                            HashPassword(
                                txtPassword.Text),

                        Role =
                            cmbRole.SelectedItem?
                                .ToString()
                            ?? "Employee",

                        IsActive =
                            chkActive.Checked
                    };
     
                userService.Add(user);

                MessageBox.Show(
                    "User added successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add user.\n\n" +
                    ex.Message,
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // UPDATE
        // =========================

        private void btnUpdate_Click(
            object? sender,
            EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show(
                    "Please select a user first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateFields(false))
                return;

            try
            {
                User user =
                    new User
                    {
                        UserID =
                            selectedUserID,

                        EmployeeID =
                            int.Parse(
                                txtEmployeeID.Text.Trim()),

                        Username =
                            txtUsername.Text.Trim(),

                        Role =
                            cmbRole.SelectedItem?
                                .ToString()
                            ?? "Employee",

                        IsActive =
                            chkActive.Checked
                    };

                // إذا أدخلنا كلمة مرور جديدة،
                // نعمل لها Hash ونحدثها.
                if (!string.IsNullOrWhiteSpace(
                        txtPassword.Text))
                {
                    user.PasswordHash =
                        HashPassword(
                            txtPassword.Text);
                }
                else
                {
                    DataGridViewRow row =
                        dgvUsers.SelectedRows[0];

                    // لا نعرض الـPasswordHash في Grid،
                    // لذلك نرفض التحديث بدون كلمة مرور
                    // إذا لم يكن لدينا قيمة محفوظة.
                    MessageBox.Show(
                        "Please enter a new password when updating a user.",
                        "VÉLORA RES",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                userService.Update(user);

                MessageBox.Show(
                    "User updated successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update user.\n\n" +
                    ex.Message,
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // DELETE
        // =========================

        private void btnDelete_Click(
            object? sender,
            EventArgs e)
        {
            if (selectedUserID == 0)
            {
                MessageBox.Show(
                    "Please select a user first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this user?",
                    "VÉLORA RES",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                userService.Delete(
                    selectedUserID);
                    MessageBox.Show(
                                        "User deleted successfully.",
                                        "VÉLORA RES",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete user.\n\n" +
                    ex.Message,
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================
        // REFRESH
        // =========================

        private void btnRefresh_Click(
            object? sender,
            EventArgs e)
        {
            LoadUsers();
        }

        // =========================
        // SELECT USER
        // =========================

        private void dgvUsers_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvUsers.Rows[e.RowIndex];

            if (row.Cells["UserID"].Value == null)
                return;

            selectedUserID =
                Convert.ToInt32(
                    row.Cells["UserID"].Value);

            txtEmployeeID.Text =
                row.Cells["EmployeeID"]
                    .Value?
                    .ToString()
                ?? string.Empty;

            txtUsername.Text =
                row.Cells["Username"]
                    .Value?
                    .ToString()
                ?? string.Empty;

            string role =
                row.Cells["Role"]
                    .Value?
                    .ToString()
                ?? "Employee";

            cmbRole.SelectedItem =
                role;

            chkActive.Checked =
                row.Cells["IsActive"].Value != null &&
                Convert.ToBoolean(
                    row.Cells["IsActive"].Value);

            // كلمة المرور لا يتم تحميلها
            // من قاعدة البيانات إلى الواجهة.
            txtPassword.Clear();
        }

        // =========================
        // VALIDATION
        // =========================

        private bool ValidateFields(
            bool passwordRequired)
        {
            if (!int.TryParse(
                    txtEmployeeID.Text.Trim(),
                    out int employeeID) ||
                employeeID <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid Employee ID.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtEmployeeID.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                    txtUsername.Text))
            {
                MessageBox.Show(
                    "Please enter a username.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsername.Focus();

                return false;
            }

            if (passwordRequired &&
                string.IsNullOrWhiteSpace(
                    txtPassword.Text))
            {
                MessageBox.Show(
                    "Please enter a password.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtPassword.Focus();

                return false;
            }

            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a role.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbRole.Focus();

                return false;
            }

            return true;
        }

        // =========================
        // PASSWORD HASH
        // =========================
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

        // =========================
        // CLEAR
        // =========================

        private void ClearFields()
        {
            selectedUserID = 0;

            txtEmployeeID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();

            cmbRole.SelectedIndex = 0;

            chkActive.Checked = true;

            dgvUsers.ClearSelection();
        }
    }
}




 using System;
using System.Data;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class EmployeesForm : Form
    {
        private readonly EmployeeService _employeeService;

        private int _selectedEmployeeId = 0;

        public EmployeesForm()
        {
            InitializeComponent();

            _employeeService =
                new EmployeeService(
                    new DatabaseConnection());

            ConfigureEvents();

            LoadEmployees();

            ClearFields();
        }

        private void ConfigureEvents()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            txtSearch.TextChanged +=
                txtSearch_TextChanged;

            dgvEmployees.CellClick +=
                dgvEmployees_CellClick;
        }

        // =========================
        // LOAD
        // =========================

        private void LoadEmployees()
        {
            try
            {
                dgvEmployees.DataSource =
                    _employeeService.GetAll();

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void ConfigureGrid()
        {
            if (dgvEmployees.Columns.Count == 0)
                return;

            dgvEmployees.Columns["EmployeeID"]
                .HeaderText = "ID";

            dgvEmployees.Columns["FullName"]
                .HeaderText = "Full Name";

            dgvEmployees.Columns["Phone"]
                .HeaderText = "Phone";

            dgvEmployees.Columns["JobTitle"]
                .HeaderText = "Job Title";

            dgvEmployees.Columns["Salary"]
                .HeaderText = "Salary";

            dgvEmployees.Columns["IsActive"]
                .HeaderText = "Active";

            dgvEmployees.Columns["CreatedAt"]
                .HeaderText = "Created At";
        }

        // =========================
        // ADD
        // =========================

        private void btnAdd_Click(
            object? sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Employee employee =
                    GetEmployeeFromFields();

                _employeeService.Add(employee);

                MessageBox.Show(
                    "Employee added successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadEmployees();

                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // =========================
        // UPDATE
        // =========================

        private void btnUpdate_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedEmployeeId == 0)
            {
                MessageBox.Show(
                    "Please select an employee first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInput())
                return;

            try
            {
                Employee employee =
                    GetEmployeeFromFields();

                employee.EmployeeID =
                    _selectedEmployeeId;

                _employeeService.Update(employee);

                MessageBox.Show(
                    "Employee updated successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadEmployees();
               ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // =========================
        // DELETE
        // =========================

        private void btnDelete_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedEmployeeId == 0)
            {
                MessageBox.Show(
                    "Please select an employee first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _employeeService.Delete(
                    _selectedEmployeeId);

                MessageBox.Show(
                    "Employee deleted successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadEmployees();

                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        // =========================
        // CLEAR
        // =========================

        private void btnClear_Click(
            object? sender,
            EventArgs e)
        {
            ClearFields();
        }

        // =========================
        // SELECT ROW
        // =========================

        private void dgvEmployees_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvEmployees.Rows[e.RowIndex];

            _selectedEmployeeId =
                Convert.ToInt32(
                    row.Cells["EmployeeID"].Value);

            txtFullName.Text =
                row.Cells["FullName"].Value?.ToString();

            txtPhone.Text =
                row.Cells["Phone"].Value?.ToString();

            txtJobTitle.Text =
                row.Cells["JobTitle"].Value?.ToString();

            txtSalary.Text =
                row.Cells["Salary"].Value?.ToString();

            chkIsActive.Checked =
                Convert.ToBoolean(
                    row.Cells["IsActive"].Value);
        }

        // =========================
        // SEARCH
        // =========================

        private void txtSearch_TextChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvEmployees.DataSource
                is not DataTable table)
                return;

            string search =
                txtSearch.Text.Trim()
                    .Replace("'", "''");

            if (string.IsNullOrWhiteSpace(search))
            {
                table.DefaultView.RowFilter =
                    string.Empty;

                return;
            }

            table.DefaultView.RowFilter =
                $"FullName LIKE '%{search}%' OR " +
                $"Phone LIKE '%{search}%' OR " +
                $"JobTitle LIKE '%{search}%'";
        }

        // =========================
        // CREATE EMPLOYEE
        // =========================

        private Employee GetEmployeeFromFields()
        {
            decimal? salary = null;

            if (!string.IsNullOrWhiteSpace(
                txtSalary.Text))
            {
                if (!decimal.TryParse(
                    txtSalary.Text,
                    out decimal parsedSalary))
                {
                    throw new Exception(
                        "Salary must be a valid number.");
                }

                salary = parsedSalary;
            }
           return new Employee
            {
                FullName =
                                txtFullName.Text.Trim(),

                Phone =
                                string.IsNullOrWhiteSpace(
                                    txtPhone.Text)
                                    ? null
                                    : txtPhone.Text.Trim(),

                JobTitle =
                                txtJobTitle.Text.Trim(),

                Salary =
                                salary,

                IsActive =
                                chkIsActive.Checked,

                CreatedAt =
                                DateTime.Now
            };
        }

        // =========================
        // VALIDATION
        // =========================

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(
                txtFullName.Text))
            {
                MessageBox.Show(
                    "Please enter the employee name.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();

                return false;
            }

            if (string.IsNullOrWhiteSpace(
                txtJobTitle.Text))
            {
                MessageBox.Show(
                    "Please enter the job title.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtJobTitle.Focus();

                return false;
            }

            return true;
        }

        // =========================
        // CLEAR FIELDS
        // =========================

        private void ClearFields()
        {
            _selectedEmployeeId = 0;

            txtFullName.Clear();
            txtPhone.Clear();
            txtJobTitle.Clear();
            txtSalary.Clear();

            chkIsActive.Checked = true;

            dgvEmployees.ClearSelection();

            txtFullName.Focus();
        }

        // =========================
        // ERROR
        // =========================

        private void ShowError(Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "VÉLORA RES - Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
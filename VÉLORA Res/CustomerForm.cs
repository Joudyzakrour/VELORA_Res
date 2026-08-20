 using System;
using System.Data;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class CustomersForm : Form
    {
        private readonly CustomerService _customerService;

        private int _selectedCustomerId = 0;

        public CustomersForm()
        {
            InitializeComponent();

            _customerService =
                new CustomerService(new DatabaseConnection());

            ConfigureEvents();

            LoadCustomers();

            ClearFields();
        }

        private void ConfigureEvents()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            txtSearch.TextChanged += txtSearch_TextChanged;

            dgvCustomers.CellClick += dgvCustomers_CellClick;
        }

        private void LoadCustomers()
        {
            try
            {
                dgvCustomers.DataSource =
                    _customerService.GetAll();

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void ConfigureGrid()
        {
            if (dgvCustomers.Columns.Count == 0)
                return;

            dgvCustomers.Columns["CustomerID"]
                .HeaderText = "ID";

            dgvCustomers.Columns["FullName"]
                .HeaderText = "Full Name";

            dgvCustomers.Columns["Phone"]
                .HeaderText = "Phone";

            dgvCustomers.Columns["Email"]
                .HeaderText = "Email";

            dgvCustomers.Columns["CreatedAt"]
                .HeaderText = "Created At";

           
        }

        private void btnAdd_Click(
            object? sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Customer customer =
                    GetCustomerFromFields();

                _customerService.Add(customer);

                MessageBox.Show(
                    "Customer added successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCustomers();

                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnUpdate_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show(
                    "Please select a customer first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInput())
                return;

            try
            {
                Customer customer =
                    GetCustomerFromFields();

                customer.CustomerID =
                    _selectedCustomerId;

                _customerService.Update(customer);

                MessageBox.Show(
                    "Customer updated successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCustomers();

                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnDelete_Click(
            object? sender,
 EventArgs e)
        {
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show(
                    "Please select a customer first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this customer?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _customerService.Delete(
                    _selectedCustomerId);

                MessageBox.Show(
                    "Customer deleted successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCustomers();

                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnClear_Click(
            object? sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void dgvCustomers_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvCustomers.Rows[e.RowIndex];

            _selectedCustomerId =
                Convert.ToInt32(
                    row.Cells["CustomerID"].Value);

            txtFullName.Text =
                row.Cells["FullName"].Value?.ToString();

            txtPhone.Text =
                row.Cells["Phone"].Value?.ToString();

            txtEmail.Text =
                row.Cells["Email"].Value?.ToString();

            

        }

        private void txtSearch_TextChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvCustomers.DataSource
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
                $"Email LIKE '%{search}%'";
        }

        private Customer GetCustomerFromFields()
        {
            return new Customer
            {
                FullName =
                    txtFullName.Text.Trim(),

                Phone =
                    string.IsNullOrWhiteSpace(
                        txtPhone.Text)
                        ? null
                        : txtPhone.Text.Trim(),

                Email =
                    string.IsNullOrWhiteSpace(
                        txtEmail.Text)
                        ? null
                        : txtEmail.Text.Trim(),

                CreatedAt =
                    DateTime.Now,

               
            };
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(
                txtFullName.Text))
            {
                MessageBox.Show(
                    "Please enter the customer's name.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtFullName.Focus();

                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            _selectedCustomerId = 0;
 txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();

            chkLoyalty.Checked = true;

            dgvCustomers.ClearSelection();

            txtFullName.Focus();
        }

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
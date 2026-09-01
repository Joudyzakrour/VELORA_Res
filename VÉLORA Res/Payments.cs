using System;
using System.Data;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class Payments : Form
    {
        private readonly PaymentService paymentService;
        private int selectedPaymentID = 0;

        public Payments()
        {
            InitializeComponent();

            DatabaseConnection database =
                new DatabaseConnection();

            paymentService =
                new PaymentService(database);

            ConfigureEvents();
            LoadPayments();
        }

        // =========================
        // EVENTS
        // =========================

        private void ConfigureEvents()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;

            dgvPayments.CellClick += dgvPayments_CellClick;
        }

        // =========================
        // LOAD PAYMENTS
        // =========================

        private void LoadPayments()
        {
            try
            {
                DataTable data =
                    paymentService.GetAll();

                dgvPayments.DataSource =
                    data;

                ConfigureGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load payments.\n\n" +
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
            if (dgvPayments.Columns.Contains("PaymentID"))
            {
                dgvPayments.Columns["PaymentID"]
                    .HeaderText = "ID";
            }

            if (dgvPayments.Columns.Contains("OrderID"))
            {
                dgvPayments.Columns["OrderID"]
                    .HeaderText = "ORDER";
            }

            if (dgvPayments.Columns.Contains("PaymentDate"))
            {
                dgvPayments.Columns["PaymentDate"]
                    .HeaderText = "DATE";

                dgvPayments.Columns["PaymentDate"]
                    .DefaultCellStyle.Format =
                    "dd/MM/yyyy HH:mm";
            }

            if (dgvPayments.Columns.Contains("Amount"))
            {
                dgvPayments.Columns["Amount"]
                    .HeaderText = "AMOUNT";

                dgvPayments.Columns["Amount"]
                    .DefaultCellStyle.Format =
                    "N2";
            }

            if (dgvPayments.Columns.Contains("PaymentMethod"))
            {
                dgvPayments.Columns["PaymentMethod"]
                    .HeaderText = "METHOD";
            }
        }

        // =========================
        // ADD
        // =========================

        private void btnAdd_Click(
            object? sender,
            EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                Payment payment =
                    new Payment
                    {
                        OrderID =
                            int.Parse(
                                txtOrderID.Text.Trim()),

                        PaymentDate =
                            dtPaymentDate.Value,

                        Amount =
                            decimal.Parse(
                                txtAmount.Text.Trim()),

                        PaymentMethod =
                            cmbPaymentMethod.SelectedItem?
                                .ToString()
                            ?? "Cash"
                    };

                paymentService.Add(payment);
                MessageBox.Show(
                    "Payment added successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add payment.\n\n" +
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
            if (selectedPaymentID == 0)
            {
                MessageBox.Show(
                    "Please select a payment first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                Payment payment =
                    new Payment
                    {
                        PaymentID =
                            selectedPaymentID,

                        OrderID =
                            int.Parse(
                                txtOrderID.Text.Trim()),

                        PaymentDate =
                            dtPaymentDate.Value,

                        Amount =
                            decimal.Parse(
                                txtAmount.Text.Trim()),

                        PaymentMethod =
                            cmbPaymentMethod.SelectedItem?
                                .ToString()
                            ?? "Cash"
                    };

                paymentService.Update(payment);

                MessageBox.Show(
                    "Payment updated successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update payment.\n\n" +
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
            if (selectedPaymentID == 0)
            {
                MessageBox.Show(
                    "Please select a payment first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this payment?",
                    "VÉLORA RES",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                paymentService.Delete(
                    selectedPaymentID);

                MessageBox.Show(
                    "Payment deleted successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadPayments();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete payment.\n\n" +
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
            LoadPayments();
        }

        // =========================
        // SELECT PAYMENT
        // =========================

        private void dgvPayments_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvPayments.Rows[e.RowIndex];

            if (row.Cells["PaymentID"].Value == null)
                return;

            selectedPaymentID =
                Convert.ToInt32(
                    row.Cells["PaymentID"].Value);

            txtOrderID.Text =
                row.Cells["OrderID"]
                    .Value?
                    .ToString()
                ?? string.Empty;

            if (row.Cells["PaymentDate"].Value != null &&
                row.Cells["PaymentDate"].Value != DBNull.Value)
            {
                dtPaymentDate.Value =
                    Convert.ToDateTime(
                        row.Cells["PaymentDate"].Value);
            }

            txtAmount.Text =
                row.Cells["Amount"]
                    .Value?
                    .ToString()
                ?? string.Empty;

            string method =
                row.Cells["PaymentMethod"]
                    .Value?
                    .ToString()
                ?? "Cash";

            cmbPaymentMethod.SelectedItem =
                method;
        }

        // =========================
        // VALIDATION
        // =========================

        private bool ValidateFields()
        {
            if (!int.TryParse(
                    txtOrderID.Text.Trim(),
                    out int orderID) ||
                orderID <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid Order ID.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtOrderID.Focus();

                return false;
            }

            if (!decimal.TryParse(
                    txtAmount.Text.Trim(),
                    out decimal amount) ||
                amount <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid payment amount.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtAmount.Focus();

                return false;
            }

            if (cmbPaymentMethod.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbPaymentMethod.Focus();

                return false;
            }

            return true;
        }

        // =========================
        // CLEAR
        // =========================

        private void ClearFields()
        {
            selectedPaymentID = 0;

            txtOrderID.Clear();
            txtAmount.Clear();

            dtPaymentDate.Value =
                DateTime.Now;

            cmbPaymentMethod.SelectedIndex =
                0;

            dgvPayments.ClearSelection();
        }
    }
}
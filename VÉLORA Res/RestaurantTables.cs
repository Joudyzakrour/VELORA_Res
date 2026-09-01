using System;
using System.Data;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class RestaurantTables : Form
    {
        private readonly RestaurantTableService tableService;
        private int selectedTableID = 0;

        public RestaurantTables()
        {
            InitializeComponent();

            DatabaseConnection database =
                new DatabaseConnection();

            tableService =
                new RestaurantTableService(database);

            ConfigureEvents();
            LoadTables();
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

            dgvTables.CellClick += dgvTables_CellClick;
        }

        // =========================
        // LOAD TABLES
        // =========================

        private void LoadTables()
        {
            try
            {
                DataTable data =
                    tableService.GetAll();

                dgvTables.DataSource = data;

                ConfigureGrid();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load restaurant tables.\n\n" +
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
            if (dgvTables.Columns.Contains("TableID"))
            {
                dgvTables.Columns["TableID"]
                    .HeaderText = "ID";
            }

            if (dgvTables.Columns.Contains("TableNumber"))
            {
                dgvTables.Columns["TableNumber"]
                    .HeaderText = "TABLE";
            }

            if (dgvTables.Columns.Contains("Capacity"))
            {
                dgvTables.Columns["Capacity"]
                    .HeaderText = "CAPACITY";
            }

            if (dgvTables.Columns.Contains("Status"))
            {
                dgvTables.Columns["Status"]
                    .HeaderText = "STATUS";
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
                RestaurantTable table =
                    new RestaurantTable
                    {
                        TableNumber =
                            int.Parse(
                                txtTableNumber.Text.Trim()),

                        Capacity =
                            int.Parse(
                                txtCapacity.Text.Trim()),

                        Status =
                            cmbStatus.SelectedItem?
                                .ToString()
                            ?? "Available"
                    };

                tableService.Add(table);

                MessageBox.Show(
                    "Restaurant table added successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to add table.\n\n" +
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
            if (selectedTableID == 0)
            {
                MessageBox.Show(
                    "Please select a table first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                RestaurantTable table =
                    new RestaurantTable
                    {
                        TableID =
                            selectedTableID,

                        TableNumber =
                            int.Parse(
                                txtTableNumber.Text.Trim()),

                        Capacity =
                            int.Parse(
                                txtCapacity.Text.Trim()),

                        Status =
                            cmbStatus.SelectedItem?
                                .ToString()
                            ?? "Available"
                    };

                tableService.Update(table);

                MessageBox.Show(
                    "Restaurant table updated successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to update table.\n\n" +
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
            if (selectedTableID == 0)
            {
                MessageBox.Show(
                    "Please select a table first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this table?",
                    "VÉLORA RES",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                tableService.Delete(
                    selectedTableID);

                MessageBox.Show(
                    "Restaurant table deleted successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadTables();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to delete table.\n\n" +
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
            LoadTables();
        }

        // =========================
        // SELECT ROW
        // =========================

        private void dgvTables_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvTables.Rows[e.RowIndex];

            if (row.Cells["TableID"].Value == null)
                return;
            selectedTableID =
                Convert.ToInt32(
                    row.Cells["TableID"].Value);

            txtTableNumber.Text =
                row.Cells["TableNumber"]
                    .Value?
                    .ToString()
                ?? string.Empty;

            txtCapacity.Text =
                row.Cells["Capacity"]
                    .Value?
                    .ToString()
                ?? string.Empty;

            string status =
                row.Cells["Status"]
                    .Value?
                    .ToString()
                ?? "Available";

            cmbStatus.SelectedItem =
                status;
        }

        // =========================
        // VALIDATION
        // =========================

        private bool ValidateFields()
        {
            if (!int.TryParse(
                    txtTableNumber.Text.Trim(),
                    out int tableNumber) ||
                tableNumber <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid table number.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtTableNumber.Focus();

                return false;
            }

            if (!int.TryParse(
                    txtCapacity.Text.Trim(),
                    out int capacity) ||
                capacity <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid capacity.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtCapacity.Focus();

                return false;
            }

            if (cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a table status.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbStatus.Focus();

                return false;
            }

            return true;
        }
        // =========================
        // CLEAR
        // =========================

        private void ClearFields()
        {
            selectedTableID = 0;

            txtTableNumber.Clear();
            txtCapacity.Clear();

            cmbStatus.SelectedIndex = 0;

            dgvTables.ClearSelection();
        }
    }
}
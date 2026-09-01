 using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class Inventory : Form
    {
        private readonly InventoryService _inventoryService;

        private DataTable _productsTable =
            new DataTable();

        private int _selectedInventoryId = 0;

        public Inventory()
        {
            InitializeComponent();

            _inventoryService =
                new InventoryService(
                    new DatabaseConnection());

            LoadProducts();
            LoadInventory();
            ConfigureEvents();

            ClearFields();
        }

        private void ConfigureEvents()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;

            dgvInventory.CellClick +=
                dgvInventory_CellClick;
        }

        private void LoadProducts()
        {
            try
            {
                const string query = @"
                    SELECT
                        ProductID,
                        ProductName
                    FROM dbo.Products
                    ORDER BY ProductName;";

                using SqlConnection connection =
                    new DatabaseConnection()
                        .CreateConnection();

                using SqlCommand command =
                    new SqlCommand(
                        query,
                        connection);

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(command);

                _productsTable =
                    new DataTable();

                adapter.Fill(_productsTable);

                cmbProduct.DataSource =
                    _productsTable;

                cmbProduct.DisplayMember =
                    "ProductName";

                cmbProduct.ValueMember =
                    "ProductID";

                cmbProduct.SelectedIndex =
                    -1;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void LoadInventory()
        {
            try
            {
                DataTable table =
                    _inventoryService.GetAll();

                dgvInventory.DataSource =
                    table;

                if (dgvInventory.Columns.Contains(
                    "InventoryID"))
                {
                    dgvInventory.Columns[
                        "InventoryID"
                    ].HeaderText =
                        "INVENTORY #";
                }

                if (dgvInventory.Columns.Contains(
                    "ProductID"))
                {
                    dgvInventory.Columns[
                        "ProductID"
                    ].HeaderText =
                        "PRODUCT";
                }

                if (dgvInventory.Columns.Contains(
                    "Quantity"))
                {
                    dgvInventory.Columns[
                        "Quantity"
                    ].HeaderText =
                        "QUANTITY";
                }

                if (dgvInventory.Columns.Contains(
                    "MinimumStock"))
                {
                    dgvInventory.Columns[
                        "MinimumStock"
                    ].HeaderText =
                        "MIN STOCK";
                }

                if (dgvInventory.Columns.Contains(
                    "LastUpdated"))
                {
                    dgvInventory.Columns[
                        "LastUpdated"
                    ].HeaderText =
                        "LAST UPDATED";
                }
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
 private void btnAdd_Click(
            object? sender,
            EventArgs e)
        {
            if (cmbProduct.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a product.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtQuantity.Text,
                out int quantity))
            {
                MessageBox.Show(
                    "Please enter a valid quantity.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtMinimumStock.Text,
                out int minimumStock))
            {
                MessageBox.Show(
                    "Please enter a valid minimum stock.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int productId =
                    Convert.ToInt32(
                        cmbProduct.SelectedValue);

                VÉLORA_Res.Models.Inventory inventory =
                    new VÉLORA_Res.Models.Inventory
                    {
                        ProductID = productId,
                        Quantity = quantity,
                        MinimumStock = minimumStock,
                        LastUpdated = DateTime.Now
                    };

                _inventoryService.Add(
                    inventory);

                MessageBox.Show(
                    "Inventory added successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadInventory();
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
            if (_selectedInventoryId == 0)
            {
                MessageBox.Show(
                    "Please select an inventory item.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (cmbProduct.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Please select a product.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtQuantity.Text,
                out int quantity))
            {
                MessageBox.Show(
                    "Please enter a valid quantity.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!int.TryParse(
                txtMinimumStock.Text,
                out int minimumStock))
            {
                MessageBox.Show(
                    "Please enter a valid minimum stock.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                int productId =
                    Convert.ToInt32(
                        cmbProduct.SelectedValue);

                VÉLORA_Res.Models.Inventory inventory =
                    new VÉLORA_Res.Models.Inventory
                    {
                        InventoryID =
                            _selectedInventoryId,

                        ProductID =
                            productId,

                        Quantity =
                            quantity,
                        MinimumStock =
                            minimumStock,

                        LastUpdated =
                            DateTime.Now
                    };

                _inventoryService.Update(
                    inventory);

                MessageBox.Show(
                    "Inventory updated successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadInventory();
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
            if (_selectedInventoryId == 0)
            {
                MessageBox.Show(
                    "Please select an inventory item.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to delete this inventory item?",
                    "VÉLORA RES",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _inventoryService.Delete(
                    _selectedInventoryId);

                MessageBox.Show(
                    "Inventory deleted successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadInventory();
                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnRefresh_Click(
            object? sender,
            EventArgs e)
        {
            LoadProducts();
            LoadInventory();
            ClearFields();
        }

        private void dgvInventory_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvInventory.Rows[e.RowIndex];

            if (row.Cells["InventoryID"].Value != null)
            {
                int.TryParse(
                    row.Cells["InventoryID"]
                        .Value
                        .ToString(),
                    out _selectedInventoryId);
            }

            if (row.Cells["ProductID"].Value != null)
            {
                if (int.TryParse(
                    row.Cells["ProductID"]
                        .Value
                        .ToString(),
                    out int productId))
                {
                    cmbProduct.SelectedValue =
                        productId;
                }
            }

            if (row.Cells["Quantity"].Value != null)
            {
                txtQuantity.Text =
                    row.Cells["Quantity"]
                        .Value
                        .ToString();
            }

            if (row.Cells["MinimumStock"].Value != null)
            {
                txtMinimumStock.Text =
                    row.Cells["MinimumStock"]
                        .Value
                        .ToString();
            }
        }

        private void ClearFields()
        {
            _selectedInventoryId = 0;

            cmbProduct.SelectedIndex = -1;

            txtQuantity.Clear();

            txtMinimumStock.Clear();

            dgvInventory.ClearSelection();
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



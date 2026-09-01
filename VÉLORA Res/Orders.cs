 using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class Orders : Form
    {
        private readonly OrderService _orderService;
        private readonly RestaurantTableService _tableService;
        private readonly OrderDetailService _orderDetailService;
        private readonly CustomerService _customerService;
        private DataTable _productsTable = new DataTable();
        private bool _showingOrders = false;

        private int _selectedOrderId = 0;
        private int _selectedCustomerId = 0;
        private Guna.UI2.WinForms.Guna2Panel orderDetailsPanel;
        private DataGridView dgvOrderDetails;
        private Label lblOrderDetailsTitle;
        public Orders()
        {
            InitializeComponent();

            _orderService =
                new OrderService(new DatabaseConnection());

            _orderDetailService =
                new OrderDetailService(new DatabaseConnection());

            _customerService =
    new CustomerService(new DatabaseConnection());

            _tableService =
    new RestaurantTableService(new DatabaseConnection());
            LoadCustomers();
            LoadTables();
            LoadProducts();
            ConfigureEvents();
            LoadOrders();
            CreateOrderDetailsPanel();
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("New");
            cmbStatus.Items.Add("Preparing");
            cmbStatus.Items.Add("Ready");
            cmbStatus.Items.Add("Completed");
            cmbStatus.Items.Add("Cancelled");

            cmbStatus.SelectedIndex = 0;

            ClearFields();
        }

        private void LoadTables()
        {
            try
            {
                DataTable table =
                    _tableService.GetAll();

                cmbTable.DataSource = table;
                cmbTable.DisplayMember = "TableNumber";
                cmbTable.ValueMember = "TableID";

                cmbTable.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void CreateOrderDetailsPanel()
        {
            orderDetailsPanel = new Guna.UI2.WinForms.Guna2Panel();

            orderDetailsPanel.BorderRadius = 18;
            orderDetailsPanel.FillColor = Color.FromArgb(25, 32, 29);
            orderDetailsPanel.Location = new Point(25, 500);
            orderDetailsPanel.Size = new Size(1130, 220);
            orderDetailsPanel.Visible = false;

            lblOrderDetailsTitle = new Label();

            lblOrderDetailsTitle.AutoSize = true;
            lblOrderDetailsTitle.Font =
                new Font("Segoe UI Semibold", 12F);
            lblOrderDetailsTitle.ForeColor =
                Color.FromArgb(225, 190, 95);
            lblOrderDetailsTitle.Location =
                new Point(22, 15);
            lblOrderDetailsTitle.Text = "ORDER DETAILS";

            dgvOrderDetails = new DataGridView();

            dgvOrderDetails.Location =
                new Point(22, 50);

            dgvOrderDetails.Size =
                new Size(1085, 150);

            dgvOrderDetails.BackgroundColor =
                Color.FromArgb(25, 32, 29);

            dgvOrderDetails.BorderStyle =
                BorderStyle.None;

            dgvOrderDetails.RowHeadersVisible = false;

            dgvOrderDetails.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;

            dgvOrderDetails.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvOrderDetails.EnableHeadersVisualStyles = false;

            dgvOrderDetails.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 42, 38);

            dgvOrderDetails.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(225, 190, 95);

            dgvOrderDetails.DefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 29);

            dgvOrderDetails.DefaultCellStyle.ForeColor =
                Color.White;

            dgvOrderDetails.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(55, 65, 58);

            dgvOrderDetails.DefaultCellStyle.SelectionForeColor =
                Color.White;

            orderDetailsPanel.Controls.Add(
                lblOrderDetailsTitle);

            orderDetailsPanel.Controls.Add(
                dgvOrderDetails);

            this.Controls.Add(orderDetailsPanel);

            orderDetailsPanel.BringToFront();
        }
        private void LoadOrders()
        {
            try
            {
                DataTable table = _orderService.GetAll();

                dgvOrders.AutoGenerateColumns = true;
                dgvOrders.Columns.Clear();
                dgvOrders.DataSource = table;
       

                if (dgvOrders.Columns.Contains("OrderID"))
                    dgvOrders.Columns["OrderID"].HeaderText = "ORDER #";

                if (dgvOrders.Columns.Contains("Customer"))
                    dgvOrders.Columns["Customer"].HeaderText = "CUSTOMER";

                if (dgvOrders.Columns.Contains("Table"))
                    dgvOrders.Columns["Table"].HeaderText = "TABLE";

                if (dgvOrders.Columns.Contains("Employee"))
                    dgvOrders.Columns["Employee"].HeaderText = "EMPLOYEE";

                if (dgvOrders.Columns.Contains("OrderDate"))
                    dgvOrders.Columns["OrderDate"].HeaderText = "DATE";

                if (dgvOrders.Columns.Contains("Status"))
                    dgvOrders.Columns["Status"].HeaderText = "STATUS";

                if (dgvOrders.Columns.Contains("Subtotal"))
                    dgvOrders.Columns["Subtotal"].HeaderText = "SUBTOTAL";

                if (dgvOrders.Columns.Contains("Discount"))
                    dgvOrders.Columns["Discount"].HeaderText = "DISCOUNT";

                if (dgvOrders.Columns.Contains("Tax"))
                    dgvOrders.Columns["Tax"].HeaderText = "TAX";

                if (dgvOrders.Columns.Contains("TotalAmount"))
                    dgvOrders.Columns["TotalAmount"].HeaderText = "TOTAL";
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void LoadCustomers()
        {
            try
            {
                DataTable table =
                    _customerService.GetAll();

                cmbCustomer.DataSource = table;
                cmbCustomer.DisplayMember = "FullName";
                cmbCustomer.ValueMember = "CustomerID";

                cmbCustomer.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void LoadProducts()
        {
            try
            {
                const string query = @"
            SELECT
                ProductID,
                ProductName,
                Price
            FROM dbo.Products
            WHERE IsAvailable = 1
            ORDER BY ProductName;";

                using SqlConnection connection =
                    new DatabaseConnection().CreateConnection();

                using SqlCommand command =
                    new SqlCommand(query, connection);

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(command);

                _productsTable = new DataTable();

                adapter.Fill(_productsTable);

                cmbProduct.DataSource = _productsTable;
                cmbProduct.DisplayMember = "ProductName";
                cmbProduct.ValueMember = "ProductID";

                cmbProduct.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void ConfigureEvents()
        {
            btnAddProduct.Click += btnAddProduct_Click;
            btnSaveOrder.Click += btnSaveOrder_Click;
            btnCancel.Click += btnCancel_Click;
            btnViewOrders.Click += btnViewOrders_Click;
            dgvOrders.CellDoubleClick += dgvOrders_CellDoubleClick;

            cmbProduct.SelectedIndexChanged +=
                cmbProduct_SelectedIndexChanged;

            txtDiscount.TextChanged +=
                CalculateTotals;

            txtTax.TextChanged +=
                CalculateTotals;

            dgvOrderItems.RowsAdded +=
                CalculateTotals;

            dgvOrderItems.RowsRemoved +=
                CalculateTotals;
            cmbCustomer.SelectedIndexChanged += cmbCustomer_SelectedIndexChanged;
        }
        private void HideOrderDetails()
        {
            if (orderDetailsPanel != null)
            {
                orderDetailsPanel.Visible = false;
            }
        }
        private void dgvOrders_CellDoubleClick(
     object? sender,
     DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvOrders.Rows[e.RowIndex];

            if (row.Cells["OrderID"].Value == null)
                return;

            if (!int.TryParse(
                row.Cells["OrderID"].Value.ToString(),
                out int orderId))
                return;

            try
            {
                DataTable details =
                    _orderDetailService.GetByOrderID(orderId);

                if (details.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No products found for this order.",
                        "VÉLORA RES",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }

                dgvOrderDetails.DataSource = null;
                dgvOrderDetails.DataSource = details;

                if (dgvOrderDetails.Columns.Contains("OrderDetailID"))
                    dgvOrderDetails.Columns["OrderDetailID"].Visible = false;

                if (dgvOrderDetails.Columns.Contains("OrderID"))
                    dgvOrderDetails.Columns["OrderID"].Visible = false;

                if (dgvOrderDetails.Columns.Contains("ProductID"))
                    dgvOrderDetails.Columns["ProductID"].HeaderText =
                        "PRODUCT ID";

                if (dgvOrderDetails.Columns.Contains("Quantity"))
                    dgvOrderDetails.Columns["Quantity"].HeaderText =
                        "QUANTITY";

                if (dgvOrderDetails.Columns.Contains("UnitPrice"))
                    dgvOrderDetails.Columns["UnitPrice"].HeaderText =
                        "UNIT PRICE";

                if (dgvOrderDetails.Columns.Contains("TotalPrice"))
                    dgvOrderDetails.Columns["TotalPrice"].HeaderText =
                        "TOTAL";

                lblOrderDetailsTitle.Text =
                    $"ORDER #{orderId}  •  DETAILS";

                orderDetailsPanel.Visible = true;
                orderDetailsPanel.BringToFront();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        //
        private void btnViewOrders_Click(
 object? sender,
 EventArgs e)
        {
            _showingOrders = !_showingOrders;

            headerPanel.Visible = true;

            customerPanel.Visible = !_showingOrders;
            productPanel.Visible = !_showingOrders;
            orderItemsPanel.Visible = !_showingOrders;
            summaryPanel.Visible = !_showingOrders;

            dgvOrders.Visible = _showingOrders;

            if (_showingOrders)
            {
                LoadOrders();
                btnViewOrders.Text = "NEW ORDER";
            }
            else
            {
                btnViewOrders.Text = "VIEW ORDERS";
                ClearFields();
            }
        }
        private void cmbCustomer_SelectedIndexChanged(
    object? sender,
    EventArgs e)
        {
            if (cmbCustomer.SelectedIndex < 0)
            {
                _selectedCustomerId = 0;
                return;
            }

            if (cmbCustomer.SelectedValue is int id)
            {
                _selectedCustomerId = id;
            }
            else
            {
                int.TryParse(
                    cmbCustomer.SelectedValue?.ToString(),
                    out _selectedCustomerId);
            }
        }
        private void btnAddProduct_Click(
            object? sender,
            EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbProduct.Text))
            {
                MessageBox.Show(
                    "Please select a product.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!decimal.TryParse(
                txtPrice.Text,
                out decimal price))
            {
                MessageBox.Show(
                    "Invalid product price.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int quantity =
                Convert.ToInt32(numQuantity.Value);

            decimal totalPrice =
                price * quantity;

            int productId =
     Convert.ToInt32(cmbProduct.SelectedValue);

            dgvOrderItems.Rows.Add(
                productId,
                cmbProduct.Text,
                quantity,
                price.ToString("0.00"),
                totalPrice.ToString("0.00"));

            CalculateTotals(null, EventArgs.Empty);

            cmbProduct.SelectedIndex = -1;
            txtPrice.Text = "0.00";
            numQuantity.Value = 1;
        }
       

        private void cmbProduct_SelectedIndexChanged(
    object? sender,
    EventArgs e)
        {
            if (cmbProduct.SelectedIndex < 0)
            {
                txtPrice.Text = "0.00";
                return;
            }

            if (cmbProduct.SelectedValue == null)
            {
                txtPrice.Text = "0.00";
                return;
            }

            DataRowView? row =
                cmbProduct.SelectedItem as DataRowView;

            if (row == null)
            {
                txtPrice.Text = "0.00";
                return;
            }

            if (decimal.TryParse(
                row["Price"]?.ToString(),
                out decimal price))
            {
                txtPrice.Text = price.ToString("0.00");
            }
        }


        private void CalculateTotals(
            object? sender,
            EventArgs e)
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row
                     in dgvOrderItems.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells["TotalPrice"].Value == null)
                    continue;

                if (decimal.TryParse(
                    row.Cells["TotalPrice"]
                        .Value
                        .ToString(),
                    out decimal value))
                {
                    subtotal += value;
                }
            }

            decimal discount = 0;
            decimal tax = 0;

            decimal.TryParse(
                txtDiscount.Text,
                out discount);

            decimal.TryParse(
                txtTax.Text,
                out tax);

            decimal total =
                subtotal - discount + tax;

            if (total < 0)
                total = 0;

            lblSubtotal.Text =
                $"${subtotal:0.00}";

            lblTotal.Text =
                $"${total:0.00}";
        }

      
        private void btnSaveOrder_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedCustomerId == 0)
            {
                MessageBox.Show(
                    "Please select a customer.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCustomer.Focus();
                return;
            }
            int customerId = 0;

            if (cmbCustomer.SelectedIndex >= 0 &&
                cmbCustomer.SelectedValue != null)
            {
                int.TryParse(
                    cmbCustomer.SelectedValue.ToString(),
                    out customerId);
            }

            if (customerId == 0)
            {
                MessageBox.Show(
                    "Please select a customer.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCustomer.Focus();
                return;
            }

            if (cmbTable.SelectedIndex < 0 ||
     cmbTable.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select a table.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbTable.Focus();
                return;
            }

            int tableId;

            if (!int.TryParse(
                cmbTable.SelectedValue.ToString(),
                out tableId))
            {
                MessageBox.Show(
                    "Invalid table selection.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            decimal subtotal = 0;
            decimal discount = 0;
            decimal tax = 0;

            decimal.TryParse(
                lblSubtotal.Text.Replace("$", ""),
                out subtotal);

            decimal.TryParse(
                txtDiscount.Text,
                out discount);

            decimal.TryParse(
                txtTax.Text,
                out tax);

            decimal total =
                subtotal - discount + tax;

            if (total < 0)
                total = 0;

            try
            {
                Order order = new Order
                {
                    CustomerID = _selectedCustomerId,
                    TableID = tableId,
                    EmployeeID = 1,
                    OrderDate = DateTime.Now,
                    Status = cmbStatus.SelectedItem?.ToString() ?? "New",
                    Subtotal = subtotal,
                    Discount = discount,
                    Tax = tax,
                    TotalAmount = total
                };

                int orderId =
                    _orderService.Add(order);

                foreach (DataGridViewRow row
                         in dgvOrderItems.Rows)
                {
                    if (row.IsNewRow)
                        continue;

                    int productId = 0;
                    int quantity = 0;
                    decimal unitPrice = 0;
                    decimal totalPrice = 0;

                    int.TryParse(
                        row.Cells["ProductID"]
                            .Value?.ToString(),
                        out productId);

                    int.TryParse(
                        row.Cells["Quantity"]
                            .Value?.ToString(),
                        out quantity);

                    decimal.TryParse(
                        row.Cells["UnitPrice"]
                            .Value?.ToString(),
                        out unitPrice);

                    decimal.TryParse(
                        row.Cells["TotalPrice"]
                            .Value?.ToString(),
                        out totalPrice);

                    OrderDetail detail = new OrderDetail
                    {
                        OrderID = orderId,
                        ProductID = productId,
                        Quantity = quantity,
                        UnitPrice = unitPrice,
                        TotalPrice = totalPrice
                    };

                    _orderDetailService.Add(detail);
                }

                MessageBox.Show(
                    $"Order #{orderId} saved successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        private void btnCancel_Click(
            object? sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            _selectedOrderId = 0;
            HideOrderDetails();
            cmbCustomer.SelectedIndex = -1;
            cmbProduct.SelectedIndex = -1;

            cmbTable.SelectedIndex=-1;

            cmbStatus.SelectedIndex = 0;

            numQuantity.Value = 1;

            txtPrice.Text = "0.00";

            txtDiscount.Text = "0";
            txtTax.Text = "0";

            dgvOrderItems.Rows.Clear();

            lblSubtotal.Text = "$0.00";
            lblTotal.Text = "$0.00";
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
using System;
using System.Data;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class Analytics : Form
    {
        private readonly AnalyticsService _analyticsService;

        public Analytics()
        {
            InitializeComponent();

            _analyticsService =
                new AnalyticsService(
                    new DatabaseConnection());

            ConfigureEvents();
            LoadAnalytics();
        }

        private void ConfigureEvents()
        {
            btnRefresh.Click += btnRefresh_Click;
        }

        private void LoadAnalytics()
        {
            try
            {
                LoadSummary();
                LoadBestSellers();
                LoadSalesByDate();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void LoadSummary()
        {
            decimal totalSales =
                _analyticsService.GetTotalSales();

            int totalOrders =
                _analyticsService.GetTotalOrders();

            int totalItems =
                _analyticsService.GetTotalItemsSold();

            decimal averageOrder =
                _analyticsService.GetAverageOrder();

            lblSalesValue.Text =
     "$" + totalSales.ToString("N2");

            lblAverageValue.Text =
                "$" + averageOrder.ToString("N2");

            lblOrdersValue.Text =
                totalOrders.ToString();

            lblItemsValue.Text =
                totalItems.ToString();

            lblAverageValue.Text =
                averageOrder.ToString("C2");
        }

        private void LoadBestSellers()
        {
            DataTable table =
                _analyticsService
                    .GetBestSellingProducts();

            dgvBestSellers.DataSource =
                table;

            if (dgvBestSellers.Columns.Contains(
                "ProductName"))
            {
                dgvBestSellers.Columns[
                    "ProductName"
                ].HeaderText =
                    "PRODUCT";
            }

            if (dgvBestSellers.Columns.Contains(
                "QuantitySold"))
            {
                dgvBestSellers.Columns[
                    "QuantitySold"
                ].HeaderText =
                    "QUANTITY SOLD";
            }

            if (dgvBestSellers.Columns.Contains(
                "Sales"))
            {
                dgvBestSellers.Columns[
                    "Sales"
                ].HeaderText =
                    "SALES";
            }
        }

        private void LoadSalesByDate()
        {
            DataTable table =
                _analyticsService
                    .GetSalesByDate();

            dgvSalesByDate.DataSource =
                table;

            if (dgvSalesByDate.Columns.Contains(
                "SaleDate"))
            {
                dgvSalesByDate.Columns[
                    "SaleDate"
                ].HeaderText =
                    "DATE";

               
            }

            if (dgvSalesByDate.Columns.Contains(
                "Sales"))
            {
                dgvSalesByDate.Columns[
                    "Sales"
                ].HeaderText =
                    "SALES";

                dgvSalesByDate.Columns[
                    "Sales"
                ].DefaultCellStyle.Format =
                    "##0.00,#$";
            }
        }
        private void btnRefresh_Click(
            object? sender,
            EventArgs e)
        {
            LoadAnalytics();
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "VÉLORA RES - Analytics Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
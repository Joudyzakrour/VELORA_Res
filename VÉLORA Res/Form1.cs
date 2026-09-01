using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateDashboardCards();
            btnProducts.Click += btnProducts_Click;
            btnCustomers.Click += btnCustomers_Click;
            btnOrders.Click += btnOrders_Click;
            btnInventory.Click += btnInventory_Click;
            btnAnalytics.Click += btnAnalytics_Click;
            btnUsers.Click += btnUsers_Click;
            btnSettings.Click += btnSettings_Click;
            btnTables.Click += btnTables_Click;
            btnClose.Click += btnClose_Click;

        }

        private void btnCustomers_Click(
     object? sender,
     EventArgs e)
        {
            using CustomersForm form = new CustomersForm();
            form.ShowDialog();
        }

        private void btnProducts_Click(
            object? sender,
            EventArgs e)
        {
            using CategoriesForm form = new CategoriesForm();
            form.ShowDialog();
        }
        private void btnOrders_Click(
            object? sender,
            EventArgs e)
        {

            using Orders form = new Orders();
            form.ShowDialog();
        }
        private void btnInventory_Click(
           object? sender,
           EventArgs e)
        {

            using Inventory form = new Inventory();
            form.ShowDialog();
        }
        private void btnAnalytics_Click(
          object? sender,
          EventArgs e)
        {

            using Analytics form = new Analytics();
            form.ShowDialog();
        }

        private void btnUsers_Click(
       object? sender,
       EventArgs e)
        {

            using UsersForm form = new UsersForm();
            form.ShowDialog();
        }
        private void btnSettings_Click(
        object? sender,
        EventArgs e)
        {

            using Settings form = new Settings();
            form.ShowDialog();
        }

        private void btnTables_Click(
       object? sender,
       EventArgs e)
        {

            using RestaurantTables form = new RestaurantTables();
            form.ShowDialog();
        }
        private void btnClose_Click(
    object? sender,
    EventArgs e)
        {
            Application.Exit();
        }


        private void UpdateDashboardCards()
        {
            try
            {
                OrderService orderService =
                    new OrderService(new DatabaseConnection());

                CustomerService customerService =
                    new CustomerService(new DatabaseConnection());

                decimal totalSales =
                    orderService.GetTotalSales();

                int orderCount =
                    orderService.GetOrderCount();

                decimal netProfit =
                    orderService.GetNetProfit();

                int customerCount =
                    customerService.GetCustomerCount();

                if (salesValueLabel != null)
                    salesValueLabel.Text =
                        $"${totalSales:0.00}";

                if (ordersValueLabel != null)
                    ordersValueLabel.Text =
                        orderCount.ToString();

                if (profitValueLabel != null)
                    profitValueLabel.Text =
                        $"${netProfit:0.00}";

                if (customersValueLabel != null)
                    customersValueLabel.Text =
                        customerCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "VÉLORA RES - Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
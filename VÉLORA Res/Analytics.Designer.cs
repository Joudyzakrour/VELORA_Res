 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class Analytics
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel headerPanel;
        private Guna2Panel salesPanel;
        private Guna2Panel ordersPanel;
        private Guna2Panel itemsPanel;
        private Guna2Panel averagePanel;
        private Guna2Panel bestSellerPanel;
        private Guna2Panel salesDatePanel;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblSalesTitle;
        private Label lblSalesValue;

        private Label lblOrdersTitle;
        private Label lblOrdersValue;

        private Label lblItemsTitle;
        private Label lblItemsValue;

        private Label lblAverageTitle;
        private Label lblAverageValue;

        private Label lblBestSellerTitle;
        private Label lblSalesDateTitle;

        private DataGridView dgvBestSellers;
        private DataGridView dgvSalesByDate;

        private Guna2Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.headerPanel =
                new Guna2Panel();

            this.salesPanel =
                new Guna2Panel();

            this.ordersPanel =
                new Guna2Panel();

            this.itemsPanel =
                new Guna2Panel();

            this.averagePanel =
                new Guna2Panel();

            this.bestSellerPanel =
                new Guna2Panel();

            this.salesDatePanel =
                new Guna2Panel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblSalesTitle =
                new Label();

            this.lblSalesValue =
                new Label();

            this.lblOrdersTitle =
                new Label();

            this.lblOrdersValue =
                new Label();

            this.lblItemsTitle =
                new Label();

            this.lblItemsValue =
                new Label();

            this.lblAverageTitle =
                new Label();

            this.lblAverageValue =
                new Label();

            this.lblBestSellerTitle =
                new Label();

            this.lblSalesDateTitle =
                new Label();

            this.dgvBestSellers =
                new DataGridView();

            this.dgvSalesByDate =
                new DataGridView();

            this.btnRefresh =
                new Guna2Button();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvBestSellers)).BeginInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSalesByDate)).BeginInit();

            // =========================
            // FORM
            // =========================

            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.BackColor =
                Color.FromArgb(15, 20, 18);

            this.ClientSize =
                new Size(1180, 760);

            this.FormBorderStyle =
                FormBorderStyle.None;

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Name =
                "Analytics";

            this.Text =
                "VÉLORA - Analytics";

            // =========================
            // HEADER
            // =========================

            this.headerPanel.BorderRadius =
                18;

            this.headerPanel.FillColor =
                Color.FromArgb(25, 32, 29);
 this.headerPanel.Location =
                new Point(25, 20);

            this.headerPanel.Size =
                new Size(1130, 90);

            this.lblTitle.AutoSize =
                true;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    22F);

            this.lblTitle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblTitle.Location =
                new Point(30, 15);

            this.lblTitle.Text =
                "ANALYTICS";

            this.lblSubtitle.AutoSize =
                true;

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    9.5F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(160, 170, 165);

            this.lblSubtitle.Location =
                new Point(34, 55);

            this.lblSubtitle.Text =
                "Business insights and restaurant performance";

            this.headerPanel.Controls.Add(
                this.lblTitle);

            this.headerPanel.Controls.Add(
                this.lblSubtitle);

            // =========================
            // SALES CARD
            // =========================

            this.salesPanel.BorderRadius =
                18;

            this.salesPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.salesPanel.Location =
                new Point(25, 130);

            this.salesPanel.Size =
                new Size(260, 115);

            this.lblSalesTitle.AutoSize =
                true;

            this.lblSalesTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblSalesTitle.ForeColor =
                Color.FromArgb(160, 170, 165);

            this.lblSalesTitle.Location =
                new Point(20, 18);

            this.lblSalesTitle.Text =
                "TOTAL SALES";

            this.lblSalesValue.AutoSize =
                true;

            this.lblSalesValue.Font =
                new Font(
                    "Segoe UI Semibold",
                    24F);

            this.lblSalesValue.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblSalesValue.Location =
                new Point(20, 43);

            this.lblSalesValue.Text =
                "$0.00";

            this.salesPanel.Controls.Add(
                this.lblSalesTitle);

            this.salesPanel.Controls.Add(
                this.lblSalesValue);

            // =========================
            // ORDERS CARD
            // =========================

            this.ordersPanel.BorderRadius =
                18;

            this.ordersPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.ordersPanel.Location =
                new Point(315, 130);

            this.ordersPanel.Size =
                new Size(260, 115);

            this.lblOrdersTitle.AutoSize =
                true;

            this.lblOrdersTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblOrdersTitle.ForeColor =
                Color.FromArgb(160, 170, 165);

            this.lblOrdersTitle.Location =
                new Point(20, 18);

            this.lblOrdersTitle.Text =
                "TOTAL ORDERS";

            this.lblOrdersValue.AutoSize =
                true;

            this.lblOrdersValue.Font =
                new Font(
                    "Segoe UI Semibold",
                    24F);

            this.lblOrdersValue.ForeColor =
                Color.White;

            this.lblOrdersValue.Location =
                new Point(20, 43);

            this.lblOrdersValue.Text =
                "0";

            this.ordersPanel.Controls.Add(
                this.lblOrdersTitle);

            this.ordersPanel.Controls.Add(
                this.lblOrdersValue);
// =========================
            // ITEMS CARD
            // =========================

            this.itemsPanel.BorderRadius =
                18;

            this.itemsPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.itemsPanel.Location =
                new Point(605, 130);

            this.itemsPanel.Size =
                new Size(260, 115);

            this.lblItemsTitle.AutoSize =
                true;

            this.lblItemsTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblItemsTitle.ForeColor =
                Color.FromArgb(160, 170, 165);

            this.lblItemsTitle.Location =
                new Point(20, 18);

            this.lblItemsTitle.Text =
                "ITEMS SOLD";

            this.lblItemsValue.AutoSize =
                true;

            this.lblItemsValue.Font =
                new Font(
                    "Segoe UI Semibold",
                    24F);

            this.lblItemsValue.ForeColor =
                Color.White;

            this.lblItemsValue.Location =
                new Point(20, 43);

            this.lblItemsValue.Text =
                "0";

            this.itemsPanel.Controls.Add(
                this.lblItemsTitle);

            this.itemsPanel.Controls.Add(
                this.lblItemsValue);

            // =========================
            // AVERAGE CARD
            // =========================

            this.averagePanel.BorderRadius =
                18;

            this.averagePanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.averagePanel.Location =
                new Point(895, 130);

            this.averagePanel.Size =
                new Size(260, 115);

            this.lblAverageTitle.AutoSize =
                true;

            this.lblAverageTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblAverageTitle.ForeColor =
                Color.FromArgb(160, 170, 165);

            this.lblAverageTitle.Location =
                new Point(20, 18);

            this.lblAverageTitle.Text =
                "AVERAGE ORDER";

            this.lblAverageValue.AutoSize =
                true;

            this.lblAverageValue.Font =
                new Font(
                    "Segoe UI Semibold",
                    24F);

            this.lblAverageValue.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblAverageValue.Location =
                new Point(20, 43);

            this.lblAverageValue.Text =
                "$0.00";

            this.averagePanel.Controls.Add(
                this.lblAverageTitle);

            this.averagePanel.Controls.Add(
                this.lblAverageValue);

            // =========================
            // BEST SELLERS
            // =========================

            this.bestSellerPanel.BorderRadius =
                18;

            this.bestSellerPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.bestSellerPanel.Location =
                new Point(25, 265);

            this.bestSellerPanel.Size =
                new Size(550, 470);

            this.lblBestSellerTitle.AutoSize =
                true;

            this.lblBestSellerTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    12F);

            this.lblBestSellerTitle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblBestSellerTitle.Location =
                new Point(20, 18);

            this.lblBestSellerTitle.Text =
                "BEST SELLING PRODUCTS";

            this.dgvBestSellers.AllowUserToAddRows =
                false;

            this.dgvBestSellers.AllowUserToDeleteRows =
                false;

            this.dgvBestSellers.AllowUserToResizeRows =
                false;
 this.dgvBestSellers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvBestSellers.BackgroundColor =
                Color.FromArgb(25, 32, 29);

            this.dgvBestSellers.BorderStyle =
                BorderStyle.None;

            this.dgvBestSellers.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvBestSellers.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvBestSellers.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 42, 38);

            this.dgvBestSellers.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.dgvBestSellers.ColumnHeadersHeight =
                40;

            this.dgvBestSellers.DefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 29);

            this.dgvBestSellers.DefaultCellStyle.ForeColor =
                Color.White;

            this.dgvBestSellers.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(55, 65, 58);

            this.dgvBestSellers.EnableHeadersVisualStyles =
                false;

            this.dgvBestSellers.Location =
                new Point(20, 55);

            this.dgvBestSellers.RowHeadersVisible =
                false;

            this.dgvBestSellers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvBestSellers.Size =
                new Size(510, 390);

            this.bestSellerPanel.Controls.Add(
                this.lblBestSellerTitle);

            this.bestSellerPanel.Controls.Add(
                this.dgvBestSellers);

            // =========================
            // SALES BY DATE
            // =========================

            this.salesDatePanel.BorderRadius =
                18;

            this.salesDatePanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.salesDatePanel.Location =
                new Point(605, 265);

            this.salesDatePanel.Size =
                new Size(550, 470);

            this.lblSalesDateTitle.AutoSize =
                true;

            this.lblSalesDateTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    12F);

            this.lblSalesDateTitle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblSalesDateTitle.Location =
                new Point(20, 18);

            this.lblSalesDateTitle.Text =
                "SALES BY DATE";

            this.dgvSalesByDate.AllowUserToAddRows =
                false;

            this.dgvSalesByDate.AllowUserToDeleteRows =
                false;

            this.dgvSalesByDate.AllowUserToResizeRows =
                false;

            this.dgvSalesByDate.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvSalesByDate.BackgroundColor =
                Color.FromArgb(25, 32, 29);

            this.dgvSalesByDate.BorderStyle =
                BorderStyle.None;

            this.dgvSalesByDate.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvSalesByDate.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvSalesByDate.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 42, 38);

            this.dgvSalesByDate.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.dgvSalesByDate.ColumnHeadersHeight =
                40;

            this.dgvSalesByDate.DefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 29);

            this.dgvSalesByDate.DefaultCellStyle.ForeColor =
                Color.White;

            this.dgvSalesByDate.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(55, 65, 58);

            this.dgvSalesByDate.EnableHeadersVisualStyles =
                false;
 this.dgvSalesByDate.Location =
                new Point(20, 55);

            this.dgvSalesByDate.RowHeadersVisible =
                false;

            this.dgvSalesByDate.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvSalesByDate.Size =
                new Size(510, 390);

            this.salesDatePanel.Controls.Add(
                this.lblSalesDateTitle);

            this.salesDatePanel.Controls.Add(
                this.dgvSalesByDate);

            // =========================
            // REFRESH
            // =========================

            this.btnRefresh.BorderRadius =
                10;

            this.btnRefresh.FillColor =
                Color.FromArgb(198, 164, 74);

            this.btnRefresh.ForeColor =
                Color.FromArgb(20, 20, 18);

            this.btnRefresh.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnRefresh.Location =
                new Point(1000, 35);

            this.btnRefresh.Size =
                new Size(120, 42);

            this.btnRefresh.Text =
                "REFRESH";

            this.headerPanel.Controls.Add(
                this.btnRefresh);

            // =========================
            // FORM CONTROLS
            // =========================

            this.Controls.Add(
                this.headerPanel);

            this.Controls.Add(
                this.salesPanel);

            this.Controls.Add(
                this.ordersPanel);

            this.Controls.Add(
                this.itemsPanel);

            this.Controls.Add(
                this.averagePanel);

            this.Controls.Add(
                this.bestSellerPanel);

            this.Controls.Add(
                this.salesDatePanel);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvBestSellers)).EndInit();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvSalesByDate)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
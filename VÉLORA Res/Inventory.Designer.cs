 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class Inventory
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel headerPanel;
        private Guna2Panel inventoryPanel;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblProduct;
        private Label lblQuantity;
        private Label lblMinimumStock;

        private Guna2ComboBox cmbProduct;
        private Guna2TextBox txtQuantity;
        private Guna2TextBox txtMinimumStock;

        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnRefresh;

        private DataGridView dgvInventory;

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

            this.inventoryPanel =
                new Guna2Panel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblProduct =
                new Label();

            this.lblQuantity =
                new Label();

            this.lblMinimumStock =
                new Label();

            this.cmbProduct =
                new Guna2ComboBox();

            this.txtQuantity =
                new Guna2TextBox();

            this.txtMinimumStock =
                new Guna2TextBox();

            this.btnAdd =
                new Guna2Button();

            this.btnUpdate =
                new Guna2Button();

            this.btnDelete =
                new Guna2Button();

            this.btnRefresh =
                new Guna2Button();

            this.dgvInventory =
                new DataGridView();

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvInventory)).BeginInit();

            // =========================
            // Inventory FORM
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
                "Inventory";

            this.Text =
                "VÉLORA - Inventory";

            // =========================
            // HEADER PANEL
            // =========================

            this.headerPanel.BorderRadius =
                18;

            this.headerPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.headerPanel.Location =
                new Point(25, 20);

            this.headerPanel.Size =
                new Size(1130, 90);

            // =========================
            // TITLE
            // =========================

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
                "INVENTORY";

            // =========================
            // SUBTITLE
            // =========================

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
                "Manage restaurant stock and inventory";

            this.headerPanel.Controls.Add(
                this.lblTitle);

            this.headerPanel.Controls.Add(
                this.lblSubtitle);

            // =========================
            // INVENTORY PANEL
            // =========================

            this.inventoryPanel.BorderRadius =
                18;

            this.inventoryPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.inventoryPanel.Location =
                new Point(25, 130);

            this.inventoryPanel.Size =
                new Size(1130, 605);

            // =========================
            // PRODUCT LABEL
            // =========================

            this.lblProduct.AutoSize =
                true;

            this.lblProduct.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblProduct.ForeColor =
                Color.FromArgb(205, 210, 207);

            this.lblProduct.Location =
                new Point(25, 22);

            this.lblProduct.Text =
                "PRODUCT";

            // =========================
            // PRODUCT COMBOBOX
            // =========================

            this.cmbProduct.BorderRadius =
                10;

            this.cmbProduct.FillColor =
                Color.FromArgb(34, 42, 38);

            this.cmbProduct.ForeColor =
                Color.White;

            this.cmbProduct.Location =
                new Point(25, 48);

            this.cmbProduct.Size =
                new Size(350, 38);

            this.cmbProduct.DropDownStyle =
                ComboBoxStyle.DropDownList;

            // =========================
            // QUANTITY LABEL
            // =========================

            this.lblQuantity.AutoSize =
                true;

            this.lblQuantity.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblQuantity.ForeColor =
                Color.FromArgb(205, 210, 207);

            this.lblQuantity.Location =
                new Point(400, 22);

            this.lblQuantity.Text =
                "QUANTITY";

            // =========================
            // QUANTITY TEXTBOX
            // =========================

            this.txtQuantity.BorderRadius =
                10;

            this.txtQuantity.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtQuantity.ForeColor =
                Color.White;

            this.txtQuantity.PlaceholderText =
                "Quantity";

            this.txtQuantity.Location =
                new Point(400, 48);

            this.txtQuantity.Size =
                new Size(180, 38);

            // =========================
            // MINIMUM STOCK LABEL
            // =========================

            this.lblMinimumStock.AutoSize =
                true;

            this.lblMinimumStock.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblMinimumStock.ForeColor =
                Color.FromArgb(205, 210, 207);

            this.lblMinimumStock.Location =
                new Point(605, 22);

            this.lblMinimumStock.Text =
                "MINIMUM STOCK";

            // =========================
            // MINIMUM STOCK TEXTBOX
            // =========================

            this.txtMinimumStock.BorderRadius =
                10;

            this.txtMinimumStock.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtMinimumStock.ForeColor =
                Color.White;
 this.txtMinimumStock.PlaceholderText =
                "Minimum stock";

            this.txtMinimumStock.Location =
                new Point(605, 48);

            this.txtMinimumStock.Size =
                new Size(180, 38);

            // =========================
            // ADD BUTTON
            // =========================

            this.btnAdd.BorderRadius =
                10;

            this.btnAdd.FillColor =
                Color.FromArgb(198, 164, 74);

            this.btnAdd.ForeColor =
                Color.FromArgb(20, 20, 18);

            this.btnAdd.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnAdd.Location =
                new Point(810, 45);

            this.btnAdd.Size =
                new Size(130, 42);

            this.btnAdd.Text =
                "ADD";

            // =========================
            // UPDATE BUTTON
            // =========================

            this.btnUpdate.BorderRadius =
                10;

            this.btnUpdate.FillColor =
                Color.FromArgb(55, 65, 58);

            this.btnUpdate.ForeColor =
                Color.White;

            this.btnUpdate.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnUpdate.Location =
                new Point(955, 45);

            this.btnUpdate.Size =
                new Size(130, 42);

            this.btnUpdate.Text =
                "UPDATE";

            // =========================
            // DATA GRID
            // =========================

            this.dgvInventory.AllowUserToAddRows =
                false;

            this.dgvInventory.AllowUserToDeleteRows =
                false;

            this.dgvInventory.AllowUserToResizeRows =
                false;

            this.dgvInventory.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvInventory.BackgroundColor =
                Color.FromArgb(25, 32, 29);

            this.dgvInventory.BorderStyle =
                BorderStyle.None;

            this.dgvInventory.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvInventory.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvInventory.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 42, 38);

            this.dgvInventory.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.dgvInventory.ColumnHeadersDefaultCellStyle.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.dgvInventory.ColumnHeadersHeight =
                40;

            this.dgvInventory.DefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 29);

            this.dgvInventory.DefaultCellStyle.ForeColor =
                Color.White;

            this.dgvInventory.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(55, 65, 58);

            this.dgvInventory.DefaultCellStyle.SelectionForeColor =
                Color.White;

            this.dgvInventory.EnableHeadersVisualStyles =
                false;

            this.dgvInventory.Location =
                new Point(25, 115);

            this.dgvInventory.RowHeadersVisible =
                false;

            this.dgvInventory.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvInventory.MultiSelect =
                false;

            this.dgvInventory.Size =
                new Size(1080, 350);

            // =========================
            // DELETE BUTTON
            // =========================

            this.btnDelete.BorderRadius =
                10;

            this.btnDelete.FillColor =
                Color.FromArgb(80, 45, 45);

            this.btnDelete.ForeColor =
                Color.White;
 this.btnDelete.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnDelete.Location =
                new Point(25, 490);

            this.btnDelete.Size =
                new Size(150, 45);

            this.btnDelete.Text =
                "DELETE";

            // =========================
            // REFRESH BUTTON
            // =========================

            this.btnRefresh.BorderRadius =
                10;

            this.btnRefresh.FillColor =
                Color.FromArgb(55, 65, 58);

            this.btnRefresh.ForeColor =
                Color.White;

            this.btnRefresh.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnRefresh.Location =
                new Point(190, 490);

            this.btnRefresh.Size =
                new Size(150, 45);

            this.btnRefresh.Text =
                "REFRESH";

            // =========================
            // ADD CONTROLS
            // =========================

            this.inventoryPanel.Controls.Add(
                this.lblProduct);

            this.inventoryPanel.Controls.Add(
                this.cmbProduct);

            this.inventoryPanel.Controls.Add(
                this.lblQuantity);

            this.inventoryPanel.Controls.Add(
                this.txtQuantity);

            this.inventoryPanel.Controls.Add(
                this.lblMinimumStock);

            this.inventoryPanel.Controls.Add(
                this.txtMinimumStock);

            this.inventoryPanel.Controls.Add(
                this.btnAdd);

            this.inventoryPanel.Controls.Add(
                this.btnUpdate);

            this.inventoryPanel.Controls.Add(
                this.dgvInventory);

            this.inventoryPanel.Controls.Add(
                this.btnDelete);

            this.inventoryPanel.Controls.Add(
                this.btnRefresh);

            // =========================
            // FORM CONTROLS
            // =========================

            this.Controls.Add(
                this.headerPanel);

            this.Controls.Add(
                this.inventoryPanel);

            ((System.ComponentModel.ISupportInitialize)
                (this.dgvInventory)).EndInit();

            this.ResumeLayout(false);
        }
    }
}
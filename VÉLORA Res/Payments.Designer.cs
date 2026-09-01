using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class Payments
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel headerPanel;
        private Guna2Panel contentPanel;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblOrderID;
        private Label lblPaymentDate;
        private Label lblAmount;
        private Label lblPaymentMethod;

        private Guna2TextBox txtOrderID;
        private Guna2TextBox txtAmount;
        private Guna2DateTimePicker dtPaymentDate;
        private Guna2ComboBox cmbPaymentMethod;

        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnRefresh;

        private DataGridView dgvPayments;

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

            this.contentPanel =
                new Guna2Panel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblOrderID =
                new Label();

            this.lblPaymentDate =
                new Label();

            this.lblAmount =
                new Label();

            this.lblPaymentMethod =
                new Label();

            this.txtOrderID =
                new Guna2TextBox();

            this.txtAmount =
                new Guna2TextBox();

            this.dtPaymentDate =
                new Guna2DateTimePicker();

            this.cmbPaymentMethod =
                new Guna2ComboBox();

            this.btnAdd =
                new Guna2Button();

            this.btnUpdate =
                new Guna2Button();

            this.btnDelete =
                new Guna2Button();

            this.btnRefresh =
                new Guna2Button();

            this.dgvPayments =
                new DataGridView();

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
                "Payments";

            this.Text =
                "VÉLORA - Payments";

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
                "PAYMENTS";

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
                "Manage restaurant payments";

            this.headerPanel.Controls.Add(
                this.lblTitle);

            this.headerPanel.Controls.Add(
                this.lblSubtitle);

            // =========================
            // CONTENT PANEL
            // =========================

            this.contentPanel.BorderRadius =
                18;

            this.contentPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.contentPanel.Location =
                new Point(25, 130);

            this.contentPanel.Size =
                new Size(1130, 605);

            // =========================
            // ORDER ID
            // =========================

            this.lblOrderID.AutoSize =
                true;

            this.lblOrderID.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F);

            this.lblOrderID.ForeColor =
                Color.White;

            this.lblOrderID.Location =
                new Point(30, 30);

            this.lblOrderID.Text =
                "ORDER ID";

            this.txtOrderID.BorderRadius =
                10;

            this.txtOrderID.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtOrderID.ForeColor =
                Color.White;

            this.txtOrderID.PlaceholderText =
                "Order ID";

            this.txtOrderID.Location =
                new Point(30, 58);

            this.txtOrderID.Size =
                new Size(230, 40);

            // =========================
            // PAYMENT DATE
            // =========================

            this.lblPaymentDate.AutoSize =
                true;

            this.lblPaymentDate.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F);

            this.lblPaymentDate.ForeColor =
                Color.White;

            this.lblPaymentDate.Location =
                new Point(290, 30);

            this.lblPaymentDate.Text =
                "PAYMENT DATE";

            this.dtPaymentDate.BorderRadius =
                10;

            this.dtPaymentDate.FillColor =
                Color.FromArgb(34, 42, 38);

            this.dtPaymentDate.ForeColor =
                Color.White;

            this.dtPaymentDate.Format =
                DateTimePickerFormat.Custom;

            this.dtPaymentDate.CustomFormat =
                "dd/MM/yyyy HH:mm";

            this.dtPaymentDate.Location =
                new Point(290, 58);

            this.dtPaymentDate.Size =
                new Size(230, 40);

            this.dtPaymentDate.Value =
                DateTime.Now;

            // =========================
            // AMOUNT
            // =========================

            this.lblAmount.AutoSize =
                true;

            this.lblAmount.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F);

            this.lblAmount.ForeColor =
                Color.White;

            this.lblAmount.Location =
                new Point(550, 30);

            this.lblAmount.Text =
                "AMOUNT";

            this.txtAmount.BorderRadius =
                10;

            this.txtAmount.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtAmount.ForeColor =
                Color.White;

            this.txtAmount.PlaceholderText =
                "Amount";

            this.txtAmount.Location =
                new Point(550, 58);

            this.txtAmount.Size =
                new Size(230, 40);

            // =========================
            // PAYMENT METHOD
            // =========================

            this.lblPaymentMethod.AutoSize =
                true;
            this.lblPaymentMethod.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F);

            this.lblPaymentMethod.ForeColor =
                Color.White;

            this.lblPaymentMethod.Location =
                new Point(810, 30);

            this.lblPaymentMethod.Text =
                "PAYMENT METHOD";

            this.cmbPaymentMethod.BorderRadius =
                10;

            this.cmbPaymentMethod.FillColor =
                Color.FromArgb(34, 42, 38);

            this.cmbPaymentMethod.ForeColor =
                Color.White;

            this.cmbPaymentMethod.Location =
                new Point(810, 58);

            this.cmbPaymentMethod.Size =
                new Size(260, 40);

            this.cmbPaymentMethod.Items.AddRange(
                new object[]
                {
                    "Cash",
                    "Card",
                    "Bank Transfer"
                });

            this.cmbPaymentMethod.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cmbPaymentMethod.SelectedIndex =
                0;

            // =========================
            // ADD
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
                new Point(30, 125);

            this.btnAdd.Size =
                new Size(130, 42);

            this.btnAdd.Text =
                "ADD";

            // =========================
            // UPDATE
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
                new Point(175, 125);

            this.btnUpdate.Size =
                new Size(130, 42);

            this.btnUpdate.Text =
                "UPDATE";

            // =========================
            // DELETE
            // =========================

            this.btnDelete.BorderRadius =
                10;

            this.btnDelete.FillColor =
                Color.FromArgb(90, 45, 45);

            this.btnDelete.ForeColor =
                Color.White;

            this.btnDelete.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnDelete.Location =
                new Point(320, 125);

            this.btnDelete.Size =
                new Size(130, 42);

            this.btnDelete.Text =
                "DELETE";

            // =========================
            // REFRESH
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
                new Point(465, 125);

            this.btnRefresh.Size =
                new Size(130, 42);

            this.btnRefresh.Text =
                "REFRESH";

            // =========================
            // DATAGRIDVIEW
            // =========================

            this.dgvPayments.AllowUserToAddRows =
                false;

            this.dgvPayments.AllowUserToDeleteRows =
                false;
            this.dgvPayments.AllowUserToResizeRows =
                false;

            this.dgvPayments.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvPayments.BackgroundColor =
                Color.FromArgb(25, 32, 29);

            this.dgvPayments.BorderStyle =
                BorderStyle.None;

            this.dgvPayments.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvPayments.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvPayments.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 42, 38);

            this.dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.dgvPayments.ColumnHeadersHeight =
                40;

            this.dgvPayments.DefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 29);

            this.dgvPayments.DefaultCellStyle.ForeColor =
                Color.White;

            this.dgvPayments.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(55, 65, 58);

            this.dgvPayments.EnableHeadersVisualStyles =
                false;

            this.dgvPayments.Location =
                new Point(30, 190);

            this.dgvPayments.RowHeadersVisible =
                false;

            this.dgvPayments.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvPayments.Size =
                new Size(1070, 375);

            // =========================
            // ADD CONTROLS
            // =========================

            this.contentPanel.Controls.Add(
                this.lblOrderID);

            this.contentPanel.Controls.Add(
                this.txtOrderID);

            this.contentPanel.Controls.Add(
                this.lblPaymentDate);

            this.contentPanel.Controls.Add(
                this.dtPaymentDate);

            this.contentPanel.Controls.Add(
                this.lblAmount);

            this.contentPanel.Controls.Add(
                this.txtAmount);

            this.contentPanel.Controls.Add(
                this.lblPaymentMethod);

            this.contentPanel.Controls.Add(
                this.cmbPaymentMethod);

            this.contentPanel.Controls.Add(
                this.btnAdd);

            this.contentPanel.Controls.Add(
                this.btnUpdate);

            this.contentPanel.Controls.Add(
                this.btnDelete);

            this.contentPanel.Controls.Add(
                this.btnRefresh);

            this.contentPanel.Controls.Add(
                this.dgvPayments);

            this.Controls.Add(
                this.headerPanel);

            this.Controls.Add(
                this.contentPanel);

            this.ResumeLayout(false);
        }
    }
}
 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class CustomersForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel mainPanel;
        private Guna2Panel headerPanel;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblFullName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblLoyalty;

        private Guna2TextBox txtFullName;
        private Guna2TextBox txtPhone;
        private Guna2TextBox txtEmail;
        private Guna2CheckBox chkLoyalty;

        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnClear;

        private Guna2TextBox txtSearch;

        private DataGridView dgvCustomers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.mainPanel =
                new Guna2Panel();

            this.headerPanel =
                new Guna2Panel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblFullName =
                new Label();

            this.lblPhone =
                new Label();

            this.lblEmail =
                new Label();

            this.lblLoyalty =
                new Label();

            this.txtFullName =
                new Guna2TextBox();

            this.txtPhone =
                new Guna2TextBox();

            this.txtEmail =
                new Guna2TextBox();

            this.chkLoyalty =
                new Guna2CheckBox();

            this.btnAdd =
                new Guna2Button();

            this.btnUpdate =
                new Guna2Button();

            this.btnDelete =
                new Guna2Button();

            this.btnClear =
                new Guna2Button();

            this.txtSearch =
                new Guna2TextBox();

            this.dgvCustomers =
                new DataGridView();

            this.SuspendLayout();

            // =========================
            // FORM
            // =========================

            this.BackColor =
                Color.FromArgb(10, 24, 20);

            this.ClientSize =
                new Size(1200, 720);

            this.FormBorderStyle =
                FormBorderStyle.None;

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Text =
                "Customers";

            // =========================
            // MAIN PANEL
            // =========================

            this.mainPanel.Dock =
                DockStyle.Fill;

            this.mainPanel.FillColor =
                Color.FromArgb(10, 24, 20);

            this.Controls.Add(
                this.mainPanel);

            // =========================
            // HEADER
            // =========================

            this.headerPanel.Location =
                new Point(25, 20);

            this.headerPanel.Size =
                new Size(1150, 90);

            this.headerPanel.FillColor =
                Color.FromArgb(20, 40, 33);

            this.headerPanel.BorderRadius =
                18;

            this.mainPanel.Controls.Add(
                this.headerPanel);

            // =========================
            // TITLE
            // =========================

            this.lblTitle.AutoSize = true;

            this.lblTitle.Text =
                "Customers";

            this.lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);
 this.lblTitle.ForeColor =
                Color.FromArgb(245, 243, 236);

            this.lblTitle.Location =
                new Point(25, 15);

            this.headerPanel.Controls.Add(
                this.lblTitle);

            // =========================
            // SUBTITLE
            // =========================

            this.lblSubtitle.AutoSize = true;

            this.lblSubtitle.Text =
                "Manage your restaurant customers";

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(160, 175, 166);

            this.lblSubtitle.Location =
                new Point(28, 53);

            this.headerPanel.Controls.Add(
                this.lblSubtitle);

            // =========================
            // FULL NAME
            // =========================

            this.lblFullName.AutoSize = true;

            this.lblFullName.Text =
                "Full Name";

            this.lblFullName.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblFullName.ForeColor =
                Color.White;

            this.lblFullName.Location =
                new Point(40, 140);

            this.mainPanel.Controls.Add(
                this.lblFullName);

            this.txtFullName.Location =
                new Point(40, 165);

            this.txtFullName.Size =
                new Size(300, 42);

            this.txtFullName.PlaceholderText =
                "Enter customer name";

            this.txtFullName.BorderRadius =
                10;

            this.mainPanel.Controls.Add(
                this.txtFullName);

            // =========================
            // PHONE
            // =========================

            this.lblPhone.AutoSize = true;

            this.lblPhone.Text =
                "Phone";

            this.lblPhone.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblPhone.ForeColor =
                Color.White;

            this.lblPhone.Location =
                new Point(370, 140);

            this.mainPanel.Controls.Add(
                this.lblPhone);

            this.txtPhone.Location =
                new Point(370, 165);

            this.txtPhone.Size =
                new Size(300, 42);

            this.txtPhone.PlaceholderText =
                "Enter phone number";

            this.txtPhone.BorderRadius =
                10;

            this.mainPanel.Controls.Add(
                this.txtPhone);

            // =========================
            // EMAIL
            // =========================

            this.lblEmail.AutoSize = true;

            this.lblEmail.Text =
                "Email";

            this.lblEmail.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            this.lblEmail.ForeColor =
                Color.White;

            this.lblEmail.Location =
                new Point(700, 140);

            this.mainPanel.Controls.Add(
                this.lblEmail);

            this.txtEmail.Location =
                new Point(700, 165);

            this.txtEmail.Size =
                new Size(300, 42);

            this.txtEmail.PlaceholderText =
                "Enter email address";

            this.txtEmail.BorderRadius =
                10;

            this.mainPanel.Controls.Add(
                this.txtEmail);

            // =========================
            // LOYALTY
            // =========================

            this.lblLoyalty.AutoSize = true;

            this.lblLoyalty.Text =
                "Loyalty";

            this.lblLoyalty.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);
 this.lblLoyalty.ForeColor =
                Color.White;

            this.lblLoyalty.Location =
                new Point(1030, 140);

            this.mainPanel.Controls.Add(
                this.lblLoyalty);

            this.chkLoyalty.Text =
                "Allow Loyalty";

            this.chkLoyalty.Checked =
                true;

            this.chkLoyalty.AutoSize =
                true;

            this.chkLoyalty.ForeColor =
                Color.White;

            this.chkLoyalty.Location =
                new Point(1030, 170);

            this.mainPanel.Controls.Add(
                this.chkLoyalty);

            // =========================
            // BUTTONS
            // =========================

            ConfigureButton(
                this.btnAdd,
                "Add",
                Color.FromArgb(214, 177, 91),
                Color.FromArgb(10, 24, 20));

            this.btnAdd.Location =
                new Point(40, 245);

            this.btnAdd.Size =
                new Size(145, 42);

            ConfigureButton(
                this.btnUpdate,
                "Update",
                Color.FromArgb(50, 80, 68),
                Color.White);

            this.btnUpdate.Location =
                new Point(200, 245);

            this.btnUpdate.Size =
                new Size(145, 42);

            ConfigureButton(
                this.btnDelete,
                "Delete",
                Color.FromArgb(100, 50, 50),
                Color.White);

            this.btnDelete.Location =
                new Point(360, 245);

            this.btnDelete.Size =
                new Size(145, 42);

            ConfigureButton(
                this.btnClear,
                "Clear",
                Color.FromArgb(50, 65, 60),
                Color.White);

            this.btnClear.Location =
                new Point(520, 245);

            this.btnClear.Size =
                new Size(145, 42);

            this.mainPanel.Controls.Add(
                this.btnAdd);

            this.mainPanel.Controls.Add(
                this.btnUpdate);

            this.mainPanel.Controls.Add(
                this.btnDelete);

            this.mainPanel.Controls.Add(
                this.btnClear);

            // =========================
            // SEARCH
            // =========================

            this.txtSearch.Location =
                new Point(40, 315);

            this.txtSearch.Size =
                new Size(350, 40);

            this.txtSearch.PlaceholderText =
                "Search customers...";

            this.txtSearch.BorderRadius =
                10;

            this.mainPanel.Controls.Add(
                this.txtSearch);

            // =========================
            // GRID
            // =========================

            this.dgvCustomers.Location =
                new Point(40, 370);

            this.dgvCustomers.Size =
                new Size(1090, 300);

            this.dgvCustomers.BackgroundColor =
                Color.FromArgb(18, 35, 30);

            this.dgvCustomers.BorderStyle =
                BorderStyle.None;

            this.dgvCustomers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvCustomers.AllowUserToAddRows =
                false;

            this.dgvCustomers.AllowUserToDeleteRows =
                false;

            this.dgvCustomers.ReadOnly =
                true;

            this.dgvCustomers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvCustomers.MultiSelect =
                false;

            this.dgvCustomers.RowHeadersVisible =
                false;

            this.mainPanel.Controls.Add(
                this.dgvCustomers);

            this.ResumeLayout(false);
            this.PerformLayout();
        }
 private void ConfigureButton(
            Guna2Button button,
            string text,
            Color fill,
            Color foreground)
        {
            button.Text = text;

            button.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            button.FillColor =
                fill;

            button.ForeColor =
                foreground;

            button.BorderRadius =
                10;

            button.HoverState.FillColor =
                Color.FromArgb(
                    214,
                    177,
                    91);

            button.HoverState.ForeColor =
                Color.FromArgb(
                    10,
                    24,
                    20);
        }
    }
}
 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class EmployeesForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel mainPanel;
        private Guna2Panel headerPanel;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullName;
        private Label lblPhone;
        private Label lblJobTitle;
        private Label lblSalary;
        private Label lblActive;

        private Guna2TextBox txtFullName;
        private Guna2TextBox txtPhone;
        private Guna2TextBox txtJobTitle;
        private Guna2TextBox txtSalary;
        private Guna2TextBox txtSearch;

        private Guna2CheckBox chkIsActive;

        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnClear;

        private DataGridView dgvEmployees;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components =
                new System.ComponentModel.Container();

            mainPanel =
                new Guna2Panel();

            headerPanel =
                new Guna2Panel();

            lblTitle =
                new Label();

            lblSubtitle =
                new Label();

            lblFullName =
                new Label();

            lblPhone =
                new Label();

            lblJobTitle =
                new Label();

            lblSalary =
                new Label();

            lblActive =
                new Label();

            txtFullName =
                new Guna2TextBox();

            txtPhone =
                new Guna2TextBox();

            txtJobTitle =
                new Guna2TextBox();

            txtSalary =
                new Guna2TextBox();

            txtSearch =
                new Guna2TextBox();

            chkIsActive =
                new Guna2CheckBox();

            btnAdd =
                new Guna2Button();

            btnUpdate =
                new Guna2Button();

            btnDelete =
                new Guna2Button();

            btnClear =
                new Guna2Button();

            dgvEmployees =
                new DataGridView();

            SuspendLayout();

            // =========================
            // FORM
            // =========================

            BackColor =
                Color.FromArgb(10, 24, 20);

            ClientSize =
                new Size(1200, 720);

            FormBorderStyle =
                FormBorderStyle.None;

            StartPosition =
                FormStartPosition.CenterScreen;

            Text =
                "Employees";

            Controls.Add(mainPanel);

            // =========================
            // MAIN PANEL
            // =========================

            mainPanel.Dock =
                DockStyle.Fill;

            mainPanel.FillColor =
                Color.FromArgb(10, 24, 20);

            // =========================
            // HEADER
            // =========================

            headerPanel.Location =
                new Point(25, 20);

            headerPanel.Size =
                new Size(1150, 90);

            headerPanel.FillColor =
                Color.FromArgb(20, 40, 33);

            headerPanel.BorderRadius =
                18;

            mainPanel.Controls.Add(headerPanel);

            // =========================
            // TITLE
            // =========================

            lblTitle.AutoSize = true;

            lblTitle.Text =
                "Employees";

            lblTitle.Font =
                new Font(
                    "Segoe UI",
                    22F,
                    FontStyle.Bold);
 lblTitle.ForeColor =
                Color.FromArgb(245, 243, 236);

            lblTitle.Location =
                new Point(25, 15);

            headerPanel.Controls.Add(lblTitle);

            // =========================
            // SUBTITLE
            // =========================

            lblSubtitle.AutoSize = true;

            lblSubtitle.Text =
                "Manage restaurant employees";

            lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    9F);

            lblSubtitle.ForeColor =
                Color.FromArgb(160, 175, 166);

            lblSubtitle.Location =
                new Point(28, 53);

            headerPanel.Controls.Add(lblSubtitle);

            // =========================
            // FULL NAME
            // =========================

            lblFullName.AutoSize = true;
            lblFullName.Text = "Full Name";

            lblFullName.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblFullName.ForeColor =
                Color.White;

            lblFullName.Location =
                new Point(40, 135);

            mainPanel.Controls.Add(lblFullName);

            txtFullName.Location =
                new Point(40, 160);

            txtFullName.Size =
                new Size(260, 42);

            txtFullName.PlaceholderText =
                "Employee full name";

            txtFullName.BorderRadius =
                10;

            mainPanel.Controls.Add(txtFullName);

            // =========================
            // PHONE
            // =========================

            lblPhone.AutoSize = true;
            lblPhone.Text = "Phone";

            lblPhone.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblPhone.ForeColor =
                Color.White;

            lblPhone.Location =
                new Point(325, 135);

            mainPanel.Controls.Add(lblPhone);

            txtPhone.Location =
                new Point(325, 160);

            txtPhone.Size =
                new Size(220, 42);

            txtPhone.PlaceholderText =
                "Phone number";

            txtPhone.BorderRadius =
                10;

            mainPanel.Controls.Add(txtPhone);

            // =========================
            // JOB TITLE
            // =========================

            lblJobTitle.AutoSize = true;
            lblJobTitle.Text = "Job Title";

            lblJobTitle.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblJobTitle.ForeColor =
                Color.White;

            lblJobTitle.Location =
                new Point(570, 135);

            mainPanel.Controls.Add(lblJobTitle);

            txtJobTitle.Location =
                new Point(570, 160);

            txtJobTitle.Size =
                new Size(250, 42);

            txtJobTitle.PlaceholderText =
                "Job title";

            txtJobTitle.BorderRadius =
                10;

            mainPanel.Controls.Add(txtJobTitle);

            // =========================
            // SALARY
            // =========================

            lblSalary.AutoSize = true;
            lblSalary.Text = "Salary";

            lblSalary.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblSalary.ForeColor =
                Color.White;

            lblSalary.Location =
                new Point(845, 135);

            mainPanel.Controls.Add(lblSalary);

            txtSalary.Location =
                new Point(845, 160);

            txtSalary.Size =
                new Size(170, 42);

            txtSalary.PlaceholderText =
                "Salary";

            txtSalary.BorderRadius =
                10;
 mainPanel.Controls.Add(txtSalary);

            // =========================
            // ACTIVE
            // =========================

            lblActive.AutoSize = true;
            lblActive.Text = "Status";

            lblActive.Font =
                new Font(
                    "Segoe UI",
                    9F,
                    FontStyle.Bold);

            lblActive.ForeColor =
                Color.White;

            lblActive.Location =
                new Point(1040, 135);

            mainPanel.Controls.Add(lblActive);

            chkIsActive.Text =
                "Active";

            chkIsActive.Checked =
                true;

            chkIsActive.AutoSize =
                true;

            chkIsActive.ForeColor =
                Color.White;

            chkIsActive.Location =
                new Point(1040, 165);

            mainPanel.Controls.Add(chkIsActive);

            // =========================
            // BUTTONS
            // =========================

            ConfigureButton(
                btnAdd,
                "Add",
                Color.FromArgb(214, 177, 91),
                Color.FromArgb(10, 24, 20));

            btnAdd.Location =
                new Point(40, 230);

            btnAdd.Size =
                new Size(145, 42);

            ConfigureButton(
                btnUpdate,
                "Update",
                Color.FromArgb(50, 80, 68),
                Color.White);

            btnUpdate.Location =
                new Point(200, 230);

            btnUpdate.Size =
                new Size(145, 42);

            ConfigureButton(
                btnDelete,
                "Delete",
                Color.FromArgb(100, 50, 50),
                Color.White);

            btnDelete.Location =
                new Point(360, 230);

            btnDelete.Size =
                new Size(145, 42);

            ConfigureButton(
                btnClear,
                "Clear",
                Color.FromArgb(50, 65, 60),
                Color.White);

            btnClear.Location =
                new Point(520, 230);

            btnClear.Size =
                new Size(145, 42);

            mainPanel.Controls.Add(btnAdd);
            mainPanel.Controls.Add(btnUpdate);
            mainPanel.Controls.Add(btnDelete);
            mainPanel.Controls.Add(btnClear);

            // =========================
            // SEARCH
            // =========================

            txtSearch.Location =
                new Point(40, 300);

            txtSearch.Size =
                new Size(360, 40);

            txtSearch.PlaceholderText =
                "Search employees...";

            txtSearch.BorderRadius =
                10;

            mainPanel.Controls.Add(txtSearch);

            // =========================
            // GRID
            // =========================

            dgvEmployees.Location =
                new Point(40, 355);

            dgvEmployees.Size =
                new Size(1090, 315);

            dgvEmployees.BackgroundColor =
                Color.FromArgb(18, 35, 30);

            dgvEmployees.BorderStyle =
                BorderStyle.None;

            dgvEmployees.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvEmployees.AllowUserToAddRows =
                false;

            dgvEmployees.AllowUserToDeleteRows =
                false;

            dgvEmployees.ReadOnly =
                true;

            dgvEmployees.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvEmployees.MultiSelect =
                false;

            dgvEmployees.RowHeadersVisible =
                false;

            mainPanel.Controls.Add(dgvEmployees);

            ResumeLayout(false);
            PerformLayout();
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
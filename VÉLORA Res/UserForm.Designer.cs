 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class UsersForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel headerPanel;
        private Guna2Panel contentPanel;

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblEmployeeID;
        private Label lblUsername;
        private Label lblPassword;
        private Label lblRole;
        private Label lblActive;

        private Guna2TextBox txtEmployeeID;
        private Guna2TextBox txtUsername;
        private Guna2TextBox txtPassword;

        private Guna2ComboBox cmbRole;
        private Guna2CheckBox chkActive;

        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnRefresh;

        private DataGridView dgvUsers;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.headerPanel = new Guna2Panel();
            this.contentPanel = new Guna2Panel();

            this.lblTitle = new Label();
            this.lblSubtitle = new Label();

            this.lblEmployeeID = new Label();
            this.lblUsername = new Label();
            this.lblPassword = new Label();
            this.lblRole = new Label();
            this.lblActive = new Label();

            this.txtEmployeeID = new Guna2TextBox();
            this.txtUsername = new Guna2TextBox();
            this.txtPassword = new Guna2TextBox();

            this.cmbRole = new Guna2ComboBox();
            this.chkActive = new Guna2CheckBox();

            this.btnAdd = new Guna2Button();
            this.btnUpdate = new Guna2Button();
            this.btnDelete = new Guna2Button();
            this.btnRefresh = new Guna2Button();

            this.dgvUsers = new DataGridView();

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
                "UsersForm";

            this.Text =
                "VÉLORA - Users";

            // =========================
            // HEADER
            // =========================

            this.headerPanel.BorderRadius = 18;

            this.headerPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.headerPanel.Location =
                new Point(25, 20);

            this.headerPanel.Size =
                new Size(1130, 90);

            this.lblTitle.AutoSize = true;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    22F);

            this.lblTitle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblTitle.Location =
                new Point(30, 15);

            this.lblTitle.Text =
                "USER MANAGEMENT";

            this.lblSubtitle.AutoSize = true;

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    9.5F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(160, 170, 165);

            this.lblSubtitle.Location =
                new Point(34, 55);

            this.lblSubtitle.Text =
                "Manage system users and access roles";
 this.headerPanel.Controls.Add(
                this.lblTitle);

            this.headerPanel.Controls.Add(
                this.lblSubtitle);

            // =========================
            // CONTENT PANEL
            // =========================

            this.contentPanel.BorderRadius = 18;

            this.contentPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.contentPanel.Location =
                new Point(25, 130);

            this.contentPanel.Size =
                new Size(1130, 605);

            // =========================
            // EMPLOYEE ID
            // =========================

            this.lblEmployeeID.AutoSize = true;

            this.lblEmployeeID.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblEmployeeID.ForeColor =
                Color.White;

            this.lblEmployeeID.Location =
                new Point(30, 25);

            this.lblEmployeeID.Text =
                "EMPLOYEE ID";

            this.txtEmployeeID.BorderRadius = 10;

            this.txtEmployeeID.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtEmployeeID.ForeColor =
                Color.White;

            this.txtEmployeeID.PlaceholderText =
                "Employee ID";

            this.txtEmployeeID.Location =
                new Point(30, 52);

            this.txtEmployeeID.Size =
                new Size(190, 40);

            // =========================
            // USERNAME
            // =========================

            this.lblUsername.AutoSize = true;

            this.lblUsername.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblUsername.ForeColor =
                Color.White;

            this.lblUsername.Location =
                new Point(240, 25);

            this.lblUsername.Text =
                "USERNAME";

            this.txtUsername.BorderRadius = 10;

            this.txtUsername.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtUsername.ForeColor =
                Color.White;

            this.txtUsername.PlaceholderText =
                "Username";

            this.txtUsername.Location =
                new Point(240, 52);

            this.txtUsername.Size =
                new Size(210, 40);

            // =========================
            // PASSWORD
            // =========================

            this.lblPassword.AutoSize = true;

            this.lblPassword.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblPassword.ForeColor =
                Color.White;

            this.lblPassword.Location =
                new Point(470, 25);

            this.lblPassword.Text =
                "PASSWORD";

            this.txtPassword.BorderRadius = 10;

            this.txtPassword.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtPassword.ForeColor =
                Color.White;

            this.txtPassword.PlaceholderText =
                "Password";

            this.txtPassword.Location =
                new Point(470, 52);

            this.txtPassword.Size =
                new Size(210, 40);

            this.txtPassword.PasswordChar = '●';

            // =========================
            // ROLE
            // =========================

            this.lblRole.AutoSize = true;

            this.lblRole.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblRole.ForeColor =
                Color.White;

            this.lblRole.Location =
                new Point(700, 25);

            this.lblRole.Text =
                "ROLE";

            this.cmbRole.BorderRadius = 10;

            this.cmbRole.FillColor =
                Color.FromArgb(34, 42, 38);

            this.cmbRole.ForeColor =
                Color.White;
 this.cmbRole.Location =
                new Point(700, 52);

            this.cmbRole.Size =
                new Size(180, 40);

            this.cmbRole.Items.AddRange(
                new object[]
                {
                    "Admin",
                    "Manager",
                    "Employee"
                });

            this.cmbRole.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cmbRole.SelectedIndex = 0;

            // =========================
            // ACTIVE
            // =========================

            this.lblActive.AutoSize = true;

            this.lblActive.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblActive.ForeColor =
                Color.White;

            this.lblActive.Location =
                new Point(900, 25);

            this.lblActive.Text =
                "STATUS";

            this.chkActive.Checked =
                true;

            this.chkActive.CheckedState.BorderRadius =
                4;

            this.chkActive.CheckedState.FillColor =
                Color.FromArgb(198, 164, 74);

            this.chkActive.UncheckedState.BorderRadius =
                4;

            this.chkActive.UncheckedState.BorderColor =
                Color.Gray;

            this.chkActive.ForeColor =
                Color.White;

            this.chkActive.Text =
                "Active";

            this.chkActive.Location =
                new Point(900, 55);

            this.chkActive.Size =
                new Size(120, 30);

            // =========================
            // ADD
            // =========================

            this.btnAdd.BorderRadius = 10;

            this.btnAdd.FillColor =
                Color.FromArgb(198, 164, 74);

            this.btnAdd.ForeColor =
                Color.FromArgb(20, 20, 18);

            this.btnAdd.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnAdd.Location =
                new Point(30, 115);

            this.btnAdd.Size =
                new Size(130, 42);

            this.btnAdd.Text = "ADD";

            // =========================
            // UPDATE
            // =========================

            this.btnUpdate.BorderRadius = 10;

            this.btnUpdate.FillColor =
                Color.FromArgb(55, 65, 58);

            this.btnUpdate.ForeColor =
                Color.White;

            this.btnUpdate.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnUpdate.Location =
                new Point(175, 115);

            this.btnUpdate.Size =
                new Size(130, 42);

            this.btnUpdate.Text = "UPDATE";

            // =========================
            // DELETE
            // =========================

            this.btnDelete.BorderRadius = 10;

            this.btnDelete.FillColor =
                Color.FromArgb(90, 45, 45);

            this.btnDelete.ForeColor =
                Color.White;

            this.btnDelete.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnDelete.Location =
                new Point(320, 115);

            this.btnDelete.Size =
                new Size(130, 42);

            this.btnDelete.Text = "DELETE";

            // =========================
            // REFRESH
            // =========================

            this.btnRefresh.BorderRadius = 10;

            this.btnRefresh.FillColor =
                Color.FromArgb(55, 65, 58);

            this.btnRefresh.ForeColor =
                Color.White;

            this.btnRefresh.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnRefresh.Location =
                new Point(465, 115);

            this.btnRefresh.Size =
                new Size(130, 42);
this.btnRefresh.Text = "REFRESH";

            // =========================
            // GRID
            // =========================

            this.dgvUsers.AllowUserToAddRows =
                false;

            this.dgvUsers.AllowUserToDeleteRows =
                false;

            this.dgvUsers.AllowUserToResizeRows =
                false;

            this.dgvUsers.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvUsers.BackgroundColor =
                Color.FromArgb(25, 32, 29);

            this.dgvUsers.BorderStyle =
                BorderStyle.None;

            this.dgvUsers.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvUsers.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvUsers.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 42, 38);

            this.dgvUsers.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.dgvUsers.ColumnHeadersHeight = 40;

            this.dgvUsers.DefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 29);

            this.dgvUsers.DefaultCellStyle.ForeColor =
                Color.White;

            this.dgvUsers.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(55, 65, 58);

            this.dgvUsers.EnableHeadersVisualStyles =
                false;

            this.dgvUsers.Location =
                new Point(30, 175);

            this.dgvUsers.RowHeadersVisible =
                false;

            this.dgvUsers.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            this.dgvUsers.Size =
                new Size(1070, 390);

            // =========================
            // ADD CONTROLS
            // =========================

            this.contentPanel.Controls.Add(
                this.lblEmployeeID);

            this.contentPanel.Controls.Add(
                this.txtEmployeeID);

            this.contentPanel.Controls.Add(
                this.lblUsername);

            this.contentPanel.Controls.Add(
                this.txtUsername);

            this.contentPanel.Controls.Add(
                this.lblPassword);

            this.contentPanel.Controls.Add(
                this.txtPassword);

            this.contentPanel.Controls.Add(
                this.lblRole);

            this.contentPanel.Controls.Add(
                this.cmbRole);

            this.contentPanel.Controls.Add(
                this.lblActive);

            this.contentPanel.Controls.Add(
                this.chkActive);

            this.contentPanel.Controls.Add(
                this.btnAdd);

            this.contentPanel.Controls.Add(
                this.btnUpdate);

            this.contentPanel.Controls.Add(
                this.btnDelete);

            this.contentPanel.Controls.Add(
                this.btnRefresh);

            this.contentPanel.Controls.Add(
                this.dgvUsers);

            this.Controls.Add(
                this.headerPanel);

            this.Controls.Add(
                this.contentPanel);

            this.ResumeLayout(false);
        }
    }
}
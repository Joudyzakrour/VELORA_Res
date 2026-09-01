using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class RestaurantTables
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel headerPanel;
        private Guna2Panel contentPanel;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblTableNumber;
        private Label lblCapacity;
        private Label lblStatus;

        private Guna2TextBox txtTableNumber;
        private Guna2TextBox txtCapacity;
        private Guna2ComboBox cmbStatus;

        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnRefresh;

        private DataGridView dgvTables;

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

            this.lblTableNumber =
                new Label();

            this.lblCapacity =
                new Label();

            this.lblStatus =
                new Label();

            this.txtTableNumber =
                new Guna2TextBox();

            this.txtCapacity =
                new Guna2TextBox();

            this.cmbStatus =
                new Guna2ComboBox();

            this.btnAdd =
                new Guna2Button();

            this.btnUpdate =
                new Guna2Button();

            this.btnDelete =
                new Guna2Button();

            this.btnRefresh =
                new Guna2Button();

            this.dgvTables =
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
                "RestaurantTables";

            this.Text =
                "VÉLORA - Restaurant Tables";

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
                "RESTAURANT TABLES";

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
                "Manage restaurant tables and availability";
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
            // TABLE NUMBER
            // =========================

            this.lblTableNumber.AutoSize =
                true;

            this.lblTableNumber.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F);

            this.lblTableNumber.ForeColor =
                Color.White;

            this.lblTableNumber.Location =
                new Point(30, 30);

            this.lblTableNumber.Text =
                "TABLE NUMBER";

            this.txtTableNumber.BorderRadius =
                10;

            this.txtTableNumber.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtTableNumber.ForeColor =
                Color.White;

            this.txtTableNumber.PlaceholderText =
                "Enter table number";

            this.txtTableNumber.Location =
                new Point(30, 58);

            this.txtTableNumber.Size =
                new Size(230, 40);

            // =========================
            // CAPACITY
            // =========================

            this.lblCapacity.AutoSize =
                true;

            this.lblCapacity.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F);

            this.lblCapacity.ForeColor =
                Color.White;

            this.lblCapacity.Location =
                new Point(290, 30);

            this.lblCapacity.Text =
                "CAPACITY";

            this.txtCapacity.BorderRadius =
                10;

            this.txtCapacity.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtCapacity.ForeColor =
                Color.White;

            this.txtCapacity.PlaceholderText =
                "Guests";

            this.txtCapacity.Location =
                new Point(290, 58);

            this.txtCapacity.Size =
                new Size(230, 40);

            // =========================
            // STATUS
            // =========================

            this.lblStatus.AutoSize =
                true;

            this.lblStatus.Font =
                new Font(
                    "Segoe UI Semibold",
                    9.5F);

            this.lblStatus.ForeColor =
                Color.White;

            this.lblStatus.Location =
                new Point(550, 30);

            this.lblStatus.Text =
                "STATUS";

            this.cmbStatus.BorderRadius =
                10;

            this.cmbStatus.FillColor =
                Color.FromArgb(34, 42, 38);

            this.cmbStatus.ForeColor =
                Color.White;

            this.cmbStatus.Location =
                new Point(550, 58);

            this.cmbStatus.Size =
                new Size(230, 40);

            this.cmbStatus.Items.AddRange(
                new object[]
                {
                    "Available",
                    "Occupied",
                    "Reserved"
                });

            this.cmbStatus.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cmbStatus.SelectedIndex =
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

            this.dgvTables.AllowUserToAddRows =
                false;

            this.dgvTables.AllowUserToDeleteRows =
                false;

            this.dgvTables.AllowUserToResizeRows =
                false;

            this.dgvTables.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvTables.BackgroundColor =
                Color.FromArgb(25, 32, 29);

            this.dgvTables.BorderStyle =
                BorderStyle.None;

            this.dgvTables.CellBorderStyle =
                DataGridViewCellBorderStyle.SingleHorizontal;

            this.dgvTables.ColumnHeadersBorderStyle =
                DataGridViewHeaderBorderStyle.None;

            this.dgvTables.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(34, 42, 38);

            this.dgvTables.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.dgvTables.ColumnHeadersHeight =
                40;

            this.dgvTables.DefaultCellStyle.BackColor =
                Color.FromArgb(25, 32, 29);

            this.dgvTables.DefaultCellStyle.ForeColor =
                Color.White;

            this.dgvTables.DefaultCellStyle.SelectionBackColor =
                Color.FromArgb(55, 65, 58);

            this.dgvTables.EnableHeadersVisualStyles =
                false;

            this.dgvTables.Location =
                new Point(30, 190);

            this.dgvTables.RowHeadersVisible =
                false;

            this.dgvTables.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            this.dgvTables.Size =
                new Size(1070, 375);

            // =========================
            // ADD CONTROLS
            // =========================

            this.contentPanel.Controls.Add(
                this.lblTableNumber);

            this.contentPanel.Controls.Add(
                this.txtTableNumber);

            this.contentPanel.Controls.Add(
                this.lblCapacity);

            this.contentPanel.Controls.Add(
                this.txtCapacity);

            this.contentPanel.Controls.Add(
                this.lblStatus);

            this.contentPanel.Controls.Add(
                this.cmbStatus);

            this.contentPanel.Controls.Add(
                this.btnAdd);

            this.contentPanel.Controls.Add(
                this.btnUpdate);

            this.contentPanel.Controls.Add(
                this.btnDelete);

            this.contentPanel.Controls.Add(
                this.btnRefresh);

            this.contentPanel.Controls.Add(
                this.dgvTables);

            // =========================
            // FORM
            // =========================

            this.Controls.Add(
                this.headerPanel);

            this.Controls.Add(
                this.contentPanel);

            this.ResumeLayout(false);
        }
    }
}
 using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class CategoriesForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel mainPanel;
        private Guna2Panel headerPanel;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblName;
        private Label lblDescription;
        private Label lblStatus;

        private Guna2TextBox txtName;
        private Guna2TextBox txtDescription;
        private Guna2CheckBox chkActive;

        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnClear;

        private Guna2TextBox txtSearch;

        private DataGridView dgvCategories;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            Color background = Color.FromArgb(10, 24, 20);
            Color panel = Color.FromArgb(20, 40, 33);
            Color gold = Color.FromArgb(214, 177, 91);
            Color white = Color.FromArgb(245, 243, 236);
            Color muted = Color.FromArgb(160, 175, 166);

            mainPanel = new Guna2Panel();
            headerPanel = new Guna2Panel();

            lblTitle = new Label();
            lblSubtitle = new Label();

            lblName = new Label();
            lblDescription = new Label();
            lblStatus = new Label();

            txtName = new Guna2TextBox();
            txtDescription = new Guna2TextBox();
            chkActive = new Guna2CheckBox();

            btnAdd = new Guna2Button();
            btnUpdate = new Guna2Button();
            btnDelete = new Guna2Button();
            btnClear = new Guna2Button();

            txtSearch = new Guna2TextBox();

            dgvCategories = new DataGridView();

            SuspendLayout();

            // =========================
            // FORM
            // =========================

            BackColor = background;
            ClientSize = new Size(1200, 700);
            FormBorderStyle = FormBorderStyle.None;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Categories";

            // =========================
            // MAIN PANEL
            // =========================

            mainPanel.Dock = DockStyle.Fill;
            mainPanel.FillColor = background;
            mainPanel.BorderRadius = 0;

            Controls.Add(mainPanel);

            // =========================
            // HEADER
            // =========================

            headerPanel.Location = new Point(25, 20);
            headerPanel.Size = new Size(1150, 90);
            headerPanel.FillColor = panel;
            headerPanel.BorderRadius = 18;

            mainPanel.Controls.Add(headerPanel);

            // TITLE

            lblTitle.AutoSize = true;
            lblTitle.Text = "Categories";
            lblTitle.Font = new Font(
                "Segoe UI",
                22F,
                FontStyle.Bold
            );
            lblTitle.ForeColor = white;
            lblTitle.Location = new Point(25, 15);

            headerPanel.Controls.Add(lblTitle);

            // SUBTITLE

            lblSubtitle.AutoSize = true;
            lblSubtitle.Text =
                "Manage restaurant categories";
            lblSubtitle.Font = new Font(
                "Segoe UI",
                9F
            );
            lblSubtitle.ForeColor = muted;
            lblSubtitle.Location = new Point(28, 53);

            headerPanel.Controls.Add(lblSubtitle);

            // =========================
            // NAME
            // =========================
            lblName.AutoSize = true;
            lblName.Text = "Category Name";
            lblName.ForeColor = white;
            lblName.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold
            );
            lblName.Location = new Point(40, 140);

            mainPanel.Controls.Add(lblName);

            txtName.Location = new Point(40, 165);
            txtName.Size = new Size(300, 42);

            txtName.PlaceholderText =
                "Enter category name";

            txtName.BorderRadius = 10;
            txtName.FillColor = Color.FromArgb(25, 48, 40);
            txtName.ForeColor = white;
            txtName.BorderColor = Color.FromArgb(60, 85, 75);

            mainPanel.Controls.Add(txtName);

            // =========================
            // DESCRIPTION
            // =========================

            lblDescription.AutoSize = true;
            lblDescription.Text = "Description";
            lblDescription.ForeColor = white;
            lblDescription.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold
            );
            lblDescription.Location = new Point(370, 140);

            mainPanel.Controls.Add(lblDescription);

            txtDescription.Location = new Point(370, 165);
            txtDescription.Size = new Size(360, 80);

            txtDescription.Multiline = true;
            txtDescription.PlaceholderText =
                "Enter category description";

            txtDescription.BorderRadius = 10;
            txtDescription.FillColor =
                Color.FromArgb(25, 48, 40);

            txtDescription.ForeColor = white;
            txtDescription.BorderColor =
                Color.FromArgb(60, 85, 75);

            mainPanel.Controls.Add(txtDescription);

            // =========================
            // ACTIVE
            // =========================

            lblStatus.AutoSize = true;
            lblStatus.Text = "Status";
            lblStatus.ForeColor = white;
            lblStatus.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold
            );
            lblStatus.Location = new Point(760, 140);

            mainPanel.Controls.Add(lblStatus);

            chkActive.Text = "Active";
            chkActive.Checked = true;
            chkActive.ForeColor = white;
            chkActive.Font = new Font(
                "Segoe UI",
                10F
            );
            chkActive.Location = new Point(760, 170);
            chkActive.AutoSize = true;

            mainPanel.Controls.Add(chkActive);

            // =========================
            // BUTTONS
            // =========================

            ConfigureButton(
                btnAdd,
                "Add",
                gold,
                Color.FromArgb(10, 24, 20)
            );

            btnAdd.Location = new Point(40, 265);
            btnAdd.Size = new Size(145, 42);

            ConfigureButton(
                btnUpdate,
                "Update",
                Color.FromArgb(50, 80, 68),
                white
            );

            btnUpdate.Location = new Point(200, 265);
            btnUpdate.Size = new Size(145, 42);

            ConfigureButton(
                btnDelete,
                "Delete",
                Color.FromArgb(100, 50, 50),
                white
            );

            btnDelete.Location = new Point(360, 265);
            btnDelete.Size = new Size(145, 42);

            ConfigureButton(
                btnClear,
                "Clear",
                Color.FromArgb(50, 65, 60),
                white
            );

            btnClear.Location = new Point(520, 265);
            btnClear.Size = new Size(145, 42);

            mainPanel.Controls.Add(btnAdd);
            mainPanel.Controls.Add(btnUpdate);
            mainPanel.Controls.Add(btnDelete);
            mainPanel.Controls.Add(btnClear);
            // =========================
            // SEARCH
            // =========================

            txtSearch.Location = new Point(40, 335);
            txtSearch.Size = new Size(300, 40);

            txtSearch.PlaceholderText =
                "Search categories...";

            txtSearch.BorderRadius = 10;
            txtSearch.FillColor =
                Color.FromArgb(25, 48, 40);

            txtSearch.ForeColor = white;

            mainPanel.Controls.Add(txtSearch);

            // =========================
            // DATAGRID
            // =========================

            dgvCategories.Location = new Point(40, 390);
            dgvCategories.Size = new Size(1090, 260);

            dgvCategories.BackgroundColor =
                Color.FromArgb(18, 35, 30);

            dgvCategories.BorderStyle =
                BorderStyle.None;

            dgvCategories.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dgvCategories.AllowUserToAddRows = false;
            dgvCategories.AllowUserToDeleteRows = false;
            dgvCategories.ReadOnly = true;
            dgvCategories.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;

            dgvCategories.MultiSelect = false;

            dgvCategories.RowHeadersVisible = false;

            dgvCategories.EnableHeadersVisualStyles = false;

            dgvCategories.ColumnHeadersDefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor = gold,
                    ForeColor =
                        Color.FromArgb(10, 24, 20),
                    Font = new Font(
                        "Segoe UI",
                        9F,
                        FontStyle.Bold
                    )
                };

            dgvCategories.DefaultCellStyle =
                new DataGridViewCellStyle
                {
                    BackColor =
                        Color.FromArgb(22, 43, 36),
                    ForeColor = white,
                    SelectionBackColor =
                        Color.FromArgb(65, 90, 78),
                    SelectionForeColor = white
                };

            mainPanel.Controls.Add(dgvCategories);

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
            button.Font = new Font(
                "Segoe UI",
                9F,
                FontStyle.Bold
            );

            button.FillColor = fill;
            button.ForeColor = foreground;

            button.BorderRadius = 10;

            button.HoverState.FillColor =
                Color.FromArgb(214, 177, 91);

            button.HoverState.ForeColor =
                Color.FromArgb(10, 24, 20);
        }
    }
}
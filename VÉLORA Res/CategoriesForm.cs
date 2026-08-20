 using System;
using System.Data;
using System.Windows.Forms;
using VÉLORA_Res.Data;
using VÉLORA_Res.Models;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class CategoriesForm : Form
    {
        private readonly CategoryService _categoryService;
        private int _selectedCategoryId = 0;

        public CategoriesForm()
        {
            InitializeComponent();

            _categoryService =
                new CategoryService(new DatabaseConnection());

            ConfigureEvents();
            LoadCategories();
            ClearFields();
        }

        private void ConfigureEvents()
        {
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            txtSearch.TextChanged += txtSearch_TextChanged;

            dgvCategories.CellClick += dgvCategories_CellClick;
        }

        private void LoadCategories()
        {
            try
            {
                dgvCategories.DataSource =
                    _categoryService.GetAll();

                ConfigureGrid();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void ConfigureGrid()
        {
            if (dgvCategories.Columns.Count == 0)
                return;

            dgvCategories.Columns["CategoryID"]
                .HeaderText = "ID";

            dgvCategories.Columns["CategoryName"]
                .HeaderText = "Category Name";

            dgvCategories.Columns["Description"]
                .HeaderText = "Description";

            dgvCategories.Columns["IsActive"]
                .HeaderText = "Active";
        }

        private void btnAdd_Click(
            object? sender,
            EventArgs e)
        {
            if (!ValidateInput())
                return;

            try
            {
                Category category = GetCategoryFromFields();

                _categoryService.Add(category);

                MessageBox.Show(
                    "Category added successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCategories();
                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnUpdate_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedCategoryId == 0)
            {
                MessageBox.Show(
                    "Please select a category first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidateInput())
                return;

            try
            {
                Category category = GetCategoryFromFields();

                category.CategoryID =
                    _selectedCategoryId;

                _categoryService.Update(category);

                MessageBox.Show(
                    "Category updated successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCategories();
                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnDelete_Click(
            object? sender,
            EventArgs e)
        {
            if (_selectedCategoryId == 0)
            {
                MessageBox.Show(
                    "Please select a category first.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
               DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this category?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                _categoryService.Delete(
                    _selectedCategoryId);

                MessageBox.Show(
                    "Category deleted successfully.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                LoadCategories();
                ClearFields();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void btnClear_Click(
            object? sender,
            EventArgs e)
        {
            ClearFields();
        }

        private void dgvCategories_CellClick(
            object? sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row =
                dgvCategories.Rows[e.RowIndex];

            _selectedCategoryId =
                Convert.ToInt32(
                    row.Cells["CategoryID"].Value);

            txtName.Text =
                row.Cells["CategoryName"].Value?.ToString();

            txtDescription.Text =
                row.Cells["Description"].Value?.ToString();

            chkActive.Checked =
                Convert.ToBoolean(
                    row.Cells["IsActive"].Value);
        }

        private void txtSearch_TextChanged(
            object? sender,
            EventArgs e)
        {
            if (dgvCategories.DataSource is not DataTable table)
                return;

            string search =
                txtSearch.Text.Trim()
                    .Replace("'", "''");

            if (string.IsNullOrWhiteSpace(search))
            {
                table.DefaultView.RowFilter = string.Empty;
                return;
            }

            table.DefaultView.RowFilter =
                $"CategoryName LIKE '%{search}%' OR " +
                $"Description LIKE '%{search}%'";
        }

        private Category GetCategoryFromFields()
        {
            return new Category
            {
                Name = txtName.Text.Trim(),
                Description =
                    string.IsNullOrWhiteSpace(
                        txtDescription.Text)
                        ? null
                        : txtDescription.Text.Trim(),

                IsActive = chkActive.Checked
            };
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show(
                    "Please enter a category name.",
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtName.Focus();

                return false;
            }

            return true;
        }

        private void ClearFields()
        {
            _selectedCategoryId = 0;

            txtName.Clear();
            txtDescription.Clear();

            chkActive.Checked = true;

            dgvCategories.ClearSelection();

            txtName.Focus();
        }

        private void ShowError(Exception ex)
        {
            MessageBox.Show(
                ex.ToString(),
                "VÉLORA RES - Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
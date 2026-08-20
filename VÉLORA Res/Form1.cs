using System;
using System.Windows.Forms;

namespace VÉLORA_Res
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnProducts.Click += btnProducts_Click;
            btnCustomers.Click += btnCustomers_Click;
           
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
    }
}
  
     namespace VÉLORA_Res
    {
        partial class Orders
        {
            private System.ComponentModel.IContainer components = null;

            private Guna.UI2.WinForms.Guna2Panel headerPanel;
            private Guna.UI2.WinForms.Guna2Panel customerPanel;
            private Guna.UI2.WinForms.Guna2Panel productPanel;
            private Guna.UI2.WinForms.Guna2Panel orderItemsPanel;
            private Guna.UI2.WinForms.Guna2Panel summaryPanel;

            private System.Windows.Forms.Label lblTitle;
            private System.Windows.Forms.Label lblSubtitle;

            private System.Windows.Forms.Label lblCustomer;
            private System.Windows.Forms.Label lblTable;
            private System.Windows.Forms.Label lblStatus;

            private Guna.UI2.WinForms.Guna2ComboBox cmbCustomer;
            private Guna.UI2.WinForms.Guna2ComboBox cmbTable;
            private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;

            private System.Windows.Forms.Label lblProduct;
            private System.Windows.Forms.Label lblQuantity;
            private System.Windows.Forms.Label lblPrice;

            private Guna.UI2.WinForms.Guna2ComboBox cmbProduct;
            private Guna.UI2.WinForms.Guna2NumericUpDown numQuantity;
            private Guna.UI2.WinForms.Guna2TextBox txtPrice;
            private Guna.UI2.WinForms.Guna2Button btnAddProduct;

            private System.Windows.Forms.Label lblOrderItems;

            private System.Windows.Forms.DataGridView dgvOrderItems;

        private System.Windows.Forms.DataGridView dgvOrders;
        private Guna.UI2.WinForms.Guna2Button btnViewOrders;

        private System.Windows.Forms.Label lblSubtotalTitle;
            private System.Windows.Forms.Label lblDiscountTitle;
            private System.Windows.Forms.Label lblTaxTitle;
            private System.Windows.Forms.Label lblTotalTitle;

            private Guna.UI2.WinForms.Guna2TextBox txtDiscount;
            private Guna.UI2.WinForms.Guna2TextBox txtTax;

            private System.Windows.Forms.Label lblSubtotal;
            private System.Windows.Forms.Label lblTotal;

            private Guna.UI2.WinForms.Guna2Button btnCancel;
            private Guna.UI2.WinForms.Guna2Button btnSaveOrder;

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
                this.components = new System.ComponentModel.Container();

                this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
                this.customerPanel = new Guna.UI2.WinForms.Guna2Panel();
                this.productPanel = new Guna.UI2.WinForms.Guna2Panel();
                this.orderItemsPanel = new Guna.UI2.WinForms.Guna2Panel();
                this.summaryPanel = new Guna.UI2.WinForms.Guna2Panel();

                this.lblTitle = new System.Windows.Forms.Label();
                this.lblSubtitle = new System.Windows.Forms.Label();

                this.lblCustomer = new System.Windows.Forms.Label();
                this.lblTable = new System.Windows.Forms.Label();
                this.lblStatus = new System.Windows.Forms.Label();

                this.cmbCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
                this.cmbTable = new Guna.UI2.WinForms.Guna2ComboBox();
                this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();

                this.lblProduct = new System.Windows.Forms.Label();
                this.lblQuantity = new System.Windows.Forms.Label();
                this.lblPrice = new System.Windows.Forms.Label();

                this.cmbProduct = new Guna.UI2.WinForms.Guna2ComboBox();
                this.numQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
                this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
                this.btnAddProduct = new Guna.UI2.WinForms.Guna2Button();

                this.lblOrderItems = new System.Windows.Forms.Label();
                this.dgvOrderItems = new System.Windows.Forms.DataGridView();
                this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnViewOrders = new Guna.UI2.WinForms.Guna2Button();
                this.lblSubtotalTitle = new System.Windows.Forms.Label();
                this.lblDiscountTitle = new System.Windows.Forms.Label();
                this.lblTaxTitle = new System.Windows.Forms.Label();
                this.lblTotalTitle = new System.Windows.Forms.Label();

                this.txtDiscount = new Guna.UI2.WinForms.Guna2TextBox();
                this.txtTax = new Guna.UI2.WinForms.Guna2TextBox();

                this.lblSubtotal = new System.Windows.Forms.Label();
                this.lblTotal = new System.Windows.Forms.Label();

                this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
                this.btnSaveOrder = new Guna.UI2.WinForms.Guna2Button();

                ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
           
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.FromArgb(15, 20, 18);
                this.ClientSize = new System.Drawing.Size(1180, 760);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Name = "Orders";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "VÉLORA - Orders";

                // 
                // headerPanel
                // 
                this.headerPanel.BorderRadius = 18;
                this.headerPanel.FillColor = System.Drawing.Color.FromArgb(25, 32, 29);
                this.headerPanel.Location = new System.Drawing.Point(25, 20);
                this.headerPanel.Size = new System.Drawing.Size(1130, 90);

                // 
                // lblTitle
                // 
                this.lblTitle.AutoSize = true;
                this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
                this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(225, 190, 95);
                this.lblTitle.Location = new System.Drawing.Point(30, 15);
                this.lblTitle.Text = "ORDERS";

                // 
                // lblSubtitle
                // 
                this.lblSubtitle.AutoSize = true;
                this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 170, 165);
                this.lblSubtitle.Location = new System.Drawing.Point(34, 55);
                this.lblSubtitle.Text = "Create and manage restaurant orders";

                this.headerPanel.Controls.Add(this.lblTitle);
                this.headerPanel.Controls.Add(this.lblSubtitle);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.BorderRadius = 10;
            this.btnViewOrders.FillColor =
                System.Drawing.Color.FromArgb(55, 62, 58);

            this.btnViewOrders.ForeColor =
                System.Drawing.Color.White;

            this.btnViewOrders.Font =
                new System.Drawing.Font("Segoe UI Semibold", 9F);

            this.btnViewOrders.Location =
                new System.Drawing.Point(950, 25);

            this.btnViewOrders.Size =
                new System.Drawing.Size(150, 40);

            this.btnViewOrders.Text = "VIEW ORDERS";

            this.headerPanel.Controls.Add(this.btnViewOrders);

            // 
            // customerPanel
            // 
            this.customerPanel.BorderRadius = 18;
                this.customerPanel.FillColor = System.Drawing.Color.FromArgb(25, 32, 29);
                this.customerPanel.Location = new System.Drawing.Point(25, 130);
                this.customerPanel.Size = new System.Drawing.Size(1130, 105);

                // 
                // lblCustomer
                // 
                this.lblCustomer.AutoSize = true;
                this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblCustomer.Location = new System.Drawing.Point(25, 18);
                this.lblCustomer.Text = "CUSTOMER";

                // 
                // cmbCustomer
                // 
                this.cmbCustomer.BorderRadius = 10;
                this.cmbCustomer.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.cmbCustomer.ForeColor = System.Drawing.Color.White;
                this.cmbCustomer.Location = new System.Drawing.Point(25, 45);
                this.cmbCustomer.Size = new System.Drawing.Size(350, 38);
                
                this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                // 
                // lblTable
                // 
                this.lblTable.AutoSize = true;
                this.lblTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblTable.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblTable.Location = new System.Drawing.Point(410, 18);
                this.lblTable.Text = "TABLE";

                // 
                // txtTable
                // 
                this.cmbTable.BorderRadius = 10;
                this.cmbTable.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.cmbTable.ForeColor = System.Drawing.Color.White;
                
                this.cmbTable.Location = new System.Drawing.Point(410, 45);
                this.cmbTable.Size = new System.Drawing.Size(250, 38);
                // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
                this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblStatus.Location = new System.Drawing.Point(695, 18);
                this.lblStatus.Text = "STATUS";

                // 
                // cmbStatus
                // 
                this.cmbStatus.BorderRadius = 10;
                this.cmbStatus.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.cmbStatus.ForeColor = System.Drawing.Color.White;
                this.cmbStatus.Location = new System.Drawing.Point(695, 45);
                this.cmbStatus.Size = new System.Drawing.Size(250, 38);
                this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                this.cmbStatus.Items.AddRange(new object[]
                {
                "Pending",
                "Preparing",
                "Completed",
                "Cancelled"
                });

                this.cmbStatus.SelectedIndex = 0;

                this.customerPanel.Controls.Add(this.lblCustomer);
                this.customerPanel.Controls.Add(this.cmbCustomer);
                this.customerPanel.Controls.Add(this.lblTable);
                this.customerPanel.Controls.Add(this.cmbTable);
                this.customerPanel.Controls.Add(this.lblStatus);
                this.customerPanel.Controls.Add(this.cmbStatus);
               // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.Color.FromArgb(15, 20, 18);
                this.ClientSize = new System.Drawing.Size(1180, 760);
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.Name = "Orders";
                this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
                this.Text = "VÉLORA - Orders";

                // 
                // headerPanel
                // 
                this.headerPanel.BorderRadius = 18;
                this.headerPanel.FillColor = System.Drawing.Color.FromArgb(25, 32, 29);
                this.headerPanel.Location = new System.Drawing.Point(25, 20);
                this.headerPanel.Size = new System.Drawing.Size(1130, 90);

                // 
                // lblTitle
                // 
                this.lblTitle.AutoSize = true;
                this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 22F);
                this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(225, 190, 95);
                this.lblTitle.Location = new System.Drawing.Point(30, 15);
                this.lblTitle.Text = "ORDERS";

                // 
                // lblSubtitle
                // 
                this.lblSubtitle.AutoSize = true;
                this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
                this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(160, 170, 165);
                this.lblSubtitle.Location = new System.Drawing.Point(34, 55);
                this.lblSubtitle.Text = "Create and manage restaurant orders";

                this.headerPanel.Controls.Add(this.lblTitle);
                this.headerPanel.Controls.Add(this.lblSubtitle);

                // 
                // customerPanel
                // 
                this.customerPanel.BorderRadius = 18;
                this.customerPanel.FillColor = System.Drawing.Color.FromArgb(25, 32, 29);
                this.customerPanel.Location = new System.Drawing.Point(25, 130);
                this.customerPanel.Size = new System.Drawing.Size(1130, 105);

                // 
                // lblCustomer
                // 
                this.lblCustomer.AutoSize = true;
                this.lblCustomer.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblCustomer.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblCustomer.Location = new System.Drawing.Point(25, 18);
                this.lblCustomer.Text = "CUSTOMER";

                // 
                // cmbCustomer
                // 
                this.cmbCustomer.BorderRadius = 10;
                this.cmbCustomer.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.cmbCustomer.ForeColor = System.Drawing.Color.White;
                this.cmbCustomer.Location = new System.Drawing.Point(25, 45);
                this.cmbCustomer.Size = new System.Drawing.Size(350, 38);
                
                this.cmbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                // 
                // lblTable
                // 
                this.lblTable.AutoSize = true;
                this.lblTable.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblTable.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblTable.Location = new System.Drawing.Point(410, 18);
                this.lblTable.Text = "TABLE";

                // 
                // txtTable
                // 
                this.cmbTable.BorderRadius = 10;
                this.cmbTable.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.cmbTable.ForeColor = System.Drawing.Color.White;
                
                this.cmbTable.Location = new System.Drawing.Point(410, 45);
                this.cmbTable.Size = new System.Drawing.Size(250, 38);
               // 
            // productPanel
            // 
            this.productPanel.BorderRadius = 18;
                this.productPanel.FillColor = System.Drawing.Color.FromArgb(25, 32, 29);
                this.productPanel.Location = new System.Drawing.Point(25, 250);
                this.productPanel.Size = new System.Drawing.Size(1130, 105);

                // 
                // lblProduct
                // 
                this.lblProduct.AutoSize = true;
                this.lblProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblProduct.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblProduct.Location = new System.Drawing.Point(25, 18);
                this.lblProduct.Text = "PRODUCT";

                // 
                // cmbProduct
                // 
                this.cmbProduct.BorderRadius = 10;
                this.cmbProduct.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.cmbProduct.ForeColor = System.Drawing.Color.White;
                this.cmbProduct.Location = new System.Drawing.Point(25, 45);
                this.cmbProduct.Size = new System.Drawing.Size(430, 38);
                
                this.cmbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                // 
                // lblQuantity
                // 
                this.lblQuantity.AutoSize = true;
                this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblQuantity.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblQuantity.Location = new System.Drawing.Point(480, 18);
                this.lblQuantity.Text = "QUANTITY";

                // 
                // numQuantity
                // 
                this.numQuantity.BorderRadius = 10;
                this.numQuantity.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.numQuantity.ForeColor = System.Drawing.Color.White;
                this.numQuantity.Location = new System.Drawing.Point(480, 45);
                this.numQuantity.Size = new System.Drawing.Size(150, 38);
                this.numQuantity.Minimum = 1;
                this.numQuantity.Maximum = 100;
                this.numQuantity.Value = 1;

                // 
                // lblPrice
                // 
                this.lblPrice.AutoSize = true;
                this.lblPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
                this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(205, 210, 207);
                this.lblPrice.Location = new System.Drawing.Point(655, 18);
                this.lblPrice.Text = "UNIT PRICE";

                // 
                // txtPrice
                // 
                this.txtPrice.BorderRadius = 10;
                this.txtPrice.FillColor = System.Drawing.Color.FromArgb(34, 42, 38);
                this.txtPrice.ForeColor = System.Drawing.Color.White;
                this.txtPrice.Location = new System.Drawing.Point(655, 45);
                this.txtPrice.Size = new System.Drawing.Size(180, 38);
                this.txtPrice.ReadOnly = true;
                this.txtPrice.Text = "0.00";

                // 
                // btnAddProduct
                // 
                this.btnAddProduct.BorderRadius = 10;
                this.btnAddProduct.FillColor = System.Drawing.Color.FromArgb(198, 164, 74);
                this.btnAddProduct.ForeColor = System.Drawing.Color.FromArgb(20, 20, 18);
                this.btnAddProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
                this.btnAddProduct.Location = new System.Drawing.Point(865, 43);
                this.btnAddProduct.Size = new System.Drawing.Size(190, 42);
                this.btnAddProduct.Text = "+  ADD PRODUCT";

                this.productPanel.Controls.Add(this.lblProduct);
                this.productPanel.Controls.Add(this.cmbProduct);
                this.productPanel.Controls.Add(this.lblQuantity);
                this.productPanel.Controls.Add(this.numQuantity);
                this.productPanel.Controls.Add(this.lblPrice);
                this.productPanel.Controls.Add(this.txtPrice);
                this.productPanel.Controls.Add(this.btnAddProduct);
                 // 
            // orderItemsPanel
            // 
            this.orderItemsPanel.BorderRadius = 18;
                this.orderItemsPanel.FillColor = System.Drawing.Color.FromArgb(25, 32, 29);
                this.orderItemsPanel.Location = new System.Drawing.Point(25, 370);
                this.orderItemsPanel.Size = new System.Drawing.Size(760, 365);

                // 
                // lblOrderItems
                // 
                this.lblOrderItems.AutoSize = true;
                this.lblOrderItems.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
                this.lblOrderItems.ForeColor = System.Drawing.Color.FromArgb(225, 190, 95);
                this.lblOrderItems.Location = new System.Drawing.Point(22, 18);
                this.lblOrderItems.Text = "ORDER ITEMS";

                // 
                // dgvOrderItems
                // 
                this.dgvOrderItems.AllowUserToAddRows = false;
                this.dgvOrderItems.AllowUserToDeleteRows = false;
                this.dgvOrderItems.AllowUserToResizeRows = false;
                this.dgvOrderItems.AutoSizeColumnsMode =
                    System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

                this.dgvOrderItems.BackgroundColor =
                    System.Drawing.Color.FromArgb(25, 32, 29);

                this.dgvOrderItems.BorderStyle =
                    System.Windows.Forms.BorderStyle.None;

                this.dgvOrderItems.CellBorderStyle =
                    System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;

                this.dgvOrderItems.ColumnHeadersBorderStyle =
                    System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

                this.dgvOrderItems.ColumnHeadersDefaultCellStyle.BackColor =
                    System.Drawing.Color.FromArgb(34, 42, 38);

                this.dgvOrderItems.ColumnHeadersDefaultCellStyle.ForeColor =
                    System.Drawing.Color.FromArgb(225, 190, 95);

                this.dgvOrderItems.ColumnHeadersDefaultCellStyle.Font =
                    new System.Drawing.Font("Segoe UI Semibold", 9F);

                this.dgvOrderItems.ColumnHeadersHeight = 40;

                this.dgvOrderItems.DefaultCellStyle.BackColor =
                    System.Drawing.Color.FromArgb(25, 32, 29);

                this.dgvOrderItems.DefaultCellStyle.ForeColor =
                    System.Drawing.Color.White;

                this.dgvOrderItems.DefaultCellStyle.SelectionBackColor =
                    System.Drawing.Color.FromArgb(55, 65, 58);

                this.dgvOrderItems.DefaultCellStyle.SelectionForeColor =
                    System.Drawing.Color.White;

                this.dgvOrderItems.EnableHeadersVisualStyles = false;

                this.dgvOrderItems.Location = new System.Drawing.Point(22, 55);

                this.dgvOrderItems.RowHeadersVisible = false;

                this.dgvOrderItems.SelectionMode =
                    System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

                this.dgvOrderItems.Size =
                    new System.Drawing.Size(716, 285);

                this.dgvOrderItems.Columns.Add("ProductID", "Product ID");
                this.dgvOrderItems.Columns.Add("ProductName", "Product");
                this.dgvOrderItems.Columns.Add("Quantity", "Qty");
                this.dgvOrderItems.Columns.Add("UnitPrice", "Unit Price");
                this.dgvOrderItems.Columns.Add("TotalPrice", "Total");

                this.orderItemsPanel.Controls.Add(this.lblOrderItems);
                this.orderItemsPanel.Controls.Add(this.dgvOrderItems);
                // 
            // summaryPanel
            // 
            this.summaryPanel.BorderRadius = 18;
                this.summaryPanel.FillColor =
                    System.Drawing.Color.FromArgb(25, 32, 29);

                this.summaryPanel.Location =
                    new System.Drawing.Point(805, 370);

                this.summaryPanel.Size =
                    new System.Drawing.Size(350, 365);

                // 
                // lblSubtotalTitle
                // 
                this.lblSubtotalTitle.AutoSize = true;
                this.lblSubtotalTitle.Font =
                    new System.Drawing.Font("Segoe UI", 10F);

                this.lblSubtotalTitle.ForeColor =
                    System.Drawing.Color.FromArgb(170, 180, 175);

                this.lblSubtotalTitle.Location =
                    new System.Drawing.Point(25, 30);

                this.lblSubtotalTitle.Text = "SUBTOTAL";

                // 
                // lblSubtotal
                // 
                this.lblSubtotal.AutoSize = true;
                this.lblSubtotal.Font =
                    new System.Drawing.Font("Segoe UI Semibold", 12F);

                this.lblSubtotal.ForeColor =
                    System.Drawing.Color.White;

                this.lblSubtotal.Location =
                    new System.Drawing.Point(245, 27);

                this.lblSubtotal.Text = "$0.00";

                // 
                // lblDiscountTitle
                // 
                this.lblDiscountTitle.AutoSize = true;
                this.lblDiscountTitle.Font =
                    new System.Drawing.Font("Segoe UI", 10F);

                this.lblDiscountTitle.ForeColor =
                    System.Drawing.Color.FromArgb(170, 180, 175);

                this.lblDiscountTitle.Location =
                    new System.Drawing.Point(25, 80);

                this.lblDiscountTitle.Text = "DISCOUNT";

                // 
                // txtDiscount
                // 
                this.txtDiscount.BorderRadius = 9;
                this.txtDiscount.FillColor =
                    System.Drawing.Color.FromArgb(34, 42, 38);

                this.txtDiscount.ForeColor =
                    System.Drawing.Color.White;

                this.txtDiscount.Location =
                    new System.Drawing.Point(210, 70);

                this.txtDiscount.Size =
                    new System.Drawing.Size(105, 35);

                this.txtDiscount.Text = "0";

                // 
                // lblTaxTitle
                // 
                this.lblTaxTitle.AutoSize = true;
                this.lblTaxTitle.Font =
                    new System.Drawing.Font("Segoe UI", 10F);

                this.lblTaxTitle.ForeColor =
                    System.Drawing.Color.FromArgb(170, 180, 175);

                this.lblTaxTitle.Location =
                    new System.Drawing.Point(25, 130);

                this.lblTaxTitle.Text = "TAX";

                // 
                // txtTax
                // 
                this.txtTax.BorderRadius = 9;
                this.txtTax.FillColor =
                    System.Drawing.Color.FromArgb(34, 42, 38);

                this.txtTax.ForeColor =
                    System.Drawing.Color.White;

                this.txtTax.Location =
                    new System.Drawing.Point(210, 120);

                this.txtTax.Size =
                    new System.Drawing.Size(105, 35);

                this.txtTax.Text = "0";

                // 
                // lblTotalTitle
                // 
                this.lblTotalTitle.AutoSize = true;
                this.lblTotalTitle.Font =
                    new System.Drawing.Font("Segoe UI Semibold", 14F);

                this.lblTotalTitle.ForeColor =
                    System.Drawing.Color.FromArgb(225, 190, 95);

                this.lblTotalTitle.Location =
                    new System.Drawing.Point(25, 180);

                this.lblTotalTitle.Text = "TOTAL";

                // 
                // lblTotal
                // 
                this.lblTotal.AutoSize = true;
                this.lblTotal.Font =
                    new System.Drawing.Font("Segoe UI Semibold", 20F);

                this.lblTotal.ForeColor =
                    System.Drawing.Color.FromArgb(225, 190, 95);

                this.lblTotal.Location =
                    new System.Drawing.Point(205, 175);

                this.lblTotal.Text = "$0.00";
                 // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 10;

                this.btnCancel.FillColor =
                    System.Drawing.Color.FromArgb(55, 62, 58);

                this.btnCancel.ForeColor =
                    System.Drawing.Color.White;

                this.btnCancel.Font =
                    new System.Drawing.Font("Segoe UI Semibold", 9F);

                this.btnCancel.Location =
                    new System.Drawing.Point(25, 285);

                this.btnCancel.Size =
                    new System.Drawing.Size(135, 45);

                this.btnCancel.Text = "CANCEL";

                // 
                // btnSaveOrder
                // 
                this.btnSaveOrder.BorderRadius = 10;

                this.btnSaveOrder.FillColor =
                    System.Drawing.Color.FromArgb(198, 164, 74);

                this.btnSaveOrder.ForeColor =
                    System.Drawing.Color.FromArgb(20, 20, 18);

                this.btnSaveOrder.Font =
                    new System.Drawing.Font("Segoe UI Semibold", 9F);

                this.btnSaveOrder.Location =
                    new System.Drawing.Point(175, 285);

                this.btnSaveOrder.Size =
                    new System.Drawing.Size(140, 45);

                this.btnSaveOrder.Text = "SAVE ORDER";

                this.summaryPanel.Controls.Add(this.lblSubtotalTitle);
                this.summaryPanel.Controls.Add(this.lblSubtotal);
                this.summaryPanel.Controls.Add(this.lblDiscountTitle);
                this.summaryPanel.Controls.Add(this.txtDiscount);
                this.summaryPanel.Controls.Add(this.lblTaxTitle);
                this.summaryPanel.Controls.Add(this.txtTax);
                this.summaryPanel.Controls.Add(this.lblTotalTitle);
                this.summaryPanel.Controls.Add(this.lblTotal);
                this.summaryPanel.Controls.Add(this.btnCancel);
                this.summaryPanel.Controls.Add(this.btnSaveOrder);

            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToResizeRows = false;

            this.dgvOrders.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvOrders.BackgroundColor =
                System.Drawing.Color.FromArgb(25, 32, 29);

            this.dgvOrders.BorderStyle =
                System.Windows.Forms.BorderStyle.None;

            this.dgvOrders.ColumnHeadersBorderStyle =
                System.Windows.Forms.DataGridViewHeaderBorderStyle.None;

            this.dgvOrders.ColumnHeadersDefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(34, 42, 38);

            this.dgvOrders.ColumnHeadersDefaultCellStyle.ForeColor =
                System.Drawing.Color.FromArgb(225, 190, 95);

            this.dgvOrders.ColumnHeadersDefaultCellStyle.Font =
                new System.Drawing.Font("Segoe UI Semibold", 9F);

            this.dgvOrders.ColumnHeadersHeight = 40;

            this.dgvOrders.DefaultCellStyle.BackColor =
                System.Drawing.Color.FromArgb(25, 32, 29);

            this.dgvOrders.DefaultCellStyle.ForeColor =
                System.Drawing.Color.White;

            this.dgvOrders.DefaultCellStyle.SelectionBackColor =
                System.Drawing.Color.FromArgb(55, 65, 58);

            this.dgvOrders.DefaultCellStyle.SelectionForeColor =
                System.Drawing.Color.White;

            this.dgvOrders.EnableHeadersVisualStyles = false;

            this.dgvOrders.Location =
                new System.Drawing.Point(25, 130);

            this.dgvOrders.Size =
                new System.Drawing.Size(1130, 605);

            this.dgvOrders.RowHeadersVisible = false;

            this.dgvOrders.SelectionMode =
                System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.dgvOrders.Visible = false;

            this.dgvOrders.Columns.Add("OrderID", "ORDER #");
            this.dgvOrders.Columns.Add("CustomerID", "CUSTOMER");
            this.dgvOrders.Columns.Add("TableID", "TABLE");
            this.dgvOrders.Columns.Add("EmployeeID", "EMPLOYEE");
            this.dgvOrders.Columns.Add("OrderDate", "DATE");
            this.dgvOrders.Columns.Add("Status", "STATUS");
            this.dgvOrders.Columns.Add("Subtotal", "SUBTOTAL");
            this.dgvOrders.Columns.Add("Discount", "DISCOUNT");
            this.dgvOrders.Columns.Add("Tax", "TAX");
            this.dgvOrders.Columns.Add("TotalAmount", "TOTAL");

            this.Controls.Add(this.dgvOrders);
            // 
            // Form controls
            // 
            this.Controls.Add(this.headerPanel);
                this.Controls.Add(this.customerPanel);
                this.Controls.Add(this.productPanel);
                this.Controls.Add(this.orderItemsPanel);
                this.Controls.Add(this.summaryPanel);

                ((System.ComponentModel.ISupportInitialize)
                    (this.numQuantity)).EndInit();

                ((System.ComponentModel.ISupportInitialize)
                    (this.dgvOrderItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)
    (this.dgvOrders)).EndInit();

            this.ResumeLayout(false);
            }
        }
    }

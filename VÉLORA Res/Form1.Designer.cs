 using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;
using VÉLORA_Res.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace VÉLORA_Res
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // MAIN
        private Guna2Panel sidebarPanel;
        private Guna2Panel contentPanel;
        private Guna2Panel headerPanel;

        // LOGO
        private Label lblLogo;
        private Label lblRestaurant;

        // NAVIGATION
        private Guna2Button btnDashboard;
        private Guna2Button btnOrders;
        private Guna2Button btnProducts;
        private Guna2Button btnCustomers;
        private Guna2Button btnInventory;
        private Guna2Button btnAnalytics;
        private Guna2Button btnUsers;
        private Guna2Button btnSettings;
        private Guna2Button btnTables;

        // HEADER
        private Label lblWelcome;
        private Label lblSubtitle;
        private Guna2Button btnClose;

        // CARDS
        private Guna2Panel cardSales;
        private Guna2Panel cardOrders;
        private Guna2Panel cardProfit;
        private Guna2Panel cardCustomers;

        // ANALYTICS
        private Guna2Panel analyticsPanel;
        private Label lblAnalyticsTitle;
        private Label lblAnalyticsSubtitle;

        // BEST SELLERS
        private Guna2Panel bestSellerPanel;
        private Panel bestSellerList;
        private Label lblBestSellerTitle;
        

        // BACKGROUND
        private PictureBox pictureBox1;


        // SIGNATURE
        private Label lblSignature;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnDashboard = new Guna2Button();
            btnOrders = new Guna2Button();
            btnProducts = new Guna2Button();
            btnCustomers = new Guna2Button();
            btnInventory = new Guna2Button();
            btnAnalytics = new Guna2Button();
            btnSettings = new Guna2Button();
            btnTables = new Guna2Button();
            btnUsers = new Guna2Button();
            sidebarPanel = new Guna2Panel();
            lblLogo = new Label();
            lblRestaurant = new Label();
            lblSignature = new Label();
            headerPanel = new Guna2Panel();
            headerPanel.Visible = true;
            headerPanel.BringToFront();
            MakeHeaderShowBackground();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            btnClose = new Guna2Button();
            contentPanel = new Guna2Panel();
            pictureBox1 = new PictureBox();
            analyticsPanel = new Guna2Panel();
            lblAnalyticsTitle = new Label();
            lblAnalyticsSubtitle = new Label();
            bestSellerPanel = new Guna2Panel();
            lblBestSellerTitle = new Label();
            sidebarPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            analyticsPanel.SuspendLayout();
            bestSellerPanel.SuspendLayout();
            SuspendLayout();
            AddDashboardContent();
            TestGlass();
           

            // 
            // btnDashboard
            // 
            btnDashboard.CustomizableEdges = customizableEdges1;
            btnDashboard.Font = new Font("Segoe UI", 9F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDashboard.Size = new Size(180, 45);
            btnDashboard.TabIndex = 0;
            // 
            // btnOrders
            // 
            btnOrders.CustomizableEdges = customizableEdges3;
            btnOrders.Font = new Font("Segoe UI", 9F);
            btnOrders.ForeColor = Color.White;
            btnOrders.Location = new Point(0, 0);
            btnOrders.Name = "btnOrders";
            btnOrders.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnOrders.Size = new Size(180, 45);
            btnOrders.TabIndex = 0;
            // 
            // btnProducts
            // 
            btnProducts.CustomizableEdges = customizableEdges5;
            btnProducts.Font = new Font("Segoe UI", 9F);
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 0);
            btnProducts.Name = "btnProducts";
            btnProducts.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnProducts.Size = new Size(180, 45);
            btnProducts.TabIndex = 0;
            // 
            // btnCustomers
            // 
            btnCustomers.CustomizableEdges = customizableEdges7;
            btnCustomers.Font = new Font("Segoe UI", 9F);
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 0);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnCustomers.Size = new Size(180, 45);
            btnCustomers.TabIndex = 0;
            // 
            // btnInventory
            // 
            btnInventory.CustomizableEdges = customizableEdges9;
            btnInventory.Font = new Font("Segoe UI", 9F);
            btnInventory.ForeColor = Color.White;
            btnInventory.Location = new Point(0, 0);
            btnInventory.Name = "btnInventory";
            btnInventory.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnInventory.Size = new Size(180, 45);
            btnInventory.TabIndex = 0;
            // 
            // btnAnalytics
            // 
            btnAnalytics.CustomizableEdges = customizableEdges11;
            btnAnalytics.Font = new Font("Segoe UI", 9F);
            btnAnalytics.ForeColor = Color.White;
            btnAnalytics.Location = new Point(0, 0);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAnalytics.Size = new Size(180, 45);
            btnAnalytics.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.CustomizableEdges = customizableEdges13;
            btnSettings.Font = new Font("Segoe UI", 9F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSettings.Size = new Size(180, 45);
            btnSettings.TabIndex = 0;
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(235, 8, 22, 18);
            sidebarPanel.Controls.Add(lblLogo);
            sidebarPanel.Controls.Add(lblRestaurant);
            sidebarPanel.Controls.Add(lblSignature);
            sidebarPanel.CustomizableEdges = customizableEdges15;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(235, 8, 22, 18);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges16;
            sidebarPanel.ShadowDecoration.Depth = 25;
            sidebarPanel.ShadowDecoration.Enabled = true;
            sidebarPanel.Size = new Size(245, 788);
            sidebarPanel.TabIndex = 2;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.BackColor = Color.Transparent;
            lblLogo.Font = new Font("Georgia", 27F, FontStyle.Bold);
            lblLogo.ForeColor = Color.FromArgb(214, 177, 91);
            lblLogo.Location = new Point(34, 32);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(182, 41);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "VÉLORA";
            // 
            // lblRestaurant
            // 
            lblRestaurant.AutoSize = true;
            lblRestaurant.BackColor = Color.Transparent;
            lblRestaurant.Font = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            lblRestaurant.ForeColor = Color.FromArgb(145, 165, 154);
            lblRestaurant.Location = new Point(39, 76);
            lblRestaurant.Name = "lblRestaurant";
            lblRestaurant.Size = new Size(146, 12);
            lblRestaurant.TabIndex = 1;
            lblRestaurant.Text = "RESTAURANT MANAGEMENT";
            // 
            // lblSignature
            // 
            lblSignature.AutoSize = true;
            lblSignature.BackColor = Color.Transparent;
            lblSignature.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
            lblSignature.ForeColor = Color.FromArgb(150, 165, 157);
            lblSignature.Location = new Point(35, 740);
            lblSignature.Name = "lblSignature";
            lblSignature.Size = new Size(161, 13);
            lblSignature.TabIndex = 2;
            lblSignature.Text = "Designed & Developed by Joudy ✦";
            // 
            // headerPanel
            // 
            

            headerPanel.Name = "headerPanel";

            headerPanel.Location =
                new Point(245, 0);

            headerPanel.Size =
                new Size(1141, 130);

            headerPanel.BackColor =
                Color.FromArgb(70, 10, 24, 20);

            headerPanel.FillColor =
                Color.FromArgb(70, 10, 24, 20);

            headerPanel.BorderThickness = 0;
            headerPanel.BorderRadius = 0;

            headerPanel.ShadowDecoration.Enabled = false;
             lblWelcome = new Label();

            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;

            lblWelcome.Font =
                new Font("Segoe UI", 22F, FontStyle.Bold);

            lblWelcome.ForeColor =
                Color.FromArgb(248, 247, 242);

            lblWelcome.Location =
                new Point(35, 27);

            lblWelcome.Text =
                "Good Evening, Joudy";

            headerPanel.Controls.Add(lblWelcome);
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(248, 247, 242);
            lblWelcome.Location = new Point(35, 27);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(314, 41);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Good Evening, Joudy";
            // 
            // lblSubtitle
            // 
            lblSubtitle = new Label();

            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;

            lblSubtitle.Font =
                new Font("Segoe UI", 9.5F);

            lblSubtitle.ForeColor =
                Color.FromArgb(176, 190, 181);

            lblSubtitle.Location =
                new Point(38, 70);

            lblSubtitle.Text =
                "Here is what's happening in your restaurant today.";

            headerPanel.Controls.Add(lblSubtitle);
            // 
            // btnClose
            // 
            btnClose = new Guna2Button();

            btnClose.Size =
                new Size(45, 40);

            btnClose.Location =
                new Point(1070, 25);

            btnClose.Anchor =
                AnchorStyles.Top | AnchorStyles.Right;

            btnClose.BorderRadius = 12;

            btnClose.FillColor =
                Color.FromArgb(45, 255, 255, 255);

            btnClose.Font =
                new Font("Segoe UI", 17F, FontStyle.Bold);

            btnClose.ForeColor =
                Color.FromArgb(248, 247, 242);

            btnClose.Text = "×";

            btnClose.Cursor =
                Cursors.Hand;

            headerPanel.Controls.Add(btnClose);
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Controls.Add(analyticsPanel);
            contentPanel.Controls.Add(bestSellerPanel);

            contentPanel.Controls.Add(pictureBox1);
            contentPanel.CustomizableEdges = customizableEdges25;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.FillColor = Color.FromArgb(55, 8, 20, 16);
            contentPanel.Location = new Point(245, 130);
            contentPanel.Name = "contentPanel";
            contentPanel.ShadowDecoration.CustomizableEdges = customizableEdges26;
            contentPanel.Size = new Size(1141, 658);
            contentPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(20, 10, 20, 16);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.photo_٢٠٢٦_٠٨_١٩_٢٢_٠١_٤٩;
            pictureBox1.Paint += (s, e) =>
            {
                using (Brush overlay = new SolidBrush(
                    Color.FromArgb(155, 8, 20, 16)))
                {
                    e.Graphics.FillRectangle(
                        overlay,
                        pictureBox1.ClientRectangle);
                }
            };
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1141, 658);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // analyticsPanel
            // 
            analyticsPanel.BackColor = Color.Transparent;
            analyticsPanel.BorderColor = Color.FromArgb(80, 255, 255, 255);
            analyticsPanel.BorderRadius = 25;
            analyticsPanel.BorderThickness = 1;
            analyticsPanel.Controls.Add(lblAnalyticsTitle);
            analyticsPanel.Controls.Add(lblAnalyticsSubtitle);
            analyticsPanel.CustomizableEdges = customizableEdges21;
            analyticsPanel.FillColor = Color.FromArgb(95, 15, 35, 28);
            analyticsPanel.Location = new Point(35, 320);
            analyticsPanel.Name = "analyticsPanel";
            analyticsPanel.ShadowDecoration.BorderRadius = 25;
            analyticsPanel.ShadowDecoration.CustomizableEdges = customizableEdges22;
            analyticsPanel.ShadowDecoration.Depth = 20;
            analyticsPanel.ShadowDecoration.Enabled = true;
            analyticsPanel.Size = new Size(720, 390);
            analyticsPanel.TabIndex = 1;
            // 
            // lblAnalyticsTitle
            // 
            lblAnalyticsTitle.AutoSize = true;
            lblAnalyticsTitle.BackColor = Color.Transparent;
            lblAnalyticsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblAnalyticsTitle.ForeColor = Color.FromArgb(248, 247, 242);
            lblAnalyticsTitle.Location = new Point(25, 22);
            lblAnalyticsTitle.Name = "lblAnalyticsTitle";
            lblAnalyticsTitle.Size = new Size(156, 28);
            lblAnalyticsTitle.TabIndex = 0;
            lblAnalyticsTitle.Text = "Sales Overview";
            // 
            // lblAnalyticsSubtitle
            // 
            lblAnalyticsSubtitle.AutoSize = true;
            lblAnalyticsSubtitle.BackColor = Color.Transparent;
            lblAnalyticsSubtitle.Font = new Font("Segoe UI", 9F);
            lblAnalyticsSubtitle.ForeColor = Color.FromArgb(176, 190, 181);
            lblAnalyticsSubtitle.Location = new Point(27, 51);
            lblAnalyticsSubtitle.Name = "lblAnalyticsSubtitle";
            lblAnalyticsSubtitle.Size = new Size(151, 15);
            lblAnalyticsSubtitle.TabIndex = 1;
            lblAnalyticsSubtitle.Text = "Monthly sales performance";
            // BEST SELLERS PANEL
            bestSellerPanel.BackColor = Color.Transparent;
            bestSellerPanel.BorderColor = Color.FromArgb(90, 255, 255, 255);
            bestSellerPanel.BorderRadius = 25;
            bestSellerPanel.BorderThickness = 1;

            bestSellerPanel.CustomizableEdges = customizableEdges23;

            bestSellerPanel.FillColor =
                Color.FromArgb(45, 15, 30, 25);

            bestSellerPanel.Location =
                new Point(775, 320);

            bestSellerPanel.Name =
                "bestSellerPanel";

            bestSellerPanel.ShadowDecoration.CustomizableEdges =
                customizableEdges24;

            bestSellerPanel.ShadowDecoration.BorderRadius =
                25;

            bestSellerPanel.ShadowDecoration.Depth =
                12;

            bestSellerPanel.ShadowDecoration.Enabled =
                true;

            bestSellerPanel.Size =
                new Size(330, 390);

            bestSellerPanel.TabIndex = 2;

            // TITLE
            bestSellerPanel.Controls.Add(lblBestSellerTitle);
            // 
            // lblBestSellerTitle
            // 
            lblBestSellerTitle.AutoSize = true;
            lblBestSellerTitle.BackColor = Color.Transparent;
            lblBestSellerTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblBestSellerTitle.ForeColor = Color.FromArgb(248, 247, 242);
            lblBestSellerTitle.Location = new Point(25, 22);
            lblBestSellerTitle.Name = "lblBestSellerTitle";
            lblBestSellerTitle.Size = new Size(121, 28);
            lblBestSellerTitle.TabIndex = 0;
            lblBestSellerTitle.Text = "Best Sellers";

            bestSellerList = new Panel();

            bestSellerList.Location = new Point(22, 65);
            bestSellerList.Size = new Size(286, 285);
            bestSellerList.BackColor = Color.Transparent;

            bestSellerPanel.Controls.Add(bestSellerList);
            BuildBestSellers();

            Label bestNote = new Label();

            bestNote.Text = "Top selling items this month";
            bestNote.AutoSize = true;
            bestNote.BackColor = Color.Transparent;
            bestNote.Font = new Font("Segoe UI", 8.5F);
            bestNote.ForeColor = Color.FromArgb(170, 185, 176);
            bestNote.Location = new Point(25, 285);

            bestSellerPanel.Controls.Add(bestNote);


            // =========================================================
            // SIDEBAR MENU BUTTONS
            // =========================================================

            btnDashboard = CreateMenuButton(
                "Dashboard",
                125,
                true,
                Color.FromArgb(8, 22, 18),
                Color.FromArgb(214, 177, 91),
                Color.White);

            btnOrders = CreateMenuButton(
                "Orders",
                178,
                false,
                Color.FromArgb(8, 22, 18),
                Color.FromArgb(214, 177, 91),
                Color.White);

            btnProducts = CreateMenuButton(
                "Products",
                231,
                false,
                Color.FromArgb(8, 22, 18),
                Color.FromArgb(214, 177, 91),
                Color.White);

            btnCustomers = CreateMenuButton(
                "Customers",
                284,
                false,
                Color.FromArgb(8, 22, 18),
                Color.FromArgb(214, 177, 91),
                Color.White);

            btnInventory = CreateMenuButton(
                "Inventory",
                337,
                false,
                Color.FromArgb(8, 22, 18),
                Color.FromArgb(214, 177, 91),
                Color.White);

            btnAnalytics = CreateMenuButton(
                "Analytics",
                390,
                false,
                Color.FromArgb(8, 22, 18),
                Color.FromArgb(214, 177, 91),
                Color.White);

            btnUsers = CreateMenuButton(
      "Users",
      443,
      false,
      Color.FromArgb(8, 22, 18),
      Color.FromArgb(214, 177, 91),
      Color.White);

            btnTables = CreateMenuButton(
   "Tables",
   496,
   false,
   Color.FromArgb(8, 22, 18),
   Color.FromArgb(214, 177, 91),
   Color.White);

            btnSettings = CreateMenuButton(
                "Settings",
                549,
                false,
                Color.FromArgb(8, 22, 18),
                Color.FromArgb(214, 177, 91),
                Color.White);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(8, 20, 16);
            ClientSize = new Size(1386, 788);
            Controls.Add(contentPanel);
            Controls.Add(headerPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1100, 650);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VÉLORA RES";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            analyticsPanel.ResumeLayout(false);
            analyticsPanel.PerformLayout();
            bestSellerPanel.ResumeLayout(false);
            bestSellerPanel.PerformLayout();
            // ===== HEADER FINAL =====

            headerPanel.Visible = true;

            headerPanel.Location = new Point(245, 0);
            headerPanel.Size = new Size(1141, 130);

            headerPanel.FillColor =
                Color.FromArgb(115, 10, 24, 20);

            headerPanel.BackColor =
                Color.FromArgb(115, 10, 24, 20);

            headerPanel.BorderThickness = 0;
            headerPanel.BorderRadius = 0;

            headerPanel.Controls.Add(lblWelcome);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Controls.Add(btnClose);

            Controls.Add(headerPanel);

            headerPanel.BringToFront();
            ResumeLayout(false);
            PerformLayout();
            // Make dashboard panels children of the background image
            pictureBox1.Controls.Add(analyticsPanel);
            pictureBox1.Controls.Add(bestSellerPanel);

            // Make them truly transparent
            analyticsPanel.FillColor = Color.Transparent;
            bestSellerPanel.FillColor = Color.Transparent;

            analyticsPanel.UseTransparentBackground = true;
            bestSellerPanel.UseTransparentBackground = true;

            analyticsPanel.BorderColor =
    Color.FromArgb(130, 255, 255, 255);

            bestSellerPanel.BorderColor =
                Color.FromArgb(130, 255, 255, 255);

            analyticsPanel.BorderThickness = 1;
            bestSellerPanel.BorderThickness = 1;

            analyticsPanel.BorderRadius = 25;
            bestSellerPanel.BorderRadius = 25;

            analyticsPanel.ShadowDecoration.Enabled = true;
            bestSellerPanel.ShadowDecoration.Enabled = true;

            analyticsPanel.ShadowDecoration.Depth = 12;
            bestSellerPanel.ShadowDecoration.Depth = 12;

            analyticsPanel.ShadowDecoration.BorderRadius = 25;
            bestSellerPanel.ShadowDecoration.BorderRadius = 25;

           
        }

        private void MakeHeaderShowBackground()
        {
            headerPanel.FillColor = Color.Transparent;
            headerPanel.BackColor = Color.Transparent;

            headerPanel.BorderThickness = 0;
            headerPanel.BorderRadius = 0;

            headerPanel.Paint += (s, e) =>
            {
                if (pictureBox1.Image == null)
                    return;

                e.Graphics.DrawImage(
                    pictureBox1.Image,
                    headerPanel.ClientRectangle,
                    0,
                    0,
                    pictureBox1.Image.Width,
                    130,
                    GraphicsUnit.Pixel);

                // طبقة خفيفة جدًا فوق الصورة
                using (Brush overlay = new SolidBrush(
                    Color.FromArgb(155, 8, 20, 16)))
                {
                    e.Graphics.FillRectangle(
                        overlay,
                        headerPanel.ClientRectangle);
                }
                using (Pen shine = new Pen(
    Color.FromArgb(70, 255, 255, 255), 1f))
                {
                    e.Graphics.DrawLine(
                        shine,
                        25,
                        headerPanel.Height - 1,
                        headerPanel.Width - 25,
                        headerPanel.Height - 1);
                }
            };
        }

       
        // =========================================================
        // MENU BUTTON CREATOR
        // =========================================================

        private Guna2Button CreateMenuButton(
            string text,
            int y,
            bool selected,
            Color sidebarColor,
            Color gold,
            Color white)
        {
            Guna2Button button =
                new Guna2Button();

            button.Text = GetMenuIcon(text) + "" + text;
                
            button.TextAlign = HorizontalAlignment.Left;
            button.TextOffset = new Point(18, 0);

            button.Size =
                new Size(205, 48);

            button.Location =
                new Point(20, y);

            button.Font =
                new Font(
                    "Segoe UI",
                    10.5F,
                    FontStyle.Bold);

            button.BorderRadius =
                16;

            button.FillColor =
                selected
                ? gold
                : Color.Transparent;

            button.BorderThickness = selected ? 1 : 0;

            button.BorderColor =
                selected
                ? Color.FromArgb(235, 205, 130)
                : Color.Transparent;

            button.HoverState.FillColor =
                Color.FromArgb(70, 214, 177, 91);

            button.HoverState.ForeColor =
                Color.White;

            button.HoverState.BorderColor =
                Color.FromArgb(150, 255, 255, 255);

            button.PressedColor =
                Color.FromArgb(180, 214, 177, 91);

            button.PressedDepth = 5;

            button.ForeColor =
                selected
                ? sidebarColor
                : white;

            button.HoverState.FillColor =
                gold;

            button.HoverState.ForeColor =
                sidebarColor;

            button.HoverState.BorderColor =
                Color.FromArgb(
                    255,
                    255,
                    255);

            button.Animated =
                true;

            button.Cursor =
                Cursors.Hand;

            button.ShadowDecoration.Enabled =
                selected;

            button.ShadowDecoration.Depth =
                8;

            sidebarPanel.Controls.Add(
                button);

            return button;
        }
        private string GetMenuIcon(string text)
        {
            switch (text)
            {
                case "Dashboard":
                    return "◆";

                case "Orders":
                    return "▣";

                case "Products":
                    return "◇";

                case "Customers":
                    return "●";

                case "Inventory":
                    return "▤";

                case "Analytics":
                    return "◈";

                case "Users":
                    return "♙";

                case "Tables":
                    return "▦";

                case "Settings":
                    return "⚙";

                default:
                    return "•";
            }
        }


        // =========================================================
        // STATISTICS CARD
        // =========================================================

        private Guna2Panel CreateCard(
            string title,
            string value,
            int x,
            int y,
            Color panelColor,
            Color gold,
            Color white,
            Color muted
           )
        {
            Guna2Panel card =
                new Guna2Panel();

            card.Size =
                new Size(220, 125);

            card.Location =
                new Point(x, y);

            card.FillColor =
                panelColor;

            card.BorderRadius =
                22;

            card.BorderColor =
                Color.FromArgb(
                    70,
                    255,
                    255,
                    255);

            card.BorderThickness =
                1;

            card.ShadowDecoration.Enabled =
                true;

            card.ShadowDecoration.Depth =
                16;

            card.ShadowDecoration.BorderRadius =
                22;
            

            // ---------------------------------------------------------
            // CARD TITLE
            // ---------------------------------------------------------

            Label titleLabel =
                new Label();

            titleLabel.AutoSize =
                true;

            titleLabel.BackColor =
                Color.Transparent;

            titleLabel.Text =
                title;

            titleLabel.Font =
                new Font(
                    "Segoe UI",
                    8F,
                    FontStyle.Bold);

            titleLabel.ForeColor =
                muted;

            titleLabel.Location =
                new Point(18, 15);

            card.Controls.Add(
                titleLabel);

            Panel goldLine = new Panel();

            goldLine.Size = new Size(70, 2);
            goldLine.Location = new Point(18, 38);
            goldLine.BackColor = Color.FromArgb(214, 177, 91);

            card.Controls.Add(goldLine);

            // ---------------------------------------------------------
            // CARD VALUE
            // ---------------------------------------------------------

            Label valueLabel = new Label();

            valueLabel.AutoSize = true;
            valueLabel.BackColor = Color.Transparent;
            valueLabel.Text = value;
            valueLabel.Font =
                new Font(
                    "Segoe UI",
                    21F,
                    FontStyle.Bold);

            valueLabel.ForeColor = white;
            valueLabel.Location =
                new Point(18, 43);

            card.Controls.Add(valueLabel);

            // ---------------------------------------------------------
            // CARD CHANGE
            // ---------------------------------------------------------

            Label changeLabel =
                new Label();

            changeLabel.AutoSize =
                true;

            changeLabel.BackColor =
                Color.Transparent;

            changeLabel.Text =
                "↑ 12.5% from last month";

            changeLabel.Font =
                new Font(
                    "Segoe UI",
                    8F);

            changeLabel.ForeColor =
                Color.FromArgb(
                    125,
                    205,
                    155);

            changeLabel.Location =
                new Point(18, 92);

            card.Controls.Add(
                changeLabel);


            return card;
        }

        private Label GetValueLabel(Guna2Panel card)
        {
            foreach (Control control in card.Controls)
            {
                if (control is Label label &&
                    label.Font.Size >= 20)
                {
                    return label;
                }
            }

            throw new Exception("Card value label was not found.");
        }
        private void LoadDashboardStatistics()
        {
            try
            {
                using SqlConnection connection =
                    new DatabaseConnection().CreateConnection();

                connection.Open();

                // TOTAL SALES
                using SqlCommand salesCommand =
                    new SqlCommand(
                        "SELECT ISNULL(SUM(TotalAmount), 0) FROM dbo.Orders",
                        connection);

                decimal totalSales =
                    Convert.ToDecimal(salesCommand.ExecuteScalar());

                // ORDERS
                using SqlCommand ordersCommand =
                    new SqlCommand(
                        "SELECT COUNT(*) FROM dbo.Orders",
                        connection);

                int totalOrders =
                    Convert.ToInt32(ordersCommand.ExecuteScalar());

                // CUSTOMERS
                using SqlCommand customersCommand =
                    new SqlCommand(
                        "SELECT COUNT(*) FROM dbo.Customers",
                        connection);

                int totalCustomers =
                    Convert.ToInt32(customersCommand.ExecuteScalar());

                // NET PROFIT
                // حالياً نحسبه من إجمالي المبيعات
                // ناقص الخصومات
                using SqlCommand profitCommand =
                    new SqlCommand(
                        @"SELECT ISNULL(SUM(TotalAmount - Discount), 0)
                  FROM dbo.Orders",
                        connection);

                decimal netProfit =
                    Convert.ToDecimal(profitCommand.ExecuteScalar());

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load dashboard statistics.\n\n" +
                    ex.Message,
                    "VÉLORA RES",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private Label salesValueLabel;
        private Label ordersValueLabel;
        private Label profitValueLabel;
        private Label customersValueLabel;
        private void AddDashboardContent()
        {
            // ==============================
            // STATISTICS CARDS
            // ==============================

            Guna2Panel salesCard = CreateCard(
     "TOTAL SALES",
     "$0.00",
     35,
     170,
     Color.FromArgb(75, 15, 35, 28),
     Color.FromArgb(214, 177, 91),
     Color.FromArgb(248, 247, 242),
     Color.FromArgb(170, 185, 176));

            salesValueLabel = GetValueLabel(salesCard);


            Guna2Panel ordersCard = CreateCard(
                "ORDERS",
                "0",
                275,
                170,
                Color.FromArgb(75, 15, 35, 28),
                Color.FromArgb(214, 177, 91),
                Color.FromArgb(248, 247, 242),
                Color.FromArgb(170, 185, 176));

            ordersValueLabel = GetValueLabel(ordersCard);


            Guna2Panel profitCard = CreateCard(
                "NET PROFIT",
                "$0.00",
                515,
                170,
                Color.FromArgb(75, 15, 35, 28),
                Color.FromArgb(214, 177, 91),
                Color.FromArgb(248, 247, 242),
                Color.FromArgb(170, 185, 176));

            profitValueLabel = GetValueLabel(profitCard);


            Guna2Panel customersCard = CreateCard(
                "CUSTOMERS",
                "0",
                755,
                170,
                Color.FromArgb(75, 15, 35, 28),
                Color.FromArgb(214, 177, 91),
                Color.FromArgb(248, 247, 242),
                Color.FromArgb(170, 185, 176));

            customersValueLabel = GetValueLabel(customersCard);


            pictureBox1.Controls.Add(salesCard);
            pictureBox1.Controls.Add(ordersCard);
            pictureBox1.Controls.Add(profitCard);
            pictureBox1.Controls.Add(customersCard);

            pictureBox1.SendToBack();

            salesCard.BringToFront();
            ordersCard.BringToFront();
            profitCard.BringToFront();
            customersCard.BringToFront();


            // ==============================
            // SALES OVERVIEW
            // ==============================

            // ==============================
            // SALES OVERVIEW
            // ==============================

            Label salesValue = new Label();

            salesValue.Text = "$0.00";
            salesValue.AutoSize = true;
            salesValue.BackColor = Color.Transparent;
            salesValue.Font =
                new Font("Segoe UI", 22F, FontStyle.Bold);
            salesValue.ForeColor = Color.White;
            salesValue.Location = new Point(25, 90);

            analyticsPanel.Controls.Add(salesValue);


            // ==============================
            // LOAD REAL SALES DATA
            // ==============================

            DataTable salesData = new DataTable();

            try
            {
                const string query = @"
        SELECT
            YEAR(OrderDate) AS OrderYear,
            MONTH(OrderDate) AS OrderMonth,
            SUM(TotalAmount) AS TotalSales
        FROM dbo.Orders
        WHERE Status <> 'Cancelled'
        GROUP BY
            YEAR(OrderDate),
            MONTH(OrderDate)
        ORDER BY
            OrderYear,
            OrderMonth;";

                using SqlConnection connection =
                    new DatabaseConnection().CreateConnection();

                using SqlCommand command =
                    new SqlCommand(query, connection);

                using SqlDataAdapter adapter =
                    new SqlDataAdapter(command);

                adapter.Fill(salesData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "VÉLORA RES - Sales Chart",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }


            // ==============================
            // TOTAL SALES
            // ==============================

            decimal totalSales = 0;

            foreach (DataRow row in salesData.Rows)
            {
                totalSales +=
                    Convert.ToDecimal(row["TotalSales"]);
            }

            salesValue.Text =
                $"${totalSales:0.00}";


            // ==============================
            // LAST 7 MONTHS
            // ==============================

            DateTime currentMonth =
                new DateTime(
                    DateTime.Now.Year,
                    DateTime.Now.Month,
                    1);

            DateTime[] chartMonths =
                new DateTime[7];

            decimal[] monthlySales =
                new decimal[7];

            for (int i = 0; i < 7; i++)
            {
                chartMonths[i] =
                    currentMonth.AddMonths(i - 6);
            }


            // ==============================
            // MATCH DATABASE DATA
            // ==============================

            for (int i = 0; i < 7; i++)
            {
                foreach (DataRow row in salesData.Rows)
                {
                    int year =
                        Convert.ToInt32(row["OrderYear"]);

                    int month =
                        Convert.ToInt32(row["OrderMonth"]);

                    if (year == chartMonths[i].Year &&
                        month == chartMonths[i].Month)
                    {
                        monthlySales[i] =
                            Convert.ToDecimal(row["TotalSales"]);

                        break;
                    }
                }
            }


            // ==============================
            // FIND MAXIMUM VALUE
            // ==============================

            decimal maxSales = 1;

            for (int i = 0; i < 7; i++)
            {
                if (monthlySales[i] > maxSales)
                    maxSales = monthlySales[i];
            }


            // ==============================
            // CHART BARS
            // ==============================

            for (int i = 0; i < 7; i++)
            {
                int barHeight;

                if (monthlySales[i] > 0)
                {
                    barHeight =
                        Math.Max(
                            8,
                            (int)(
                                (monthlySales[i] / maxSales)
                                * 205));
                }
                else
                {
                    barHeight = 5;
                }


                Guna2Panel bar =
                    new Guna2Panel();

                bar.Size =
                    new Size(30, barHeight);

                bar.Location =
                    new Point(
                        260 + (i * 55),
                        330 - barHeight);

                bar.FillColor =
                    Color.FromArgb(214, 177, 91);

                bar.BorderRadius = 12;

                bar.ShadowDecoration.Enabled = true;
                bar.ShadowDecoration.Depth = 8;

                analyticsPanel.Controls.Add(bar);


                Label valueLabel =
                    new Label();

                valueLabel.Text =
                    monthlySales[i] > 0
                    ? $"${monthlySales[i]:0}"
                    : "$0";

                valueLabel.AutoSize = true;
                valueLabel.BackColor =
                    Color.Transparent;

                valueLabel.Font =
                    new Font(
                        "Segoe UI",
                        7F,
                        FontStyle.Bold);

                valueLabel.ForeColor =
                    Color.FromArgb(214, 177, 91);

                valueLabel.Location =
                    new Point(
                        bar.Left - 5,
                        bar.Top - 18);

                analyticsPanel.Controls.Add(valueLabel);
                valueLabel.BringToFront();
                bar.BringToFront();
            }


            // ==============================
            // MONTH LABELS
            // ==============================

            for (int i = 0; i < 7; i++)
            {
                Label monthLabel =
                    new Label();

                monthLabel.Text =
                    chartMonths[i].ToString("MMM");

                monthLabel.AutoSize = true;
                monthLabel.BackColor =
                    Color.Transparent;

                monthLabel.Font =
                    new Font(
                        "Segoe UI",
                        8F);

                monthLabel.ForeColor =
                    Color.FromArgb(170, 185, 176);

                monthLabel.Location =
                    new Point(
                        262 + (i * 55),
                        345);

                analyticsPanel.Controls.Add(
                    monthLabel);
            }


            // ==============================
            // SALES TREND LINE
            // ==============================

            analyticsPanel.Paint +=
                (sender, e) =>
                {
                    Graphics g = e.Graphics;

                    g.SmoothingMode =
            System.Drawing.Drawing2D
            .SmoothingMode.AntiAlias;

                    Point[] points =
            new Point[7];

                    for (int i = 0; i < 7; i++)
                    {
                        int y;

                        if (monthlySales[i] > 0)
                        {
                            int height =
                    (int)(
                        (monthlySales[i] / maxSales)
                        * 205);

                            y = 330 - height;
                        }
                        else
                        {
                            y = 330;
                        }

                        points[i] =
                new Point(
                    275 + (i * 55),
                    y);
                    }


                    using (Pen trendPen =
            new Pen(
                Color.FromArgb(
                    190,
                    214,
                    177,
                    91),
                2f))
                    {
                        g.DrawLines(
                trendPen,
                points);
                    }


                    using (Brush dotBrush =
            new SolidBrush(
                Color.FromArgb(
                    214,
                    177,
                    91)))
                    {
                        foreach (Point point in points)
                        {
                            g.FillEllipse(
                    dotBrush,
                    point.X - 3,
                    point.Y - 3,
                    6,
                    6);
                        }
                    }
                };
        }
           

        // =========================================================
        // PRODUCT LABEL
        // =========================================================

        
        private void CreateBestSellerRow(
     string product,
     string price,
     int y)
        {
            Panel row = new Panel();

            row.Size = new Size(280, 42);
            row.Location = new Point(25, y);
            row.BackColor = Color.Transparent;

            Label lblProduct = new Label();

            lblProduct.Text = product;
            lblProduct.AutoSize = true;
            lblProduct.BackColor = Color.Transparent;
            lblProduct.Font =
                new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProduct.ForeColor = Color.White;
            lblProduct.Location = new Point(0, 4);

            row.Controls.Add(lblProduct);

            Label lblPrice = new Label();

            lblPrice.Text = price;
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font =
                new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPrice.ForeColor =
                Color.FromArgb(214, 177, 91);
            lblPrice.Location = new Point(235, 4);

            row.Controls.Add(lblPrice);

            Panel line = new Panel();

            line.Size = new Size(280, 1);
            line.Location = new Point(0, 35);
            line.BackColor =
                Color.FromArgb(45, 255, 255, 255);

            row.Controls.Add(line);

            bestSellerPanel.Controls.Add(row);
        }
        private void TestGlass()
{
    analyticsPanel.FillColor =
        Color.FromArgb(30, 255, 255, 255);

    bestSellerPanel.FillColor =
        Color.FromArgb(30, 255, 255, 255);

    analyticsPanel.BorderColor =
        Color.FromArgb(140, 255, 255, 255);

    bestSellerPanel.BorderColor =
        Color.FromArgb(140, 255, 255, 255);
}

        private void AddGlassShine(Guna2Panel panel)
        {
            panel.Paint += (sender, e) =>
            {
                Graphics g = e.Graphics;

                g.SmoothingMode =
                    System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (Pen shine = new Pen(
                    Color.FromArgb(90, 255, 255, 255),
                    1.5f))
                {
                    g.DrawLine(
                        shine,
                        28,
                        1,
                        panel.Width - 28,
                        1);
                }

                using (Pen softShine = new Pen(
                    Color.FromArgb(35, 255, 255, 255),
                    1f))
                {
                    g.DrawLine(
                        softShine,
                        45,
                        3,
                        panel.Width - 45,
                        3);
                }
            };
        }

        private void BuildBestSellers()
        {
            bestSellerList.Controls.Clear();

            AddBestSellerItem(
                "01",
                "Truffle Pasta",
                "Most ordered",
                "$24",
                0);

            AddBestSellerItem(
                "02",
                "Premium Burger",
                "Chef's choice",
                "$21",
                68);

            AddBestSellerItem(
                "03",
                "Salmon Steak",
                "Fresh today",
                "$19",
                136);


        }

        private void AddBestSellerItem(
    string number,
    string product,
    string subtitle,
    string price,
    int y)
        {
            Panel item = new Panel();

            item.Location = new Point(0, y);
            item.Size = new Size(286, 60);
            item.BackColor = Color.Transparent;

            // NUMBER
            Label lblNumber = new Label();

            lblNumber.Text = number;
            lblNumber.Font =
                new Font("Segoe UI", 8.5F, FontStyle.Bold);

            lblNumber.ForeColor =
                Color.FromArgb(214, 177, 91);

            lblNumber.BackColor =
                Color.Transparent;

            lblNumber.AutoSize = true;
            lblNumber.Location =
                new Point(3, 5);

            item.Controls.Add(lblNumber);


            // PRODUCT NAME
            Label lblProduct = new Label();

            lblProduct.Text = product;
            lblProduct.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            lblProduct.ForeColor =
                Color.FromArgb(248, 247, 242);

            lblProduct.BackColor =
                Color.Transparent;

            lblProduct.AutoSize = true;
            lblProduct.Location =
                new Point(35, 2);

            item.Controls.Add(lblProduct);


            // SUBTITLE
            Label lblSubtitle = new Label();

            lblSubtitle.Text = subtitle;
            lblSubtitle.Font =
                new Font("Segoe UI", 7.5F);

            lblSubtitle.ForeColor =
                Color.FromArgb(155, 175, 164);

            lblSubtitle.BackColor =
                Color.Transparent;

            lblSubtitle.AutoSize = true;
            lblSubtitle.Location =
                new Point(35, 27);

            item.Controls.Add(lblSubtitle);


            // PRICE
            Label lblPrice = new Label();

            lblPrice.Text = price;
            lblPrice.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            lblPrice.ForeColor =
                Color.FromArgb(214, 177, 91);

            lblPrice.BackColor =
                Color.Transparent;

            lblPrice.AutoSize = true;
            lblPrice.Location =
                new Point(230, 8);

            item.Controls.Add(lblPrice);


            // SEPARATOR
            Panel separator = new Panel();

            separator.Size =
                new Size(280, 1);

            separator.Location =
                new Point(3, 54);

            separator.BackColor =
                Color.FromArgb(45, 255, 255, 255);

            item.Controls.Add(separator);


            bestSellerList.Controls.Add(item);
        }

        // =========================================================
        // END OF DESIGNER
        // =========================================================

    }
}
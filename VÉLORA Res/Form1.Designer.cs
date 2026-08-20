 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

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
        private Guna2Button btnSettings;

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
        private Label lblBestSellerTitle;
        private Label lblProduct1;
        private Label lblProduct2;
        private Label lblProduct3;
        private Label lblProduct4;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            sidebarPanel = new Guna2Panel();
            lblLogo = new Label();
            lblRestaurant = new Label();
            lblSignature = new Label();
            headerPanel = new Guna2Panel();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            btnClose = new Guna2Button();
            contentPanel = new Guna2Panel();
            analyticsPanel = new Guna2Panel();
            lblAnalyticsTitle = new Label();
            lblAnalyticsSubtitle = new Label();
            bestSellerPanel = new Guna2Panel();
            lblBestSellerTitle = new Label();
            pictureBox1 = new PictureBox();
            sidebarPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            analyticsPanel.SuspendLayout();
            bestSellerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(235, 8, 22, 18);
            sidebarPanel.Controls.Add(lblLogo);
            sidebarPanel.Controls.Add(lblRestaurant);
            sidebarPanel.Controls.Add(lblSignature);
            sidebarPanel.CustomizableEdges = customizableEdges1;
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.FillColor = Color.FromArgb(235, 8, 22, 18);
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            headerPanel.BackColor = Color.FromArgb(115, 10, 24, 20);
            headerPanel.Controls.Add(lblWelcome);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Controls.Add(btnClose);
            headerPanel.CustomizableEdges = customizableEdges5;
            headerPanel.Dock = DockStyle.Top;
            headerPanel.FillColor = Color.FromArgb(115, 10, 24, 20);
            headerPanel.Location = new Point(245, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            headerPanel.ShadowDecoration.Depth = 12;
            headerPanel.ShadowDecoration.Enabled = true;
            headerPanel.Size = new Size(1141, 130);
            headerPanel.TabIndex = 1;
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
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(176, 190, 181);
            lblSubtitle.Location = new Point(38, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(302, 17);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Here is what's happening in your restaurant today.";
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BorderRadius = 12;
            btnClose.CustomizableEdges = customizableEdges3;
            btnClose.FillColor = Color.FromArgb(45, 255, 255, 255);
            btnClose.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(248, 247, 242);
            btnClose.HoverState.FillColor = Color.FromArgb(150, 130, 50, 50);
            btnClose.Location = new Point(1070, 25);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnClose.Size = new Size(45, 40);
            btnClose.TabIndex = 2;
            btnClose.Text = "×";
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.Transparent;
            contentPanel.Controls.Add(pictureBox1);
            contentPanel.Controls.Add(analyticsPanel);
            contentPanel.Controls.Add(bestSellerPanel);
            contentPanel.CustomizableEdges = customizableEdges11;
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.FillColor = Color.FromArgb(55, 8, 20, 16);
            contentPanel.Location = new Point(245, 130);
            contentPanel.Name = "contentPanel";
            contentPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            contentPanel.Size = new Size(1141, 658);
            contentPanel.TabIndex = 0;
            // 
            // analyticsPanel
            // 
            analyticsPanel.BackColor = Color.Transparent;
            analyticsPanel.BorderColor = Color.FromArgb(80, 255, 255, 255);
            analyticsPanel.BorderRadius = 25;
            analyticsPanel.BorderThickness = 1;
            analyticsPanel.Controls.Add(lblAnalyticsTitle);
            analyticsPanel.Controls.Add(lblAnalyticsSubtitle);
            analyticsPanel.CustomizableEdges = customizableEdges7;
            analyticsPanel.FillColor = Color.FromArgb(95, 15, 35, 28);
            analyticsPanel.Location = new Point(35, 180);
            analyticsPanel.Name = "analyticsPanel";
            analyticsPanel.ShadowDecoration.BorderRadius = 25;
            analyticsPanel.ShadowDecoration.CustomizableEdges = customizableEdges8;
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
            // 
            // bestSellerPanel
            // 
            bestSellerPanel.BackColor = Color.Transparent;
            bestSellerPanel.BorderColor = Color.FromArgb(85, 255, 255, 255);
            bestSellerPanel.BorderRadius = 25;
            bestSellerPanel.BorderThickness = 1;
            bestSellerPanel.Controls.Add(lblBestSellerTitle);
            bestSellerPanel.CustomizableEdges = customizableEdges9;
            bestSellerPanel.FillColor = Color.FromArgb(105, 15, 35, 28);
            bestSellerPanel.Location = new Point(775, 180);
            bestSellerPanel.Name = "bestSellerPanel";
            bestSellerPanel.ShadowDecoration.BorderRadius = 25;
            bestSellerPanel.ShadowDecoration.CustomizableEdges = customizableEdges10;
            bestSellerPanel.ShadowDecoration.Depth = 20;
            bestSellerPanel.ShadowDecoration.Enabled = true;
            bestSellerPanel.Size = new Size(330, 390);
            bestSellerPanel.TabIndex = 2;
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
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(20, 10, 20, 16);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.photo_٢٠٢٦_٠٨_١٩_٢٢_٠١_٤٩;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1141, 658);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            analyticsPanel.ResumeLayout(false);
            analyticsPanel.PerformLayout();
            bestSellerPanel.ResumeLayout(false);
            bestSellerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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

            button.Text =
                text;

            button.Size =
                new Size(205, 43);

            button.Location =
                new Point(20, y);

            button.Font =
                new Font(
                    "Segoe UI",
                    10F,
                    FontStyle.Bold);

            button.BorderRadius =
                14;

            button.FillColor =
                selected
                ? gold
                : Color.Transparent;

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
            Color muted)
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
                new Point(18, 17);

            card.Controls.Add(
                titleLabel);


            // ---------------------------------------------------------
            // CARD VALUE
            // ---------------------------------------------------------

            Label valueLabel =
                new Label();

            valueLabel.AutoSize =
                true;

            valueLabel.BackColor =
                Color.Transparent;

            valueLabel.Text =
                value;
                 valueLabel.Font =
                new Font(
                    "Segoe UI",
                    21F,
                    FontStyle.Bold);

            valueLabel.ForeColor =
                white;

            valueLabel.Location =
                new Point(18, 42);

            card.Controls.Add(
                valueLabel);


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
                new Point(18, 91);

            card.Controls.Add(
                changeLabel);


            return card;
        }


        // =========================================================
        // PRODUCT LABEL
        // =========================================================

        private Label CreateProductLabel(
            string text,
            int y,
            Color white,
            Color gold)
        {
            Label label =
                new Label();

            label.AutoSize =
                true;

            label.BackColor =
                Color.Transparent;

            label.Text =
                text;

            label.Font =
                new Font(
                    "Segoe UI",
                    9.5F,
                    FontStyle.Bold);

            label.ForeColor =
                white;

            label.Location =
                new Point(25, y);

            bestSellerPanel.Controls.Add(
                label);

            return label;
        }


        // =========================================================
        // END OF DESIGNER
        // =========================================================

    }
}
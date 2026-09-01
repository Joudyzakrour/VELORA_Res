 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class Settings
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel headerPanel;
        private Guna2Panel settingsPanel;

        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblRestaurant;
        private Label lblRestaurantValue;

        private Label lblCurrency;
        private Guna2ComboBox cmbCurrency;

        private Label lblTheme;
        private Guna2ComboBox cmbTheme;

        private Label lblNotifications;
        private Guna2ToggleSwitch toggleNotifications;

        private Guna2Button btnSave;
        private Guna2Button btnReset;

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

            this.settingsPanel =
                new Guna2Panel();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblRestaurant =
                new Label();

            this.lblRestaurantValue =
                new Label();

            this.lblCurrency =
                new Label();

            this.cmbCurrency =
                new Guna2ComboBox();

            this.lblTheme =
                new Label();

            this.cmbTheme =
                new Guna2ComboBox();

            this.lblNotifications =
                new Label();

            this.toggleNotifications =
                new Guna2ToggleSwitch();

            this.btnSave =
                new Guna2Button();

            this.btnReset =
                new Guna2Button();

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
                "Settings";

            this.Text =
                "VÉLORA - Settings";

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

            // =========================
            // TITLE
            // =========================

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
                "SETTINGS";

            // =========================
            // SUBTITLE
            // =========================

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
                "Manage your VÉLORA restaurant preferences";

            this.headerPanel.Controls.Add(
                this.lblTitle);

            this.headerPanel.Controls.Add(
                this.lblSubtitle);

            // =========================
            // SETTINGS PANEL
            // =========================

            this.settingsPanel.BorderRadius =
                18;

            this.settingsPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.settingsPanel.Location =
                new Point(25, 130);

            this.settingsPanel.Size =
                new Size(1130, 605);

            // =========================
            // RESTAURANT
            // =========================

            this.lblRestaurant.AutoSize =
                true;

            this.lblRestaurant.Font =
                new Font(
                    "Segoe UI Semibold",
                    10F);

            this.lblRestaurant.ForeColor =
                Color.FromArgb(205, 210, 207);

            this.lblRestaurant.Location =
                new Point(35, 35);

            this.lblRestaurant.Text =
                "RESTAURANT";

            this.lblRestaurantValue.AutoSize =
                true;

            this.lblRestaurantValue.Font =
                new Font(
                    "Segoe UI Semibold",
                    16F);

            this.lblRestaurantValue.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblRestaurantValue.Location =
                new Point(35, 65);

            this.lblRestaurantValue.Text =
                "VÉLORA RESTAURANT";

            // =========================
            // CURRENCY
            // =========================

            this.lblCurrency.AutoSize =
                true;

            this.lblCurrency.Font =
                new Font(
                    "Segoe UI Semibold",
                    10F);

            this.lblCurrency.ForeColor =
                Color.FromArgb(205, 210, 207);

            this.lblCurrency.Location =
                new Point(35, 140);

            this.lblCurrency.Text =
                "CURRENCY";

            this.cmbCurrency.BorderRadius =
                10;

            this.cmbCurrency.FillColor =
                Color.FromArgb(34, 42, 38);

            this.cmbCurrency.ForeColor =
                Color.White;

            this.cmbCurrency.Location =
                new Point(35, 170);

            this.cmbCurrency.Size =
                new Size(300, 40);

            this.cmbCurrency.Items.AddRange(
                new object[]
                {
                    "USD ($)",
                    "EUR (€)",
                    "GBP (£)"
                });

            this.cmbCurrency.DropDownStyle =
                ComboBoxStyle.DropDownList;

            this.cmbCurrency.SelectedIndex =
                0;

            // =========================
            // THEME
            // =========================

            this.lblTheme.AutoSize =
                true;

            this.lblTheme.Font =
                new Font(
                    "Segoe UI Semibold",
                    10F);

            this.lblTheme.ForeColor =
                Color.FromArgb(205, 210, 207);

            this.lblTheme.Location =
                new Point(400, 140);

            this.lblTheme.Text =
                "THEME";

            this.cmbTheme.BorderRadius =
                10;

            this.cmbTheme.FillColor =
                Color.FromArgb(34, 42, 38);

            this.cmbTheme.ForeColor =
                Color.White;

            this.cmbTheme.Location =
                new Point(400, 170);

            this.cmbTheme.Size =
                new Size(300, 40);

            this.cmbTheme.Items.AddRange(
                new object[]
                {
                    "Dark",
                    "Light"
                });

            this.cmbTheme.DropDownStyle =
                ComboBoxStyle.DropDownList;
 this.cmbTheme.SelectedIndex =
                0;

            // =========================
            // NOTIFICATIONS
            // =========================

            this.lblNotifications.AutoSize =
                true;

            this.lblNotifications.Font =
                new Font(
                    "Segoe UI Semibold",
                    10F);

            this.lblNotifications.ForeColor =
                Color.FromArgb(205, 210, 207);

            this.lblNotifications.Location =
                new Point(35, 260);

            this.lblNotifications.Text =
                "NOTIFICATIONS";

            this.toggleNotifications.Checked =
                true;

            this.toggleNotifications.Location =
                new Point(35, 295);

            this.toggleNotifications.Size =
                new Size(50, 25);

            // =========================
            // SAVE BUTTON
            // =========================

            this.btnSave.BorderRadius =
                10;

            this.btnSave.FillColor =
                Color.FromArgb(198, 164, 74);

            this.btnSave.ForeColor =
                Color.FromArgb(20, 20, 18);

            this.btnSave.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnSave.Location =
                new Point(35, 390);

            this.btnSave.Size =
                new Size(150, 45);

            this.btnSave.Text =
                "SAVE";

            // =========================
            // RESET BUTTON
            // =========================

            this.btnReset.BorderRadius =
                10;

            this.btnReset.FillColor =
                Color.FromArgb(55, 65, 58);

            this.btnReset.ForeColor =
                Color.White;

            this.btnReset.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.btnReset.Location =
                new Point(200, 390);

            this.btnReset.Size =
                new Size(150, 45);

            this.btnReset.Text =
                "RESET";

            // =========================
            // ADD CONTROLS
            // =========================

            this.settingsPanel.Controls.Add(
                this.lblRestaurant);

            this.settingsPanel.Controls.Add(
                this.lblRestaurantValue);

            this.settingsPanel.Controls.Add(
                this.lblCurrency);

            this.settingsPanel.Controls.Add(
                this.cmbCurrency);

            this.settingsPanel.Controls.Add(
                this.lblTheme);

            this.settingsPanel.Controls.Add(
                this.cmbTheme);

            this.settingsPanel.Controls.Add(
                this.lblNotifications);

            this.settingsPanel.Controls.Add(
                this.toggleNotifications);

            this.settingsPanel.Controls.Add(
                this.btnSave);

            this.settingsPanel.Controls.Add(
                this.btnReset);

            // =========================
            // FORM CONTROLS
            // =========================

            this.Controls.Add(
                this.headerPanel);

            this.Controls.Add(
                this.settingsPanel);

            this.ResumeLayout(false);
        }
    }
}
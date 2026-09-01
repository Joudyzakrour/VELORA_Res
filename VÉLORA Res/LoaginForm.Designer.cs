 using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel loginPanel;

        private Label lblLogo;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblUsername;
        private Label lblPassword;

        private Guna2TextBox txtUsername;
        private Guna2TextBox txtPassword;

        private Guna2Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components =
                new System.ComponentModel.Container();

            this.loginPanel =
                new Guna2Panel();

            this.lblLogo =
                new Label();

            this.lblTitle =
                new Label();

            this.lblSubtitle =
                new Label();

            this.lblUsername =
                new Label();

            this.lblPassword =
                new Label();

            this.txtUsername =
                new Guna2TextBox();

            this.txtPassword =
                new Guna2TextBox();

            this.btnLogin =
                new Guna2Button();

            // =========================
            // FORM
            // =========================

            this.AutoScaleDimensions =
                new SizeF(7F, 15F);

            this.AutoScaleMode =
                AutoScaleMode.Font;

            this.BackColor =
                Color.FromArgb(10, 14, 12);

            this.ClientSize =
                new Size(900, 560);

            this.FormBorderStyle =
                FormBorderStyle.None;

            this.StartPosition =
                FormStartPosition.CenterScreen;

            this.Name =
                "LoginForm";

            this.Text =
                "VÉLORA RES - Login";

            // =========================
            // LOGIN PANEL
            // =========================

            this.loginPanel.BorderRadius =
                25;

            this.loginPanel.FillColor =
                Color.FromArgb(25, 32, 29);

            this.loginPanel.Location =
                new Point(250, 65);

            this.loginPanel.Size =
                new Size(400, 430);

            // =========================
            // LOGO
            // =========================

            this.lblLogo.AutoSize =
                true;

            this.lblLogo.Font =
                new Font(
                    "Segoe UI Semibold",
                    26F);

            this.lblLogo.ForeColor =
                Color.FromArgb(225, 190, 95);

            this.lblLogo.Location =
                new Point(145, 30);

            this.lblLogo.Text =
                "VÉLORA";

            // =========================
            // TITLE
            // =========================

            this.lblTitle.AutoSize =
                true;

            this.lblTitle.Font =
                new Font(
                    "Segoe UI Semibold",
                    18F);

            this.lblTitle.ForeColor =
                Color.White;

            this.lblTitle.Location =
                new Point(120, 85);

            this.lblTitle.Text =
                "Welcome Back";

            // =========================
            // SUBTITLE
            // =========================

            this.lblSubtitle.AutoSize =
                true;

            this.lblSubtitle.Font =
                new Font(
                    "Segoe UI",
                    9F);

            this.lblSubtitle.ForeColor =
                Color.FromArgb(
                    160,
                    170,
                    165);

            this.lblSubtitle.Location =
                new Point(95, 120);
this.lblSubtitle.Text =
                "Sign in to VÉLORA Restaurant";

            // =========================
            // USERNAME
            // =========================

            this.lblUsername.AutoSize =
                true;

            this.lblUsername.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblUsername.ForeColor =
                Color.White;

            this.lblUsername.Location =
                new Point(45, 165);

            this.lblUsername.Text =
                "USERNAME";

            this.txtUsername.BorderRadius =
                10;

            this.txtUsername.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtUsername.ForeColor =
                Color.White;

            this.txtUsername.PlaceholderText =
                "Enter username";

            this.txtUsername.Location =
                new Point(45, 192);

            this.txtUsername.Size =
                new Size(310, 42);

            // =========================
            // PASSWORD
            // =========================

            this.lblPassword.AutoSize =
                true;

            this.lblPassword.Font =
                new Font(
                    "Segoe UI Semibold",
                    9F);

            this.lblPassword.ForeColor =
                Color.White;

            this.lblPassword.Location =
                new Point(45, 250);

            this.lblPassword.Text =
                "PASSWORD";

            this.txtPassword.BorderRadius =
                10;

            this.txtPassword.FillColor =
                Color.FromArgb(34, 42, 38);

            this.txtPassword.ForeColor =
                Color.White;

            this.txtPassword.PlaceholderText =
                "Enter password";

            this.txtPassword.Location =
                new Point(45, 277);

            this.txtPassword.Size =
                new Size(310, 42);

            this.txtPassword.PasswordChar =
                '●';

            // =========================
            // LOGIN BUTTON
            // =========================

            this.btnLogin.BorderRadius =
                10;

            this.btnLogin.FillColor =
                Color.FromArgb(
                    198,
                    164,
                    74);

            this.btnLogin.ForeColor =
                Color.FromArgb(
                    20,
                    20,
                    18);

            this.btnLogin.Font =
                new Font(
                    "Segoe UI Semibold",
                    10F);

            this.btnLogin.Location =
                new Point(45, 350);

            this.btnLogin.Size =
                new Size(310, 45);

            this.btnLogin.Text =
                "SIGN IN";

            // =========================
            // ADD CONTROLS
            // =========================

            this.loginPanel.Controls.Add(
                this.lblLogo);

            this.loginPanel.Controls.Add(
                this.lblTitle);

            this.loginPanel.Controls.Add(
                this.lblSubtitle);

            this.loginPanel.Controls.Add(
                this.lblUsername);

            this.loginPanel.Controls.Add(
                this.txtUsername);

            this.loginPanel.Controls.Add(
                this.lblPassword);

            this.loginPanel.Controls.Add(
                this.txtPassword);

            this.loginPanel.Controls.Add(
                this.btnLogin);

            this.Controls.Add(
                this.loginPanel);

            this.ResumeLayout(false);
        }
    }
}
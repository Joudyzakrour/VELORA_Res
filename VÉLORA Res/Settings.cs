using System;
using System.Windows.Forms;
using VÉLORA_Res.Services;

namespace VÉLORA_Res
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();

            ConfigureEvents();
            LoadSettings();
        }

        private void ConfigureEvents()
        {
            btnSave.Click += btnSave_Click;
            btnReset.Click += btnReset_Click;
        }

        private void LoadSettings()
        {
            cmbCurrency.SelectedIndex = 0;
            cmbTheme.SelectedIndex = 0;
            toggleNotifications.Checked = true;

            ApplySelectedTheme();
        }

        private void ApplySelectedTheme()
        {
            bool lightTheme =
                cmbTheme.SelectedItem?.ToString() == "Light";

            ThemeManager.ApplyTheme(
                this,
                lightTheme);

            ApplySettingsSpecificTheme(
                lightTheme);
        }

        private void ApplySettingsSpecificTheme(
            bool lightTheme)
        {
            if (lightTheme)
            {
                this.BackColor =
                    System.Drawing.Color.FromArgb(
                        245, 247, 245);

                settingsPanel.FillColor =
                    System.Drawing.Color.White;

                lblTitle.ForeColor =
                    System.Drawing.Color.FromArgb(
                        35, 40, 37);

                lblSubtitle.ForeColor =
                    System.Drawing.Color.FromArgb(
                        90, 100, 94);
            }
            else
            {
                this.BackColor =
                    System.Drawing.Color.FromArgb(
                        15, 20, 18);

                settingsPanel.FillColor =
                    System.Drawing.Color.FromArgb(
                        25, 32, 29);

                lblTitle.ForeColor =
                    System.Drawing.Color.FromArgb(
                        225, 190, 95);

                lblSubtitle.ForeColor =
                    System.Drawing.Color.FromArgb(
                        160, 170, 165);
            }
        }

        private void btnSave_Click(
            object? sender,
            EventArgs e)
        {
            ApplySelectedTheme();

            MessageBox.Show(
                "Settings saved successfully.",
                "VÉLORA RES",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnReset_Click(
            object? sender,
            EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Reset all settings to default?",
                    "VÉLORA RES",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            cmbCurrency.SelectedIndex = 0;
            cmbTheme.SelectedIndex = 0;
            toggleNotifications.Checked = true;

            ApplySelectedTheme();

            MessageBox.Show(
                "Settings reset successfully.",
                "VÉLORA RES",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
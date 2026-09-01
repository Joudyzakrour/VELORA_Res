 using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace VÉLORA_Res.Services
{
    public static class ThemeManager
    {
        public static bool IsLightTheme { get; private set; }

        public static void ApplyTheme(
            Control root,
            bool lightTheme)
        {
            IsLightTheme = lightTheme;

            Color backgroundColor;
            Color panelColor;
            Color inputColor;
            Color textColor;

            if (lightTheme)
            {
                backgroundColor =
                    Color.FromArgb(245, 247, 245);

                panelColor =
                    Color.White;

                inputColor =
                    Color.FromArgb(238, 241, 239);

                textColor =
                    Color.FromArgb(35, 40, 37);
            }
            else
            {
                backgroundColor =
                    Color.FromArgb(15, 20, 18);

                panelColor =
                    Color.FromArgb(25, 32, 29);

                inputColor =
                    Color.FromArgb(34, 42, 38);

                textColor =
                    Color.White;
            }

            ApplyToControl(
                root,
                lightTheme,
                backgroundColor,
                panelColor,
                inputColor,
                textColor);
        }

        private static void ApplyToControl(
            Control control,
            bool lightTheme,
            Color backgroundColor,
            Color panelColor,
            Color inputColor,
            Color textColor)
        {
            if (control is Form)
            {
                control.BackColor =
                    backgroundColor;
            }

            if (control is Guna2Panel gunaPanel)
            {
                gunaPanel.FillColor =
                    panelColor;
            }

            if (control is Label label)
            {
                if (label.Name == "lblTitle" ||
                    label.Name == "lblSalesTitle" ||
                    label.Name == "lblBestSellerTitle" ||
                    label.Name == "lblSalesDateTitle")
                {
                    label.ForeColor =
                        Color.FromArgb(225, 190, 95);
                }
                else
                {
                    label.ForeColor =
                        textColor;
                }
            }

            if (control is Guna2TextBox textBox)
            {
                textBox.FillColor =
                    inputColor;

                textBox.ForeColor =
                    textColor;
            }

            if (control is Guna2ComboBox comboBox)
            {
                comboBox.FillColor =
                    inputColor;

                comboBox.ForeColor =
                    textColor;
            }

            if (control is Guna2ToggleSwitch toggle)
            {
                toggle.CheckedState.FillColor =
                    Color.FromArgb(225, 190, 95);
            }

            if (control is DataGridView grid)
            {
                grid.BackgroundColor =
                    panelColor;

                grid.DefaultCellStyle.BackColor =
                    panelColor;

                grid.DefaultCellStyle.ForeColor =
                    textColor;

                grid.DefaultCellStyle.SelectionBackColor =
                    lightTheme
                        ? Color.FromArgb(220, 225, 222)
                        : Color.FromArgb(55, 65, 58);

                grid.DefaultCellStyle.SelectionForeColor =
                    textColor;

                grid.ColumnHeadersDefaultCellStyle.BackColor =
                    inputColor;

                grid.ColumnHeadersDefaultCellStyle.ForeColor =
                    Color.FromArgb(225, 190, 95);
            }
 foreach (Control child in control.Controls)
            {
                ApplyToControl(
                    child,
                    lightTheme,
                    backgroundColor,
                    panelColor,
                    inputColor,
                    textColor);
            }
        }
    }
}
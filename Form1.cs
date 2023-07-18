using System;
using System.IO;
using IWshRuntimeLibrary;

namespace Crosshair
{
    public partial class CrosshairConfig : Form
    {
        public CrosshairConfig()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            OverlayForm ch = new OverlayForm(decimal.ToInt32(sizeVal.Value),
                decimal.ToInt32(xOffsetVal.Value), decimal.ToInt32(yOffsetVal.Value),
                decimal.ToInt32(rVal.Value), decimal.ToInt32(gVal.Value),
                decimal.ToInt32(bVal.Value), decimal.ToInt32(aVal.Value));
            ch.Closed += (s, args) => this.Close();
            ch.Show();
        }

        private void shortcutButton_Click(object sender, EventArgs e)
        {
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/Crosshair.exe"; // Get the current executable file path

            string shortcutLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Crosshair.lnk");

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            shortcut.TargetPath = filePath;
            shortcut.WorkingDirectory = Path.GetDirectoryName(filePath);
            shortcut.Arguments =
                decimal.ToInt32(sizeVal.Value).ToString() + " " +
                decimal.ToInt32(xOffsetVal.Value).ToString() + " " +
                decimal.ToInt32(yOffsetVal.Value).ToString() + " " +
                decimal.ToInt32(rVal.Value).ToString() + " " +
                decimal.ToInt32(gVal.Value).ToString() + " " +
                decimal.ToInt32(bVal.Value).ToString() + " " +
                decimal.ToInt32(aVal.Value).ToString();
            shortcut.Save();

            shortcutConfirm.Show();
        }
    }
}
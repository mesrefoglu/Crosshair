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
            Overlay ch = new Overlay(decimal.ToInt32(sizeVal.Value),
                decimal.ToInt32(xOffsetVal.Value), decimal.ToInt32(yOffsetVal.Value),
                decimal.ToInt32(rVal.Value), decimal.ToInt32(gVal.Value),
                decimal.ToInt32(bVal.Value), decimal.ToInt32(aVal.Value),
                hideInRecording.Checked);
            ch.Show();
        }

        private void shortcutButton_Click(object sender, EventArgs e)
        {
            // Get the current executable file path
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "/Crosshair.exe";

            // Get the desktop file path (and name)
            string shortcutLocation = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Crosshair.lnk");

            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);
            
            // Create the actual shortcut with given parameters
            shortcut.TargetPath = filePath;
            shortcut.WorkingDirectory = Path.GetDirectoryName(filePath);
            shortcut.Arguments =
                decimal.ToInt32(sizeVal.Value).ToString() + " " +
                decimal.ToInt32(xOffsetVal.Value).ToString() + " " +
                decimal.ToInt32(yOffsetVal.Value).ToString() + " " +
                decimal.ToInt32(rVal.Value).ToString() + " " +
                decimal.ToInt32(gVal.Value).ToString() + " " +
                decimal.ToInt32(bVal.Value).ToString() + " " +
                decimal.ToInt32(aVal.Value).ToString() + " " +
                hideInRecording.Checked.ToString();
            shortcut.Save();

            // Show confirmation text on the form
            shortcutConfirm.Show();
        }
    }
}
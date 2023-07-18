namespace Crosshair
{
    public partial class OverlayForm : Form
    {
        private int crosshairSize = 40;
        private NotifyIcon notifyIcon = new();

        private int xOffset = 0;
        private int yOffset = 0;

        private Color color;

        public OverlayForm(int size, int x, int y, int r, int g, int b, int a)
        {
            InitializeComponent();
            crosshairSize = size * 8;
            xOffset = x;
            yOffset = y;
            color = new Color();
            color = Color.FromArgb(a, r, g, b);
            InitializeOverlay();
        }

        private void InitializeOverlay()
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ShowInTaskbar = false;
            TransparencyKey = BackColor;

            notifyIcon.Icon = Icon;
            notifyIcon.Visible = true;
            notifyIcon.ContextMenuStrip = new ContextMenuStrip();
            notifyIcon.ContextMenuStrip.Items.Add("Exit", null, ExitApplication);

            notifyIcon.MouseClick += NotifyIcon_MouseClick;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80; // WS_EX_TOOLWINDOW
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a graphics object to draw on the form
            Graphics g = e.Graphics;

            // Set the properties for drawing the crosshair
            Pen pen2 = new(color, 2)
            {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Center
            };
            // Set the properties for drawing the crosshair
            Pen pen4 = new(color, 4)
            {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Center
            };

            // Calculate the position of the crosshair
            int centerX = (Width - crosshairSize) / 2 + xOffset;
            int centerY = (Height - crosshairSize) / 2 + yOffset;

            // Draw the horizontal line of the crosshair
            g.DrawLine(pen2, centerX, centerY + (crosshairSize / 2), centerX + (crosshairSize * 3 / 8), centerY + (crosshairSize / 2));
            g.DrawLine(pen2, centerX + (crosshairSize * 5 / 8), centerY + (crosshairSize / 2), centerX + crosshairSize, centerY + (crosshairSize / 2));

            // Draw the vertical line of the crosshair
            g.DrawLine(pen2, centerX + (crosshairSize / 2), centerY, centerX + (crosshairSize / 2), centerY + crosshairSize * 3 / 8);
            g.DrawLine(pen2, centerX + (crosshairSize / 2), centerY + crosshairSize * 5 / 8, centerX + (crosshairSize / 2), centerY + crosshairSize);

            // Draw the horizontal line of the crosshair
            g.DrawLine(pen4, centerX + 1, centerY + (crosshairSize / 2), centerX + (crosshairSize * 3 / 8) - 1, centerY + (crosshairSize / 2));
            g.DrawLine(pen4, centerX + (crosshairSize * 5 / 8) + 1, centerY + (crosshairSize / 2), centerX + crosshairSize - 1, centerY + (crosshairSize / 2));

            // Draw the vertical line of the crosshair
            g.DrawLine(pen4, centerX + (crosshairSize / 2), centerY + 1, centerX + (crosshairSize / 2), centerY + crosshairSize * 3 / 8 - 1);
            g.DrawLine(pen4, centerX + (crosshairSize / 2), centerY + crosshairSize * 5 / 8 + 1, centerX + (crosshairSize / 2), centerY + crosshairSize - 1);
        }
        private void NotifyIcon_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    WindowState = FormWindowState.Normal;
                    Activate();
                }
                else
                {
                    WindowState = FormWindowState.Minimized;
                }
            }
        }

        private void ExitApplication(object? sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Close();
        }
    }
}
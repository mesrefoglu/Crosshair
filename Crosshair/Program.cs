using System.Drawing;

namespace Crosshair
{
    internal static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            if (args.Length >= 8)
            {
                int size = int.Parse(args[0]);
                int x = int.Parse(args[1]);
                int y = int.Parse(args[2]);
                int r = int.Parse(args[3]);
                int g = int.Parse(args[4]);
                int b = int.Parse(args[5]);
                int a = int.Parse(args[6]);
                bool h = Convert.ToBoolean(args[7]);
                Application.Run(new Overlay(size, x, y, r, g, b, a, h));
            }
            else
                Application.Run(new CrosshairConfig());
        }
    }
}
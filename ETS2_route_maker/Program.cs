using System;
using System.Windows.Forms;

namespace ETS2_route_maker
{
    internal static class Program
    {
        [System.STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Views;

namespace Parking_Management_V3
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Heart heart = new Heart();
            if (Environment.OSVersion.Version.Major == 6)
                SetProcessDPIAware();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            if (!heart.IsFirstTime())
                Application.Run(new SignForm());
            else
                Application.Run(new FirstTimeForm());
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}

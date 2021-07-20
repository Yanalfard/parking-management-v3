using System;
using System.Windows.Forms;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class PrinterSettings : DevExpress.XtraEditors.XtraForm
    {
        public TblAgent Agent;

        public PrinterSettings()
        {
            InitializeComponent();
        }

        private void PrinterSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingMenu a = new SettingMenu { Agent = Agent };
                a.Show();
                Hide();
            }
        }

        private void PrinterSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void PrinterSettings_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
            PrintStatusToggle.IsOn = heart.FetchPrintStatus();
        }

        private void PrintStatusToggle_Toggled(object sender, EventArgs e)
        {
            new Heart().ChangePrintStatus(PrintStatusToggle.IsOn);
        }
    }
}
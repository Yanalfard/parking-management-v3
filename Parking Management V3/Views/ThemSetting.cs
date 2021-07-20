using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class ThemSetting : XtraForm
    {
        public TblAgent Agent;
        public ThemSetting()
        {
            InitializeComponent();
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            if (!heart.UpdateThem(comboBoxEdit1.SelectedText))
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            else
                LookAndFeel.SkinName = comboBoxEdit1.SelectedText;
        }

        private void ThemSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ThemSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingMenu a = new SettingMenu { Agent = Agent };
                a.Show();
                Hide();
            }
        }

        private void ThemSetting_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }
    }
}
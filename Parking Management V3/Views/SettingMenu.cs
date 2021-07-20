using System;
using System.Windows.Forms;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class SettingMenu : DevExpress.XtraEditors.XtraForm
    {
        public TblAgent Agent;
        public SettingMenu()
        {
            InitializeComponent();
        }

        private void BtnFloor_Click(object sender, EventArgs e)
        {
            FloorSetting form = new FloorSetting { Agent = Agent };
            form.Show();
            Hide();
        }

        private void BtnSpot_Click(object sender, EventArgs e)
        {
            SpotSetting form = new SpotSetting { Agent = Agent };
            form.Show();
            Hide();
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            RestorSetting form = new RestorSetting { Agent = Agent };
            form.Show();
            Hide();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            ThemSetting form = new ThemSetting { Agent = Agent };
            form.Show();
            Hide();
        }

        private void SettingMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SettingMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainAppMenu form = new MainAppMenu {Agent = Agent};
                form.Show();
                Hide();
            }
        }

        private void SettingMenu_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void BtnPolicy_Click(object sender, EventArgs e)
        {
            PricingPolicyForm form = new PricingPolicyForm { Agent = Agent };
            form.Show();
            Hide();
        }

        private void BtnCheckForUpdate_Click(object sender, EventArgs e)
        {
            CheckForUpdateForm form = new CheckForUpdateForm { Agent = Agent };
            form.Show();
            Hide();
        }
    }
}
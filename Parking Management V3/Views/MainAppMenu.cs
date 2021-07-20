using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class MainAppMenu : XtraForm
    {
        public TblAgent Agent;
        public MainAppMenu()
        {
            InitializeComponent();
        }

        private void MainAppMenu_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
            try
            {
                LblId.Text = @" کد ملی  : " + Agent.Identification;
                LblName.Text = @" نام : " + Agent.FirstName + @" " + Agent.LastName;
                try
                {
                    ImgAgentImage.Image = Image.FromFile(Agent.ImageSrc);
                }
                catch
                {
                    // ignored
                }
            }
            catch
            {
                // ignored
            }
        }

        private void MainAppMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm a = new MainForm
                {
                    Me = Agent,
                    LblAgentName = { Text = Agent.FirstName + " " + Agent.LastName },
                };
                a.Show();
                Hide();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnAgentControl_Click(object sender, EventArgs e)
        {
            try
            {
                AgentControlForm a = new AgentControlForm { Agent = Agent };
                a.Show();
                Hide();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnConsole_Click(object sender, EventArgs e)
        {
            try
            {
                CostomerVehicleControlForm a = new CostomerVehicleControlForm { Agent = Agent };
                a.Show();
                Hide();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            try
            {
                SettingCondfirmation a = new SettingCondfirmation() { Agent = Agent };
                a.Show();
                Hide();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void MainAppMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SignForm a = new SignForm();
                a.Show(); Hide();
            }
        }

        private void BtnVip_Click(object sender, EventArgs e)
        {
            try
            {
                VipControlForm a = new VipControlForm() { Agent = Agent };
                a.Show();
                Hide();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnFund_Click(object sender, EventArgs e)
        {
            try
            {
                FundControllForm a = new FundControllForm() { Agent = Agent };
                a.Show();
                Hide();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
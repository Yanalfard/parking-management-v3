using System;
using System.Windows.Forms;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class SettingCondfirmation : DevExpress.XtraEditors.XtraForm
    {
        public TblAgent Agent;
        public SettingCondfirmation()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Err.ClearErrors();
            if (TxtPassword.Text == "")
            {
                Err.SetError(TxtPassword, "فیلد موردنظر خالی است");
                TxtPassword.Focus();
            }
            else if (TxtPassword.Text.Length > 16)
            {
                Err.SetError(TxtPassword, "تعداد کاراکتر های رمز عبور بزرگ تر از 16 است");
                TxtPassword.Focus();
            }
            else if (TxtPassword.Text == Agent.Password)
            {
                SettingMenu a = new SettingMenu { Agent = Agent };
                a.Show();
                Hide();
            }
            else
            {
                Err.SetError(TxtPassword, "داده ی اشتباه وارد شده است");
                TxtPassword.Focus();
            }
        }

        private void SettingCondfirmation_Load(object sender, EventArgs e)
        {
            TxtUsername.Text = Agent.Username;
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void SettingCondfirmation_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SettingCondfirmation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainAppMenu a = new MainAppMenu { Agent = Agent };
                a.Show();
                Hide();
            }
        }
    }
}
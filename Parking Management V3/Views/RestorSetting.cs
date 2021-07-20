using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class RestorSetting : XtraForm
    {
        public TblAgent Agent;
        public RestorSetting()
        {
            InitializeComponent();
        }

        private void RestorSetting_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به بازنشانی طبقات و جاهای پارک هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    Heart heart = new Heart();
                    heart.ResetFloorsAndSpots();
                }

            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به بازنشانی پایگاه داده هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    Heart heart = new Heart();
                    heart.ResetTblAgent();
                    heart.ResetTblCostomerVehicle();

                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به بازنشانی پایگاه داده های کاربران هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    Heart heart = new Heart();
                    heart.ResetTblAgent();
                }

            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به بازنشانی پایگاه داده های خودرو و مشتری هستید؟", "هشدار", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    Heart heart = new Heart();
                    heart.ResetTblCostomerVehicle();
                }

            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void RestorSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RestorSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingMenu @from = new SettingMenu { Agent = Agent };
                @from.Show();
                Hide();
            }
        }

        private void BtnBackUp_Click(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                Saver.Filter = "backup file | *.bak";
                if (Saver.ShowDialog() == DialogResult.OK)
                    if (!heart.BackupDb(Saver.FileName))
                        XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("با این کار اطلاعات قبلی ثبت شده ی شما پاک خواهد شد؟", "هشدار",
                        MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    Heart heart = new Heart();
                    Saver.Filter = "backup file | *.bak";
                    if (Saver.ShowDialog() == DialogResult.OK)
                        if (!heart.RestoreDb(Saver.FileName))
                            XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده است لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
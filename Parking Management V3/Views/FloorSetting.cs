using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class FloorSetting : XtraForm
    {
        public TblAgent Agent;
        public FloorSetting()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            Heart heart = new Heart();
            int floorCount = heart.FetchFloorCount();
            NumAddFlr.Properties.MaxValue = 9 - floorCount;
            NumDeleteFlr.Properties.MaxValue = floorCount - 1;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به اضافه کردن طبقه هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Heart heart = new Heart();
                    for (int i = 0; i < NumAddFlr.Value; i++)
                    {
                        heart.AddFloor();
                    }
                    Calculate();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد هی مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به کم کردن طبقه هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Heart heart = new Heart();
                    for (int i = 0; i < NumDeleteFlr.Value; i++)
                    {
                        heart.DeleteFloor();
                    }
                    Calculate();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد هی مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void FloorSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FloorSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingMenu a = new SettingMenu { Agent = Agent };
                a.Show();
                Hide();
            }
        }

        private void FloorSetting_Load(object sender, EventArgs e)
        {
            Calculate();
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }
    }
}
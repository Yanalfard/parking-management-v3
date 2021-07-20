using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class SpotSetting : XtraForm
    {
        //--1000%---9
        //--500%---8
        //--300%---7
        //--250%---6
        //--180%---5
        //--160%---4
        //--140%---3
        //--120%---2
        //--110%---1
        //============
        //--90%--+1
        //--85%--+2
        //--80%--+3
        //--70%--+4
        //--67%--+5
        //--65%--+6
        //--60%--+7
        //--57%--+8
        //--54%--+9
        //--51%--+10
        //--48%--+11
        //--45%--+12
        //--43%--+13
        //--42%--+14
        //--40%--+15
        //--39%--+16
        //--37%--+17
        //--36%--+18
        //--35%--+19
        //--34%--+20
        private int _spotCount;
        private int[] _ratios =
         {
             1000, 500, 300, 250, 180, 160, 140, 120, 110,
            100, 90, 85, 80, 70, 67, 65, 60, 57, 54, 51,
            48, 45, 43, 42, 40, 39, 37, 36, 35, 34
         };
        public TblAgent Agent;
        public SpotSetting()
        {
            InitializeComponent();
        }
        private void Calculate()
        {
            Heart heart = new Heart();
            int floorCount = heart.FetchFloorCount();
            NumWichFlr.Properties.MaxValue = floorCount - 1;
            if (NumWichFlr.Properties.MaxValue == 0)
                NumWichFlr.Enabled = false;
        }

        private void Calculate(int flr)
        {
            Heart heart = new Heart();
            int floorCount = heart.FetchFloorCount();
            NumWichFlr.Properties.MaxValue = floorCount - 1;
            _spotCount = heart.FetchSpots(flr).Count;
            NumAddSpt.Properties.MaxValue = 80 - _spotCount;
            NumDeleteSpt.Properties.MaxValue = _spotCount;
        }
        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به اضافه کردن جای پارک هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    Heart heart = new Heart();
                    for (int i = 0; i < NumAddSpt.Value; i++)
                    {
                        heart.AddSpot(Convert.ToInt32(NumWichFlr.Value));
                    }
                    Calculate();
                    Calculate(Convert.ToInt32(NumWichFlr.Value));
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد هی مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به کم کردن جای پارک هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)

                {
                    Heart heart = new Heart();
                    for (int i = 0; i < NumDeleteSpt.Value; i++)
                    {
                        heart.DeleteSpot(Convert.ToInt32(NumWichFlr.Value));
                    }
                    Calculate();
                    Calculate(Convert.ToInt32(NumWichFlr.Value));
                }

            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد هی مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void SpotSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SpotSetting_Load(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
                int ratio = heart.FetchColumnRatio();
                switch (ratio)
                {
                    case 1000:
                        TrackBarColumnCount.Value = 1;
                        break;
                    case 500:
                        TrackBarColumnCount.Value = 2;
                        break;
                    case 300:
                        TrackBarColumnCount.Value = 3;
                        break;
                    case 250:
                        TrackBarColumnCount.Value = 4;
                        break;
                    case 180:
                        TrackBarColumnCount.Value = 5;
                        break;
                    case 160:
                        TrackBarColumnCount.Value = 6;
                        break;
                    case 140:
                        TrackBarColumnCount.Value = 7;
                        break;
                    case 120:
                        TrackBarColumnCount.Value = 8;
                        break;
                    case 110:
                        TrackBarColumnCount.Value = 9;
                        break;
                    case 100:
                        TrackBarColumnCount.Value = 10;
                        break;
                    case 90:
                        TrackBarColumnCount.Value = 11;
                        break;
                    case 85:
                        TrackBarColumnCount.Value = 12;
                        break;
                    case 80:
                        TrackBarColumnCount.Value = 13;
                        break;
                    case 70:
                        TrackBarColumnCount.Value = 14;
                        break;
                    case 67:
                        TrackBarColumnCount.Value = 15;
                        break;
                    case 65:
                        TrackBarColumnCount.Value = 16;
                        break;
                    case 60:
                        TrackBarColumnCount.Value = 17;
                        break;
                    case 57:
                        TrackBarColumnCount.Value = 18;
                        break;
                    case 54:
                        TrackBarColumnCount.Value = 19;
                        break;
                    case 51:
                        TrackBarColumnCount.Value = 20;
                        break;
                    case 48:
                        TrackBarColumnCount.Value = 21;
                        break;
                    case 45:
                        TrackBarColumnCount.Value = 22;
                        break;
                    case 43:
                        TrackBarColumnCount.Value = 23;
                        break;
                    case 42:
                        TrackBarColumnCount.Value = 24;
                        break;
                    case 40:
                        TrackBarColumnCount.Value = 25;
                        break;
                    case 39:
                        TrackBarColumnCount.Value = 26;
                        break;
                    case 37:
                        TrackBarColumnCount.Value = 27;
                        break;
                    case 36:
                        TrackBarColumnCount.Value = 28;
                        break;
                    case 35:
                        TrackBarColumnCount.Value = 29;
                        break;
                    case 34:
                        TrackBarColumnCount.Value = 30;
                        break;
                }
                Calculate();
                Calculate(Convert.ToInt32(NumWichFlr.Value));
                LblSpots.Text = _spotCount.ToString();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد هی مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void SpotSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingMenu form = new SettingMenu { Agent = Agent };
                form.Show();
                Hide();
            }
        }

        private void TrackBarColumnCount_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                heart.UpdateColumnRatio(_ratios[TrackBarColumnCount.Value - 1]);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد هی مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void NumWichFlr_ValueChanged(object sender, EventArgs e)
        {
            Calculate(Convert.ToInt32(NumWichFlr.Value));
            LblSpots.Text = _spotCount.ToString();
        }
    }
}
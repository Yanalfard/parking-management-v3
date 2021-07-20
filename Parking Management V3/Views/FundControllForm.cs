using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class FundControllForm : XtraForm
    {
        public TblAgent Agent;
        public FundControllForm()
        {
            InitializeComponent();
        }

        private void FundControllForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    MainAppMenu form = new MainAppMenu { Agent = Agent };
                    form.Show();
                    Hide();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void FundControllForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FundControllForm_Load(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
            }
            catch
            {
                // ignored
            }
        }

        private void BtnCalcNorm_Click(object sender, EventArgs e)
        {
            try
            {
                List<TblCostomerVehicle> costomerVehicles = new Heart().FetchTimedCostomerVehicles(TimeFromNorm.Time, TimeToNorm.Time);
                if (costomerVehicles.Count == 0)
                    XtraMessageBox.Show("چنین داده ای در جدول ثبت نشده", "اخطار");
                else
                {
                    FundCalcForm form = new FundCalcForm
                    {
                        Agent = Agent,
                        CostomerVehicle = costomerVehicles.ToArray()
                    };
                    form.Show();
                    Hide();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnTodaysFund_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime nowDate = DateTime.Now;
                DateTime dayBegins = DateTime.Parse(DateTime.Now.Date.ToShortDateString() + " 12:00:00 PM");
                DateTime dayForSub = dayBegins;
                DateTime[] daysOfChart = new DateTime[10];
                double[] moneyDays = new double[10];
                double sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    List<TblCostomerVehicle> listForSum = new Heart().FetchTimedCostomerVehicles(dayForSub, dayForSub.AddDays(1));
                    foreach (TblCostomerVehicle costomerVehicle in listForSum)
                        sum += costomerVehicle.Price;
                    moneyDays[i] = sum;
                    sum = 0;
                    listForSum.Clear();
                    daysOfChart[i] = dayForSub;
                    dayForSub = dayForSub.Subtract(new TimeSpan(1, 0, 0, 0));
                }
                List<TblCostomerVehicle> costomerVehicles = new Heart().FetchTimedCostomerVehicles(dayBegins, nowDate);
                FundCalcForm form = new FundCalcForm
                {
                    IsAiInclouded = true,
                    Agent = Agent,
                    MoneyDays = moneyDays,
                    DaysOfChart = daysOfChart
                };
                if (costomerVehicles.ToArray().Length != 0)
                    form.CostomerVehicle = costomerVehicles.ToArray();
                form.Show();
                Hide();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnVipShow_Click(object sender, EventArgs e)
        {
            try
            {
                List<TblVip> vips = new Heart().FetchCurrentVips();
                if (vips.Count == 0)
                    XtraMessageBox.Show("در حال حاضر هیچ فرد ویژه ای وجود ندارد", "اخطار");
                else
                {
                    FundCalcVipForm form = new FundCalcVipForm { Agent = Agent };
                    form.Vips = vips.ToArray();
                    form.Show();
                    Hide();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnCalcVip_Click(object sender, EventArgs e)
        {
            try
            {
                List<TblVip> vips = new Heart().FetchTimedVips(TimeFromVip.Time, TimeToVip.Time);
                if (vips.Count == 0)
                    XtraMessageBox.Show("چنین داده ای در جدول ثبت نشده", "اخطار");
                else
                {
                    FundCalcVipForm form = new FundCalcVipForm { Agent = Agent };
                    form.Vips = vips.ToArray();
                    form.Show();
                    Hide();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
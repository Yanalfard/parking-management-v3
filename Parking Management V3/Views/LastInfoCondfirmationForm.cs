using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class LastInfoCondfirmationForm : XtraForm
    {
        public TblCostomerVehicle Man;
        public bool IsPrinterEnable;

        public LastInfoCondfirmationForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (CmbPrices.SelectedIndex < 0)
                {
                    Err.SetError(CmbPrices, "تعرفه ی انتخابی قابل قبول نیست لطفا یکی از موارد لیست را انتخاب کنید");
                    CmbPrices.Focus();
                }
                else
                {
                    Man.Price = long.Parse(CmbPrices.SelectedItem.ToString().Split('-')[1]);
                    Heart heart = new Heart();
                    heart.EditCostomerVehicle(Man, Man);
                    bool k = heart.ExitSpot(Man.Floor, Man.Id);
                    if (k)
                    {
                        long currentXp = heart.FetchXpHave();
                        DialogResult = heart.UpdateXpHave(currentXp + Man.Price) ? DialogResult.OK : DialogResult.Retry;
                    }
                    else
                        DialogResult = DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnForceExit_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("این عمل موجب ذخیره نشدن داده میشود", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Heart heart = new Heart();
                    bool k = heart.ExitSpot(Man.Floor, Man.Id);
                    if (k)
                        DialogResult = DialogResult.OK;
                    else
                        DialogResult = DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void LastInfoCondfirmationForm_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
            //-----main
            List<TblPricingPolicy> policies = heart.SelectAllPricingPolicies();
            foreach (TblPricingPolicy policy in policies)
            {
                CmbPrices.Properties.Items.Add(
                    $"{policy.PlanName}-{MethodRepo.PriceCalculator(Man.TimeStayed, policy.EntrancPrice, policy.Hour)}");
            }
            CmbPrices.SelectedIndex = 0;
        }

        private void LastInfoCondfirmationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
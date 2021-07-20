using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class PricingPolicyForm : XtraForm
    {
        public TblAgent Agent;
        private TblPricingPolicy _nowPricingPolicy;
        public PricingPolicyForm()
        {
            InitializeComponent();
        }

        void ResetCtrl()
        {
            TxtName.Text = "";
            NumEnt.Value = 0;
            NumHour.Value = 0;
            TxtDesc.Text = "";
        }

        private void PricingPolicyForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pricingPolicyDataSet.PricingPolicyView' table. You can move, or remove it, as needed.
            pricingPolicyViewTableAdapter.Fill(pricingPolicyDataSet.PricingPolicyView);
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void PricingPolicyForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingMenu a = new SettingMenu { Agent = Agent };
                a.Show();
                Hide();
            }
        }

        private void PricingPolicyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Err.ClearErrors();
            if (TxtName.Text == "")
            {
                Err.SetError(TxtName, "این جا خالی میباشد");
                TxtName.Focus();
            }
            else if (NumEnt.Value == 0)
            {
                Err.SetError(NumEnt, "این جا خالی میباشد");
                NumEnt.Focus();
            }
            else if (NumHour.Value == 0)
            {
                Err.SetError(NumHour, "این جا خالی میباشد");
                NumHour.Focus();
            }
            else if (TxtName.Text.Length > 16)
            {
                Err.SetError(TxtName, "تعداد کاراکتر باید کم تر از 16 باشد");
                TxtName.Focus();
            }
            else
            {
                Heart heart = new Heart();
                TblPricingPolicy policy = new TblPricingPolicy(TxtName.Text, long.Parse(NumEnt.Value.ToString()), long.Parse(NumHour.Value.ToString()), TxtDesc.Text);
                heart.AddPricingPolicy(policy);
                pricingPolicyViewTableAdapter.Fill(pricingPolicyDataSet.PricingPolicyView);
                ResetCtrl();
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (_nowPricingPolicy == null)
                XtraMessageBox.Show("هیچ داده ای انتخاب نشده است", "اخطار");
            else
            {
                Heart heart = new Heart();
                heart.DeletePricingPolicy(_nowPricingPolicy.id);
                pricingPolicyViewTableAdapter.Fill(pricingPolicyDataSet.PricingPolicyView);
                ResetCtrl();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            int rowHandle = gridView1.FocusedRowHandle;
            _nowPricingPolicy = new TblPricingPolicy(Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "کد")), gridView1.GetRowCellValue(rowHandle, "نام تعرفه").ToString(), long.Parse(gridView1.GetRowCellValue(rowHandle, "ورودیه").ToString()), long.Parse(gridView1.GetRowCellValue(rowHandle, "قیمت هر ساعت").ToString()), gridView1.GetRowCellValue(rowHandle, "توضیحات").ToString());
            TxtName.Text = _nowPricingPolicy.PlanName;
            NumEnt.Value = _nowPricingPolicy.EntrancPrice;
            NumHour.Value = _nowPricingPolicy.Hour;
            TxtDesc.Text = _nowPricingPolicy.Description;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (_nowPricingPolicy == null)
                XtraMessageBox.Show("هیچ داده ای انتخاب نشده است", "اخطار");
            else
            {
                Heart heart = new Heart();
                heart.UpdatePricingPolicy(
                    new TblPricingPolicy(TxtName.Text, long.Parse(NumEnt.Value.ToString()),
                        long.Parse(NumHour.Value.ToString()), TxtDesc.Text), _nowPricingPolicy.id);
                pricingPolicyViewTableAdapter.Fill(pricingPolicyDataSet.PricingPolicyView);
                ResetCtrl();
            }
        }
    }
}
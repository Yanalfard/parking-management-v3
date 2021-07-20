using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{

    public partial class InfoCondfirmationForm : DevExpress.XtraBars.TabForm
    {
        public TblCostomerVehicle Man;
        public TblVip Vip;
        private TblProgramm _programm;

        public InfoCondfirmationForm()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtFirstName.Text == "")
                {
                    Err.SetError(TxtFirstName, "این فیلد خالی است");
                    TxtFirstName.Focus();
                }
                else if (TxtP1.Text == "" || TxtP2.Text == "" || TxtP3.Text == "" || TxtP4.Text == "" ||
                         TxtP5.Text == "" || TxtP6.Text == "" || TxtP1.Text == "")
                {
                    Err.SetError(GrpPlate, "مشکلی در اینجا وجود دارد");
                    GrpPlate.Focus();
                }
                else if (TxtFirstName.Text.Length > 16)
                {
                    Err.SetError(TxtFirstName, "The text length must be less than 16");
                    TxtFirstName.Focus();
                }
                else
                {
                    Heart heart = new Heart();
                    Man.Name = TxtFirstName.Text;
                    Man.VehicleId = TxtP1.Text + TxtP2.Text + TxtP3.Text + TxtP4.Text + TxtP5.Text + TxtP6.Text;
                    Man.TimeArrived = DateTime.Now;
                    bool s = heart.AddCostomerVehicle(Man);
                    bool k = heart.EnterSpot(Man.Floor, Man.Id, Man.VehicleId);
                    DialogResult = s ? (k ? DialogResult.OK : DialogResult.Retry) : DialogResult.Retry;
                    if (heart.FetchPrintStatus())
                    {
                        //ignored
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void InfoCondfirmationForm_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void InfoCondfirmationForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void TabNormal_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GrpNormal.Visible = true;
            GrpVip.Visible = false;
        }

        private void TabVip_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            GrpNormal.Visible = false;
            GrpVip.Visible = true;
        }

        private void BtnVipSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtVipFirstName.Text == "")
                {
                    Err.SetError(TxtVipFirstName, "این فیلد خالی است");
                    TxtVipFirstName.Focus();
                }
                else if (TxtVipLastName.Text == "")
                {
                    Err.SetError(TxtVipLastName, "این فیلد خالی است");
                    TxtVipLastName.Focus();
                }
                else if (TxtP1.Text == "" || TxtP2.Text == "" || TxtP3.Text == "" || TxtP4.Text == "" || TxtP5.Text == "" || TxtP6.Text == "")
                {
                    Err.SetError(GrpVipPlate, "این فیلد خالی است");
                    GrpVipPlate.Focus();
                }
                else if (TxtVipFirstName.Text.Length > 16)
                {
                    Err.SetError(TxtVipFirstName, "The text length must be less than 16");
                    TxtVipFirstName.Focus();
                }
                else if (TxtVipLastName.Text.Length > 16)
                {
                    Err.SetError(TxtVipLastName, "The text length must be less than 16");
                    TxtVipLastName.Focus();
                }
                else if (_programm.Id == 0)
                {
                    Err.SetError(BtnProgramm, "تعرفه باید انتخاب شده باشد");
                    BtnProgramm.Focus();
                }
                else
                {
                    Heart heart = new Heart();
                    Vip.FirstName = TxtVipFirstName.Text;
                    Vip.LastName = TxtVipLastName.Text;
                    Vip.VehicleId = TxtVipP1.Text + TxtVipP2.Text + TxtVipP3.Text + TxtVipP4.Text + TxtVipP5.Text + TxtVipP6.Text;
                    Vip.TimeHoldFrom = DateTime.Now;
                    Vip.TimeHoldTo = Vip.TimeHoldFrom.AddDays(_programm.TimeHold); Vip.ProgrammId = _programm.Id;
                    heart.AddVip(Vip);
                    bool k = heart.EnterVip(Convert.ToInt32(Convert.ToString(Vip.Column) + Convert.ToString(Vip.Row)), Vip.Floor, Vip.VehicleId);
                    DialogResult = k ? DialogResult.Yes : DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnProgramm_Click(object sender, EventArgs e)
        {
            ProgrammForm p = new ProgrammForm();
            if (p.ShowDialog() == DialogResult.OK)
            {
                _programm = p.Programm;
                BtnVipSubmit.Focus();
            }
        }

        private void TxtP1_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtP1.Text != @"0")
            {
                TxtP2.Focus();
                TxtP2.SelectAll();
            }
        }

        private void TxtP2_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtP2.Text != @"0")
            {
                TxtP3.Focus();
                TxtP3.SelectAll();
            }
        }

        private void TxtP3_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtP3.Text != @"_")
            {
                TxtP4.Focus();
                TxtP4.SelectAll();
            }
        }

        private void TxtP4_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtP4.Text != @"0")
            {
                TxtP5.Focus();
                TxtP5.SelectAll();
            }
        }

        private void TxtP5_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtP5.Text != @"0")
            {
                TxtP6.Focus();
                TxtP6.SelectAll();
            }
        }

        private void TxtP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtP2.Focus();
                TxtP2.SelectAll();
            }
        }

        private void TxtP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtP3.Focus();
                TxtP3.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtP1.Focus();
                TxtP1.SelectAll();
            }
        }

        private void TxtP3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtP4.Focus();
                TxtP4.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtP2.Focus();
                TxtP2.SelectAll();
            }
        }

        private void TxtP4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtP5.Focus();
                TxtP5.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtP3.Focus();
                TxtP3.SelectAll();
            }
        }

        private void TxtP5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtP6.Focus();
                TxtP6.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtP4.Focus();
                TxtP4.SelectAll();
            }
        }

        private void TxtP6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                TxtP5.Focus();
                TxtP5.SelectAll();
            }
        }
    }
}
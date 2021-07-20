using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class AddProgrammForm : XtraForm
    {
        public TblProgramm Programm;
        public AddProgrammForm()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtName.Text == "")
                {
                    Err.SetError(TxtName, "داده نمیتواند خالی باشد");
                    TxtName.Focus();
                }
                else if (NumDay.Value == 0)
                {
                    Err.SetError(NumDay, "نمیتواند صفر باشد");
                    NumDay.Focus();
                }
                else if (NumDay.Value < 0)
                {
                    Err.SetError(NumDay, "نمیتواند کوچک تر از صفر باشد");
                    NumDay.Focus();
                }
                else if (TxtPrice.Text == "")
                {
                    Err.SetError(TxtPrice, "داده نمیتواند خالی باشد");
                    TxtPrice.Focus();
                }
                else if (long.Parse(TxtPrice.Text) < 0)
                {
                    Err.SetError(TxtPrice, "نمیتواند کوچک تر از صفر باشد");
                    TxtPrice.Focus();
                }
                else
                {
                    Programm = new TblProgramm
                    {
                        Name = TxtName.Text,
                        TimeHold = Convert.ToInt32(NumDay.Value),
                        Price = long.Parse(TxtPrice.Text),
                        Discription = TxtDisc.Text
                    };
                    Heart heart = new Heart();
                    if (heart.AddProgramm(Programm))
                    {
                        XtraMessageBox.Show("عملیات با موفقیت انجام شد");
                        DialogResult = DialogResult.OK;
                    }
                    else
                        XtraMessageBox.Show("خطا رخ داده لطفا دوباره امتحان کنید دقت کنید نام برنامه با نام های قبلی برابر نباشد");
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void AddProgrammForm_Load(object sender, EventArgs e)
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
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void AddProgrammForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
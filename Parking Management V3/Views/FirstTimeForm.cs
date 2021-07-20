using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class FirstTimeForm : XtraForm
    {
        private int _step = 1;
        private int _floorCount = 0;
        private int _floor;
        private int[] _spot;
        private int _ratio = 9;
        private string _them;
        TblAgent _agent = new TblAgent();

        public FirstTimeForm()
        {
            InitializeComponent();
        }

        private void FirstTimeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        void StatusEffectStp1(bool effect)
        {
            label1.Visible = effect;
            label2.Visible = effect;
            label3.Visible = effect;
            label4.Visible = effect;
            label5.Visible = effect;
            TxtIdentification.Visible = effect;
            TxtFirstName.Visible = effect;
            TxtLastName.Visible = effect;
            TxtUsername.Visible = effect;
            TxtPassword.Visible = effect;
            Pic.Visible = effect;
            BtnImgSelect.Visible = effect;
        }

        void StatusEffectStp2(bool effect)
        {
            label6.Visible = effect;
            label7.Visible = effect;
            LblFloor.Visible = effect;
            label10.Visible = effect;
            NumAddFlr.Visible = effect;
            BtnAddFlr.Visible = effect;
            TrackBarColumnCount.Visible = effect;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_step == 1)
                {
                    //--stp1 start
                    _step++;
                    Radio.SelectedIndex = 1;
                    StatusEffectStp1(true);
                    LblVar.Visible = true;
                    simpleButton1.Text = "ادامه";
                }
                else if (_step == 2)
                {
                    Err.ClearErrors();
                    if (TxtIdentification.Text == "")
                    {
                        Err.SetError(TxtIdentification, "این فیلد خالی است");
                        TxtIdentification.Focus();
                    }
                    else if (TxtFirstName.Text == "")
                    {
                        Err.SetError(TxtFirstName, "این فیلد خالی است");
                        TxtFirstName.Focus();
                    }
                    else if (TxtLastName.Text == "")
                    {
                        Err.SetError(TxtLastName, "این فیلد خالی است");
                        TxtLastName.Focus();
                    }
                    else if (TxtUsername.Text == "")
                    {
                        Err.SetError(TxtUsername, "این فیلد خالی است");
                        TxtUsername.Focus();
                    }
                    else if (TxtPassword.Text == "")
                    {
                        Err.SetError(TxtPassword, "این فیلد خالی است");
                        TxtPassword.Focus();
                    }
                    else
                    {
                        _agent.Identification = long.Parse(TxtIdentification.Text);
                        _agent.FirstName = TxtFirstName.Text;
                        _agent.LastName = TxtLastName.Text;
                        _agent.Username = TxtUsername.Text;
                        _agent.Password = TxtPassword.Text;
                        if (xtraOpenFileDialog1.FileName != "xtraOpenFileDialog1")
                            _agent.ImageSrc = xtraOpenFileDialog1.FileName;
                        else
                            _agent.ImageSrc = "";
                        _step++;
                        Radio.SelectedIndex = 2;
                        StatusEffectStp1(false);
                        StatusEffectStp2(true);
                        LblVar.Text = "پارکینگ خود را بسازید";

                    }
                }
                else if (_step == 3)
                {
                    StatusEffectStp2(false);
                    label8.Visible = false;
                    BtnAddStp.Visible = false;
                    NumAddSpt.Visible = false;
                    CmbThem.Visible = true;
                    _step++;
                    Radio.SelectedIndex = 3;
                    LblVar.Text = "تم خود را انتخاب کنید";
                }
                else if (_step == 4)
                {
                    CmbThem.Visible = false;
                    _step++;
                    Radio.SelectedIndex = 4;
                    LblVar.Text = "تایید صلاحیت خرید محصول";
                    label9.Visible = true;
                    TxtHash.Visible = true;
                }
                else if (_step == 5)
                {
                    Heart heart = new Heart();
                    int[] ratios =
                    {
                        1000, 500, 300, 250, 180, 160, 140, 120, 110,
                        100, 90, 85, 80, 70, 67, 65, 60, 57, 54, 51,
                        48, 45, 43, 42, 40, 39, 37, 36, 35, 34
                    };
                    if (!MethodRepo.IsLicenseValid(TxtHash.Text))
                        XtraMessageBox.Show("کد فعالسازی اشتباه است", "اخطار");
                    else
                    {
                        if (MethodRepo.AddLicenseToDb(TxtFirstName.Text + TxtLastName.Text, TxtIdentification.Text,
                            TxtHash.Text, MethodRepo.GetNistTime()))
                        {
                            heart.AddAgent(_agent);
                            for (int i = 0; i < _floor; i++)
                                heart.AddFloor();
                            for (int i = 0; i < _spot.Length; i++)
                                for (int j = 0; j < _spot[i]; j++)
                                    heart.AddSpot(Convert.ToInt32(i));
                            heart.UpdateColumnRatio(ratios[_ratio]);
                            heart.UpdateThem(_them);
                            heart.ChangeFirstLogStatus(false);
                            SignForm a = new SignForm();
                            a.Show();
                            Hide();
                        }
                        else
                            XtraMessageBox.Show("خطا رخ داده لطفا فیلد های مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد های مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnImgSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                    Pic.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnAddFlr_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به اضافه کردن طبقه هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _floor = Convert.ToInt32(NumAddFlr.Value);
                    _spot = new int[_floor];
                    LblFloor.Text = _floorCount.ToString();
                    BtnAddFlr.Enabled = false;
                    NumAddFlr.Enabled = false;
                    label8.Visible = true;
                    NumAddSpt.Visible = true;
                    BtnAddStp.Visible = true;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد های مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnAddStp_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مایل به اضافه کردن جای پارک هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int coreFloor = _floor;
                    _spot[_floorCount] = Convert.ToInt32(NumAddSpt.Value);
                    if (_floorCount + 1 != coreFloor)
                    {
                        _floorCount++;
                        LblFloor.Text = _floorCount.ToString();
                    }
                    else
                    {
                        BtnAddStp.Enabled = false;
                        NumAddSpt.Enabled = false;

                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد های مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void TrackBarColumnCount_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                _ratio = TrackBarColumnCount.Value - 1;
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا فیلد های مورد نظر را پر کرده و دوباره سعی کنید", "اخطار");
            }
        }

        private void CmbThem_SelectedIndexChanged(object sender, EventArgs e)
        {
            _them = CmbThem.SelectedText;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
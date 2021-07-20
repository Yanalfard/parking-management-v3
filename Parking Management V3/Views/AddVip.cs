using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class AddVip : XtraForm
    {
        public int Effect;
        public TblVip CurrentVip;
        private DateTime _timeFrom;
        private int _programmId;
        public AddVip()
        {
            InitializeComponent();
        }

        private void AddVip_Load(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
                if (Effect == 1 || Effect == 2)
                {
                    _programmId = CurrentVip.ProgrammId;
                    TxtFirstName.Text = CurrentVip.FirstName;
                    TxtLastName.Text = CurrentVip.LastName;
                    TxtVehicleID.Text = CurrentVip.VehicleId;
                    TimeCome.Time = CurrentVip.TimeHoldFrom;
                    NumFloor.Value = CurrentVip.Floor;
                    NumColumn.Value = CurrentVip.Column;
                    NumRow.Value = CurrentVip.Row;
                    _programmId = CurrentVip.ProgrammId;
                }
            }
            catch
            {
                XtraMessageBox.Show("مورد باید اول انتخاب شده باشد", "اخطار");
            }
        }

        private void AddVip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Hide();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtFirstName.Text == "")
                {
                    Err.SetError(TxtFirstName, "داده نمیتواند خالی باشد");
                    TxtFirstName.Focus();
                }
                else if (TxtLastName.Text == "")
                {
                    Err.SetError(TxtLastName, "داده نمیتواند خالی باشد");
                    TxtLastName.Focus();
                }
                else if (TxtVehicleID.Text == "")
                {
                    Err.SetError(TxtVehicleID, "داده نمیتواند خالی باشد");
                    TxtVehicleID.Focus();
                }
                else if (NumFloor.Value < 0)
                {
                    Err.SetError(NumFloor, "داده باید بیشتر از صفر باشد");
                    NumFloor.Focus();
                }
                else if (NumColumn.Value < 0)
                {
                    Err.SetError(NumColumn, "داده باید بیشتر از صفر باشد");
                    NumColumn.Focus();
                }
                else if (NumRow.Value < 0)
                {
                    Err.SetError(NumRow, "داده باید بیشتر از صفر باشد");
                    NumRow.Focus();
                }
                else if (_programmId == 0)
                {
                    Err.SetError(BtnChouse, "باید برنامه انتخاب شده باشد");
                    BtnChouse.Focus();
                }
                else
                {
                    _timeFrom = TimeCome.Time;
                    Heart heart = new Heart();
                    TblProgramm programm = new TblProgramm();
                    programm.Id = _programmId;
                    programm = heart.FetchProgrammWithId(programm);
                    TblVip vip = new TblVip
                    {
                        FirstName = TxtFirstName.Text,
                        LastName = TxtLastName.Text,
                        VehicleId = TxtVehicleID.Text,
                        TimeHoldFrom = _timeFrom,
                        TimeHoldTo = _timeFrom.AddDays(programm.TimeHold),
                        Floor = Convert.ToInt32(NumFloor.Value),
                        Column = Convert.ToInt32(NumColumn.Value),
                        Row = Convert.ToInt32(NumRow.Value),
                        ProgrammId = _programmId
                    };
                    vip.TimeHoldTo = new DateTime(vip.TimeHoldTo.Year, vip.TimeHoldTo.Month, vip.TimeHoldTo.Day, 3, 0, 0);
                    vip.PositionId = vip.Column + "." + vip.Row;
                    if (_timeFrom == DateTime.Parse("2001/2/2 12:00"))
                        vip.TimeHoldFrom = TimeCome.Time;
                    heart.AddVip(vip);
                    DialogResult = heart.EnterVip(Convert.ToInt32(Convert.ToString(vip.Column) + Convert.ToString(vip.Row)), vip.Floor, vip.VehicleId) ? DialogResult.OK : DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            _timeFrom = DateTime.Now;
            TimeCome.Time = _timeFrom;
        }

        private void BtnChouse_Click(object sender, EventArgs e)
        {
            ProgrammForm p = new ProgrammForm();
            if (p.ShowDialog() == DialogResult.OK)
                _programmId = p.Programm.Id;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtFirstName.Text == "")
                {
                    Err.SetError(TxtFirstName, "داده نمیتواند خالی باشد");
                    TxtFirstName.Focus();
                }
                else if (TxtLastName.Text == "")
                {
                    Err.SetError(TxtLastName, "داده نمیتواند خالی باشد");
                    TxtLastName.Focus();
                }
                else if (TxtVehicleID.Text == "")
                {
                    Err.SetError(TxtVehicleID, "داده نمیتواند خالی باشد");
                    TxtVehicleID.Focus();
                }
                else if (NumFloor.Value < 0)
                {
                    Err.SetError(NumFloor, "داده باید بیشتر از صفر باشد");
                    NumFloor.Focus();
                }
                else if (NumColumn.Value < 0)
                {
                    Err.SetError(NumColumn, "داده باید بیشتر از صفر باشد");
                    NumColumn.Focus();
                }
                else if (NumRow.Value < 0)
                {
                    Err.SetError(NumRow, "داده باید بیشتر از صفر باشد");
                    NumRow.Focus();
                }
                else if (_programmId == 0)
                {
                    Err.SetError(BtnChouse, "باید برنامه انتخاب شده باشد");
                    BtnChouse.Focus();
                }
                else
                {
                    _timeFrom = TimeCome.Time;
                    Heart heart = new Heart();
                    TblProgramm programm = new TblProgramm();
                    programm.Id = _programmId;
                    programm = heart.FetchProgrammWithId(programm);
                    TblVip vip = new TblVip
                    {
                        FirstName = TxtFirstName.Text,
                        LastName = TxtLastName.Text,
                        VehicleId = TxtVehicleID.Text,
                        TimeHoldFrom = _timeFrom,
                        TimeHoldTo = new DateTime(_timeFrom.Year, _timeFrom.Month, _timeFrom.Day + programm.TimeHold, 3, 00, 00),
                        Floor = Convert.ToInt32(NumFloor.Value),
                        Column = Convert.ToInt32(NumColumn.Value),
                        Row = Convert.ToInt32(NumRow.Value),
                        ProgrammId = _programmId
                    };
                    vip.PositionId = vip.Column + "." + vip.Row;
                    if (_timeFrom == DateTime.Parse("2001/2/2 12:00"))
                        vip.TimeHoldFrom = TimeCome.Time;
                    DialogResult = heart.EditVip(vip, new TblVip { VehicleId = CurrentVip.VehicleId }) ? DialogResult.OK : DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (CurrentVip.VehicleId != "")
                {
                    Heart heart = new Heart();
                    if (heart.DeleteVip(CurrentVip))
                        DialogResult = heart.ExitSpot(CurrentVip.Floor, Convert.ToInt32(Convert.ToString(CurrentVip.Column) + Convert.ToString(CurrentVip.Row))) ? DialogResult.OK : DialogResult.Retry;
                }
                else
                    XtraMessageBox.Show("مورد باید اول انتخاب شده باشد", "اخطار");
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using TblCostomerVehicle = Parking_Management_V3.Models.TblCostomerVehicle;

namespace Parking_Management_V3.Views
{
    public partial class AddCostomerVehicle : XtraForm
    {
        public int Effect;
        public TblCostomerVehicle _currentCustomerVehicle;
        public AddCostomerVehicle()
        {
            InitializeComponent();
        }

        private void AddCostomerVehicle_Load(object sender, EventArgs e)
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
                    TxtName.Text = _currentCustomerVehicle.Name;
                    TimeArrived.Time = _currentCustomerVehicle.TimeArrived;
                    TimeGone.Time = _currentCustomerVehicle.TimeGone;
                    if (_currentCustomerVehicle.TimeStayed != "")
                        TimeStayed.TimeSpan = TimeSpan.Parse(_currentCustomerVehicle.TimeStayed);
                    TxtPrice.Text = _currentCustomerVehicle.Price.ToString();
                    NunFloor.Value = _currentCustomerVehicle.Floor;
                    NumColumn.Value = _currentCustomerVehicle.Column;
                    NumRow.Value = _currentCustomerVehicle.Row;
                    TxtVehicleID.Text = _currentCustomerVehicle.VehicleId;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void AddCostomerVehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Hide();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtName.Text == "")
                {
                    Err.SetError(TxtName, "این فیلد خالی است");
                    TxtName.Focus();
                }
                else if (TxtPrice.Text == "")
                {
                    Err.SetError(TxtPrice, "این فیلد خالی است");
                    TxtPrice.Focus();
                }
                else if (TxtVehicleID.Text == "")
                {
                    Err.SetError(TxtVehicleID, "این فیلد خالی است");
                    TxtVehicleID.Focus();
                }
                else
                {
                    var costomer = new TblCostomerVehicle
                    {
                        Column = Convert.ToInt32(NumColumn.Value),
                        Row = Convert.ToInt32(NumRow.Value),
                        Floor = Convert.ToInt32(NunFloor.Value),
                        PositionId = NumColumn.Value + "." + NumRow.Value
                    };
                    Heart heart = new Heart();
                    costomer.Name = TxtName.Text;
                    costomer.VehicleId = TxtVehicleID.Text;
                    costomer.TimeArrived = DateTime.Parse(TimeArrived.Text);
                    costomer.TimeGone = DateTime.Parse(TimeGone.Text == "1900/01/01 12:00" ? "1900 /01/01 1:00 PM" : TimeGone.Text);
                    costomer.TimeStayed = TimeStayed.Text;
                    costomer.Price = 0;
                    costomer.Price = long.Parse(TxtPrice.Text);
                    if (heart.AddCostomerVehicle(costomer))
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (_currentCustomerVehicle.VehicleId == "")
                {
                    XtraMessageBox.Show("مورد اول باید انتخاب شود");
                }
                else
                {
                    TblCostomerVehicle costomer = new TblCostomerVehicle { VehicleId = _currentCustomerVehicle.VehicleId };
                    Heart heart = new Heart();
                    if (heart.DeleteCostomerVehicle(costomer))
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtName.Text == "")
                {
                    Err.SetError(TxtName, "این فیلد خالی است");
                    TxtName.Focus();
                }
                else if (TxtPrice.Text == "")
                {
                    Err.SetError(TxtPrice, "این فیلد خالی است");
                    TxtPrice.Focus();
                }
                else if (TxtVehicleID.Text == "")
                {
                    Err.SetError(TxtVehicleID, "این فیلد خالی است");
                    TxtVehicleID.Focus();
                }
                else
                {
                    Heart heart = new Heart();
                    TblCostomerVehicle costomer = new TblCostomerVehicle();
                    costomer.Id = _currentCustomerVehicle.Id;
                    costomer.Column = Convert.ToInt32(NumColumn.Value);
                    costomer.Row = Convert.ToInt32(NumRow.Value);
                    costomer.Floor = Convert.ToInt32(NunFloor.Value);
                    costomer.PositionId = NumColumn.Value + "." + NumRow.Value;
                    costomer.Name = TxtName.Text;
                    costomer.VehicleId = TxtVehicleID.Text;
                    costomer.TimeArrived = DateTime.Parse(TimeArrived.Text);
                    costomer.TimeGone = DateTime.Parse(TimeGone.Text == "1900/01/01 12:00" ? "1900/01/01 1:00 PM" : TimeGone.Text);
                    costomer.TimeStayed = TimeStayed.Text;
                    costomer.Price = 0;
                    costomer.Price = long.Parse(TxtPrice.Text);
                    if (heart.EditCostomerVehicle(costomer, new TblCostomerVehicle { VehicleId = _currentCustomerVehicle.VehicleId }))
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
    }
}
using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class CostomerVehicleControlForm : XtraForm
    {
        public TblAgent Agent;
        private TblCostomerVehicle _currentCustomerVehicle;
        public CostomerVehicleControlForm()
        {
            InitializeComponent();
        }

        private void GridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowHandle = gridView1.FocusedRowHandle;
                _currentCustomerVehicle = new TblCostomerVehicle
                {
                    Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "کد")),
                    Name = gridView1.GetRowCellValue(rowHandle, "نام").ToString(),
                    TimeArrived = DateTime.Parse(gridView1.GetRowCellValue(rowHandle, "زمان آمدن").ToString()),
                    TimeGone = DateTime.Parse(gridView1.GetRowCellValue(rowHandle, "زمان رفتن").ToString()),
                    TimeStayed = gridView1.GetRowCellValue(rowHandle, "زمان ماندن").ToString(),
                    Price = long.Parse(gridView1.GetRowCellValue(rowHandle, "قیمت").ToString()),
                    Floor = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "طبقه")),
                    Column = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "سطر")),
                    Row = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "ستون")),
                    PositionId = gridView1.GetRowCellValue(rowHandle, "کد مکان").ToString(),
                    VehicleId = gridView1.GetRowCellValue(rowHandle, "پلاک").ToString()
                };
                if (_currentCustomerVehicle != null)
                {
                    AddCostomerVehicle form = new AddCostomerVehicle
                    {
                        Effect = 2,
                        _currentCustomerVehicle = _currentCustomerVehicle
                    };
                    form.BtnEdit.Visible = true;
                    form.BtnDelete.Visible = true;
                    if (form.ShowDialog() == DialogResult.OK)
                        costomerVehicleViewTableAdapter.Fill(parkingManagementV3DataSet.CostomerVehicleView);

                }
                else
                    XtraMessageBox.Show("مورد اول باید انتخاب شود");
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void CostomerVehicleControlForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'parkingManagementV3DataSet.CostomerVehicleView' table. You can move, or remove it, as needed.
            costomerVehicleViewTableAdapter.Fill(parkingManagementV3DataSet.CostomerVehicleView);
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void CostomerVehicleControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                AddCostomerVehicle form = new AddCostomerVehicle { Effect = 0 };
                form.BtnSubmit.Visible = true;
                if (form.ShowDialog() == DialogResult.OK)
                    costomerVehicleViewTableAdapter.Fill(parkingManagementV3DataSet.CostomerVehicleView);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentCustomerVehicle.Id != 0)
                {
                    AddCostomerVehicle form = new AddCostomerVehicle { Effect = 1, _currentCustomerVehicle = _currentCustomerVehicle };
                    if (form.ShowDialog() == DialogResult.OK)
                        costomerVehicleViewTableAdapter.Fill(parkingManagementV3DataSet.CostomerVehicleView);
                }
                else
                    XtraMessageBox.Show("مورد اول باید انتخاب شود");
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void CostomerVehicleControlForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    MainAppMenu a = new MainAppMenu { Agent = Agent };
                    a.Show();
                    Hide();
                }
                if (e.Alt && e.KeyCode == Keys.X)
                    groupControl2.Visible = true;
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                bool succes = heart.Execute(richTextBox1.Text);
                if (succes)
                {
                    XtraMessageBox.Show("Command executed succesfuly");
                    costomerVehicleViewTableAdapter.Fill(parkingManagementV3DataSet.CostomerVehicleView);
                }
                else
                    XtraMessageBox.Show("Command execution faild");
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentCustomerVehicle != null)
                {
                    AddCostomerVehicle form = new AddCostomerVehicle
                    {
                        Effect = 2,
                        _currentCustomerVehicle = _currentCustomerVehicle
                    };
                    if (form.ShowDialog() == DialogResult.OK)
                        costomerVehicleViewTableAdapter.Fill(parkingManagementV3DataSet.CostomerVehicleView);

                }
                else
                    XtraMessageBox.Show("مورد اول باید انتخاب شود");
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
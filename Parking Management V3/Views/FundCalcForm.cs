using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using OfficeOpenXml;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class FundCalcForm : XtraForm
    {
        public TblAgent Agent;
        public TblCostomerVehicle[] CostomerVehicle;
        public double[] MoneyDays;
        public DateTime[] DaysOfChart;
        public bool IsAiInclouded = false;

        public FundCalcForm()
        {
            InitializeComponent();
            sqlDataSource1.Fill();
        }

        private void _createGrid()
        {
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "کد",
                FieldName = "Id",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "نام",
                FieldName = "Name",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "زمان آمدن",
                FieldName = "TimeArrived",
                UnboundType = DevExpress.Data.UnboundColumnType.DateTime,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "زمان رفتین",
                FieldName = "TimeGone",
                UnboundType = DevExpress.Data.UnboundColumnType.DateTime,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "زمان ماندن",
                FieldName = "TimeStayed",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "قیمت",
                FieldName = "Price",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "طبقه",
                FieldName = "Floor",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "سطر",
                FieldName = "Row",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "ستون",
                FieldName = "Column",
                UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "کد مکان",
                FieldName = "PositionId",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            });
            gridView1.Columns.Add(new GridColumn
            {
                Caption = "پلاک",
                FieldName = "VehicleId",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            });
        }

        private void FundCalcForm_Load(object sender, EventArgs e)
        {
            try
            {
                //--------------------look
                Heart heart = new Heart();
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
                _createGrid();
                gridControl1.DataSource = CostomerVehicle;
                if (IsAiInclouded)
                {
                    List<double> moneyDaysOrg = MoneyDays.ToList();
                    List<DateTime> daysOfChartOrg = DaysOfChart.ToList();
                    long[] days = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                    double a, b;
                    LblPrice.Text = MoneyDays[0].ToString();
                    ChartOfDays.Series.Add("", ViewType.Bar);
                    ChartOfDays.Series[0].ArgumentScaleType = ScaleType.DateTime;
                    ChartOfDays.Series[0].ValueScaleType = ScaleType.Numerical;
                    ChartOfDays.Series.Add("مقادیر", ViewType.ScatterLine);
                    ChartOfDays.Series[0].ArgumentScaleType = ScaleType.DateTime;
                    ChartOfDays.Series[0].ValueScaleType = ScaleType.Numerical;
                    //--------------------core consept
                    MethodRepo.LinearRegression(out a, out b, days, moneyDaysOrg.ToArray());
                    moneyDaysOrg.Reverse();
                    daysOfChartOrg.Reverse();
                    daysOfChartOrg.Add(daysOfChartOrg[9].AddDays(1));
                    daysOfChartOrg.Add(daysOfChartOrg[9].AddDays(2));
                    daysOfChartOrg.Add(daysOfChartOrg[9].AddDays(3));
                    daysOfChartOrg.Add(daysOfChartOrg[9].AddDays(4));
                    daysOfChartOrg.Add(daysOfChartOrg[9].AddDays(5));
                    moneyDaysOrg.Add(Math.Floor(a * 11 + b));
                    moneyDaysOrg.Add(Math.Floor(a * 12 + b));
                    moneyDaysOrg.Add(Math.Floor(a * 13 + b));
                    moneyDaysOrg.Add(Math.Floor(a * 14 + b));
                    moneyDaysOrg.Add(Math.Floor(a * 15 + b));
                    SeriesPoint[] serieValues = new SeriesPoint[15];
                    for (int i = 0; i < 15; i++)
                        serieValues[i] = new SeriesPoint(daysOfChartOrg[i], moneyDaysOrg[i]);
                    ChartOfDays.Series[0].Points.AddRange(serieValues.ToArray());
                    ChartOfDays.Series[1].Points.AddRange(serieValues.ToArray());
                }
                else
                    ChartOfDays.Visible = false;
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void FundCalcForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    FundControllForm form = new FundControllForm { Agent = Agent };
                    form.Show();
                    Hide();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnCalcNorm_Click(object sender, EventArgs e)
        {
            try
            {
                List<TblCostomerVehicle> costomerVehicles = new Heart().FetchAllCostomerVehicles();
                List<TblCostomerVehicle> newCostomerVehicles = new List<TblCostomerVehicle>();
                foreach (TblCostomerVehicle costomerVehicle in costomerVehicles)
                    if (costomerVehicle.TimeGone > TimeFromNorm.Time && costomerVehicle.TimeGone < TimeToNorm.Time)
                        newCostomerVehicles.Add(costomerVehicle);
                if (newCostomerVehicles.Count == 0)
                    XtraMessageBox.Show("چنین داده ای در جدول ثبت نشده", "اخطار");
                else
                {
                    long sum = 0;
                    gridControl1.DataSource = newCostomerVehicles;
                    foreach (TblCostomerVehicle costomerVehicle in newCostomerVehicles)
                        sum += costomerVehicle.Price;
                    LblPrice.Text = sum.ToString();
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
        private void FundCalcForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                OpdExport.Filter = "Exel Archive | *.xlsx";
                if (OpdExport.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.ExportToXlsx(OpdExport.FileName);
                    byte[] bin = File.ReadAllBytes(OpdExport.FileName);
                    using (MemoryStream stream = new MemoryStream(bin))
                    using (ExcelPackage excel = new ExcelPackage(stream))
                    {
                        ExcelWorksheet worksheet = excel.Workbook.Worksheets["Sheet"];
                        int lastPriceCount = 0;
                        double sumPayed = 0;
                        for (int i = 1; i < worksheet.Cells.End.Row; i++)
                        {
                            if (worksheet.Cells[i, 1].Value == null)
                            {
                                lastPriceCount = i;
                                break;
                            }

                            sumPayed += Convert.ToInt32(worksheet.Cells[i + 1, 6].Value);
                        }
                        List<object[]> cellData2 = new List<object[]>
                        {
                            new String[] {sumPayed.ToString()}
                        };
                        worksheet.Cells[$"F{lastPriceCount}:L{lastPriceCount}"].LoadFromArrays(cellData2);
                        excel.SaveAs(new FileInfo(OpdExport.FileName));
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
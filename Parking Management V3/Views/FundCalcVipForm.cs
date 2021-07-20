using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using OfficeOpenXml;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class FundCalcVipForm : XtraForm
    {
        public TblAgent Agent;
        public TblVip[] Vips;
        public FundCalcVipForm()
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
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "نام",
                FieldName = "FirstName",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "نام خانوادگی",
                FieldName = "LastName",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "پلاک",
                FieldName = "VehicleId",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "زمان آمدن",
                FieldName = "TimeHoldFrom",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "زمان رفتن",
                FieldName = "TimeHoldTo",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "طبقه",
                FieldName = "Floor",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "ستون",
                FieldName = "Column",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "سطر",
                FieldName = "Row",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "کد مکان",
                FieldName = "PositionId",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            }); gridView1.Columns.Add(new GridColumn
            {
                Caption = "کد تعرفه",
                FieldName = "ProgrammId",
                UnboundType = DevExpress.Data.UnboundColumnType.String,
                Visible = true
            });
        }

        private void FundCalcVipForm_Load(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
                long sum = 0;
                _createGrid();
                gridControl1.DataSource = Vips;
                foreach (TblVip vip in Vips)
                    sum += heart.FetchProgrammWithId(new TblProgramm { Id = vip.ProgrammId }).Price;
                LblPrice.Text = sum.ToString();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void FundCalcVipForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Escape)
                {
                    FundControllForm a = new FundControllForm { Agent = Agent };
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

        private void BtnCalcVip_Click(object sender, EventArgs e)
        {
            try
            {
                List<TblVip> vips = new Heart().FetchAllVips();
                List<TblVip> newVips = new List<TblVip>();
                foreach (TblVip vip in vips)
                    if (vip.TimeHoldFrom > TimeFromVip.Time && vip.TimeHoldTo < TimeToVip.Time)
                        newVips.Add(vip);
                if (newVips.Count == 0)
                    XtraMessageBox.Show("چنین داده ای در جدول ثبت نشده", "اخطار");
                else
                {
                    long sum = 0;
                    Heart heart = new Heart();
                    gridControl1.DataSource = newVips;
                    foreach (TblVip vip in newVips)
                        sum += heart.FetchProgrammWithId(new TblProgramm { Id = vip.ProgrammId }).Price;
                    LblPrice.Text = sum.ToString();
                }
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
                    gridControl1.DataSource = Vips;
                }
                else
                    XtraMessageBox.Show("Command execution faild");
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void FundCalcVipForm_FormClosed(object sender, FormClosedEventArgs e)
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
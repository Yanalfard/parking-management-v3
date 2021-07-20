using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class MainForm : XtraForm
    {
        public TblAgent Me;
        private List<TblFloor_i> _floorSpots;
        private int _floorCount;
        private int _nowFloor;
        private int _nowFloorFullSpots;
        private int _nowFloorEmptySpots;
        private bool _printStatus;
        private int _width = 250;
        private int _height = 130;

        public MainForm()
        {
            InitializeComponent();
        }

        void ColorSetter(Color col, SimpleButton btn)
        {
            btn.LookAndFeel.Style = LookAndFeelStyle.UltraFlat;
            btn.LookAndFeel.UseDefaultLookAndFeel = false;
            btn.Appearance.BackColor = col;
            btn.Appearance.Options.UseBackColor = true;
        }

        void ResetLblCtrl()
        {
            LblAllFlr.Text = _floorCount.ToString();
            LblFlrSpt.Text = FlowSpots.Controls.Count.ToString();
            _nowFloorEmptySpots = 0;
            _nowFloorFullSpots = 0;
            foreach (SimpleButton simpleButton in FlowSpots.Controls)
                if (!simpleButton.LookAndFeel.UseDefaultLookAndFeel)
                    _nowFloorFullSpots++;
                else
                    _nowFloorEmptySpots++;
            LblFlrFSpt.Text = _nowFloorFullSpots.ToString();
            LblEspt.Text = _nowFloorEmptySpots.ToString();
        }

        void CreateFloorLoad(int howMany)
        {
            for (int i = 0; i < howMany; i++)
            {
                SimpleButton but = new SimpleButton
                {
                    Size = new Size(250, 130),
                    Text = i.ToString(),
                    Font = new Font("B Nazanin", 12, FontStyle.Bold)
                };
                FlowFloors.Controls.Add(but);
                but.Click += Floor_Click;
            }
        }

        void ChartReset()
        {
            DateTime dayForSub = DateTime.Parse(DateTime.Now.Date.ToShortDateString() + " 12:00:00 PM");
            DateTime[] daysOfChart = new DateTime[10];
            double[] moneyDays = new double[10];
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                List<TblCostomerVehicle> listForSum = new Heart().FetchTimedCostomerVehicles(dayForSub, dayForSub.AddDays(1));
                foreach (TblCostomerVehicle costomerVehicle in listForSum)
                    sum += costomerVehicle.Price;
                if (i == 0)
                    sum += listForSum[0].Price /** (1 / 2)*/;
                moneyDays[i] = sum;
                sum = 0;
                listForSum.Clear();
                daysOfChart[i] = dayForSub;
                dayForSub = dayForSub.Subtract(new TimeSpan(1, 0, 0, 0));
            }
            List<double> moneyDaysOrg = moneyDays.ToList();
            List<DateTime> daysOfChartOrg = daysOfChart.ToList();
            daysOfChartOrg.Reverse();
            moneyDaysOrg.Reverse();
            SeriesPoint[] serriedValues = new SeriesPoint[10];
            for (int i = 0; i < 10; i++)
                serriedValues[i] = new SeriesPoint(daysOfChartOrg[i], moneyDaysOrg[i]);
            ChartOfDays.Series[0].Points.AddRange(serriedValues.ToArray());
            ChartOfDays.Series[1].Points.AddRange(serriedValues.ToArray());
        }

        void CreateSpotsLoad(int howMany)
        {
            int c = 0;
            int k = 0;
            for (int i = 0; i < howMany; i++)
            {
                SimpleButton but = new SimpleButton
                {
                    Size = new Size(_width, _height),
                    Text = k + @"." + c,
                    Font = new Font("B Nazanin", 12, FontStyle.Bold)
                };
                FlowSpots.Controls.Add(but);
                but.Click += Spot_Click;
                c++;
                if (c >= 10)
                {
                    c = 0;
                    k++;
                }
                if (_floorSpots[i].SpotStatus == 1)
                {
                    ColorSetter(Color.FromArgb(45, 83, 185), but);
                    but.Appearance.BorderColor = Color.FromArgb(205, 207, 208);
                }
                else if (_floorSpots[i].SpotStatus == 2)
                {
                    ColorSetter(Color.FromArgb(32, 111, 36), but);
                    but.Appearance.BorderColor = Color.FromArgb(204, 207, 208);
                }
                else
                    but.LookAndFeel.UseDefaultLookAndFeel = true;
            }
        }

        private void ResetLevelXp()
        {
            Heart heart = new Heart();
            int level = heart.FetchLevel();
            long totalXp = MethodRepo.LevelXp(level);
            long xpHave = heart.FetchXpHave();
            if (xpHave >= totalXp)
            {
                xpHave = xpHave - totalXp;
                heart.UpdateXpHave(xpHave);
                heart.UpdateLevel(level + 1);
                level++;
                XtraMessageBox.Show($" تبریک شما وارد سطح {level} شدید  هدف شما روی {totalXp} تنظیم شد ", "تبریک");
            }
            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            LblXpHave.Text = Convert.ToDouble(xpHave).ToString();
            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            LblTotalXp.Text = Convert.ToDouble(totalXp).ToString();
            LblLevel.Text = level.ToString();
        }

        private void Floor_Click(object sender, EventArgs e)
        {
            try
            {
                FlowSpots.Controls.Clear();
                SimpleButton but = (SimpleButton)sender;
                Heart heart = new Heart();
                _floorSpots = heart.FetchSpots(Convert.ToInt32(but.Text));
                _nowFloor = Convert.ToInt32(but.Text);
                CreateSpotsLoad(_floorSpots.Count);
                ResetLblCtrl();
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void Spot_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton but = (SimpleButton)sender;
                if (!but.LookAndFeel.UseDefaultLookAndFeel)
                {
                    if (but.Appearance.BorderColor == Color.FromArgb(205, 207, 208))
                    {
                        LastInfoCondfirmationForm infoForm = new LastInfoCondfirmationForm
                        {
                            Man = new TblCostomerVehicle
                            {
                                Column = Convert.ToInt32(but.Text.Split('.')[0]),
                                Row = Convert.ToInt32(but.Text.Split('.')[1]),
                                Floor = _nowFloor,
                                PositionId = but.Text
                            }
                        };
                        infoForm.Man.Id = Convert.ToInt32(infoForm.Man.Column.ToString() + infoForm.Man.Row);
                        Heart heart = new Heart();
                        TblCostomerVehicle nowMan = heart.FetchCostomerAndVehicleByPosition(_nowFloor, infoForm.Man.Id);
                        infoForm.TxtName.Text = infoForm.Man.Name = nowMan.Name;
                        infoForm.TxtVehicleID.Text = infoForm.Man.VehicleId = nowMan.VehicleId;
                        infoForm.TxtTimeArrived.Text = MethodRepo.DateTimeToPersian(nowMan.TimeArrived) + @" " +
                            nowMan.TimeArrived.Hour + @":" + nowMan.TimeArrived.Minute +
                            @":" + nowMan.TimeArrived.Second;
                        infoForm.Man.TimeArrived = nowMan.TimeArrived;
                        infoForm.Man.TimeGone = DateTime.Now;
                        infoForm.TxtTimeGone.Text = MethodRepo.DateTimeToPersian(infoForm.Man.TimeGone) + @" " +
                                                    infoForm.Man.TimeGone.Hour + @":" + infoForm.Man.TimeGone.Minute +
                                                    @":" + infoForm.Man.TimeGone.Second;
                        TimeSpan timeStayed = infoForm.Man.TimeGone.Subtract(nowMan.TimeArrived);
                        if (timeStayed.Days == 0)
                            infoForm.Man.TimeStayed = timeStayed.Hours.ToString();
                        else
                            infoForm.Man.TimeStayed = (timeStayed.Days * 24 + timeStayed.Hours).ToString();
                        if (infoForm.Man.TimeStayed == "0")
                            infoForm.TxtTimeStayed.Text = @"کم تر از 1 ساعت";
                        else
                            infoForm.TxtTimeStayed.Text = infoForm.Man.TimeStayed + @" ساعت ";
                        infoForm.IsPrinterEnable = _printStatus;
                        if (infoForm.ShowDialog() == DialogResult.OK)
                        {
                            ResetLevelXp();
                            but.LookAndFeel.UseDefaultLookAndFeel = true;
                            ResetLblCtrl();
                            LblPeopleCount.Text = (Convert.ToInt32(LblPeopleCount.Text) + 1).ToString();
                            LblCurrency.Text = (Convert.ToInt32(LblCurrency.Text) + infoForm.Man.Price).ToString();
                            ChartReset();
                        }
                    }
                    else if (but.Appearance.BorderColor == Color.FromArgb(204, 207, 208))
                    {
                        Heart heart = new Heart();
                        List<TblVip> vips = heart.FetchCurrentVips();
                        TblVip selectedVip = new TblVip();
                        foreach (TblVip vip in vips)
                            if (vip.Column == Convert.ToInt32(but.Text.Split('.')[0]) &&
                                vip.Row == Convert.ToInt32(but.Text.Split('.')[1]))
                            {
                                selectedVip = vip;
                                break;
                            }
                        if (XtraMessageBox.Show(
                                $"زمان پایان عضویت {selectedVip.FirstName + " " + selectedVip.LastName} برابر است با {MethodRepo.DateTimeToPersian(selectedVip.TimeHoldTo.Date)} آیا واقعا میخواهید عضویت این فرد را لغو کنید؟", "اخطار",
                                MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            string[] colRow = but.Text.Split('.');
                            heart.ExitSpot(_nowFloor, Convert.ToInt32(colRow[0] + colRow[1]));
                            but.LookAndFeel.UseDefaultLookAndFeel = true;
                            ResetLblCtrl();
                        }
                    }
                }
                else
                {
                    string[] colRow = but.Text.Split('.');
                    InfoCondfirmationForm infoForm = new InfoCondfirmationForm
                    {
                        Man = new TblCostomerVehicle
                        {
                            Column = Convert.ToInt32(colRow[0]),
                            Row = Convert.ToInt32(colRow[1]),
                            Floor = _nowFloor,
                            PositionId = but.Text
                        },
                        Vip = new TblVip
                        {
                            Column = Convert.ToInt32(colRow[0]),
                            Row = Convert.ToInt32(colRow[1]),
                            Floor = _nowFloor,
                            PositionId = but.Text
                        }
                    };
                    infoForm.Man.Id = Convert.ToInt32(infoForm.Man.Column.ToString() + infoForm.Man.Row);
                    infoForm.LblPosition.Text = infoForm.Man.PositionId;
                    infoForm.ShowDialog();
                    if (infoForm.DialogResult == DialogResult.OK)
                    {
                        ColorSetter(Color.FromArgb(45, 83, 185), but);
                        but.Appearance.BorderColor = Color.FromArgb(205, 207, 208);
                        ResetLblCtrl();
                    }
                    else if (infoForm.DialogResult == DialogResult.Yes)
                    {
                        ColorSetter(Color.FromArgb(32, 111, 36), but);
                        but.Appearance.BorderColor = Color.FromArgb(204, 207, 208);
                        ResetLblCtrl();
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                //-------------------------------------look
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
                string bgImg = heart.FetchBgImg();
                if (bgImg != "nothing")
                    FlowSpots.BackgroundImage = Image.FromFile(bgImg);
                ResetLevelXp();
                //-------------------------------------Column count start
                int ratio = heart.FetchColumnRatio();
                _width = 250 * ratio / 100;
                _height = 130 * ratio / 100;
                //-------------------------------------Column count end
                //-------------------------------------grid operation
                gridView1.Columns.Add(new GridColumn
                {
                    Caption = @"نام",
                    FieldName = "Name",
                    UnboundType = DevExpress.Data.UnboundColumnType.String,
                    Visible = true
                }); gridView1.Columns.Add(new GridColumn
                {
                    Caption = @"پلاک",
                    FieldName = "VehicleId",
                    UnboundType = DevExpress.Data.UnboundColumnType.String,
                    Visible = true
                }); gridView1.Columns.Add(new GridColumn
                {
                    Caption = @"طبقه",
                    FieldName = "Floor",
                    UnboundType = DevExpress.Data.UnboundColumnType.Integer,
                    Visible = true
                }); gridView1.Columns.Add(new GridColumn
                {
                    Caption = @"کد مکان",
                    FieldName = "PositionId",
                    UnboundType = DevExpress.Data.UnboundColumnType.String,
                    Visible = true
                });
                //-------------------------------------main operation
                int floorCount = heart.FetchFloorCount();
                for (int i = 0; i < floorCount; i++)
                {
                    List<TblFloor_i> thisFloor = heart.FetchSpots(i);
                    foreach (var spot in thisFloor)
                        if (spot.SpotStatus == 2)
                        {
                            TblVip vip = new TblVip { VehicleId = spot.VehicleId };
                            vip = heart.FetchVipWithVehicleId(vip);
                            if (vip.TimeHoldTo <= DateTime.Now)
                                heart.ExitSpot(i,
                                    Convert.ToInt32(Convert.ToString(vip.Column) + Convert.ToString(vip.Row)));
                        }
                }
                _floorCount = heart.FetchFloorCount();
                CreateFloorLoad(_floorCount);
                ResetLblCtrl();
                LblMachineName.Text = Environment.MachineName;
                LblDate.Text = MethodRepo.DateTimeToPersian(DateTime.Now);
                LblDayOfWeek.Text = MethodRepo.DayOfweek(DateTime.Now.DayOfWeek);
                LblTimeCome.Text = heart.FetchTimeCome();
                //---people and currency start
                DateTime dayBegins = DateTime.Parse(DateTime.Now.Date.ToShortDateString() + " 12:00:00 PM");
                List<TblCostomerVehicle> listOfPeople = new Heart().FetchTimedCostomerVehicles(dayBegins, dayBegins.AddDays(1));
                LblPeopleCount.Text = listOfPeople.Count.ToString();
                long sum0 = 0;
                foreach (TblCostomerVehicle person in listOfPeople)
                    sum0 += person.Price;
                LblCurrency.Text = sum0.ToString();
                //---people and currency end
                //---core concept start
                ChartOfDays.Series.Add("", ViewType.Bar);
                ChartOfDays.Series[0].ArgumentScaleType = ScaleType.DateTime;
                ChartOfDays.Series[0].ValueScaleType = ScaleType.Numerical;
                ChartOfDays.Series.Add("مقادیر", ViewType.ScatterLine);
                ChartOfDays.Series[0].ArgumentScaleType = ScaleType.DateTime;
                ChartOfDays.Series[0].ValueScaleType = ScaleType.Numerical;
                //---
                DateTime dayForSub = dayBegins;
                DateTime[] daysOfChart = new DateTime[10];
                double[] moneyDays = new double[10];
                double sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    List<TblCostomerVehicle> listForSum = new Heart().FetchTimedCostomerVehicles(dayForSub, dayForSub.AddDays(1));
                    foreach (TblCostomerVehicle costomerVehicle in listForSum)
                        sum += costomerVehicle.Price;
                    moneyDays[i] = sum;
                    sum = 0;
                    listForSum.Clear();
                    daysOfChart[i] = dayForSub;
                    dayForSub = dayForSub.Subtract(new TimeSpan(1, 0, 0, 0));
                }
                List<double> moneyDaysOrg = moneyDays.ToList();
                List<DateTime> daysOfChartOrg = daysOfChart.ToList();
                daysOfChartOrg.Reverse();
                moneyDaysOrg.Reverse();
                SeriesPoint[] serriedValues = new SeriesPoint[10];
                for (int i = 0; i < 10; i++)
                    serriedValues[i] = new SeriesPoint(daysOfChartOrg[i], moneyDaysOrg[i]);
                ChartOfDays.Series[0].Points.AddRange(serriedValues.ToArray());
                ChartOfDays.Series[1].Points.AddRange(serriedValues.ToArray());
                //---core concept end
                if (Me.ImageSrc != "")
                    Pbx.Image = Image.FromFile(Me.ImageSrc);
                _printStatus = heart.FetchPrintStatus();
            }
            catch
            {
                // ignored
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainAppMenu form = new MainAppMenu { Agent = Me };
                form.Show();
                Hide();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BtnBackGround_Click(object sender, EventArgs e)
        {
            try
            {
                BackGroundControll control = new BackGroundControll();
                if (control.ShowDialog() == DialogResult.OK) FlowSpots.BackgroundImage = control.BgImage;
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnAutoChoose_Click(object sender, EventArgs e)
        {
            try
            {
                bool flag = false;
                Heart heart = new Heart();
                int floorCount = heart.FetchFloorCount();
                for (int i = 0; i < floorCount; i++)
                {
                    List<TblFloor_i> thisFloor = heart.FetchSpots(i);
                    foreach (TblFloor_i spot in thisFloor)
                        if (spot.SpotStatus == 0)
                        {
                            int[] colRow = new int[2];
                            if (spot.SpotId < 10)
                            {
                                colRow[0] = 0;
                                colRow[1] = spot.SpotId;
                            }
                            else
                            {
                                colRow[1] = Convert.ToInt32(spot.SpotId.ToString()[spot.SpotId.ToString().Length - 1]
                                    .ToString());
                                colRow[0] = Convert.ToInt32(spot.SpotId.ToString()
                                    .Remove(spot.SpotId.ToString().Length - 1, 1));
                            }
                            InfoCondfirmationForm infoForm = new InfoCondfirmationForm
                            {
                                Man = new TblCostomerVehicle
                                {
                                    Column = Convert.ToInt32(colRow[0]),
                                    Row = Convert.ToInt32(colRow[1]),
                                    Floor = i,
                                    PositionId = colRow[0] + "." + colRow[1]
                                },
                                Vip = new TblVip
                                {
                                    Column = Convert.ToInt32(colRow[0]),
                                    Row = Convert.ToInt32(colRow[1]),
                                    Floor = i,
                                    PositionId = colRow[0] + "." + colRow[1]
                                }
                            };
                            infoForm.Man.Id = Convert.ToInt32(infoForm.Man.Column.ToString() + infoForm.Man.Row);
                            infoForm.LblPosition.Text = infoForm.Man.PositionId;
                            infoForm.ShowDialog();
                            if (infoForm.DialogResult == DialogResult.OK)
                            {
                                if (i == _nowFloor)
                                    foreach (SimpleButton but in FlowSpots.Controls)
                                        if (but.Text == infoForm.Man.PositionId)
                                        {
                                            ColorSetter(Color.FromArgb(45, 83, 185), but);
                                            but.Appearance.BorderColor = Color.FromArgb(205, 207, 208);
                                            ResetLblCtrl();
                                        }
                            }
                            else if (infoForm.DialogResult == DialogResult.Yes)
                            {
                                if (i == _nowFloor)
                                    foreach (SimpleButton but in FlowSpots.Controls)
                                        if (but.Text == infoForm.Man.PositionId)
                                        {
                                            ColorSetter(Color.FromArgb(32, 111, 36), but);
                                            but.Appearance.BorderColor = Color.FromArgb(204, 207, 208);
                                            ResetLblCtrl();
                                        }
                            }
                            flag = true;
                            break;
                        }
                    if (flag)
                        break;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
        private void GridSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (GridSearch.DataSource != null)
                {
                    Heart heart = new Heart();
                    int rowHandle = gridView1.FocusedRowHandle;
                    string vehicleId = gridView1.GetRowCellValue(rowHandle, "VehicleId").ToString();
                    TblCostomerVehicle nowMan = heart.FetchCostomerAndVehicleByVehicleId(vehicleId);
                    LastInfoCondfirmationForm infoForm = new LastInfoCondfirmationForm
                    {
                        Man = new TblCostomerVehicle
                        {
                            Column = nowMan.Column,
                            Row = nowMan.Row,
                            Floor = nowMan.Floor,
                            PositionId = nowMan.PositionId,
                        }
                    };
                    infoForm.Man.Id = Convert.ToInt32(infoForm.Man.Column.ToString() + infoForm.Man.Row);
                    infoForm.TxtName.Text = infoForm.Man.Name = nowMan.Name;
                    infoForm.TxtVehicleID.Text = infoForm.Man.VehicleId = nowMan.VehicleId;
                    infoForm.TxtTimeArrived.Text = MethodRepo.DateTimeToPersian(nowMan.TimeArrived) + @" " +
                                                   nowMan.TimeArrived.Hour + @":" + nowMan.TimeArrived.Minute +
                                                   @":" + nowMan.TimeArrived.Second;
                    infoForm.Man.TimeArrived = nowMan.TimeArrived;
                    infoForm.Man.TimeGone = DateTime.Now;
                    infoForm.TxtTimeGone.Text = MethodRepo.DateTimeToPersian(infoForm.Man.TimeGone) + @" " +
                                                infoForm.Man.TimeGone.Hour + @":" + infoForm.Man.TimeGone.Minute +
                                                @":" + infoForm.Man.TimeGone.Second;
                    infoForm.Man.TimeStayed = (infoForm.Man.TimeGone - nowMan.TimeArrived).ToString();
                    infoForm.TxtTimeStayed.Text = infoForm.Man.TimeStayed.Split('.')[0];
                    infoForm.IsPrinterEnable = _printStatus;
                    if (infoForm.ShowDialog() == DialogResult.OK)
                        foreach (Control spot in FlowSpots.Controls)
                            if (spot.Text == nowMan.PositionId)
                            {
                                ResetLevelXp();
                                SimpleButton but = (SimpleButton)spot;
                                but.LookAndFeel.UseDefaultLookAndFeel = true;
                                GridSearch.DataSource = null;
                                ResetLblCtrl();
                                LblPeopleCount.Text = (Convert.ToInt32(LblPeopleCount.Text) + 1).ToString();
                                LblCurrency.Text = (Convert.ToInt32(LblCurrency.Text) + infoForm.Man.Price).ToString();
                                ChartReset();
                                break;
                            }
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtSearchP1.Text == "" || TxtSearchP2.Text == "" || TxtSearchP3.Text == "" ||
                    TxtSearchP4.Text == "" || TxtSearchP5.Text == "" || TxtSearchP6.Text == "")
                    GridSearch.DataSource = null;
                else
                    GridSearch.DataSource = new Heart().FetchCostomerVehicleSearch(TxtSearchP1.Text + TxtSearchP2.Text + TxtSearchP3.Text + TxtSearchP4.Text + TxtSearchP5.Text + TxtSearchP6.Text);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void TxtSearchP1_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSearchP1.Text != @"0")
            {
                TxtSearchP2.Focus();
                TxtSearchP2.SelectAll();
            }
        }

        private void TxtSearchP2_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSearchP2.Text != @"0")
            {
                TxtSearchP3.Focus();
                TxtSearchP3.SelectAll();
            }
        }

        private void TxtSearchP3_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSearchP3.Text != @"_")
            {
                TxtSearchP4.Focus();
                TxtSearchP4.SelectAll();
            }
        }

        private void TxtSearchP4_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSearchP4.Text != @"0")
            {
                TxtSearchP5.Focus();
                TxtSearchP5.SelectAll();
            }
        }

        private void TxtSearchP5_EditValueChanged(object sender, EventArgs e)
        {
            if (TxtSearchP5.Text != @"0")
            {
                TxtSearchP6.Focus();
                TxtSearchP6.SelectAll();
            }
        }

        private void TxtSearchP1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtSearchP2.Focus();
                TxtSearchP2.SelectAll();
            }
        }

        private void TxtSearchP2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtSearchP3.Focus();
                TxtSearchP3.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtSearchP1.Focus();
                TxtSearchP1.SelectAll();
            }
        }

        private void TxtSearchP3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtSearchP4.Focus();
                TxtSearchP4.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtSearchP2.Focus();
                TxtSearchP2.SelectAll();
            }
        }

        private void TxtSearchP4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtSearchP5.Focus();
                TxtSearchP5.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtSearchP3.Focus();
                TxtSearchP3.SelectAll();
            }
        }

        private void TxtSearchP5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                TxtSearchP6.Focus();
                TxtSearchP6.SelectAll();
            }
            else if (e.KeyCode == Keys.Left)
            {
                TxtSearchP4.Focus();
                TxtSearchP4.SelectAll();
            }
        }

        private void TxtSearchP6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                TxtSearchP5.Focus();
                TxtSearchP5.SelectAll();
            }
        }
    }
}
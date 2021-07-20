using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class VipControlForm : XtraForm
    {
        public TblAgent Agent;
        private TblVip _currentVip;

        public VipControlForm()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                AddVip form = new AddVip { Effect = 0 };
                form.BtnAdd.Visible = true;
                if (form.ShowDialog() == DialogResult.OK)
                    vipViewTableAdapter.Fill(vipGrid.VipView);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void VipControlForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainAppMenu form = new MainAppMenu { Agent = Agent };
                form.Show();
                Hide();
            }
        }

        private void VipControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VipControlForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vipGrid.VipView' table. You can move, or remove it, as needed.
            vipViewTableAdapter.Fill(vipGrid.VipView);
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                AddVip form = new AddVip { Effect = 2, CurrentVip = _currentVip };
                if (form.ShowDialog() == DialogResult.OK)
                    vipViewTableAdapter.Fill(vipGrid.VipView);
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
                AddVip form = new AddVip { Effect = 1, CurrentVip = _currentVip };
                if (form.ShowDialog() == DialogResult.OK)
                    vipViewTableAdapter.Fill(vipGrid.VipView);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void GridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowHandle = gridView1.FocusedRowHandle;
                _currentVip = new TblVip
                {
                    Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "کد")),
                    FirstName = gridView1.GetRowCellValue(rowHandle, "نام").ToString(),
                    LastName = gridView1.GetRowCellValue(rowHandle, "نام خانوادگی").ToString(),
                    TimeHoldFrom = DateTime.Parse(gridView1.GetRowCellValue(rowHandle, "زمان آمدن").ToString()),
                    TimeHoldTo = DateTime.Parse(gridView1.GetRowCellValue(rowHandle, "زمان رفتن").ToString()),
                    Floor = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "طبقه")),
                    Column = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "سطر")),
                    Row = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "ستون")),
                    PositionId = gridView1.GetRowCellValue(rowHandle, "کد مکان").ToString(),
                    VehicleId = gridView1.GetRowCellValue(rowHandle, "پلاک").ToString(),
                    ProgrammId = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "کد تعرفه"))
                };
                AddVip form = new AddVip { Effect = 2, CurrentVip = _currentVip };
                form.BtnEdit.Visible = true;
                form.BtnDelete.Visible = true;
                if (form.ShowDialog() == DialogResult.OK)
                    vipViewTableAdapter.Fill(vipGrid.VipView);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}

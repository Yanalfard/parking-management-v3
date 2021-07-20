using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Diagnostics;
using Parking_Management_V3.Controllers;

namespace Parking_Management_V3.Views
{
    public partial class BackGroundControll : XtraForm
    {
        public Image BgImage;

        public BackGroundControll()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DlgBackGround.Filter = "Image files | *.jpg";
                DlgBackGround.Title = "انتخاب_عکس";
                if (DlgBackGround.ShowDialog() == DialogResult.OK)
                {
                    BgImage = Image.FromFile(DlgBackGround.FileName);
                    Heart heart = new Heart();
                    DialogResult = heart.UpdateBgImg(DlgBackGround.FileName) ? DialogResult.OK : DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("لطفا پس از اتمام رسم تصویر مورد نظر آن را انتخاب کنید", "توجه",
                        MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Process process = Process.Start("mspaint.exe");
                    if (process != null)
                    {
                        process.WaitForExit();
                        DlgBackGround.Filter = "Image files | *.jpg";
                        DlgBackGround.Title = "انتخاب_عکس_نقاشی_شده";
                        if (DlgBackGround.ShowDialog() == DialogResult.OK)
                        {
                            BgImage = Image.FromFile(DlgBackGround.FileName);
                            Heart heart = new Heart();
                            DialogResult = heart.UpdateBgImg(DlgBackGround.FileName) ? DialogResult.OK : DialogResult.Retry;
                        }
                    }
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BackGroundControll_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void BackGroundControll_Load(object sender, EventArgs e)
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

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("آیا مطمعن به حذف پس زمینه هستید", "توجه",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    BgImage = null;
                    Heart heart = new Heart();
                    DialogResult = heart.UpdateBgImg("nothing") ? DialogResult.OK : DialogResult.Retry;
                    DialogResult = DialogResult.OK;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
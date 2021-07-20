using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;

namespace Parking_Management_V3.Views
{
    public partial class LicenceForm : XtraForm
    {
        public LicenceForm()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                if (!MethodRepo.IsLicenseValid(TxtHash.Text))
                    XtraMessageBox.Show("کد فعالسازی اشتباه است", "اخطار");
                else
                    if (MethodRepo.AddLicenseToDb(TxtName.Text, TxtIdentification.Text, TxtHash.Text,
                        MethodRepo.GetNistTime()))
                {
                    XtraMessageBox.Show("فعالسازی با موفقیت انجام شد", "تبریک");
                    Application.Restart();
                }
            }
            catch
            {
                XtraMessageBox.Show("کد فعالسازی اشتباه است", "اخطار");
            }
        }

        private void LicenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LicenceForm_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }
    }
}
using System;
using System.Windows.Forms;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class LevelUpForm : DevExpress.XtraEditors.XtraForm
    {
        public LevelUpForm()
        {
            InitializeComponent();
        }
        public TblAgent Agent;
        public int Level;
        public long TotalXp;
        private void LevelUpForm_Load(object sender, EventArgs e)
        {
            LblAll.Text = $"تبریک شما وارد سطح {Level} شدید";
        }

        private void LevelUpForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
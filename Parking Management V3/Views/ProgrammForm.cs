using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class ProgrammForm : XtraForm
    {
        public TblProgramm Programm;
        public ProgrammForm()
        {
            InitializeComponent();
        }

        private void CreateBtn(TblProgramm programm)
        {
            SimpleButton btn = new SimpleButton();
            btn.Size = new Size(272, 172);
            btn.Font = new Font("Tahoma", 10);
            btn.Text = programm.Name + "\n\r" + programm.TimeHold + " Day\n\r" + programm.Price + " T";
            ToolTip tip = new ToolTip();
            btn.Name = programm.Id.ToString();
            btn.DoubleClick += Btn_Double_Click;
            btn.Click += Btn_Click;
            tip.SetToolTip(btn, programm.Discription);
            FlowBtns.Controls.Add(btn);
        }

        private void ProgrammForm_Load(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
                List<TblProgramm> programms = heart.FetchAllProgramms();
                foreach (TblProgramm programm in programms)
                    CreateBtn(programm);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            SimpleButton btn = (SimpleButton)sender;
            btn.Focus();
        }

        private void Btn_Double_Click(object sender, EventArgs e)
        {
            try
            {
                SimpleButton btn = (SimpleButton)sender;
                string[] names = btn.Text.Split('\n');
                Programm = new TblProgramm
                {
                    Id = Convert.ToInt32(btn.Name),
                    Name = names[0],
                    TimeHold = Convert.ToInt32(names[1].Split(' ')[0]),
                    Price = long.Parse(names[2].Split(' ')[0])
                };
                DialogResult = DialogResult.OK;
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddProgrammForm form = new AddProgrammForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Heart heart = new Heart();
                    TblProgramm programm = new TblProgramm { Name = form.Programm.Name };
                    CreateBtn(heart.FetchProgrammWithName(programm));
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
                foreach (SimpleButton btn in FlowBtns.Controls)
                    if (btn.Focused)
                    {
                        TblProgramm programm = new TblProgramm { Id = Convert.ToInt32(btn.Name) };
                        Heart heart = new Heart();
                        if (!heart.DeleteProgramm(programm))
                            XtraMessageBox.Show("از این تعرفه یک بار استفاده شده است نمیتوان آن را حذف کرد برای حذف به بخش افراد ویژه مراجعه کرده و مورد استفاده شده را پاک نمایید و دوباره امتحان کنید", "اخطار");
                        else
                        {
                            FlowBtns.Controls.Clear();
                            ProgrammForm_Load(sender, e);
                        }
                    }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void ProgrammForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
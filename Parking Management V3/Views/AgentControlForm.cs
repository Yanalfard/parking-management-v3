using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class AgentControlForm : XtraForm
    {
        public TblAgent Agent;
        private TblAgent _currenAgent;
        public AgentControlForm()
        {
            InitializeComponent();
        }

        private void AgentControlForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agentGrid.AgentView' table. You can move, or remove it, as needed.
            agentViewTableAdapter.Fill(agentGrid.AgentView);
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }

        private void AgentControlForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                AddAgent form = new AddAgent
                {
                    Agent = Agent,
                    Effect = 0
                };
                form.BtnSubmit.Visible = true;
                if (form.ShowDialog() == DialogResult.OK)
                    agentViewTableAdapter.Fill(agentGrid.AgentView);
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void AgentControlForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MainAppMenu a = new MainAppMenu { Agent = Agent };
                a.Show();
                Hide();
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                int rowHandle = gridView1.FocusedRowHandle;
                _currenAgent = new TblAgent
                {
                    Id = Convert.ToInt32(gridView1.GetRowCellValue(rowHandle, "کد")),
                    Identification = long.Parse(gridView1.GetRowCellValue(rowHandle, "کد ملی").ToString()),
                    FirstName = gridView1.GetRowCellValue(rowHandle, "نام").ToString(),
                    LastName = gridView1.GetRowCellValue(rowHandle, "نام خانوادگی").ToString(),
                    Username = gridView1.GetRowCellValue(rowHandle, "نام کاربری").ToString(),
                    Password = gridView1.GetRowCellValue(rowHandle, "رمز عبور").ToString(),
                    ImageSrc = gridView1.GetRowCellValue(rowHandle, "محل عکس").ToString()
                };
                if (_currenAgent == null)
                {
                    XtraMessageBox.Show("مورد اول باید انتخاب شود");
                }
                else
                {
                    AddAgent form = new AddAgent
                    {
                        Agent = Agent,
                        Effect = 2,
                        CurrenAgent = _currenAgent
                    };
                    form.BtnDelete.Visible = true;
                    form.BtnEdit.Visible = true;
                    if (form.ShowDialog() == DialogResult.OK)
                        agentViewTableAdapter.Fill(agentGrid.AgentView);
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
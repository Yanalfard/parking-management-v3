using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using TblAgent = Parking_Management_V3.Models.TblAgent;

namespace Parking_Management_V3.Views
{
    public partial class AddAgent : XtraForm
    {
        public TblAgent Agent;
        public int Effect;
        public TblAgent CurrenAgent;
        public AddAgent()
        {
            InitializeComponent();
        }

        private void AddAgent_Load(object sender, EventArgs e)
        {
            try
            {
                Heart heart = new Heart();
                string themSrc = heart.FetchThem();
                if (themSrc != "")
                    LookAndFeel.SkinName = themSrc;
                else
                    heart.InsertBaseSource();
                if (Effect == 1 || Effect == 2)
                {
                    TxtIdentification.Text = CurrenAgent.Identification.ToString();
                    TxtIdentification.Text = CurrenAgent.Identification.ToString();
                    TxtFirstName.Text = CurrenAgent.FirstName;
                    TxtLastName.Text = CurrenAgent.LastName;
                    TxtUsername.Text = CurrenAgent.Username;
                    TxtPassword.Text = CurrenAgent.Password;
                    if (CurrenAgent.ImageSrc != "")
                        pictureEdit1.Image = Image.FromFile(CurrenAgent.ImageSrc);
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void AddAgent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Hide();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (xtraOpenFileDialog1.ShowDialog() == DialogResult.OK)
                    pictureEdit1.Image = Image.FromFile(xtraOpenFileDialog1.FileName);
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
                Err.ClearErrors();
                if (TxtFirstName.Text == "")
                {
                    Err.SetError(TxtFirstName, "این فیلد خالی است");
                    TxtFirstName.Focus();
                }
                else if (TxtLastName.Text == "")
                {
                    Err.SetError(TxtLastName, "این فیلد خالی است");
                    TxtLastName.Focus();
                }
                else if (TxtIdentification.Text == "")
                {
                    Err.SetError(TxtIdentification, "این فیلد خالی است");
                    TxtIdentification.Focus();
                }
                else if (TxtUsername.Text == "")
                {
                    Err.SetError(TxtUsername, "این فیلد خالی است");
                    TxtUsername.Focus();
                }
                else if (TxtPassword.Text == "")
                {
                    Err.SetError(TxtPassword, "این فیلد خالی است");
                    TxtPassword.Focus();
                }
                else
                {
                    TblAgent agent = new TblAgent();

                    agent.Identification = long.Parse(TxtIdentification.Text);
                    agent.FirstName = TxtFirstName.Text;
                    agent.LastName = TxtLastName.Text;
                    agent.Username = TxtUsername.Text;
                    agent.Password = TxtPassword.Text;
                    if (xtraOpenFileDialog1.FileName != "xtraOpenFileDialog1")
                    {
                        agent.ImageSrc = xtraOpenFileDialog1.FileName;
                    }
                    else if (CurrenAgent != null)
                    {
                        agent.ImageSrc = CurrenAgent.ImageSrc;
                    }
                    else
                    {
                        agent.ImageSrc = "";
                    }
                    Heart heart = new Heart();
                    DialogResult = heart.AddAgent(agent) ? DialogResult.OK : DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            CurrenAgent.ImageSrc = "";
            xtraOpenFileDialog1.FileName = "";
            pictureEdit1.Image = null;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtFirstName.Text == "")
                {
                    Err.SetError(TxtFirstName, "این فیلد خالی است");
                    TxtFirstName.Focus();
                }
                else if (TxtLastName.Text == "")
                {
                    Err.SetError(TxtLastName, "این فیلد خالی است");
                    TxtLastName.Focus();
                }
                else if (TxtIdentification.Text == "")
                {
                    Err.SetError(TxtIdentification, "این فیلد خالی است");
                    TxtIdentification.Focus();
                }
                else if (TxtUsername.Text == "")
                {
                    Err.SetError(TxtUsername, "این فیلد خالی است");
                    TxtUsername.Focus();
                }
                else if (TxtPassword.Text == "")
                {
                    Err.SetError(TxtPassword, "این فیلد خالی است");
                    TxtPassword.Focus();
                }
                else
                {
                    TblAgent agent = new TblAgent();

                    agent.Identification = long.Parse(TxtIdentification.Text);
                    agent.FirstName = TxtFirstName.Text;
                    agent.LastName = TxtLastName.Text;
                    agent.Username = TxtUsername.Text;
                    agent.Password = TxtPassword.Text;
                    if (xtraOpenFileDialog1.FileName != "xtraOpenFileDialog1")
                    {
                        agent.ImageSrc = xtraOpenFileDialog1.FileName;
                    }
                    else if (CurrenAgent.ImageSrc != "")
                    {
                        agent.ImageSrc = CurrenAgent.ImageSrc;
                    }
                    else
                    {
                        agent.ImageSrc = "";
                    }
                    Heart heart = new Heart();
                    DialogResult = heart.EditAgent(agent, new TblAgent { Identification = CurrenAgent.Identification }) ? DialogResult.OK : DialogResult.Retry;
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
                if (CurrenAgent.Identification == 0)
                {
                    XtraMessageBox.Show("مورد اول باید انتخاب شود");
                }
                else
                {
                    Heart heart = new Heart();
                    TblAgent agent = new TblAgent { Identification = CurrenAgent.Identification };
                    DialogResult = heart.DeleteAgent(agent) ? DialogResult.OK : DialogResult.Retry;
                }
            }
            catch
            {
                XtraMessageBox.Show("خطا رخ داده لطفا دوباره سعی کنید", "اخطار");
            }
        }
    }
}
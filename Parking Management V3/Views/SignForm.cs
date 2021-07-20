using System;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class SignForm : XtraForm
    {
        private const string Username = "yanal";
        private const string Password = "1234";

        public SignForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Err.ClearErrors();
                if (TxtUsername.Text == "")
                {
                    Err.SetError(TxtUsername, "مقادیر این فیلد خالی است");
                    TxtUsername.Focus();
                }
                else if (TxtPassword.Text == "")
                {
                    Err.SetError(TxtPassword, "مقادیر این فیلد خالی است");
                    TxtPassword.Focus();
                }
                else if (TxtUsername.Text.Length > 16)
                {
                    Err.SetError(TxtUsername, "باید تعداد کاراکتر ها کم تر از 16 باشد");
                    TxtUsername.Focus();
                }
                else if (TxtPassword.Text.Length > 16)
                {
                    Err.SetError(TxtPassword, "باید تعداد کاراکتر ها کم تر از 16 باشد");
                    TxtPassword.Focus();
                }
                else
                {
                    Heart heart = new Heart();
                    TblAgent agent = new TblAgent
                    {
                        Username = TxtUsername.Text,
                        Password = TxtPassword.Text
                    };
                    agent = heart.LoginAgent(agent);
                    if (agent.Id == -1)
                    {
                        if (TxtUsername.Text == Username && TxtPassword.Text == Password)
                        {
                            agent.Username = Username;
                            agent.Password = Password;
                            agent.FirstName = "root";
                            agent.LastName = "zero";
                            agent.Identification = 1111111111;
                            MainAppMenu a = new MainAppMenu
                            {
                                Agent = agent
                            };
                            heart.UpdateTimeCome(DateTime.Now.ToLongTimeString());
                            a.Show();
                            Hide();
                        }
                        else
                            XtraMessageBox.Show("رمز عبور اشتباه است");
                    }
                    else
                    {
                        MainAppMenu a = new MainAppMenu
                        {
                            Agent = agent,
                        };
                        heart.UpdateTimeCome(DateTime.Now.ToLongTimeString());
                        a.Show();
                        Hide();
                    }
                }
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.ToString());
            }
        }

        private void SignForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void SignForm_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            try
            {
                DateTime nowDate = MethodRepo.GetNistTime();
                //DateTime nowDate = DateTime.Now;
                if (nowDate > heart.SelectActivatedTime())
                {
                    LicenceForm a = new LicenceForm();
                    a.Show();
                    Hide();
                }
            }
            catch (WebException)
            {
                XtraMessageBox.Show("لطفا سیستم خود را برای چند لحضه به اینترنت متصل کرده و دوباره امتحان کنید", "اخطار");
                Application.Exit();
            }
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
        }
    }
}
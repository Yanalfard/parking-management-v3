using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Parking_Management_V3.Controllers;
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    public partial class CheckForUpdateForm : XtraForm
    {
        public TblAgent Agent;
        private bool _isUpdateRequired = true;
        private string _lastVersion;
        private string _fileName;

        public CheckForUpdateForm()
        {
            InitializeComponent();
        }

        private void CheckForUpdateForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                SettingMenu a = new SettingMenu { Agent = Agent };
                a.Show();
                Hide();
            }
        }

        private void CheckForUpdateForm_Load(object sender, EventArgs e)
        {
            Heart heart = new Heart();
            string themSrc = heart.FetchThem();
            if (themSrc != "")
                LookAndFeel.SkinName = themSrc;
            else
                heart.InsertBaseSource();
            //-------------------------------------
            //string s4 = new DirectoryInfo(Application.StartupPath).Parent.Parent.Parent.Parent.FullName;
        }

        private void CheckForUpdateForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                //-------get sql start
                SqlConnection connection = new SqlConnection("Data Source=109.169.76.76;Initial Catalog=tabrizhe_ParkingCore;Persist Security Info=True;User ID=tabrizhe_core;Password=1710ahmad.fard");
                connection.Open();
                SqlCommand command = new SqlCommand($"select Version from TblSource", connection);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                _lastVersion = reader[0].ToString();
                reader.Close();
                reader.Dispose();
                connection.Close();
                //-----get file sql end
                string downloadUrl = $"https://tabrizhealthtourism.com/yanalV{_lastVersion}.zip";
                //string downloadUrl = $"http://nashid.ir/dl/c995";
                string applicationVersion = Application.ProductVersion;
                //_fileName = downloadUrl.Split('/')[downloadUrl.Split('/').Length - 1].Replace('%', ' ');
                _fileName = Path.GetTempFileName();

                WebClient downloader = new WebClient();
                downloader.DownloadProgressChanged += downloader_DownloadProgressChanged;
                downloader.DownloadFileCompleted += downloader_DownloadProgressComplete;
                if (int.Parse(applicationVersion.Split('.')[0]) < int.Parse(_lastVersion.Split('.')[0]))
                {
                    downloader.DownloadFileAsync(
                        new Uri(downloadUrl),
                        $"{_fileName}"
                    );
                }
                else if (int.Parse(applicationVersion.Split('.')[0]) == int.Parse(_lastVersion.Split('.')[0]) &&
                         int.Parse(applicationVersion.Split('.')[1]) < int.Parse(_lastVersion.Split('.')[1]))
                {
                    downloader.DownloadFileAsync(
                        new Uri(downloadUrl),
                        $"{_fileName}"
                    );
                }
                else if (int.Parse(applicationVersion.Split('.')[0]) == int.Parse(_lastVersion.Split('.')[0]) &&
                         int.Parse(applicationVersion.Split('.')[1]) == int.Parse(_lastVersion.Split('.')[1]) &&
                         int.Parse(applicationVersion.Split('.')[2]) < int.Parse(_lastVersion.Split('.')[2]))
                {
                    downloader.DownloadFileAsync(
                        new Uri(downloadUrl),
                        $"{_fileName}"
                    );
                }
                else if (int.Parse(applicationVersion.Split('.')[0]) == int.Parse(_lastVersion.Split('.')[0]) &&
                         int.Parse(applicationVersion.Split('.')[1]) == int.Parse(_lastVersion.Split('.')[1]) &&
                         int.Parse(applicationVersion.Split('.')[2]) == int.Parse(_lastVersion.Split('.')[2]) &&
                         int.Parse(applicationVersion.Split('.')[3]) < int.Parse(_lastVersion.Split('.')[3]))
                {
                    downloader.DownloadFileAsync(
                        new Uri(downloadUrl),
                        $"{_fileName}"
                    );
                }
                else
                {
                    _isUpdateRequired = true;
                    LblContext.Visible = true;
                }


            }
            catch
            {
                if (XtraMessageBox.Show("مشکلی در برقراری اتصال پیش آمده آیا میخواهید دوباره امتحان کنید؟", "اخطار",
                    MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    BtnDownload_Click(sender, e);
                }
                // ignored
            }
        }

        private void downloader_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            PrbUpdate.Position = e.ProgressPercentage;
        }

        private void downloader_DownloadProgressComplete(object sender, AsyncCompletedEventArgs e)
        {
            //Heart heart = new Heart();
            if (_isUpdateRequired)
            {
                //string applicationPath = Application.StartupPath + "\\" + _fileName;
                //string updateFileLocation = Application.StartupPath + "\\Update";
                if (Directory.Exists(Application.StartupPath + "\\Update"))
                {
                    DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + "\\Update");
                    dir.Delete(true);
                }
                //ZipFile.ExtractToDirectory(applicationPath, updateFileLocation);
                //MethodRepo.CopyDirectory(updateFileLocation, Application.CommonAppDataPath);
                //heart.UpdateIsUpdateReady(true);
                //heart.UpdateUpdateFileLocation(Application.CommonAppDataPath);
                //heart.UpdateCurrentFileLocation()
            }
        }
    }
}
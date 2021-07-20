namespace Parking_Management_V3.Views
{
    partial class MainAppMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.BtnMain = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.LblId = new DevExpress.XtraEditors.LabelControl();
            this.LblName = new DevExpress.XtraEditors.LabelControl();
            this.ImgAgentImage = new DevExpress.XtraEditors.PictureEdit();
            this.BtnSettings = new DevExpress.XtraEditors.SimpleButton();
            this.BtnConsole = new DevExpress.XtraEditors.SimpleButton();
            this.BtnAgentControl = new DevExpress.XtraEditors.SimpleButton();
            this.BtnVip = new DevExpress.XtraEditors.SimpleButton();
            this.BtnFund = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAgentImage.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(294, -10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(443, 84);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "خوش آمدید کاربر گرامی";
            // 
            // BtnMain
            // 
            this.BtnMain.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnMain.Appearance.Options.UseFont = true;
            this.BtnMain.Location = new System.Drawing.Point(515, 235);
            this.BtnMain.Margin = new System.Windows.Forms.Padding(2);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(479, 91);
            this.BtnMain.TabIndex = 1;
            this.BtnMain.Text = "صفحه ی اصلی";
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LblId);
            this.groupControl1.Controls.Add(this.LblName);
            this.groupControl1.Controls.Add(this.ImgAgentImage);
            this.groupControl1.Location = new System.Drawing.Point(10, 78);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(984, 143);
            this.groupControl1.TabIndex = 2;
            // 
            // LblId
            // 
            this.LblId.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.LblId.Appearance.Options.UseFont = true;
            this.LblId.Location = new System.Drawing.Point(348, 80);
            this.LblId.Margin = new System.Windows.Forms.Padding(2);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(201, 64);
            this.LblId.TabIndex = 1;
            this.LblId.Text = " : کد ملی کاربر";
            // 
            // LblName
            // 
            this.LblName.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.LblName.Appearance.Options.UseFont = true;
            this.LblName.Location = new System.Drawing.Point(381, 15);
            this.LblName.Margin = new System.Windows.Forms.Padding(2);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(165, 64);
            this.LblName.TabIndex = 1;
            this.LblName.Text = " : نام کاربری";
            // 
            // ImgAgentImage
            // 
            this.ImgAgentImage.Location = new System.Drawing.Point(5, 5);
            this.ImgAgentImage.Margin = new System.Windows.Forms.Padding(2);
            this.ImgAgentImage.Name = "ImgAgentImage";
            this.ImgAgentImage.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.ImgAgentImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.ImgAgentImage.Size = new System.Drawing.Size(139, 131);
            this.ImgAgentImage.TabIndex = 0;
            // 
            // BtnSettings
            // 
            this.BtnSettings.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSettings.Appearance.Options.UseFont = true;
            this.BtnSettings.Location = new System.Drawing.Point(10, 448);
            this.BtnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(479, 91);
            this.BtnSettings.TabIndex = 4;
            this.BtnSettings.Text = "تنظیمات";
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // BtnConsole
            // 
            this.BtnConsole.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnConsole.Appearance.Options.UseFont = true;
            this.BtnConsole.Location = new System.Drawing.Point(515, 442);
            this.BtnConsole.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsole.Name = "BtnConsole";
            this.BtnConsole.Size = new System.Drawing.Size(479, 91);
            this.BtnConsole.TabIndex = 3;
            this.BtnConsole.Text = "اطلاعات خودرو ها و مشتری ها";
            this.BtnConsole.Click += new System.EventHandler(this.BtnConsole_Click);
            // 
            // BtnAgentControl
            // 
            this.BtnAgentControl.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAgentControl.Appearance.Options.UseFont = true;
            this.BtnAgentControl.Location = new System.Drawing.Point(515, 338);
            this.BtnAgentControl.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAgentControl.Name = "BtnAgentControl";
            this.BtnAgentControl.Size = new System.Drawing.Size(479, 91);
            this.BtnAgentControl.TabIndex = 2;
            this.BtnAgentControl.Text = "ناحیه ی کاربری";
            this.BtnAgentControl.Click += new System.EventHandler(this.BtnAgentControl_Click);
            // 
            // BtnVip
            // 
            this.BtnVip.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnVip.Appearance.Options.UseFont = true;
            this.BtnVip.Location = new System.Drawing.Point(10, 235);
            this.BtnVip.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVip.Name = "BtnVip";
            this.BtnVip.Size = new System.Drawing.Size(479, 91);
            this.BtnVip.TabIndex = 4;
            this.BtnVip.Text = "افراد ویژه";
            this.BtnVip.Click += new System.EventHandler(this.BtnVip_Click);
            // 
            // BtnFund
            // 
            this.BtnFund.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnFund.Appearance.Options.UseFont = true;
            this.BtnFund.Location = new System.Drawing.Point(10, 340);
            this.BtnFund.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFund.Name = "BtnFund";
            this.BtnFund.Size = new System.Drawing.Size(479, 91);
            this.BtnFund.TabIndex = 4;
            this.BtnFund.Text = "صندوق";
            this.BtnFund.Click += new System.EventHandler(this.BtnFund_Click);
            // 
            // MainAppMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1030, 593);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.BtnAgentControl);
            this.Controls.Add(this.BtnConsole);
            this.Controls.Add(this.BtnVip);
            this.Controls.Add(this.BtnFund);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.BtnMain);
            this.Controls.Add(this.labelControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainAppMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " منو ی اصلی";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainAppMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainAppMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainAppMenu_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgAgentImage.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnMain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl LblName;
        private DevExpress.XtraEditors.PictureEdit ImgAgentImage;
        private DevExpress.XtraEditors.LabelControl LblId;
        private DevExpress.XtraEditors.SimpleButton BtnSettings;
        private DevExpress.XtraEditors.SimpleButton BtnConsole;
        private DevExpress.XtraEditors.SimpleButton BtnAgentControl;
        private DevExpress.XtraEditors.SimpleButton BtnVip;
        private DevExpress.XtraEditors.SimpleButton BtnFund;
    }
}
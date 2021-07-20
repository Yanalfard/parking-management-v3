namespace Parking_Management_V3.Views
{
    partial class RestorSetting
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
            this.components = new System.ComponentModel.Container();
            this.simpleButton8 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.BtnBackUp = new DevExpress.XtraEditors.SimpleButton();
            this.Saver = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.SuspendLayout();
            // 
            // simpleButton8
            // 
            this.simpleButton8.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton8.Appearance.Options.UseFont = true;
            this.simpleButton8.Location = new System.Drawing.Point(11, 11);
            this.simpleButton8.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton8.Name = "simpleButton8";
            this.simpleButton8.Size = new System.Drawing.Size(478, 93);
            this.simpleButton8.TabIndex = 3;
            this.simpleButton8.Text = "بازنشانی جدول خودرو و مشتری";
            this.simpleButton8.Click += new System.EventHandler(this.simpleButton8_Click);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(518, 246);
            this.simpleButton7.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(478, 93);
            this.simpleButton7.TabIndex = 2;
            this.simpleButton7.Text = "بازنشانی جدول کاربران";
            this.simpleButton7.Click += new System.EventHandler(this.simpleButton7_Click);
            // 
            // simpleButton6
            // 
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.Location = new System.Drawing.Point(518, 129);
            this.simpleButton6.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(478, 93);
            this.simpleButton6.TabIndex = 1;
            this.simpleButton6.Text = "بازنشانی پایگاه داده";
            this.simpleButton6.Click += new System.EventHandler(this.simpleButton6_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Location = new System.Drawing.Point(518, 11);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(478, 93);
            this.simpleButton5.TabIndex = 0;
            this.simpleButton5.Text = "بازنشانی طبقات و جاهای پارک";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRestore.Appearance.Options.UseFont = true;
            this.BtnRestore.Location = new System.Drawing.Point(11, 246);
            this.BtnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(478, 93);
            this.BtnRestore.TabIndex = 5;
            this.BtnRestore.Text = "استفاده از داده پشتیبان";
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // BtnBackUp
            // 
            this.BtnBackUp.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnBackUp.Appearance.Options.UseFont = true;
            this.BtnBackUp.Location = new System.Drawing.Point(11, 129);
            this.BtnBackUp.Margin = new System.Windows.Forms.Padding(2);
            this.BtnBackUp.Name = "BtnBackUp";
            this.BtnBackUp.Size = new System.Drawing.Size(478, 93);
            this.BtnBackUp.TabIndex = 4;
            this.BtnBackUp.Text = "پشتیبان گیری داده ها";
            this.BtnBackUp.Click += new System.EventHandler(this.BtnBackUp_Click);
            // 
            // Saver
            // 
            this.Saver.FileName = "Saver";
            // 
            // RestorSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1050, 403);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnBackUp);
            this.Controls.Add(this.simpleButton8);
            this.Controls.Add(this.simpleButton7);
            this.Controls.Add(this.simpleButton6);
            this.Controls.Add(this.simpleButton5);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "RestorSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات بازنشانی";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RestorSetting_FormClosed);
            this.Load += new System.EventHandler(this.RestorSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RestorSetting_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton8;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton BtnRestore;
        private DevExpress.XtraEditors.SimpleButton BtnBackUp;
        private DevExpress.XtraEditors.XtraSaveFileDialog Saver;
    }
}
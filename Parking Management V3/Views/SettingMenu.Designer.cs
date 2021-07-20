namespace Parking_Management_V3.Views
{
    partial class SettingMenu
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
            this.BtnFloor = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSpot = new DevExpress.XtraEditors.SimpleButton();
            this.BtnRestore = new DevExpress.XtraEditors.SimpleButton();
            this.BtnThem = new DevExpress.XtraEditors.SimpleButton();
            this.BtnPolicy = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCheckForUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // BtnFloor
            // 
            this.BtnFloor.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnFloor.Appearance.Options.UseFont = true;
            this.BtnFloor.Location = new System.Drawing.Point(487, 26);
            this.BtnFloor.Margin = new System.Windows.Forms.Padding(2);
            this.BtnFloor.Name = "BtnFloor";
            this.BtnFloor.Size = new System.Drawing.Size(396, 97);
            this.BtnFloor.TabIndex = 0;
            this.BtnFloor.Text = "تنظیمات طبقات";
            this.BtnFloor.Click += new System.EventHandler(this.BtnFloor_Click);
            // 
            // BtnSpot
            // 
            this.BtnSpot.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSpot.Appearance.Options.UseFont = true;
            this.BtnSpot.Location = new System.Drawing.Point(487, 186);
            this.BtnSpot.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSpot.Name = "BtnSpot";
            this.BtnSpot.Size = new System.Drawing.Size(396, 97);
            this.BtnSpot.TabIndex = 1;
            this.BtnSpot.Text = "تنظیمات جاهای پارک";
            this.BtnSpot.Click += new System.EventHandler(this.BtnSpot_Click);
            // 
            // BtnRestore
            // 
            this.BtnRestore.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnRestore.Appearance.Options.UseFont = true;
            this.BtnRestore.Location = new System.Drawing.Point(487, 352);
            this.BtnRestore.Margin = new System.Windows.Forms.Padding(2);
            this.BtnRestore.Name = "BtnRestore";
            this.BtnRestore.Size = new System.Drawing.Size(396, 97);
            this.BtnRestore.TabIndex = 2;
            this.BtnRestore.Text = "تنظیمات بازنشانی نرم افزار";
            this.BtnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // BtnThem
            // 
            this.BtnThem.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnThem.Appearance.Options.UseFont = true;
            this.BtnThem.Location = new System.Drawing.Point(27, 26);
            this.BtnThem.Margin = new System.Windows.Forms.Padding(2);
            this.BtnThem.Name = "BtnThem";
            this.BtnThem.Size = new System.Drawing.Size(396, 97);
            this.BtnThem.TabIndex = 3;
            this.BtnThem.Text = "تنظیمات تم";
            this.BtnThem.Click += new System.EventHandler(this.BtnThem_Click);
            // 
            // BtnPolicy
            // 
            this.BtnPolicy.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnPolicy.Appearance.Options.UseFont = true;
            this.BtnPolicy.Location = new System.Drawing.Point(27, 186);
            this.BtnPolicy.Margin = new System.Windows.Forms.Padding(2);
            this.BtnPolicy.Name = "BtnPolicy";
            this.BtnPolicy.Size = new System.Drawing.Size(396, 97);
            this.BtnPolicy.TabIndex = 5;
            this.BtnPolicy.Text = "تنظیمات تعرفه ها";
            this.BtnPolicy.Click += new System.EventHandler(this.BtnPolicy_Click);
            // 
            // BtnCheckForUpdate
            // 
            this.BtnCheckForUpdate.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnCheckForUpdate.Appearance.Options.UseFont = true;
            this.BtnCheckForUpdate.Location = new System.Drawing.Point(27, 352);
            this.BtnCheckForUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCheckForUpdate.Name = "BtnCheckForUpdate";
            this.BtnCheckForUpdate.Size = new System.Drawing.Size(396, 97);
            this.BtnCheckForUpdate.TabIndex = 6;
            this.BtnCheckForUpdate.Text = "آپدیت نرم افزار";
            this.BtnCheckForUpdate.Click += new System.EventHandler(this.BtnCheckForUpdate_Click);
            // 
            // SettingMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.Controls.Add(this.BtnCheckForUpdate);
            this.Controls.Add(this.BtnPolicy);
            this.Controls.Add(this.BtnThem);
            this.Controls.Add(this.BtnRestore);
            this.Controls.Add(this.BtnSpot);
            this.Controls.Add(this.BtnFloor);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "SettingMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "منوی تنظیمات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingMenu_FormClosed);
            this.Load += new System.EventHandler(this.SettingMenu_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingMenu_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnFloor;
        private DevExpress.XtraEditors.SimpleButton BtnSpot;
        private DevExpress.XtraEditors.SimpleButton BtnRestore;
        private DevExpress.XtraEditors.SimpleButton BtnThem;
        private DevExpress.XtraEditors.SimpleButton BtnPolicy;
        private DevExpress.XtraEditors.SimpleButton BtnCheckForUpdate;
    }
}
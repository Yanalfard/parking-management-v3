namespace Parking_Management_V3.Views
{
    partial class SignForm
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
            this.TxtUsername = new DevExpress.XtraEditors.TextEdit();
            this.LblUsername = new DevExpress.XtraEditors.LabelControl();
            this.TxtPassword = new DevExpress.XtraEditors.TextEdit();
            this.LblPassword = new DevExpress.XtraEditors.LabelControl();
            this.BtnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.EditValue = "yanal";
            this.TxtUsername.Location = new System.Drawing.Point(85, 70);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(536, 50);
            this.TxtUsername.TabIndex = 0;
            // 
            // LblUsername
            // 
            this.LblUsername.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblUsername.Appearance.Options.UseFont = true;
            this.LblUsername.LineLocation = DevExpress.XtraEditors.LineLocation.Right;
            this.LblUsername.Location = new System.Drawing.Point(652, 66);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(139, 64);
            this.LblUsername.TabIndex = 1;
            this.LblUsername.Text = "نام کاربری";
            // 
            // TxtPassword
            // 
            this.TxtPassword.EditValue = "1234";
            this.TxtPassword.Location = new System.Drawing.Point(85, 205);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Properties.UseSystemPasswordChar = true;
            this.TxtPassword.Size = new System.Drawing.Size(536, 50);
            this.TxtPassword.TabIndex = 1;
            // 
            // LblPassword
            // 
            this.LblPassword.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblPassword.Appearance.Options.UseFont = true;
            this.LblPassword.LineLocation = DevExpress.XtraEditors.LineLocation.Right;
            this.LblPassword.Location = new System.Drawing.Point(652, 201);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(123, 64);
            this.LblPassword.TabIndex = 1;
            this.LblPassword.Text = "رمز عبود";
            // 
            // BtnLogin
            // 
            this.BtnLogin.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnLogin.Appearance.Options.UseFont = true;
            this.BtnLogin.Location = new System.Drawing.Point(267, 332);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(335, 75);
            this.BtnLogin.TabIndex = 2;
            this.BtnLogin.Text = "ورود";
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(846, 506);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.TxtUsername);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "SignForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرم کاربر";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignForm_FormClosed);
            this.Load += new System.EventHandler(this.SignForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtUsername;
        private DevExpress.XtraEditors.LabelControl LblUsername;
        private DevExpress.XtraEditors.TextEdit TxtPassword;
        private DevExpress.XtraEditors.LabelControl LblPassword;
        private DevExpress.XtraEditors.SimpleButton BtnLogin;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
    }
}
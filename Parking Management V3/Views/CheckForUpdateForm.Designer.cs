namespace Parking_Management_V3.Views
{
    partial class CheckForUpdateForm
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
            this.PrbUpdate = new DevExpress.XtraEditors.ProgressBarControl();
            this.BtnDownload = new DevExpress.XtraEditors.SimpleButton();
            this.LblContext = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PrbUpdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PrbUpdate
            // 
            this.PrbUpdate.Location = new System.Drawing.Point(53, 312);
            this.PrbUpdate.Name = "PrbUpdate";
            this.PrbUpdate.Size = new System.Drawing.Size(1420, 65);
            this.PrbUpdate.TabIndex = 0;
            // 
            // BtnDownload
            // 
            this.BtnDownload.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDownload.Appearance.Options.UseFont = true;
            this.BtnDownload.Location = new System.Drawing.Point(53, 173);
            this.BtnDownload.Name = "BtnDownload";
            this.BtnDownload.Size = new System.Drawing.Size(318, 101);
            this.BtnDownload.TabIndex = 1;
            this.BtnDownload.Text = "بارگیری آپدیت";
            this.BtnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // LblContext
            // 
            this.LblContext.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblContext.Appearance.Options.UseFont = true;
            this.LblContext.Location = new System.Drawing.Point(804, 173);
            this.LblContext.Name = "LblContext";
            this.LblContext.Size = new System.Drawing.Size(669, 76);
            this.LblContext.TabIndex = 2;
            this.LblContext.Text = "شما صاحب آخرین ورژن نرم افزار هستید";
            this.LblContext.Visible = false;
            // 
            // CheckForUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1524, 858);
            this.Controls.Add(this.LblContext);
            this.Controls.Add(this.BtnDownload);
            this.Controls.Add(this.PrbUpdate);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "CheckForUpdateForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آپدیت نرم افزار";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CheckForUpdateForm_FormClosing);
            this.Load += new System.EventHandler(this.CheckForUpdateForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CheckForUpdateForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PrbUpdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ProgressBarControl PrbUpdate;
        private DevExpress.XtraEditors.SimpleButton BtnDownload;
        private DevExpress.XtraEditors.LabelControl LblContext;
    }
}
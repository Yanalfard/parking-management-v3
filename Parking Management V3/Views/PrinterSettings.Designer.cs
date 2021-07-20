namespace Parking_Management_V3.Views
{
    partial class PrinterSettings
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
            this.PrintStatusToggle = new DevExpress.XtraEditors.ToggleSwitch();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.PrintStatusToggle.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintStatusToggle
            // 
            this.PrintStatusToggle.Location = new System.Drawing.Point(12, 12);
            this.PrintStatusToggle.Name = "PrintStatusToggle";
            this.PrintStatusToggle.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.PrintStatusToggle.Properties.OffText = "خیر";
            this.PrintStatusToggle.Properties.OnText = "بلی";
            this.PrintStatusToggle.Size = new System.Drawing.Size(262, 73);
            this.PrintStatusToggle.TabIndex = 0;
            this.PrintStatusToggle.Toggled += new System.EventHandler(this.PrintStatusToggle_Toggled);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(317, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(243, 64);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "چاپ هنگام خروج";
            // 
            // PrinterSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1879, 1114);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PrintStatusToggle);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "PrinterSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات چاپگر";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrinterSettings_FormClosed);
            this.Load += new System.EventHandler(this.PrinterSettings_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PrinterSettings_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.PrintStatusToggle.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ToggleSwitch PrintStatusToggle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
namespace Parking_Management_V3.Views
{
    partial class LevelUpForm
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
            this.LblAll = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // LblAll
            // 
            this.LblAll.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblAll.Appearance.Options.UseFont = true;
            this.LblAll.Location = new System.Drawing.Point(737, 104);
            this.LblAll.Name = "LblAll";
            this.LblAll.Size = new System.Drawing.Size(113, 76);
            this.LblAll.TabIndex = 0;
            this.LblAll.Text = "تبریک";
            // 
            // LevelUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1358, 325);
            this.Controls.Add(this.LblAll);
            this.MaximizeBox = false;
            this.Name = "LevelUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تبریک";
            this.Load += new System.EventHandler(this.LevelUpForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LevelUpForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl LblAll;
    }
}
namespace Parking_Management_V3.Views
{
    partial class FloorSetting
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.NumDeleteFlr = new DevExpress.XtraEditors.SpinEdit();
            this.NumAddFlr = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeleteFlr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddFlr.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.NumDeleteFlr);
            this.groupControl1.Controls.Add(this.NumAddFlr);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl1.Location = new System.Drawing.Point(11, 11);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(912, 346);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "تنظیمات طبقات";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Location = new System.Drawing.Point(75, 226);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(327, 67);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "کم کردن";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(75, 119);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(327, 69);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "اضافه کردن";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // NumDeleteFlr
            // 
            this.NumDeleteFlr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumDeleteFlr.Location = new System.Drawing.Point(458, 233);
            this.NumDeleteFlr.Margin = new System.Windows.Forms.Padding(2);
            this.NumDeleteFlr.Name = "NumDeleteFlr";
            this.NumDeleteFlr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumDeleteFlr.Size = new System.Drawing.Size(125, 50);
            this.NumDeleteFlr.TabIndex = 3;
            // 
            // NumAddFlr
            // 
            this.NumAddFlr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumAddFlr.Location = new System.Drawing.Point(458, 126);
            this.NumAddFlr.Margin = new System.Windows.Forms.Padding(2);
            this.NumAddFlr.Name = "NumAddFlr";
            this.NumAddFlr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumAddFlr.Size = new System.Drawing.Size(125, 50);
            this.NumAddFlr.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(658, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 64);
            this.label2.TabIndex = 0;
            this.label2.Text = "کم کردن طبقه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(621, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "اضافه کردن طبقه";
            // 
            // FloorSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(957, 394);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "FloorSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات طبقات";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FloorSetting_FormClosed);
            this.Load += new System.EventHandler(this.FloorSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FloorSetting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeleteFlr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddFlr.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SpinEdit NumDeleteFlr;
        private DevExpress.XtraEditors.SpinEdit NumAddFlr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
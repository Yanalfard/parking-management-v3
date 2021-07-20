namespace Parking_Management_V3.Views
{
    partial class SpotSetting
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
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.label2 = new System.Windows.Forms.Label();
            this.LblSpots = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TrackBarColumnCount = new DevExpress.XtraEditors.TrackBarControl();
            this.NumWichFlr = new DevExpress.XtraEditors.SpinEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.NumDeleteSpt = new DevExpress.XtraEditors.SpinEdit();
            this.NumAddSpt = new DevExpress.XtraEditors.SpinEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColumnCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColumnCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWichFlr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeleteSpt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddSpt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.LblSpots);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.TrackBarColumnCount);
            this.groupControl2.Controls.Add(this.NumWichFlr);
            this.groupControl2.Controls.Add(this.label5);
            this.groupControl2.Controls.Add(this.simpleButton3);
            this.groupControl2.Controls.Add(this.simpleButton4);
            this.groupControl2.Controls.Add(this.NumDeleteSpt);
            this.groupControl2.Controls.Add(this.NumAddSpt);
            this.groupControl2.Controls.Add(this.label3);
            this.groupControl2.Controls.Add(this.label4);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl2.Location = new System.Drawing.Point(11, 11);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1275, 524);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "تنظیمات جاهای پارک";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(94, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 64);
            this.label2.TabIndex = 8;
            this.label2.Text = "محل پارک";
            // 
            // LblSpots
            // 
            this.LblSpots.AutoSize = true;
            this.LblSpots.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.LblSpots.Location = new System.Drawing.Point(354, 82);
            this.LblSpots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblSpots.Name = "LblSpots";
            this.LblSpots.Size = new System.Drawing.Size(0, 64);
            this.LblSpots.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(562, 335);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 64);
            this.label1.TabIndex = 6;
            this.label1.Text = "تعداد ستون";
            // 
            // TrackBarColumnCount
            // 
            this.TrackBarColumnCount.EditValue = 1;
            this.TrackBarColumnCount.Location = new System.Drawing.Point(27, 414);
            this.TrackBarColumnCount.Name = "TrackBarColumnCount";
            this.TrackBarColumnCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered;
            this.TrackBarColumnCount.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.TrackBarColumnCount.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TrackBarColumnCount.Properties.Maximum = 30;
            this.TrackBarColumnCount.Properties.Minimum = 1;
            this.TrackBarColumnCount.Properties.ShowLabels = true;
            this.TrackBarColumnCount.Properties.ShowValueToolTip = true;
            this.TrackBarColumnCount.Size = new System.Drawing.Size(1229, 114);
            this.TrackBarColumnCount.TabIndex = 0;
            this.TrackBarColumnCount.Value = 1;
            this.TrackBarColumnCount.EditValueChanged += new System.EventHandler(this.TrackBarColumnCount_EditValueChanged);
            // 
            // NumWichFlr
            // 
            this.NumWichFlr.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumWichFlr.Location = new System.Drawing.Point(626, 89);
            this.NumWichFlr.Margin = new System.Windows.Forms.Padding(2);
            this.NumWichFlr.Name = "NumWichFlr";
            this.NumWichFlr.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumWichFlr.Size = new System.Drawing.Size(125, 50);
            this.NumWichFlr.TabIndex = 1;
            this.NumWichFlr.ValueChanged += new System.EventHandler(this.NumWichFlr_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1081, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 64);
            this.label5.TabIndex = 4;
            this.label5.Text = "کدام طبقه";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButton3.Location = new System.Drawing.Point(91, 244);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(327, 68);
            this.simpleButton3.TabIndex = 5;
            this.simpleButton3.Text = "کم کردن";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Location = new System.Drawing.Point(91, 157);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(327, 67);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "اضافه کردن";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // NumDeleteSpt
            // 
            this.NumDeleteSpt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumDeleteSpt.Location = new System.Drawing.Point(626, 266);
            this.NumDeleteSpt.Margin = new System.Windows.Forms.Padding(2);
            this.NumDeleteSpt.Name = "NumDeleteSpt";
            this.NumDeleteSpt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumDeleteSpt.Size = new System.Drawing.Size(125, 50);
            this.NumDeleteSpt.TabIndex = 4;
            // 
            // NumAddSpt
            // 
            this.NumAddSpt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumAddSpt.Location = new System.Drawing.Point(626, 174);
            this.NumAddSpt.Margin = new System.Windows.Forms.Padding(2);
            this.NumAddSpt.Name = "NumAddSpt";
            this.NumAddSpt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumAddSpt.Size = new System.Drawing.Size(125, 50);
            this.NumAddSpt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(959, 259);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(297, 64);
            this.label3.TabIndex = 0;
            this.label3.Text = "کم کردن جای پارک";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(922, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 64);
            this.label4.TabIndex = 0;
            this.label4.Text = "اضافه کردن جای پارک";
            // 
            // SpotSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1329, 632);
            this.Controls.Add(this.groupControl2);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "SpotSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات جاهای پارک";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SpotSetting_FormClosed);
            this.Load += new System.EventHandler(this.SpotSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SpotSetting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColumnCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarColumnCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumWichFlr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDeleteSpt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumAddSpt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SpinEdit NumWichFlr;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SpinEdit NumDeleteSpt;
        private DevExpress.XtraEditors.SpinEdit NumAddSpt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TrackBarControl TrackBarColumnCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblSpots;
        private System.Windows.Forms.Label label2;
    }
}
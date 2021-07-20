namespace Parking_Management_V3.Views
{
    partial class FundControllForm
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
            this.BtnTodaysFund = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.TimeFromNorm = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TimeToNorm = new DevExpress.XtraEditors.TimeEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnCalcNorm = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.BtnVipShow = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TimeToVip = new DevExpress.XtraEditors.TimeEdit();
            this.TimeFromVip = new DevExpress.XtraEditors.TimeEdit();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.BtnCalcVip = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromNorm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeToNorm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeToVip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromVip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTodaysFund
            // 
            this.BtnTodaysFund.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnTodaysFund.Appearance.Options.UseFont = true;
            this.BtnTodaysFund.Location = new System.Drawing.Point(12, 20);
            this.BtnTodaysFund.Name = "BtnTodaysFund";
            this.BtnTodaysFund.Size = new System.Drawing.Size(290, 114);
            this.BtnTodaysFund.TabIndex = 0;
            this.BtnTodaysFund.Text = "درآمد روزانه";
            this.BtnTodaysFund.Click += new System.EventHandler(this.BtnTodaysFund_Click);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(12, 142);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(822, 27);
            this.separatorControl1.TabIndex = 1;
            // 
            // TimeFromNorm
            // 
            this.TimeFromNorm.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeFromNorm.Location = new System.Drawing.Point(373, 234);
            this.TimeFromNorm.Margin = new System.Windows.Forms.Padding(2);
            this.TimeFromNorm.Name = "TimeFromNorm";
            this.TimeFromNorm.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TimeFromNorm.Properties.Appearance.Options.UseFont = true;
            this.TimeFromNorm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeFromNorm.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeFromNorm.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeFromNorm.Size = new System.Drawing.Size(313, 68);
            this.TimeFromNorm.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(737, 226);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 64);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = " از";
            // 
            // TimeToNorm
            // 
            this.TimeToNorm.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeToNorm.Location = new System.Drawing.Point(373, 311);
            this.TimeToNorm.Margin = new System.Windows.Forms.Padding(2);
            this.TimeToNorm.Name = "TimeToNorm";
            this.TimeToNorm.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TimeToNorm.Properties.Appearance.Options.UseFont = true;
            this.TimeToNorm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeToNorm.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeToNorm.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeToNorm.Size = new System.Drawing.Size(313, 68);
            this.TimeToNorm.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(737, 318);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(30, 64);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = " تا";
            // 
            // BtnCalcNorm
            // 
            this.BtnCalcNorm.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnCalcNorm.Appearance.Options.UseFont = true;
            this.BtnCalcNorm.Location = new System.Drawing.Point(12, 233);
            this.BtnCalcNorm.Name = "BtnCalcNorm";
            this.BtnCalcNorm.Size = new System.Drawing.Size(290, 138);
            this.BtnCalcNorm.TabIndex = 3;
            this.BtnCalcNorm.Text = "محاسبه";
            this.BtnCalcNorm.Click += new System.EventHandler(this.BtnCalcNorm_Click);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(12, 386);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(822, 27);
            this.separatorControl2.TabIndex = 6;
            // 
            // BtnVipShow
            // 
            this.BtnVipShow.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.BtnVipShow.Appearance.Options.UseFont = true;
            this.BtnVipShow.Location = new System.Drawing.Point(12, 428);
            this.BtnVipShow.Name = "BtnVipShow";
            this.BtnVipShow.Size = new System.Drawing.Size(290, 114);
            this.BtnVipShow.TabIndex = 4;
            this.BtnVipShow.Text = "افراد ویژه ی حاضر";
            this.BtnVipShow.Click += new System.EventHandler(this.BtnVipShow_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(737, 746);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(30, 64);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = " تا";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(737, 659);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(32, 64);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = " از";
            // 
            // TimeToVip
            // 
            this.TimeToVip.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeToVip.Location = new System.Drawing.Point(373, 739);
            this.TimeToVip.Margin = new System.Windows.Forms.Padding(2);
            this.TimeToVip.Name = "TimeToVip";
            this.TimeToVip.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TimeToVip.Properties.Appearance.Options.UseFont = true;
            this.TimeToVip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeToVip.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeToVip.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeToVip.Size = new System.Drawing.Size(313, 68);
            this.TimeToVip.TabIndex = 6;
            // 
            // TimeFromVip
            // 
            this.TimeFromVip.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeFromVip.Location = new System.Drawing.Point(373, 662);
            this.TimeFromVip.Margin = new System.Windows.Forms.Padding(2);
            this.TimeFromVip.Name = "TimeFromVip";
            this.TimeFromVip.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TimeFromVip.Properties.Appearance.Options.UseFont = true;
            this.TimeFromVip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeFromVip.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeFromVip.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeFromVip.Size = new System.Drawing.Size(313, 68);
            this.TimeFromVip.TabIndex = 5;
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(12, 557);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(822, 27);
            this.separatorControl3.TabIndex = 8;
            // 
            // BtnCalcVip
            // 
            this.BtnCalcVip.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnCalcVip.Appearance.Options.UseFont = true;
            this.BtnCalcVip.Location = new System.Drawing.Point(12, 661);
            this.BtnCalcVip.Name = "BtnCalcVip";
            this.BtnCalcVip.Size = new System.Drawing.Size(290, 138);
            this.BtnCalcVip.TabIndex = 7;
            this.BtnCalcVip.Text = "محاسبه";
            this.BtnCalcVip.Click += new System.EventHandler(this.BtnCalcVip_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(322, 56);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(451, 64);
            this.labelControl5.TabIndex = 13;
            this.labelControl5.Text = "درآمد کل امروز را محاسبه میکند";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(322, 464);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(477, 64);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "افراد ویژه ی حاضر را نمایش میدهد";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(355, 585);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(130, 64);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "افراد ویژه";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(365, 162);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(100, 64);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "معمولی";
            // 
            // FundControllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(840, 870);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TimeToVip);
            this.Controls.Add(this.TimeFromVip);
            this.Controls.Add(this.separatorControl3);
            this.Controls.Add(this.BtnCalcVip);
            this.Controls.Add(this.separatorControl2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TimeToNorm);
            this.Controls.Add(this.TimeFromNorm);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.BtnCalcNorm);
            this.Controls.Add(this.BtnVipShow);
            this.Controls.Add(this.BtnTodaysFund);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "FundControllForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صندق";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FundControllForm_FormClosing);
            this.Load += new System.EventHandler(this.FundControllForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FundControllForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromNorm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeToNorm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeToVip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromVip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnTodaysFund;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.TimeEdit TimeFromNorm;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit TimeToNorm;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnCalcNorm;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton BtnVipShow;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TimeEdit TimeToVip;
        private DevExpress.XtraEditors.TimeEdit TimeFromVip;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.SimpleButton BtnCalcVip;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}
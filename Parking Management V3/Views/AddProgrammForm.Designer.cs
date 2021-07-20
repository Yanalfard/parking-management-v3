namespace Parking_Management_V3.Views
{
    partial class AddProgrammForm
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
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDisc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.NumDay = new DevExpress.XtraEditors.SpinEdit();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(700, 66);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(341, 68);
            this.TxtName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1128, 68);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(122, 64);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "نام برنامه";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1056, 200);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(199, 64);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "زمان اجرا(روز)";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(27, 66);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TxtPrice.Properties.Appearance.Options.UseFont = true;
            this.TxtPrice.Properties.Mask.EditMask = "n";
            this.TxtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtPrice.Size = new System.Drawing.Size(346, 68);
            this.TxtPrice.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(427, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(229, 64);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "قیمت کل(تومان)";
            // 
            // TxtDisc
            // 
            this.TxtDisc.Location = new System.Drawing.Point(27, 198);
            this.TxtDisc.Name = "TxtDisc";
            this.TxtDisc.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TxtDisc.Properties.Appearance.Options.UseFont = true;
            this.TxtDisc.Size = new System.Drawing.Size(346, 68);
            this.TxtDisc.TabIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(404, 200);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(268, 64);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "توضیحات(اختیاری)";
            // 
            // NumDay
            // 
            this.NumDay.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumDay.Location = new System.Drawing.Point(700, 191);
            this.NumDay.Name = "NumDay";
            this.NumDay.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.NumDay.Properties.Appearance.Options.UseFont = true;
            this.NumDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumDay.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.NumDay.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.NumDay.Size = new System.Drawing.Size(341, 68);
            this.NumDay.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(896, 346);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(359, 79);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "اضافه کردن";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // AddProgrammForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 502);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtDisc);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.NumDay);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProgrammForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن تعرفه";
            this.Load += new System.EventHandler(this.AddProgrammForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddProgrammForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDisc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtDisc;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit NumDay;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
    }
}
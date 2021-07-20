namespace Parking_Management_V3.Views
{
    partial class AddCostomerVehicle
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TimeStayed = new DevExpress.XtraEditors.TimeSpanEdit();
            this.TimeGone = new DevExpress.XtraEditors.TimeEdit();
            this.TimeArrived = new DevExpress.XtraEditors.TimeEdit();
            this.NumRow = new DevExpress.XtraEditors.SpinEdit();
            this.NumColumn = new DevExpress.XtraEditors.SpinEdit();
            this.NunFloor = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TxtPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtVehicleID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.BtnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStayed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeGone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeArrived.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NunFloor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVehicleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TimeStayed);
            this.groupControl1.Controls.Add(this.TimeGone);
            this.groupControl1.Controls.Add(this.TimeArrived);
            this.groupControl1.Controls.Add(this.NumRow);
            this.groupControl1.Controls.Add(this.NumColumn);
            this.groupControl1.Controls.Add(this.NunFloor);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.TxtPrice);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtVehicleID);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Location = new System.Drawing.Point(24, 26);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1125, 417);
            this.groupControl1.TabIndex = 33;
            this.groupControl1.Text = "groupControl1";
            // 
            // TimeStayed
            // 
            this.TimeStayed.EditValue = System.TimeSpan.Parse("00:00:00");
            this.TimeStayed.Location = new System.Drawing.Point(637, 22);
            this.TimeStayed.Margin = new System.Windows.Forms.Padding(2);
            this.TimeStayed.Name = "TimeStayed";
            this.TimeStayed.Properties.AllowEditSeconds = false;
            this.TimeStayed.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeStayed.Properties.Appearance.Options.UseFont = true;
            this.TimeStayed.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeStayed.Properties.MaxDays = 1000;
            this.TimeStayed.Size = new System.Drawing.Size(219, 60);
            this.TimeStayed.TabIndex = 5;
            // 
            // TimeGone
            // 
            this.TimeGone.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeGone.Location = new System.Drawing.Point(32, 235);
            this.TimeGone.Margin = new System.Windows.Forms.Padding(2);
            this.TimeGone.Name = "TimeGone";
            this.TimeGone.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeGone.Properties.Appearance.Options.UseFont = true;
            this.TimeGone.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeGone.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeGone.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeGone.Size = new System.Drawing.Size(391, 60);
            this.TimeGone.TabIndex = 4;
            // 
            // TimeArrived
            // 
            this.TimeArrived.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeArrived.Location = new System.Drawing.Point(32, 157);
            this.TimeArrived.Margin = new System.Windows.Forms.Padding(2);
            this.TimeArrived.Name = "TimeArrived";
            this.TimeArrived.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeArrived.Properties.Appearance.Options.UseFont = true;
            this.TimeArrived.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeArrived.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeArrived.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeArrived.Size = new System.Drawing.Size(391, 60);
            this.TimeArrived.TabIndex = 3;
            // 
            // NumRow
            // 
            this.NumRow.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumRow.Location = new System.Drawing.Point(637, 324);
            this.NumRow.Margin = new System.Windows.Forms.Padding(2);
            this.NumRow.Name = "NumRow";
            this.NumRow.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumRow.Properties.Appearance.Options.UseFont = true;
            this.NumRow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumRow.Size = new System.Drawing.Size(219, 60);
            this.NumRow.TabIndex = 9;
            // 
            // NumColumn
            // 
            this.NumColumn.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumColumn.Location = new System.Drawing.Point(637, 246);
            this.NumColumn.Margin = new System.Windows.Forms.Padding(2);
            this.NumColumn.Name = "NumColumn";
            this.NumColumn.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumColumn.Properties.Appearance.Options.UseFont = true;
            this.NumColumn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumColumn.Size = new System.Drawing.Size(219, 60);
            this.NumColumn.TabIndex = 8;
            // 
            // NunFloor
            // 
            this.NunFloor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NunFloor.Location = new System.Drawing.Point(637, 176);
            this.NunFloor.Margin = new System.Windows.Forms.Padding(2);
            this.NunFloor.Name = "NunFloor";
            this.NunFloor.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NunFloor.Properties.Appearance.Options.UseFont = true;
            this.NunFloor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NunFloor.Size = new System.Drawing.Size(219, 60);
            this.NunFloor.TabIndex = 7;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(1010, 90);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(77, 64);
            this.labelControl7.TabIndex = 47;
            this.labelControl7.Text = "قیمت";
            // 
            // TxtPrice
            // 
            this.TxtPrice.Location = new System.Drawing.Point(637, 98);
            this.TxtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtPrice.Properties.Appearance.Options.UseFont = true;
            this.TxtPrice.Properties.Mask.EditMask = "c0";
            this.TxtPrice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TxtPrice.Size = new System.Drawing.Size(219, 60);
            this.TxtPrice.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(875, 17);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(216, 64);
            this.labelControl4.TabIndex = 48;
            this.labelControl4.Text = "زمان صرف شده";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(468, 238);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(141, 64);
            this.labelControl5.TabIndex = 49;
            this.labelControl5.Text = "زمان رفتن";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(463, 162);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(146, 64);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "زمان آمدن";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(448, 94);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(161, 64);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "شماره پلاک";
            // 
            // TxtVehicleID
            // 
            this.TxtVehicleID.Location = new System.Drawing.Point(32, 87);
            this.TxtVehicleID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtVehicleID.Name = "TxtVehicleID";
            this.TxtVehicleID.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtVehicleID.Properties.Appearance.Options.UseFont = true;
            this.TxtVehicleID.Properties.Mask.EditMask = "000L00";
            this.TxtVehicleID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtVehicleID.Size = new System.Drawing.Size(391, 60);
            this.TxtVehicleID.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(1024, 320);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(64, 64);
            this.labelControl10.TabIndex = 44;
            this.labelControl10.Text = "سطر";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(1011, 248);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(80, 64);
            this.labelControl9.TabIndex = 43;
            this.labelControl9.Text = "ستون";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(1017, 172);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(68, 64);
            this.labelControl8.TabIndex = 42;
            this.labelControl8.Text = "طبقه";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(572, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 64);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "نام";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(32, 17);
            this.TxtName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.Size = new System.Drawing.Size(391, 60);
            this.TxtName.TabIndex = 0;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSubmit.Appearance.Options.UseFont = true;
            this.BtnSubmit.Location = new System.Drawing.Point(447, 474);
            this.BtnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(308, 76);
            this.BtnSubmit.TabIndex = 34;
            this.BtnSubmit.Text = "ثبت";
            this.BtnSubmit.Visible = false;
            this.BtnSubmit.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(24, 474);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(308, 76);
            this.BtnDelete.TabIndex = 35;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.Location = new System.Drawing.Point(841, 474);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(308, 76);
            this.BtnEdit.TabIndex = 36;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.Visible = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // AddCostomerVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1202, 614);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddCostomerVehicle";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddCostomerVehicle_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddCostomerVehicle_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeStayed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeGone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeArrived.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NunFloor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVehicleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TimeSpanEdit TimeStayed;
        private DevExpress.XtraEditors.TimeEdit TimeGone;
        private DevExpress.XtraEditors.TimeEdit TimeArrived;
        private DevExpress.XtraEditors.SpinEdit NumRow;
        private DevExpress.XtraEditors.SpinEdit NumColumn;
        private DevExpress.XtraEditors.SpinEdit NunFloor;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        public DevExpress.XtraEditors.TextEdit TxtPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit TxtVehicleID;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        public DevExpress.XtraEditors.SimpleButton BtnEdit;
        public DevExpress.XtraEditors.SimpleButton BtnDelete;
        public DevExpress.XtraEditors.SimpleButton BtnSubmit;
    }
}
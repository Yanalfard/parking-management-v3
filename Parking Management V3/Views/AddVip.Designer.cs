namespace Parking_Management_V3.Views
{
    partial class AddVip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddVip));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TimeCome = new DevExpress.XtraEditors.TimeEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnChouse = new DevExpress.XtraEditors.SimpleButton();
            this.NumRow = new DevExpress.XtraEditors.SpinEdit();
            this.NumColumn = new DevExpress.XtraEditors.SpinEdit();
            this.NumFloor = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtVehicleID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtLastName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtFirstName = new DevExpress.XtraEditors.TextEdit();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEdit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCome.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumColumn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFloor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVehicleID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TimeCome);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.BtnChouse);
            this.groupControl1.Controls.Add(this.NumRow);
            this.groupControl1.Controls.Add(this.NumColumn);
            this.groupControl1.Controls.Add(this.NumFloor);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtVehicleID);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtLastName);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TxtFirstName);
            this.groupControl1.Location = new System.Drawing.Point(31, 32);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1218, 357);
            this.groupControl1.TabIndex = 36;
            this.groupControl1.Text = "groupControl1";
            // 
            // TimeCome
            // 
            this.TimeCome.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeCome.Location = new System.Drawing.Point(116, 249);
            this.TimeCome.Margin = new System.Windows.Forms.Padding(2);
            this.TimeCome.Name = "TimeCome";
            this.TimeCome.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeCome.Properties.Appearance.Options.UseFont = true;
            this.TimeCome.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeCome.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeCome.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeCome.Size = new System.Drawing.Size(399, 60);
            this.TimeCome.TabIndex = 50;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("B Nazanin", 8F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton1.Location = new System.Drawing.Point(25, 248);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(69, 61);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.ToolTip = "نوشتن شماره پلاک در محل مذکور اجباری است";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // BtnChouse
            // 
            this.BtnChouse.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnChouse.Appearance.Options.UseFont = true;
            this.BtnChouse.Location = new System.Drawing.Point(766, 257);
            this.BtnChouse.Margin = new System.Windows.Forms.Padding(2);
            this.BtnChouse.Name = "BtnChouse";
            this.BtnChouse.Size = new System.Drawing.Size(247, 68);
            this.BtnChouse.TabIndex = 7;
            this.BtnChouse.Text = "انتخاب تعرفه";
            this.BtnChouse.Click += new System.EventHandler(this.BtnChouse_Click);
            // 
            // NumRow
            // 
            this.NumRow.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumRow.Location = new System.Drawing.Point(766, 185);
            this.NumRow.Margin = new System.Windows.Forms.Padding(2);
            this.NumRow.Name = "NumRow";
            this.NumRow.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumRow.Properties.Appearance.Options.UseFont = true;
            this.NumRow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumRow.Size = new System.Drawing.Size(247, 60);
            this.NumRow.TabIndex = 6;
            // 
            // NumColumn
            // 
            this.NumColumn.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumColumn.Location = new System.Drawing.Point(766, 102);
            this.NumColumn.Margin = new System.Windows.Forms.Padding(2);
            this.NumColumn.Name = "NumColumn";
            this.NumColumn.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumColumn.Properties.Appearance.Options.UseFont = true;
            this.NumColumn.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumColumn.Size = new System.Drawing.Size(247, 60);
            this.NumColumn.TabIndex = 5;
            // 
            // NumFloor
            // 
            this.NumFloor.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumFloor.Location = new System.Drawing.Point(766, 26);
            this.NumFloor.Margin = new System.Windows.Forms.Padding(2);
            this.NumFloor.Name = "NumFloor";
            this.NumFloor.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NumFloor.Properties.Appearance.Options.UseFont = true;
            this.NumFloor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumFloor.Size = new System.Drawing.Size(247, 60);
            this.NumFloor.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(576, 254);
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
            this.labelControl3.Location = new System.Drawing.Point(561, 183);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(161, 64);
            this.labelControl3.TabIndex = 40;
            this.labelControl3.Text = "شماره پلاک";
            // 
            // TxtVehicleID
            // 
            this.TxtVehicleID.Location = new System.Drawing.Point(25, 172);
            this.TxtVehicleID.Margin = new System.Windows.Forms.Padding(2);
            this.TxtVehicleID.Name = "TxtVehicleID";
            this.TxtVehicleID.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtVehicleID.Properties.Appearance.Options.UseFont = true;
            this.TxtVehicleID.Properties.Mask.EditMask = "000L00";
            this.TxtVehicleID.Size = new System.Drawing.Size(490, 60);
            this.TxtVehicleID.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(550, 101);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(172, 64);
            this.labelControl2.TabIndex = 41;
            this.labelControl2.Text = "نام خانوادگی";
            // 
            // TxtLastName
            // 
            this.TxtLastName.Location = new System.Drawing.Point(25, 93);
            this.TxtLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtLastName.Name = "TxtLastName";
            this.TxtLastName.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtLastName.Properties.Appearance.Options.UseFont = true;
            this.TxtLastName.Size = new System.Drawing.Size(490, 60);
            this.TxtLastName.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1101, 257);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(74, 64);
            this.labelControl4.TabIndex = 44;
            this.labelControl4.Text = "تعرفه";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(1101, 189);
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
            this.labelControl9.Location = new System.Drawing.Point(1088, 112);
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
            this.labelControl8.Location = new System.Drawing.Point(1094, 30);
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
            this.labelControl1.Location = new System.Drawing.Point(685, 21);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 64);
            this.labelControl1.TabIndex = 45;
            this.labelControl1.Text = "نام";
            // 
            // TxtFirstName
            // 
            this.TxtFirstName.Location = new System.Drawing.Point(25, 17);
            this.TxtFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.TxtFirstName.Name = "TxtFirstName";
            this.TxtFirstName.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtFirstName.Properties.Appearance.Options.UseFont = true;
            this.TxtFirstName.Size = new System.Drawing.Size(490, 60);
            this.TxtFirstName.TabIndex = 0;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(492, 413);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(308, 76);
            this.BtnAdd.TabIndex = 37;
            this.BtnAdd.Text = "ثبت";
            this.BtnAdd.Visible = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(31, 413);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(308, 76);
            this.BtnDelete.TabIndex = 38;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Visible = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnEdit.Appearance.Options.UseFont = true;
            this.BtnEdit.Location = new System.Drawing.Point(941, 413);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(308, 76);
            this.BtnEdit.TabIndex = 39;
            this.BtnEdit.Text = "ویرایش";
            this.BtnEdit.Visible = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // AddVip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 555);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.groupControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVip";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddVip_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddVip_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeCome.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumRow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumColumn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumFloor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVehicleID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TimeEdit TimeCome;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton BtnChouse;
        private DevExpress.XtraEditors.SpinEdit NumRow;
        private DevExpress.XtraEditors.SpinEdit NumColumn;
        private DevExpress.XtraEditors.SpinEdit NumFloor;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.TextEdit TxtVehicleID;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.TextEdit TxtLastName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.TextEdit TxtFirstName;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        public DevExpress.XtraEditors.SimpleButton BtnEdit;
        public DevExpress.XtraEditors.SimpleButton BtnDelete;
        public DevExpress.XtraEditors.SimpleButton BtnAdd;
    }
}
namespace Parking_Management_V3.Views
{
    partial class PricingPolicyForm
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.pricingPolicyViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pricingPolicyDataSet = new Parking_Management_V3.PricingPolicyDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colکد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنامتعرفه = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colورودیه = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colقیمتهرساعت = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colتوضیحات = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pricingPolicyViewTableAdapter = new Parking_Management_V3.PricingPolicyDataSetTableAdapters.PricingPolicyViewTableAdapter();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtDesc = new DevExpress.XtraEditors.TextEdit();
            this.NumEnt = new DevExpress.XtraEditors.SpinEdit();
            this.NumHour = new DevExpress.XtraEditors.SpinEdit();
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricingPolicyViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricingPolicyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHour.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pricingPolicyViewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(1401, 1283);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // pricingPolicyViewBindingSource
            // 
            this.pricingPolicyViewBindingSource.DataMember = "PricingPolicyView";
            this.pricingPolicyViewBindingSource.DataSource = this.pricingPolicyDataSet;
            // 
            // pricingPolicyDataSet
            // 
            this.pricingPolicyDataSet.DataSetName = "PricingPolicyDataSet";
            this.pricingPolicyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colکد,
            this.colنامتعرفه,
            this.colورودیه,
            this.colقیمتهرساعت,
            this.colتوضیحات});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colکد
            // 
            this.colکد.FieldName = "کد";
            this.colکد.Name = "colکد";
            this.colکد.Visible = true;
            this.colکد.VisibleIndex = 0;
            this.colکد.Width = 100;
            // 
            // colنامتعرفه
            // 
            this.colنامتعرفه.FieldName = "نام تعرفه";
            this.colنامتعرفه.Name = "colنامتعرفه";
            this.colنامتعرفه.Visible = true;
            this.colنامتعرفه.VisibleIndex = 1;
            this.colنامتعرفه.Width = 200;
            // 
            // colورودیه
            // 
            this.colورودیه.FieldName = "ورودیه";
            this.colورودیه.Name = "colورودیه";
            this.colورودیه.Visible = true;
            this.colورودیه.VisibleIndex = 2;
            this.colورودیه.Width = 200;
            // 
            // colقیمتهرساعت
            // 
            this.colقیمتهرساعت.FieldName = "قیمت هر ساعت";
            this.colقیمتهرساعت.Name = "colقیمتهرساعت";
            this.colقیمتهرساعت.Visible = true;
            this.colقیمتهرساعت.VisibleIndex = 3;
            this.colقیمتهرساعت.Width = 300;
            // 
            // colتوضیحات
            // 
            this.colتوضیحات.FieldName = "توضیحات";
            this.colتوضیحات.Name = "colتوضیحات";
            this.colتوضیحات.Visible = true;
            this.colتوضیحات.VisibleIndex = 4;
            this.colتوضیحات.Width = 561;
            // 
            // pricingPolicyViewTableAdapter
            // 
            this.pricingPolicyViewTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1936, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 60);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "نام تعرفه";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(1437, 28);
            this.TxtName.Name = "TxtName";
            this.TxtName.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtName.Properties.Appearance.Options.UseFont = true;
            this.TxtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtName.Size = new System.Drawing.Size(435, 74);
            this.TxtName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(1962, 133);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 60);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "ورودیه";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(1888, 235);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(163, 60);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "قیمت ساعت";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(1924, 328);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(127, 60);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "توضیحات";
            // 
            // TxtDesc
            // 
            this.TxtDesc.Location = new System.Drawing.Point(1437, 322);
            this.TxtDesc.Name = "TxtDesc";
            this.TxtDesc.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 11.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TxtDesc.Properties.Appearance.Options.UseFont = true;
            this.TxtDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TxtDesc.Size = new System.Drawing.Size(435, 74);
            this.TxtDesc.TabIndex = 4;
            // 
            // NumEnt
            // 
            this.NumEnt.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumEnt.Location = new System.Drawing.Point(1437, 143);
            this.NumEnt.Margin = new System.Windows.Forms.Padding(2);
            this.NumEnt.Name = "NumEnt";
            this.NumEnt.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumEnt.Size = new System.Drawing.Size(435, 50);
            this.NumEnt.TabIndex = 2;
            // 
            // NumHour
            // 
            this.NumHour.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NumHour.Location = new System.Drawing.Point(1437, 238);
            this.NumHour.Margin = new System.Windows.Forms.Padding(2);
            this.NumHour.Name = "NumHour";
            this.NumHour.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.NumHour.Size = new System.Drawing.Size(435, 50);
            this.NumHour.TabIndex = 3;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.Location = new System.Drawing.Point(1437, 436);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(614, 84);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "اضافه کردن";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Location = new System.Drawing.Point(1437, 553);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(614, 84);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "حذف";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.BtnUpdate.Appearance.Options.UseFont = true;
            this.BtnUpdate.Location = new System.Drawing.Point(1437, 675);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(614, 84);
            this.BtnUpdate.TabIndex = 7;
            this.BtnUpdate.Text = "ادیت";
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // PricingPolicyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2079, 1283);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.NumHour);
            this.Controls.Add(this.NumEnt);
            this.Controls.Add(this.TxtDesc);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "PricingPolicyForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات تعرفه";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PricingPolicyForm_FormClosed);
            this.Load += new System.EventHandler(this.PricingPolicyForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PricingPolicyForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricingPolicyViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pricingPolicyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumHour.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private PricingPolicyDataSet pricingPolicyDataSet;
        private System.Windows.Forms.BindingSource pricingPolicyViewBindingSource;
        private PricingPolicyDataSetTableAdapters.PricingPolicyViewTableAdapter pricingPolicyViewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colکد;
        private DevExpress.XtraGrid.Columns.GridColumn colنامتعرفه;
        private DevExpress.XtraGrid.Columns.GridColumn colورودیه;
        private DevExpress.XtraGrid.Columns.GridColumn colقیمتهرساعت;
        private DevExpress.XtraGrid.Columns.GridColumn colتوضیحات;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtDesc;
        private DevExpress.XtraEditors.SpinEdit NumEnt;
        private DevExpress.XtraEditors.SpinEdit NumHour;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnUpdate;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
    }
}
namespace Parking_Management_V3.Views
{
    partial class VipControlForm
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
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery4 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VipControlForm));
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.tblAgentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sqlDataSource2 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource3 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.sqlDataSource4 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.BtnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.vipViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vipViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.vipViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.vipGrid = new Parking_Management_V3.VipGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colکد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنام = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنامخانوادگی = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colزمانآمدن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colزمانرفتن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colطبقه = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسطر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colستون = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colکدمکان = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colپلاک = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنامتعرفه = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colقیمتتعرفه = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colکدتعرفه = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vipViewTableAdapter = new Parking_Management_V3.VipGridTableAdapters.VipViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAgentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ParkingManagementV3ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            queryParameter1.Name = "iomom";
            queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
            queryParameter1.Value = new DevExpress.DataAccess.Expression("0", typeof(int));
            queryParameter2.Name = "omoi";
            queryParameter2.Type = typeof(int);
            queryParameter2.ValueInfo = "0";
            queryParameter3.Name = "Parameter3";
            queryParameter3.Type = typeof(int);
            queryParameter3.ValueInfo = "0";
            customSqlQuery1.Parameters.Add(queryParameter1);
            customSqlQuery1.Parameters.Add(queryParameter2);
            customSqlQuery1.Parameters.Add(queryParameter3);
            customSqlQuery1.Sql = "select * from TblAgents";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // tblAgentsBindingSource
            // 
            this.tblAgentsBindingSource.DataMember = "TblAgents";
            // 
            // sqlDataSource2
            // 
            this.sqlDataSource2.ConnectionName = "Parking_Management_V3.Properties.Settings.ParkingManagementV3ConnectionString";
            this.sqlDataSource2.Name = "sqlDataSource2";
            customSqlQuery2.Name = "Query";
            customSqlQuery2.Sql = "select * from TblVip";
            this.sqlDataSource2.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery2});
            this.sqlDataSource2.ResultSchemaSerializable = resources.GetString("sqlDataSource2.ResultSchemaSerializable");
            // 
            // sqlDataSource3
            // 
            this.sqlDataSource3.ConnectionName = "Parking_Management_V3.Properties.Settings.ParkingManagementV3ConnectionString";
            this.sqlDataSource3.Name = "sqlDataSource3";
            customSqlQuery3.Name = "Query";
            customSqlQuery3.Sql = "select * from TblVip";
            this.sqlDataSource3.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery3});
            this.sqlDataSource3.ResultSchemaSerializable = resources.GetString("sqlDataSource3.ResultSchemaSerializable");
            // 
            // sqlDataSource4
            // 
            this.sqlDataSource4.ConnectionName = "ParkingManagementV3ConnectionString";
            this.sqlDataSource4.Name = "sqlDataSource4";
            customSqlQuery4.Name = "Query";
            customSqlQuery4.Sql = "select * from TblVip";
            this.sqlDataSource4.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery4});
            this.sqlDataSource4.ResultSchemaSerializable = resources.GetString("sqlDataSource4.ResultSchemaSerializable");
            // 
            // BtnAdd
            // 
            this.BtnAdd.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.BtnAdd.Appearance.Options.UseFont = true;
            this.BtnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.ImageOptions.Image")));
            this.BtnAdd.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.BtnAdd.Location = new System.Drawing.Point(1, -1);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(88, 86);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // vipViewBindingSource
            // 
            this.vipViewBindingSource.DataMember = "VipView";
            // 
            // vipViewBindingSource1
            // 
            this.vipViewBindingSource1.DataMember = "VipView";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.vipViewBindingSource2;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(3836, 1981);
            this.gridControl1.TabIndex = 10;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.GridControl1_Click);
            // 
            // vipViewBindingSource2
            // 
            this.vipViewBindingSource2.DataMember = "VipView";
            this.vipViewBindingSource2.DataSource = this.vipGrid;
            // 
            // vipGrid
            // 
            this.vipGrid.DataSetName = "VipGrid";
            this.vipGrid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colکد,
            this.colنام,
            this.colنامخانوادگی,
            this.colزمانآمدن,
            this.colزمانرفتن,
            this.colطبقه,
            this.colسطر,
            this.colستون,
            this.colکدمکان,
            this.colپلاک,
            this.colنامتعرفه,
            this.colقیمتتعرفه,
            this.colکدتعرفه});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colکد
            // 
            this.colکد.FieldName = "کد";
            this.colکد.MinWidth = 100;
            this.colکد.Name = "colکد";
            this.colکد.Visible = true;
            this.colکد.VisibleIndex = 0;
            this.colکد.Width = 100;
            // 
            // colنام
            // 
            this.colنام.FieldName = "نام";
            this.colنام.MinWidth = 400;
            this.colنام.Name = "colنام";
            this.colنام.Visible = true;
            this.colنام.VisibleIndex = 1;
            this.colنام.Width = 400;
            // 
            // colنامخانوادگی
            // 
            this.colنامخانوادگی.FieldName = "نام خانوادگی";
            this.colنامخانوادگی.MinWidth = 400;
            this.colنامخانوادگی.Name = "colنامخانوادگی";
            this.colنامخانوادگی.Visible = true;
            this.colنامخانوادگی.VisibleIndex = 2;
            this.colنامخانوادگی.Width = 400;
            // 
            // colزمانآمدن
            // 
            this.colزمانآمدن.FieldName = "زمان آمدن";
            this.colزمانآمدن.MinWidth = 400;
            this.colزمانآمدن.Name = "colزمانآمدن";
            this.colزمانآمدن.Visible = true;
            this.colزمانآمدن.VisibleIndex = 3;
            this.colزمانآمدن.Width = 400;
            // 
            // colزمانرفتن
            // 
            this.colزمانرفتن.FieldName = "زمان رفتن";
            this.colزمانرفتن.MinWidth = 400;
            this.colزمانرفتن.Name = "colزمانرفتن";
            this.colزمانرفتن.Visible = true;
            this.colزمانرفتن.VisibleIndex = 4;
            this.colزمانرفتن.Width = 400;
            // 
            // colطبقه
            // 
            this.colطبقه.FieldName = "طبقه";
            this.colطبقه.MinWidth = 100;
            this.colطبقه.Name = "colطبقه";
            this.colطبقه.Visible = true;
            this.colطبقه.VisibleIndex = 5;
            this.colطبقه.Width = 103;
            // 
            // colسطر
            // 
            this.colسطر.FieldName = "سطر";
            this.colسطر.MinWidth = 100;
            this.colسطر.Name = "colسطر";
            this.colسطر.Visible = true;
            this.colسطر.VisibleIndex = 6;
            this.colسطر.Width = 103;
            // 
            // colستون
            // 
            this.colستون.FieldName = "ستون";
            this.colستون.MinWidth = 100;
            this.colستون.Name = "colستون";
            this.colستون.Visible = true;
            this.colستون.VisibleIndex = 7;
            this.colستون.Width = 103;
            // 
            // colکدمکان
            // 
            this.colکدمکان.FieldName = "کد مکان";
            this.colکدمکان.MinWidth = 300;
            this.colکدمکان.Name = "colکدمکان";
            this.colکدمکان.Visible = true;
            this.colکدمکان.VisibleIndex = 8;
            this.colکدمکان.Width = 300;
            // 
            // colپلاک
            // 
            this.colپلاک.FieldName = "پلاک";
            this.colپلاک.MinWidth = 300;
            this.colپلاک.Name = "colپلاک";
            this.colپلاک.Visible = true;
            this.colپلاک.VisibleIndex = 9;
            this.colپلاک.Width = 300;
            // 
            // colنامتعرفه
            // 
            this.colنامتعرفه.FieldName = "نام تعرفه";
            this.colنامتعرفه.MinWidth = 400;
            this.colنامتعرفه.Name = "colنامتعرفه";
            this.colنامتعرفه.Visible = true;
            this.colنامتعرفه.VisibleIndex = 10;
            this.colنامتعرفه.Width = 511;
            // 
            // colقیمتتعرفه
            // 
            this.colقیمتتعرفه.FieldName = "قیمت تعرفه";
            this.colقیمتتعرفه.MinWidth = 300;
            this.colقیمتتعرفه.Name = "colقیمتتعرفه";
            this.colقیمتتعرفه.Visible = true;
            this.colقیمتتعرفه.VisibleIndex = 11;
            this.colقیمتتعرفه.Width = 400;
            // 
            // colکدتعرفه
            // 
            this.colکدتعرفه.FieldName = "کد تعرفه";
            this.colکدتعرفه.MinWidth = 200;
            this.colکدتعرفه.Name = "colکدتعرفه";
            this.colکدتعرفه.Visible = true;
            this.colکدتعرفه.VisibleIndex = 12;
            this.colکدتعرفه.Width = 200;
            // 
            // vipViewTableAdapter
            // 
            this.vipViewTableAdapter.ClearBeforeFill = true;
            // 
            // VipControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(3836, 1981);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "VipControlForm";
            this.ShowIcon = false;
            this.Text = "افراد ویژه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VipControlForm_FormClosed);
            this.Load += new System.EventHandler(this.VipControlForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VipControlForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAgentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vipGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource2;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private System.Windows.Forms.BindingSource tblAgentsBindingSource;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource3;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource4;
        private DevExpress.XtraEditors.SimpleButton BtnAdd;
        private System.Windows.Forms.BindingSource vipViewBindingSource;
        private System.Windows.Forms.BindingSource vipViewBindingSource1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private VipGrid vipGrid;
        private System.Windows.Forms.BindingSource vipViewBindingSource2;
        private VipGridTableAdapters.VipViewTableAdapter vipViewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colکد;
        private DevExpress.XtraGrid.Columns.GridColumn colنام;
        private DevExpress.XtraGrid.Columns.GridColumn colنامخانوادگی;
        private DevExpress.XtraGrid.Columns.GridColumn colزمانآمدن;
        private DevExpress.XtraGrid.Columns.GridColumn colزمانرفتن;
        private DevExpress.XtraGrid.Columns.GridColumn colطبقه;
        private DevExpress.XtraGrid.Columns.GridColumn colسطر;
        private DevExpress.XtraGrid.Columns.GridColumn colستون;
        private DevExpress.XtraGrid.Columns.GridColumn colکدمکان;
        private DevExpress.XtraGrid.Columns.GridColumn colپلاک;
        private DevExpress.XtraGrid.Columns.GridColumn colنامتعرفه;
        private DevExpress.XtraGrid.Columns.GridColumn colقیمتتعرفه;
        private DevExpress.XtraGrid.Columns.GridColumn colکدتعرفه;
    }
}
namespace Parking_Management_V3.Views
{
    partial class FundCalcForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FundCalcForm));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TimeToNorm = new DevExpress.XtraEditors.TimeEdit();
            this.TimeFromNorm = new DevExpress.XtraEditors.TimeEdit();
            this.BtnCalcNorm = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LblPrice = new DevExpress.XtraEditors.LabelControl();
            this.costomerVehicleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ChartOfDays = new DevExpress.XtraCharts.ChartControl();
            this.BtnExport = new DevExpress.XtraEditors.SimpleButton();
            this.OpdExport = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TimeToNorm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromNorm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerVehicleViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfDays)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ParkingManagementV3ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select * from TblCostomerVehicle";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(146, 1247);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(100, 64);
            this.labelControl8.TabIndex = 21;
            this.labelControl8.Text = "معمولی";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(386, 1406);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 75);
            this.labelControl2.TabIndex = 19;
            this.labelControl2.Text = " تا";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(386, 1312);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(37, 75);
            this.labelControl1.TabIndex = 20;
            this.labelControl1.Text = " از";
            // 
            // TimeToNorm
            // 
            this.TimeToNorm.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeToNorm.Location = new System.Drawing.Point(22, 1399);
            this.TimeToNorm.Margin = new System.Windows.Forms.Padding(2);
            this.TimeToNorm.Name = "TimeToNorm";
            this.TimeToNorm.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TimeToNorm.Properties.Appearance.Options.UseFont = true;
            this.TimeToNorm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeToNorm.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeToNorm.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeToNorm.Size = new System.Drawing.Size(313, 68);
            this.TimeToNorm.TabIndex = 17;
            // 
            // TimeFromNorm
            // 
            this.TimeFromNorm.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeFromNorm.Location = new System.Drawing.Point(22, 1322);
            this.TimeFromNorm.Margin = new System.Windows.Forms.Padding(2);
            this.TimeFromNorm.Name = "TimeFromNorm";
            this.TimeFromNorm.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 10F, System.Drawing.FontStyle.Bold);
            this.TimeFromNorm.Properties.Appearance.Options.UseFont = true;
            this.TimeFromNorm.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeFromNorm.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeFromNorm.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeFromNorm.Size = new System.Drawing.Size(313, 68);
            this.TimeFromNorm.TabIndex = 16;
            // 
            // BtnCalcNorm
            // 
            this.BtnCalcNorm.Appearance.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.BtnCalcNorm.Appearance.Options.UseFont = true;
            this.BtnCalcNorm.Location = new System.Drawing.Point(22, 1598);
            this.BtnCalcNorm.Name = "BtnCalcNorm";
            this.BtnCalcNorm.Size = new System.Drawing.Size(313, 94);
            this.BtnCalcNorm.TabIndex = 18;
            this.BtnCalcNorm.Text = "محاسبه";
            this.BtnCalcNorm.Click += new System.EventHandler(this.BtnCalcNorm_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(297, 1501);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(126, 75);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = " : درآمد";
            // 
            // LblPrice
            // 
            this.LblPrice.Appearance.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.LblPrice.Appearance.Options.UseFont = true;
            this.LblPrice.Location = new System.Drawing.Point(31, 1501);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(0, 75);
            this.LblPrice.TabIndex = 21;
            // 
            // costomerVehicleViewBindingSource
            // 
            this.costomerVehicleViewBindingSource.DataMember = "CostomerVehicleView";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(22, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(3808, 1219);
            this.gridControl1.TabIndex = 35;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // ChartOfDays
            // 
            this.ChartOfDays.Legend.Name = "Default Legend";
            this.ChartOfDays.Location = new System.Drawing.Point(455, 1251);
            this.ChartOfDays.Name = "ChartOfDays";
            this.ChartOfDays.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.ChartOfDays.SeriesTemplate.SeriesColorizer = null;
            this.ChartOfDays.Size = new System.Drawing.Size(3377, 706);
            this.ChartOfDays.TabIndex = 36;
            // 
            // BtnExport
            // 
            this.BtnExport.Appearance.Font = new System.Drawing.Font("Bahnschrift Light", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Appearance.Options.UseFont = true;
            this.BtnExport.Location = new System.Drawing.Point(22, 1709);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(313, 94);
            this.BtnExport.TabIndex = 37;
            this.BtnExport.Text = "Export Excel";
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // OpdExport
            // 
            this.OpdExport.FileName = "New Excel File";
            // 
            // FundCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(3836, 1988);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.ChartOfDays);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TimeToNorm);
            this.Controls.Add(this.TimeFromNorm);
            this.Controls.Add(this.BtnCalcNorm);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "FundCalcForm";
            this.ShowIcon = false;
            this.Text = "صندوق";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FundCalcForm_FormClosed);
            this.Load += new System.EventHandler(this.FundCalcForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FundCalcForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TimeToNorm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromNorm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerVehicleViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartOfDays)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TimeEdit TimeToNorm;
        private DevExpress.XtraEditors.TimeEdit TimeFromNorm;
        private DevExpress.XtraEditors.SimpleButton BtnCalcNorm;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl LblPrice;
        private System.Windows.Forms.BindingSource costomerVehicleViewBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraCharts.ChartControl ChartOfDays;
        private DevExpress.XtraEditors.SimpleButton BtnExport;
        private DevExpress.XtraEditors.XtraSaveFileDialog OpdExport;
    }
}
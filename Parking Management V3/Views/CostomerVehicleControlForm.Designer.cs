
using Parking_Management_V3.Models;

namespace Parking_Management_V3.Views
{
    partial class CostomerVehicleControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CostomerVehicleControlForm));
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.costomerVehicleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parkingManagementV3DataSet = new Parking_Management_V3.ParkingManagementV3DataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colکد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنام = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colزمانآمدن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colزمانرفتن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colزمانماندن = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colقیمت = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colطبقه = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colسطر = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colستون = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colکدمکان = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colپلاک = new DevExpress.XtraGrid.Columns.GridColumn();
            this.costomerVehicleViewTableAdapter = new Parking_Management_V3.ParkingManagementV3DataSetTableAdapters.CostomerVehicleViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerVehicleViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingManagementV3DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.Location = new System.Drawing.Point(1, 0);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(88, 84);
            this.simpleButton2.TabIndex = 10;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.richTextBox1);
            this.groupControl2.Location = new System.Drawing.Point(12, 1542);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(2216, 404);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "groupControl2";
            this.groupControl2.Visible = false;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(1931, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(259, 69);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "EXECUTE";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 15);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1900, 373);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.costomerVehicleViewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(3836, 1958);
            this.gridControl1.TabIndex = 34;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.GridControl1_Click);
            // 
            // costomerVehicleViewBindingSource
            // 
            this.costomerVehicleViewBindingSource.DataMember = "CostomerVehicleView";
            this.costomerVehicleViewBindingSource.DataSource = this.parkingManagementV3DataSet;
            // 
            // parkingManagementV3DataSet
            // 
            this.parkingManagementV3DataSet.DataSetName = "ParkingManagementV3DataSet";
            this.parkingManagementV3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colکد,
            this.colنام,
            this.colزمانآمدن,
            this.colزمانرفتن,
            this.colزمانماندن,
            this.colقیمت,
            this.colطبقه,
            this.colسطر,
            this.colستون,
            this.colکدمکان,
            this.colپلاک});
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
            // colزمانآمدن
            // 
            this.colزمانآمدن.FieldName = "زمان آمدن";
            this.colزمانآمدن.MinWidth = 500;
            this.colزمانآمدن.Name = "colزمانآمدن";
            this.colزمانآمدن.Visible = true;
            this.colزمانآمدن.VisibleIndex = 2;
            this.colزمانآمدن.Width = 500;
            // 
            // colزمانرفتن
            // 
            this.colزمانرفتن.FieldName = "زمان رفتن";
            this.colزمانرفتن.MinWidth = 500;
            this.colزمانرفتن.Name = "colزمانرفتن";
            this.colزمانرفتن.Visible = true;
            this.colزمانرفتن.VisibleIndex = 3;
            this.colزمانرفتن.Width = 500;
            // 
            // colزمانماندن
            // 
            this.colزمانماندن.FieldName = "زمان ماندن";
            this.colزمانماندن.MinWidth = 500;
            this.colزمانماندن.Name = "colزمانماندن";
            this.colزمانماندن.Visible = true;
            this.colزمانماندن.VisibleIndex = 4;
            this.colزمانماندن.Width = 500;
            // 
            // colقیمت
            // 
            this.colقیمت.FieldName = "قیمت";
            this.colقیمت.MinWidth = 500;
            this.colقیمت.Name = "colقیمت";
            this.colقیمت.Visible = true;
            this.colقیمت.VisibleIndex = 5;
            this.colقیمت.Width = 500;
            // 
            // colطبقه
            // 
            this.colطبقه.FieldName = "طبقه";
            this.colطبقه.MinWidth = 100;
            this.colطبقه.Name = "colطبقه";
            this.colطبقه.Visible = true;
            this.colطبقه.VisibleIndex = 6;
            this.colطبقه.Width = 100;
            // 
            // colسطر
            // 
            this.colسطر.FieldName = "سطر";
            this.colسطر.MinWidth = 100;
            this.colسطر.Name = "colسطر";
            this.colسطر.Visible = true;
            this.colسطر.VisibleIndex = 7;
            this.colسطر.Width = 100;
            // 
            // colستون
            // 
            this.colستون.FieldName = "ستون";
            this.colستون.MinWidth = 100;
            this.colستون.Name = "colستون";
            this.colستون.Visible = true;
            this.colستون.VisibleIndex = 8;
            this.colستون.Width = 100;
            // 
            // colکدمکان
            // 
            this.colکدمکان.FieldName = "کد مکان";
            this.colکدمکان.MinWidth = 400;
            this.colکدمکان.Name = "colکدمکان";
            this.colکدمکان.Visible = true;
            this.colکدمکان.VisibleIndex = 9;
            this.colکدمکان.Width = 400;
            // 
            // colپلاک
            // 
            this.colپلاک.FieldName = "پلاک";
            this.colپلاک.MinWidth = 400;
            this.colپلاک.Name = "colپلاک";
            this.colپلاک.Visible = true;
            this.colپلاک.VisibleIndex = 10;
            this.colپلاک.Width = 400;
            // 
            // costomerVehicleViewTableAdapter
            // 
            this.costomerVehicleViewTableAdapter.ClearBeforeFill = true;
            // 
            // CostomerVehicleControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(3836, 1958);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "CostomerVehicleControlForm";
            this.ShowIcon = false;
            this.Text = "فرم خودرو و مشتری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CostomerVehicleControlForm_FormClosed);
            this.Load += new System.EventHandler(this.CostomerVehicleControlForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CostomerVehicleControlForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costomerVehicleViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingManagementV3DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colکد;
        private DevExpress.XtraGrid.Columns.GridColumn colنام;
        private DevExpress.XtraGrid.Columns.GridColumn colزمانآمدن;
        private DevExpress.XtraGrid.Columns.GridColumn colزمانرفتن;
        private DevExpress.XtraGrid.Columns.GridColumn colزمانماندن;
        private DevExpress.XtraGrid.Columns.GridColumn colقیمت;
        private DevExpress.XtraGrid.Columns.GridColumn colطبقه;
        private DevExpress.XtraGrid.Columns.GridColumn colسطر;
        private DevExpress.XtraGrid.Columns.GridColumn colستون;
        private DevExpress.XtraGrid.Columns.GridColumn colکدمکان;
        private DevExpress.XtraGrid.Columns.GridColumn colپلاک;
        private ParkingManagementV3DataSet parkingManagementV3DataSet;
        private System.Windows.Forms.BindingSource costomerVehicleViewBindingSource;
        private ParkingManagementV3DataSetTableAdapters.CostomerVehicleViewTableAdapter costomerVehicleViewTableAdapter;
    }
}
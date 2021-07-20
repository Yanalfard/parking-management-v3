namespace Parking_Management_V3.Views
{
    partial class FundCalcVipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FundCalcVipForm));
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TimeToVip = new DevExpress.XtraEditors.TimeEdit();
            this.TimeFromVip = new DevExpress.XtraEditors.TimeEdit();
            this.BtnCalcVip = new DevExpress.XtraEditors.SimpleButton();
            this.LblPrice = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.vipViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnExport = new DevExpress.XtraEditors.SimpleButton();
            this.OpdExport = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.TimeToVip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromVip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "ParkingManagementV3ConnectionString";
            this.sqlDataSource1.Name = "sqlDataSource1";
            customSqlQuery1.Name = "Query";
            customSqlQuery1.Sql = "select * from TblVip";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(355, 1245);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(157, 76);
            this.labelControl7.TabIndex = 21;
            this.labelControl7.Text = "افراد ویژه";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(737, 1429);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 76);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = " تا";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(737, 1334);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(37, 76);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = " از";
            // 
            // TimeToVip
            // 
            this.TimeToVip.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeToVip.Location = new System.Drawing.Point(373, 1422);
            this.TimeToVip.Margin = new System.Windows.Forms.Padding(2);
            this.TimeToVip.Name = "TimeToVip";
            this.TimeToVip.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeToVip.Properties.Appearance.Options.UseFont = true;
            this.TimeToVip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeToVip.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeToVip.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeToVip.Size = new System.Drawing.Size(313, 68);
            this.TimeToVip.TabIndex = 17;
            // 
            // TimeFromVip
            // 
            this.TimeFromVip.EditValue = new System.DateTime(2018, 8, 22, 0, 0, 0, 0);
            this.TimeFromVip.Location = new System.Drawing.Point(373, 1345);
            this.TimeFromVip.Margin = new System.Windows.Forms.Padding(2);
            this.TimeFromVip.Name = "TimeFromVip";
            this.TimeFromVip.Properties.Appearance.Font = new System.Drawing.Font("B Nazanin", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.TimeFromVip.Properties.Appearance.Options.UseFont = true;
            this.TimeFromVip.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TimeFromVip.Properties.Mask.EditMask = "yyyy/MM/dd hh:mm";
            this.TimeFromVip.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.TimeFromVip.Size = new System.Drawing.Size(313, 68);
            this.TimeFromVip.TabIndex = 16;
            // 
            // BtnCalcVip
            // 
            this.BtnCalcVip.Appearance.Font = new System.Drawing.Font("B Nazanin", 14F, System.Drawing.FontStyle.Bold);
            this.BtnCalcVip.Appearance.Options.UseFont = true;
            this.BtnCalcVip.Location = new System.Drawing.Point(12, 1344);
            this.BtnCalcVip.Name = "BtnCalcVip";
            this.BtnCalcVip.Size = new System.Drawing.Size(313, 138);
            this.BtnCalcVip.TabIndex = 18;
            this.BtnCalcVip.Text = "محاسبه";
            this.BtnCalcVip.Click += new System.EventHandler(this.BtnCalcVip_Click);
            // 
            // LblPrice
            // 
            this.LblPrice.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LblPrice.Appearance.Options.UseFont = true;
            this.LblPrice.Location = new System.Drawing.Point(485, 1566);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(0, 75);
            this.LblPrice.TabIndex = 22;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(662, 1565);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(129, 76);
            this.labelControl1.TabIndex = 23;
            this.labelControl1.Text = " : درآمد";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.richTextBox1);
            this.groupControl2.Location = new System.Drawing.Point(835, 1248);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(2216, 404);
            this.groupControl2.TabIndex = 34;
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
            // vipViewBindingSource
            // 
            this.vipViewBindingSource.DataMember = "VipView";
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(3820, 1219);
            this.gridControl1.TabIndex = 35;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // BtnExport
            // 
            this.BtnExport.Appearance.Font = new System.Drawing.Font("Bahnschrift Light", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExport.Appearance.Options.UseFont = true;
            this.BtnExport.Location = new System.Drawing.Point(12, 1547);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(313, 94);
            this.BtnExport.TabIndex = 38;
            this.BtnExport.Text = "Export Excel";
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // OpdExport
            // 
            this.OpdExport.FileName = "New Excel File";
            // 
            // FundCalcVipForm
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(3836, 1760);
            this.Controls.Add(this.BtnExport);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.TimeToVip);
            this.Controls.Add(this.TimeFromVip);
            this.Controls.Add(this.BtnCalcVip);
            this.Font = new System.Drawing.Font("B Nazanin", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "FundCalcVipForm";
            this.ShowIcon = false;
            this.Text = "صندوق ویژه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FundCalcVipForm_FormClosed);
            this.Load += new System.EventHandler(this.FundCalcVipForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FundCalcVipForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.TimeToVip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeFromVip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vipViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TimeEdit TimeToVip;
        private DevExpress.XtraEditors.TimeEdit TimeFromVip;
        private DevExpress.XtraEditors.SimpleButton BtnCalcVip;
        private DevExpress.XtraEditors.LabelControl LblPrice;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.BindingSource vipViewBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnExport;
        private DevExpress.XtraEditors.XtraSaveFileDialog OpdExport;
    }
}
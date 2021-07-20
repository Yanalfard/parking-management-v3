namespace Parking_Management_V3.Views
{
    partial class AgentControlForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentControlForm));
            this.tblAgentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.xtraOpenFileDialog1 = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.Err = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            this.agentViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.agentViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.agentGrid = new Parking_Management_V3.AgentGrid();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colکد = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colکدملی = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنام = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنامخانوادگی = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colنامکاربری = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colرمزعبور = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colمحلعکس = new DevExpress.XtraGrid.Columns.GridColumn();
            this.agentViewTableAdapter = new Parking_Management_V3.AgentGridTableAdapters.AgentViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tblAgentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblAgentsBindingSource
            // 
            this.tblAgentsBindingSource.DataMember = "TblAgents";
            // 
            // xtraOpenFileDialog1
            // 
            this.xtraOpenFileDialog1.FileName = "xtraOpenFileDialog1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold);
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageIndex = 1;
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.simpleButton2.ImageOptions.ImageToTextIndent = 2;
            this.simpleButton2.Location = new System.Drawing.Point(1, -1);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(90, 86);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Err
            // 
            this.Err.ContainerControl = this;
            // 
            // agentViewBindingSource
            // 
            this.agentViewBindingSource.DataMember = "AgentView";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.agentViewBindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Tahoma", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gridControl1.Size = new System.Drawing.Size(3836, 1987);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // agentViewBindingSource1
            // 
            this.agentViewBindingSource1.DataMember = "AgentView";
            this.agentViewBindingSource1.DataSource = this.agentGrid;
            // 
            // agentGrid
            // 
            this.agentGrid.DataSetName = "AgentGrid";
            this.agentGrid.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colکد,
            this.colکدملی,
            this.colنام,
            this.colنامخانوادگی,
            this.colنامکاربری,
            this.colرمزعبور,
            this.colمحلعکس});
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
            this.colکد.Width = 104;
            // 
            // colکدملی
            // 
            this.colکدملی.FieldName = "کد ملی";
            this.colکدملی.MinWidth = 400;
            this.colکدملی.Name = "colکدملی";
            this.colکدملی.Visible = true;
            this.colکدملی.VisibleIndex = 1;
            this.colکدملی.Width = 416;
            // 
            // colنام
            // 
            this.colنام.FieldName = "نام";
            this.colنام.Name = "colنام";
            this.colنام.Visible = true;
            this.colنام.VisibleIndex = 2;
            this.colنام.Width = 400;
            // 
            // colنامخانوادگی
            // 
            this.colنامخانوادگی.FieldName = "نام خانوادگی";
            this.colنامخانوادگی.Name = "colنامخانوادگی";
            this.colنامخانوادگی.Visible = true;
            this.colنامخانوادگی.VisibleIndex = 3;
            this.colنامخانوادگی.Width = 400;
            // 
            // colنامکاربری
            // 
            this.colنامکاربری.FieldName = "نام کاربری";
            this.colنامکاربری.Name = "colنامکاربری";
            this.colنامکاربری.Visible = true;
            this.colنامکاربری.VisibleIndex = 4;
            this.colنامکاربری.Width = 400;
            // 
            // colرمزعبور
            // 
            this.colرمزعبور.FieldName = "رمز عبور";
            this.colرمزعبور.Name = "colرمزعبور";
            this.colرمزعبور.Visible = true;
            this.colرمزعبور.VisibleIndex = 5;
            this.colرمزعبور.Width = 400;
            // 
            // colمحلعکس
            // 
            this.colمحلعکس.FieldName = "محل عکس";
            this.colمحلعکس.Name = "colمحلعکس";
            this.colمحلعکس.Visible = true;
            this.colمحلعکس.VisibleIndex = 6;
            this.colمحلعکس.Width = 1663;
            // 
            // agentViewTableAdapter
            // 
            this.agentViewTableAdapter.ClearBeforeFill = true;
            // 
            // AgentControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(3836, 1987);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.gridControl1);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AgentControlForm";
            this.ShowIcon = false;
            this.Text = "ناحیه ی کاربری";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AgentControlForm_FormClosed);
            this.Load += new System.EventHandler(this.AgentControlForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AgentControlForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tblAgentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Err)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblAgentsBindingSource;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider Err;
        private System.Windows.Forms.BindingSource agentViewBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private AgentGrid agentGrid;
        private System.Windows.Forms.BindingSource agentViewBindingSource1;
        private AgentGridTableAdapters.AgentViewTableAdapter agentViewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colکد;
        private DevExpress.XtraGrid.Columns.GridColumn colکدملی;
        private DevExpress.XtraGrid.Columns.GridColumn colنام;
        private DevExpress.XtraGrid.Columns.GridColumn colنامخانوادگی;
        private DevExpress.XtraGrid.Columns.GridColumn colنامکاربری;
        private DevExpress.XtraGrid.Columns.GridColumn colرمزعبور;
        private DevExpress.XtraGrid.Columns.GridColumn colمحلعکس;
    }
}
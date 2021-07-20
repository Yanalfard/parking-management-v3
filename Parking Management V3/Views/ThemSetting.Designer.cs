namespace Parking_Management_V3.Views
{
    partial class ThemSetting
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.simpleButton9);
            this.groupControl3.Controls.Add(this.comboBoxEdit1);
            this.groupControl3.GroupStyle = DevExpress.Utils.GroupStyle.Title;
            this.groupControl3.Location = new System.Drawing.Point(11, 11);
            this.groupControl3.Margin = new System.Windows.Forms.Padding(2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(935, 152);
            this.groupControl3.TabIndex = 7;
            this.groupControl3.Text = "تم ظاهری نرم افزار";
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("B Nazanin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Location = new System.Drawing.Point(8, 63);
            this.simpleButton9.Margin = new System.Windows.Forms.Padding(2);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(334, 67);
            this.simpleButton9.TabIndex = 1;
            this.simpleButton9.Text = "اعمال";
            this.simpleButton9.Click += new System.EventHandler(this.simpleButton9_Click);
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.EditValue = "";
            this.comboBoxEdit1.Location = new System.Drawing.Point(360, 67);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "DevExpress Style",
            "DevExpress Dark Style",
            "Office 2016 Colorful",
            "Office 2016 Dark",
            "Office 2016 Black",
            "The Bezier",
            "Office 2013 Dark Gray",
            "Office 2013 Light Gray",
            "Office 2010 Blue",
            "Office 2010 Black",
            "Office 2010 Silver",
            "Visual Studio 2013 Blue",
            "Visual Studio 2013 Dark",
            "Visual Studio 2013 Light",
            "Seven Classic",
            "Black",
            "Blue",
            "Caramel",
            "Coffee",
            "Dark Side",
            "Foggy",
            "Glass Oceans",
            "High Contrast",
            "iMaginary",
            "Lilian",
            "Liquid Sky",
            "London Liquid Sky",
            "Metropolis",
            "Metropolis Dark",
            "Office 2007 Blue",
            "Office 2007 Green",
            "Office 2007 Pink",
            "Office 2007 Silver",
            "Seven",
            "Sharp",
            "Sharp Plus",
            "Stardust",
            "The Asphalt World",
            "Springtime",
            "Valentine",
            "McSkin",
            "Blueprint",
            "Whiteprint"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(528, 64);
            this.comboBoxEdit1.TabIndex = 0;
            // 
            // ThemSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(957, 226);
            this.Controls.Add(this.groupControl3);
            this.KeyPreview = true;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "ThemSetting";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تنظیمات تم";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThemSetting_FormClosed);
            this.Load += new System.EventHandler(this.ThemSetting_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThemSetting_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}
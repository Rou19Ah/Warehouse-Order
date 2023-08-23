
namespace Order.Report
{
    partial class FrmReportListStore
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportListStore));
            this.rgvProductStore = new Telerik.WinControls.UI.RadGridView();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.stiReport1 = new Stimulsoft.Report.StiReport();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvProductStore
            // 
            this.rgvProductStore.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgvProductStore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvProductStore.Location = new System.Drawing.Point(0, 42);
            // 
            // 
            // 
            this.rgvProductStore.MasterTemplate.AllowAddNewRow = false;
            this.rgvProductStore.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn7.FieldName = "ProName";
            gridViewTextBoxColumn7.HeaderText = "نام کالا";
            gridViewTextBoxColumn7.Name = "column1";
            gridViewTextBoxColumn7.Width = 103;
            gridViewTextBoxColumn8.FieldName = "CountStore";
            gridViewTextBoxColumn8.HeaderText = "تعداد کالای ورودی";
            gridViewTextBoxColumn8.Name = "column2";
            gridViewTextBoxColumn8.Width = 103;
            gridViewTextBoxColumn9.FieldName = "Date";
            gridViewTextBoxColumn9.FormatString = "{0:yyy/MM/dd}";
            gridViewTextBoxColumn9.HeaderText = "تاریخ";
            gridViewTextBoxColumn9.Name = "column3";
            gridViewTextBoxColumn9.Width = 103;
            this.rgvProductStore.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
            this.rgvProductStore.MasterTemplate.EnableFiltering = true;
            this.rgvProductStore.MasterTemplate.EnableGrouping = false;
            this.rgvProductStore.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgvProductStore.Name = "rgvProductStore";
            this.rgvProductStore.ReadOnly = true;
            this.rgvProductStore.Size = new System.Drawing.Size(328, 298);
            this.rgvProductStore.TabIndex = 1;
            // 
            // radButton1
            // 
            this.radButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radButton1.Location = new System.Drawing.Point(12, 12);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(95, 24);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "چاپ گزارش";
            this.radButton1.Click += new System.EventHandler(this.radButton1_Click);
            // 
            // stiReport1
            // 
            this.stiReport1.CookieContainer = null;
            this.stiReport1.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReport1.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReport1.ReportAlias = "Report";
            this.stiReport1.ReportGuid = "3151ba6074ba43acaf781e0cd4e63cee";
            this.stiReport1.ReportName = "Report";
            this.stiReport1.ReportSource = resources.GetString("stiReport1.ReportSource");
            this.stiReport1.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReport1.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReport1.UseProgressInThread = false;
            // 
            // FrmReportListStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 340);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.rgvProductStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmReportListStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "گزارشات کالا های ورودی به انبار";
            this.Load += new System.EventHandler(this.FrmReportListStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvProductStore;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Stimulsoft.Report.StiReport stiReport1;
    }
}

namespace Order.Store
{
    partial class FrmProductStore
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvProductStore = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvProductStore
            // 
            this.rgvProductStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvProductStore.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvProductStore.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgvProductStore.MasterTemplate.AllowAddNewRow = false;
            this.rgvProductStore.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProName";
            gridViewTextBoxColumn1.HeaderText = "نام کالا";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 109;
            gridViewTextBoxColumn2.FieldName = "CountStore";
            gridViewTextBoxColumn2.HeaderText = "تعداد کالای ورودی";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 109;
            gridViewTextBoxColumn3.FieldName = "Date";
            gridViewTextBoxColumn3.FormatString = "{0:yyy/MM/dd}";
            gridViewTextBoxColumn3.HeaderText = "تاریخ";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 112;
            this.rgvProductStore.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.rgvProductStore.MasterTemplate.EnableFiltering = true;
            this.rgvProductStore.MasterTemplate.EnableGrouping = false;
            this.rgvProductStore.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvProductStore.Name = "rgvProductStore";
            this.rgvProductStore.ReadOnly = true;
            this.rgvProductStore.Size = new System.Drawing.Size(349, 391);
            this.rgvProductStore.TabIndex = 0;
            // 
            // FrmProductStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 391);
            this.Controls.Add(this.rgvProductStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProductStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "کالا های ورودی به انبار";
            this.Load += new System.EventHandler(this.FrmProductStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProductStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvProductStore;
    }
}
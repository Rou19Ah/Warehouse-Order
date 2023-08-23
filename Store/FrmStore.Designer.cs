
namespace Order.Store
{
    partial class FrmStore
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
            this.rgvStore = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgvStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvStore.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvStore
            // 
            this.rgvStore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvStore.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvStore.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgvStore.MasterTemplate.AllowAddNewRow = false;
            this.rgvStore.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProductID";
            gridViewTextBoxColumn1.HeaderText = "ProductID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "ProductID";
            gridViewTextBoxColumn2.FieldName = "ProductName";
            gridViewTextBoxColumn2.HeaderText = "نام محصول";
            gridViewTextBoxColumn2.Name = "ProductName";
            gridViewTextBoxColumn2.Width = 168;
            gridViewTextBoxColumn3.FieldName = "Count";
            gridViewTextBoxColumn3.HeaderText = "تعداد موجود";
            gridViewTextBoxColumn3.Name = " ";
            gridViewTextBoxColumn3.Width = 169;
            this.rgvStore.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.rgvStore.MasterTemplate.EnableFiltering = true;
            this.rgvStore.MasterTemplate.EnableGrouping = false;
            this.rgvStore.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvStore.Name = "rgvStore";
            this.rgvStore.ReadOnly = true;
            this.rgvStore.Size = new System.Drawing.Size(357, 334);
            this.rgvStore.TabIndex = 0;
            this.rgvStore.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvStore_CellDoubleClick);
            // 
            // FrmStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 334);
            this.Controls.Add(this.rgvStore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmStore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت انبار";
            this.Load += new System.EventHandler(this.FrmStore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvStore.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvStore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvStore;
    }
}
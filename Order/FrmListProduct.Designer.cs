
namespace Order.Order
{
    partial class FrmListProduct
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvloadproduct = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.rgvloadproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvloadproduct.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvloadproduct
            // 
            this.rgvloadproduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvloadproduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvloadproduct.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.rgvloadproduct.MasterTemplate.AllowAddNewRow = false;
            this.rgvloadproduct.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProductID";
            gridViewTextBoxColumn1.HeaderText = "ProductID";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn2.FieldName = "ProductName";
            gridViewTextBoxColumn2.HeaderText = "ProductName";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 240;
            this.rgvloadproduct.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.rgvloadproduct.MasterTemplate.EnableFiltering = true;
            this.rgvloadproduct.MasterTemplate.EnableGrouping = false;
            this.rgvloadproduct.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvloadproduct.Name = "rgvloadproduct";
            this.rgvloadproduct.ReadOnly = true;
            this.rgvloadproduct.Size = new System.Drawing.Size(261, 328);
            this.rgvloadproduct.TabIndex = 0;
            this.rgvloadproduct.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvloadproduct_CellDoubleClick);
            // 
            // FrmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 328);
            this.Controls.Add(this.rgvloadproduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmListProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست محصولات";
            this.Load += new System.EventHandler(this.FrmListProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvloadproduct.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvloadproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvloadproduct;
    }
}
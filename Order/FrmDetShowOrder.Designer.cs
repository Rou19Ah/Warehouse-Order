
namespace Order.Order
{
    partial class FrmDetShowOrder
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvdetlistorder = new Telerik.WinControls.UI.RadGridView();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtpriceall = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rgvdetlistorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvdetlistorder.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpriceall)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvdetlistorder
            // 
            this.rgvdetlistorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rgvdetlistorder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvdetlistorder.Location = new System.Drawing.Point(0, 37);
            // 
            // 
            // 
            this.rgvdetlistorder.MasterTemplate.AllowAddNewRow = false;
            this.rgvdetlistorder.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProductName";
            gridViewTextBoxColumn1.HeaderText = "نام کالا";
            gridViewTextBoxColumn1.Name = "column1";
            gridViewTextBoxColumn1.Width = 103;
            gridViewTextBoxColumn2.FieldName = "Count";
            gridViewTextBoxColumn2.HeaderText = "تعداد کالا";
            gridViewTextBoxColumn2.Name = "column2";
            gridViewTextBoxColumn2.Width = 103;
            gridViewTextBoxColumn3.FieldName = "Price";
            gridViewTextBoxColumn3.HeaderText = "قیمت کالا";
            gridViewTextBoxColumn3.Name = "column3";
            gridViewTextBoxColumn3.Width = 103;
            gridViewTextBoxColumn4.FieldName = "PriceAll";
            gridViewTextBoxColumn4.HeaderText = "جمع کل";
            gridViewTextBoxColumn4.Name = "column4";
            gridViewTextBoxColumn4.Width = 104;
            this.rgvdetlistorder.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.rgvdetlistorder.MasterTemplate.EnableFiltering = true;
            this.rgvdetlistorder.MasterTemplate.EnableGrouping = false;
            this.rgvdetlistorder.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.rgvdetlistorder.Name = "rgvdetlistorder";
            this.rgvdetlistorder.ReadOnly = true;
            this.rgvdetlistorder.Size = new System.Drawing.Size(431, 324);
            this.rgvdetlistorder.TabIndex = 0;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(90, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(82, 17);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "جمع کل فاکتور :";
            // 
            // txtpriceall
            // 
            this.txtpriceall.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpriceall.Location = new System.Drawing.Point(168, 12);
            this.txtpriceall.Name = "txtpriceall";
            this.txtpriceall.Size = new System.Drawing.Size(124, 19);
            this.txtpriceall.TabIndex = 2;
            // 
            // FrmDetShowOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 361);
            this.Controls.Add(this.txtpriceall);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.rgvdetlistorder);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmDetShowOrder";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "جزئیات فاکتور";
            this.Load += new System.EventHandler(this.FrmDetShowOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvdetlistorder.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvdetlistorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpriceall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvdetlistorder;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtpriceall;
    }
}
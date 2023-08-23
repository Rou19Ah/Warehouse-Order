
namespace Order.Product
{
    partial class FrmProduct
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rgvProduct = new Telerik.WinControls.UI.RadGridView();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProduct.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvProduct
            // 
            this.rgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvProduct.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgvProduct.Location = new System.Drawing.Point(0, 86);
            // 
            // 
            // 
            this.rgvProduct.MasterTemplate.AllowAddNewRow = false;
            this.rgvProduct.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn13.FieldName = "ProductID";
            gridViewTextBoxColumn13.HeaderText = "شماره محصول";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.Name = "column1";
            gridViewTextBoxColumn14.FieldName = "ProductName";
            gridViewTextBoxColumn14.HeaderText = "نام محصول";
            gridViewTextBoxColumn14.Name = "column2";
            gridViewTextBoxColumn14.Width = 127;
            gridViewTextBoxColumn15.FieldName = "Count";
            gridViewTextBoxColumn15.HeaderText = "تعداد";
            gridViewTextBoxColumn15.Name = "column3";
            gridViewTextBoxColumn15.Width = 127;
            gridViewTextBoxColumn16.FieldName = "Barcode";
            gridViewTextBoxColumn16.HeaderText = "شماره بارکد";
            gridViewTextBoxColumn16.Name = "column4";
            gridViewTextBoxColumn16.Width = 127;
            gridViewTextBoxColumn17.FieldName = "Price";
            gridViewTextBoxColumn17.HeaderText = "قیمت محصول";
            gridViewTextBoxColumn17.Name = "column5";
            gridViewTextBoxColumn17.Width = 127;
            gridViewTextBoxColumn18.FieldName = "Note";
            gridViewTextBoxColumn18.HeaderText = "توضیحات";
            gridViewTextBoxColumn18.Name = "column6";
            gridViewTextBoxColumn18.Width = 127;
            this.rgvProduct.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17,
            gridViewTextBoxColumn18});
            this.rgvProduct.MasterTemplate.EnableFiltering = true;
            this.rgvProduct.MasterTemplate.EnableGrouping = false;
            this.rgvProduct.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.rgvProduct.Name = "rgvProduct";
            this.rgvProduct.ReadOnly = true;
            this.rgvProduct.Size = new System.Drawing.Size(657, 364);
            this.rgvProduct.TabIndex = 3;
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(657, 86);
            this.radCommandBar1.TabIndex = 2;
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Name = "commandBarRowElement1";
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton1,
            this.commandBarButton2,
            this.commandBarButton3});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.UseCompatibleTextRendering = false;
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.DisplayName = "commandBarButton1";
            this.commandBarButton1.DrawText = true;
            this.commandBarButton1.Image = global::Order.Properties.Resources._3669464_add_cart_shopping_ic_icon;
            this.commandBarButton1.ImageOpacity = 1D;
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.Text = "افزودن";
            this.commandBarButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.commandBarButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.commandBarButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.UseCompatibleTextRendering = false;
            this.commandBarButton1.Click += new System.EventHandler(this.commandBarButton1_Click);
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.DisplayName = "commandBarButton2";
            this.commandBarButton2.DrawText = true;
            this.commandBarButton2.Image = global::Order.Properties.Resources._8674493_ic_fluent_box_edit_regular_icon;
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "ویرایش";
            this.commandBarButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.commandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.UseCompatibleTextRendering = false;
            this.commandBarButton2.Click += new System.EventHandler(this.commandBarButton2_Click);
            // 
            // commandBarButton3
            // 
            this.commandBarButton3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton3.DisplayName = "commandBarButton3";
            this.commandBarButton3.DrawText = true;
            this.commandBarButton3.Image = global::Order.Properties.Resources._8324258_ui_essential_app_delete_junk_icon;
            this.commandBarButton3.Name = "commandBarButton3";
            this.commandBarButton3.Text = "حذف";
            this.commandBarButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.commandBarButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton3.UseCompatibleTextRendering = false;
            this.commandBarButton3.Click += new System.EventHandler(this.commandBarButton3_Click);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.rgvProduct);
            this.Controls.Add(this.radCommandBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "مدیریت محصولات";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvProduct.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvProduct;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
    }
}
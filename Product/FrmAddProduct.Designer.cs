
namespace Order.Product
{
    partial class FrmAddProduct
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtbarcode = new Telerik.WinControls.UI.RadTextBox();
            this.btnadd = new Telerik.WinControls.UI.RadButton();
            this.txtnamep = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtcount = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.txtprice = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtnotep = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.btncancel = new Telerik.WinControls.UI.RadButton();
            this.btnbarcode = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnamep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbarcode)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(7, 12);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(76, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "شماره بارکد :";
            this.radLabel1.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtbarcode
            // 
            this.txtbarcode.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbarcode.Location = new System.Drawing.Point(86, 12);
            this.txtbarcode.Name = "txtbarcode";
            this.txtbarcode.Size = new System.Drawing.Size(178, 20);
            this.txtbarcode.TabIndex = 1;
            // 
            // btnadd
            // 
            this.btnadd.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(86, 238);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(82, 24);
            this.btnadd.TabIndex = 2;
            this.btnadd.Text = "افزودن";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtnamep
            // 
            this.txtnamep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamep.Location = new System.Drawing.Point(86, 36);
            this.txtnamep.Name = "txtnamep";
            this.txtnamep.Size = new System.Drawing.Size(178, 20);
            this.txtnamep.TabIndex = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 36);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(71, 18);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "نام محصول :";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtcount
            // 
            this.txtcount.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcount.Location = new System.Drawing.Point(86, 60);
            this.txtcount.Name = "txtcount";
            this.txtcount.Size = new System.Drawing.Size(178, 20);
            this.txtcount.TabIndex = 5;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 60);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(40, 18);
            this.radLabel3.TabIndex = 4;
            this.radLabel3.Text = "تعداد :";
            this.radLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtprice
            // 
            this.txtprice.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprice.Location = new System.Drawing.Point(86, 84);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(178, 20);
            this.txtprice.TabIndex = 5;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(12, 84);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(43, 18);
            this.radLabel4.TabIndex = 4;
            this.radLabel4.Text = "قیمت :";
            this.radLabel4.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtnotep
            // 
            this.txtnotep.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnotep.Location = new System.Drawing.Point(86, 108);
            this.txtnotep.Multiline = true;
            this.txtnotep.Name = "txtnotep";
            // 
            // 
            // 
            this.txtnotep.RootElement.StretchVertically = true;
            this.txtnotep.Size = new System.Drawing.Size(178, 124);
            this.txtnotep.TabIndex = 5;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(12, 108);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(59, 18);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "توضیحات :";
            this.radLabel5.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(182, 238);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(82, 24);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "انصراف";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnbarcode
            // 
            this.btnbarcode.Location = new System.Drawing.Point(270, 12);
            this.btnbarcode.Name = "btnbarcode";
            this.btnbarcode.Size = new System.Drawing.Size(35, 20);
            this.btnbarcode.TabIndex = 3;
            this.btnbarcode.Text = ".....";
            this.btnbarcode.Click += new System.EventHandler(this.btnbarcode_Click);
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 275);
            this.Controls.Add(this.btnbarcode);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.txtnotep);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.txtcount);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.txtnamep);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtbarcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddProduct";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن محصول";
            this.Load += new System.EventHandler(this.FrmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtbarcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnadd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnamep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtprice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtnotep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnbarcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtbarcode;
        private Telerik.WinControls.UI.RadButton btnadd;
        private Telerik.WinControls.UI.RadTextBox txtnamep;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtcount;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox txtprice;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox txtnotep;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadButton btncancel;
        private Telerik.WinControls.UI.RadButton btnbarcode;
    }
}
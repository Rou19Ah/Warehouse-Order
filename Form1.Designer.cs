
namespace Order
{
    partial class Form1
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
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtuser = new Telerik.WinControls.UI.RadTextBox();
            this.txtpass = new Telerik.WinControls.UI.RadTextBox();
            this.btncancel = new Telerik.WinControls.UI.RadButton();
            this.btnlogin = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogin)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(57, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "نام کاربری :";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 59);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "کلمه عبور :";
            this.radLabel2.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(86, 31);
            this.txtuser.Name = "txtuser";
            this.txtuser.NullText = "نام کاربری را وارد کنید";
            this.txtuser.Size = new System.Drawing.Size(175, 20);
            this.txtuser.TabIndex = 2;
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(86, 57);
            this.txtpass.Name = "txtpass";
            this.txtpass.NullText = "کلمه عبور را وارد کنید";
            this.txtpass.Size = new System.Drawing.Size(175, 20);
            this.txtpass.TabIndex = 3;
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(199, 95);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(62, 24);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "انصراف";
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(86, 95);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(62, 24);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "ورود";
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 136);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ورود به سیستم";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btncancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnlogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox txtuser;
        private Telerik.WinControls.UI.RadTextBox txtpass;
        private Telerik.WinControls.UI.RadButton btncancel;
        private Telerik.WinControls.UI.RadButton btnlogin;
    }
}


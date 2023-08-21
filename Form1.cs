using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order.Server;

namespace Order
{
    public partial class Form1 : Form
    {
        Server.D_ShopOrderEntities db = new D_ShopOrderEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var user = (from u in db.Sh_User where u.UserName == txtuser.Text && u.Password == txtpass.Text select u).Any();
            if (user)
            {
                this.Hide();
                FrmMain fa = new FrmMain();
                fa.ShowDialog();
            }
            else
            {
                MessageBox.Show("اطلاعات شما تایید نشد");
            }    
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

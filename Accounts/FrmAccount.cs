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

namespace Order.Accounts
{
    public partial class FrmAccount : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public FrmAccount()
        {
            InitializeComponent();
        }

        private void FrmAccount_Load(object sender, EventArgs e)
        {
            Grid();
        }
        private void Grid()
        {
            rgvuser.DataSource = D.Sh_User.ToList();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            D.Sh_User.Add(new Sh_User()
            {
                UserName = txtuser.Text,
                Password = txtpassword.Text
            });
            D.SaveChanges();
            Grid();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (rgvuser.CurrentRow != null)
            {
                if (MessageBox.Show("آیا اطمینان دارید به انجام عملیات حذف؟", "اخطار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int userid = int.Parse(rgvuser.CurrentRow.Cells[0].Value.ToString());
                    var user = (from u in D.Sh_User where u.UserID == userid select u).First();
                    D.Sh_User.Remove(user);
                    D.SaveChanges();
                    Grid();
                }
            }
        }
    }
}

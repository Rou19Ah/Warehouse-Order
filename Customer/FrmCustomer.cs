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

namespace Order.Customer
{
    public partial class FrmCustomer : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public FrmCustomer()
        {
            InitializeComponent();
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            Grid(); 
        }
        private void Grid()
        {
            rgvCustomer.DataSource = (from c in D.Sh_Customer select c).ToList();
        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            if((new FrmAddCustomer()).ShowDialog()==DialogResult.OK)
            {
                Grid();
            }
        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            if(rgvCustomer.CurrentRow!=null)
            {
                int customerid = int.Parse(rgvCustomer.CurrentRow.Cells[0].Value.ToString());
                if(new FrmAddCustomer() { idcustomer = customerid}.ShowDialog()==DialogResult.OK)
                {
                    Grid();
                }    
            }
        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        {
            if (rgvCustomer.CurrentRow != null)
            {
                int customerid = int.Parse(rgvCustomer.CurrentRow.Cells[0].Value.ToString());
                var cusromer = (from u in D.Sh_Customer where u.CustomerID == customerid select u).First();
                D.Sh_Customer.Remove(cusromer);
                D.SaveChanges();
                MessageBox.Show("کاربر با موفقیت حذف شد");
                Grid();
            }
        }
    }
}

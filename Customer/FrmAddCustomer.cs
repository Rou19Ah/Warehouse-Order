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
    public partial class FrmAddCustomer : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public int idcustomer = 0;
        public FrmAddCustomer()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (idcustomer == 0)
            {
                D.Sh_Customer.Add(new Sh_Customer()
                {
                    Name = txtname.Text,
                    Family = txtfamilyname.Text,
                    FullName = txtname.Text + " " + txtfamilyname.Text,
                    Address = txtadress.Text,
                    Mobile = txtnumber.Text,
                    Note = txtnote.Text,
                });
                D.SaveChanges();
                MessageBox.Show("اطلاعات ثبت شد");
                DialogResult = DialogResult.OK;
            }
            else
            {
                var customer = (from u in D.Sh_Customer where u.CustomerID == idcustomer select u).First();
                customer.Name = txtname.Text;
                customer.Family = txtfamilyname.Text;
                customer.Address = txtadress.Text;
                customer.Mobile = txtnumber.Text;
                customer.Note = txtnote.Text;
                D.SaveChanges();
                MessageBox.Show("ویرایش انجام شد");
                DialogResult = DialogResult.OK;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAddCustomer_Load(object sender, EventArgs e)
        {
            if(idcustomer!=0)
            {
                var customer = (from u in D.Sh_Customer where u.CustomerID == idcustomer select u).First();
                txtname.Text = customer.Name;
                txtfamilyname.Text = customer.Family;
                txtnumber.Text = customer.Mobile;
                txtadress.Text = customer.Address;
                txtnote.Text = customer.Note;
                btnadd.Text = "ویرایش";
            }
        }
    }
}

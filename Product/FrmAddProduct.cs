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

namespace Order.Product
{
    public partial class FrmAddProduct : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public int Proid = 0;
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        private void btnbarcode_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int barcode = rnd.Next(1, 99999999);
            txtbarcode.Text = barcode.ToString();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (Proid == 0)
            {
                D.Sh_Product.Add(new Sh_Product()
                {
                    Barcode = int.Parse(txtbarcode.Text),
                    ProductName = txtnamep.Text,
                    Price = int.Parse(txtprice.Text),
                    Count = int.Parse(txtcount.Text),
                    Note = txtnotep.Text,
                });
                D.SaveChanges();
                MessageBox.Show("محصول ثبت شد");
                DialogResult = DialogResult.OK;
            }
            else
            {
                var product = (from u in D.Sh_Product where u.ProductID == Proid select u).First();
                product.ProductName = txtnamep.Text;
                product.Count = int.Parse(txtcount.Text);
                product.Price = int.Parse(txtprice.Text);
                product.Barcode = int.Parse(txtbarcode.Text);
                product.Note = txtnotep.Text;
                D.SaveChanges();
                MessageBox.Show("ویرایش انجام شد");
                DialogResult = DialogResult.OK;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            if (Proid != 0)
            {
                var product = (from u in D.Sh_Product where u.ProductID == Proid select u).First();
                txtnamep.Text = product.ProductName;
                txtcount.Text = product.Count.ToString();
                txtprice.Text = product.Price.ToString();
                txtbarcode.Text = product.Barcode.ToString();
                txtnotep.Text = product.Note;
                btnadd.Text = "ویرایش";
            }
        }
    }
}

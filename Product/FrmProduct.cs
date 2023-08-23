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
    public partial class FrmProduct : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            Grid();
        }
        private void Grid()
        {
            rgvProduct.DataSource = (from u in D.Sh_Product select u).ToList();
        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            if(new FrmAddProduct().ShowDialog()==DialogResult.OK)
            {
                Grid();
            }
        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            if(rgvProduct.CurrentRow!=null)
            {
                int idProduct = int.Parse(rgvProduct.CurrentRow.Cells[0].Value.ToString());
                if (new FrmAddProduct() { Proid = idProduct }.ShowDialog() == DialogResult.OK)
                {
                    Grid();
                }
            }
        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        {
            if (rgvProduct.CurrentRow != null)
            {
                int idProduct = int.Parse(rgvProduct.CurrentRow.Cells[0].Value.ToString());
                var product = (from u in D.Sh_Product where u.ProductID == idProduct select u).First();
                var products = (from o in D.Sh_Store where o.ProductID == idProduct select o).First();
                D.Sh_Store.Remove(products);
                D.Sh_Product.Remove(product);
                D.SaveChanges();
                MessageBox.Show("محصول با موفقیت حذف شد");
                Grid();
            }
        }
    }
}

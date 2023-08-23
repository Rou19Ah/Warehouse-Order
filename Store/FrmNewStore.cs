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

namespace Order.Store
{
    public partial class FrmNewStore : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public int ProductID = 0;
        public FrmNewStore()
        {
            InitializeComponent();
        }

        private void FrmNewStore_Load(object sender, EventArgs e)
        {
            if(ProductID!=0)
            {
                var product = (from p in D.Sh_Product where p.ProductID == ProductID select p).First();
                lblCount.Text = product.Count.ToString();
                lblProName.Text = product.ProductName;
            }
        }

        private void btnAddstore_Click(object sender, EventArgs e)
        {
            int mojodi = int.Parse(lblCount.Text);
            var product = (from p in D.Sh_Product where p.ProductID == ProductID select p).First();
            product.Count = int.Parse(txtCount.Text) + mojodi;
            D.SaveChanges();
            Sh_Store S = new Sh_Store()
            {
                Count = int.Parse(txtCount.Text),
                ProductID = ProductID,
                Date = DateTime.Now,
            };
            D.Sh_Store.Add(S);
            D.SaveChanges();
            MessageBox.Show("کالا با موفقیت به انبار اضافه شد");
            DialogResult = DialogResult.OK;
        }
    }
}

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
    public partial class FrmProductStore : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();

        public FrmProductStore()
        {
            InitializeComponent();
        }

        private void FrmProductStore_Load(object sender, EventArgs e)
        {
            rgvProductStore.DataSource = (from u in D.Sh_Store
                                          orderby u.Date descending
                                          select new
                                          {
                                              ProName = u.Sh_Product.ProductName,
                                              CountStore = u.Count,
                                              u.Date,
                                          }).ToList();
        }
    }
}

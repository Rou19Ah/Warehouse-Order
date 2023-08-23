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
    public partial class FrmStore : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public FrmStore()
        {
            InitializeComponent();
        }

        private void FrmStore_Load(object sender, EventArgs e)
        {
            Grid();
        }
        private void Grid()
        {
            rgvStore.DataSource = D.Sh_Product.ToList();
        }

        private void rgvStore_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if (rgvStore.CurrentRow != null)
            {
                int proid = int.Parse(rgvStore.CurrentRow.Cells[0].Value.ToString());
                if (new FrmNewStore() { ProductID = proid }.ShowDialog() == DialogResult.OK)
                {
                    Grid();
                }
            }
        }
    }
}

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

namespace Order.Order
{
    public partial class FrmOrder : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public FrmOrder()
        {
            InitializeComponent();
        }

        private void commandBarButton1_Click(object sender, EventArgs e)
        {
            if(new FrmNewOrder().ShowDialog()==DialogResult.OK)
            {
                Grid();
            }
        }
        private void Grid()
        {
            rgvShowListOrder.DataSource = (from u in D.Sh_Order orderby u.Date descending select new
            {
                u.OrderID,
                u.Sh_Customer.FullName,
                u.Date,
            }).ToList();
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            Grid();
        }

        private void commandBarButton3_Click(object sender, EventArgs e)
        { 
            if(rgvShowListOrder.CurrentRow!=null)
            {
                int orderid = int.Parse(rgvShowListOrder.CurrentRow.Cells[0].Value.ToString());
                (from u in D.Sh_OrderDet where u.OrderID == orderid select u).ToList().ForEach(c => D.Sh_OrderDet.Remove(c));
                var order = (from u in D.Sh_Order where u.OrderID == orderid select u).First();
                D.Sh_Order.Remove(order);
                D.SaveChanges();
                Grid();
            }
        }

        private void commandBarButton2_Click(object sender, EventArgs e)
        {
            if (rgvShowListOrder.CurrentRow != null)
            {
                int orderid = int.Parse(rgvShowListOrder.CurrentRow.Cells[0].Value.ToString());
                if (new FrmNewOrder(){ Idorder = orderid}.ShowDialog() == DialogResult.OK)
                {
                    Grid();
                }
            }

        }

        private void rgvShowListOrder_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int orderid = int.Parse(rgvShowListOrder.CurrentRow.Cells[0].Value.ToString());
            if (new FrmDetShowOrder() { Orderid = orderid }.ShowDialog() == DialogResult.OK)
            {
                Grid();
            }
        }
    }
}

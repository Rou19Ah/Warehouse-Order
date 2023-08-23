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
    public partial class FrmDetShowOrder : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();

        public int Orderid = 0;
        public FrmDetShowOrder()
        {
            InitializeComponent();
        }

        private void FrmDetShowOrder_Load(object sender, EventArgs e)
        {
            if (Orderid != 0)
            {
                var order = (from u in D.Sh_OrderDet
                             where u.OrderID == Orderid
                             select new
                             {
                                 u.OrderID,
                                 u.Sh_Product.ProductName,
                                 u.Count,
                                 u.Price,
                                 u.PriceAll,
                             }).ToList();
                rgvdetlistorder.DataSource = order;
                SubAllOrder();
            }
        }
        private void SubAllOrder()
        {
            float sum = rgvdetlistorder.Rows.Select(row => float.Parse(row.Cells[3].Value.ToString()))
                                            .Aggregate<float, float>(0, (current, price) => current + price);
            txtpriceall.Text = sum.ToString();
        }
    }
}

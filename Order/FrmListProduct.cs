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
    public partial class FrmListProduct : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public int ProductId { get; set; }
        public string Productname { get; set; }
        public FrmListProduct()
        {
            InitializeComponent();
        }

        private void FrmListProduct_Load(object sender, EventArgs e)
        {
            rgvloadproduct.DataSource = D.Sh_Product.ToList();
        }

        private void rgvloadproduct_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            if(rgvloadproduct.CurrentRow!=null)
            {
                ProductId = int.Parse(rgvloadproduct.CurrentRow.Cells[0].Value.ToString());
                Productname = rgvloadproduct.CurrentRow.Cells[1].Value.ToString();
                DialogResult = DialogResult.OK;
            }
        }
    }
}

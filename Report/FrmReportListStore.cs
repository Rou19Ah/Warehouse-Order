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

namespace Order.Report
{
    public partial class FrmReportListStore : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public FrmReportListStore()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            DataTable T = new DataTable();
            T.Columns.Add("ProductName");
            T.Columns.Add("Count");
            T.Columns.Add("Date");
            foreach(var row in rgvProductStore.Rows)
            {
                T.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value);
            }
            stiReport1.RegData("T", T);
            stiReport1.Show();
        }

        private void FrmReportListStore_Load(object sender, EventArgs e)
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

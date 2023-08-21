using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Order.Customer;
using Order.Store;
using Order.Product;
using Order.Order;
using Order.Report;
using Order.Accounts;

namespace Order
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        private void radRibbonBarGroup2_Click(object sender, EventArgs e)
        {
            FrmStore Fa = new FrmStore();
            Fa.ShowDialog();
        }

        private void radRibbonBarGroup3_Click(object sender, EventArgs e)
        {
            FrmOrder Fa = new FrmOrder();
            Fa.ShowDialog();
        }

        private void radRibbonBarGroup4_Click(object sender, EventArgs e)
        {
            FrmProductStore Fa = new FrmProductStore();
            Fa.ShowDialog();
        }

        private void radRibbonBarGroup5_Click(object sender, EventArgs e)
        {
            FrmCustomer Fa = new FrmCustomer();
            Fa.ShowDialog();
        }

        private void radRibbonBarGroup6_Click(object sender, EventArgs e)
        {
            FrmReportListStore Fa = new FrmReportListStore();
            Fa.ShowDialog();
        }

        private void radRibbonBarGroup7_Click(object sender, EventArgs e)
        {
            FrmAccount Fa = new FrmAccount();
            Fa.ShowDialog();
        }

        private void radRibbonBarGroup1_Click(object sender, EventArgs e)
        {
            FrmProduct Fa = new FrmProduct();
            Fa.ShowDialog();
        }
    }
}

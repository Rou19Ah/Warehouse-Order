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
    public partial class FrmNewOrder : Form
    {
        private Server.D_ShopOrderEntities D = new D_ShopOrderEntities();
        public int Idorder = 0;
        public FrmNewOrder()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            if (txtCount.Text == string.Empty)
            {
                MessageBox.Show("تعداد کالا را لطفا مشخص کنید");
            }
            else
            {
                int productid = int.Parse(ddlProduct.SelectedValue.ToString());
                int price = (from u in D.Sh_Product where u.ProductID == productid select u.Price).First();
                rgvListOrder.Rows.Add(productid, ddlProduct.Text, txtCount.Text, price);
                SumOrderProduct();
                SubAllOrder();
            }
        }

        private void FrmNewOrder_Load(object sender, EventArgs e)
        {
            if (Idorder != 0)
            {
                Edit();
                txtDate.Text = DateTime.Now.ToString("yyy/MM/dd");
                ddlProduct.DataSource = D.Sh_Product.ToList();
                ddlCustomer.DataSource = D.Sh_Customer.ToList();
            }
            else
            {
                txtDate.Text = DateTime.Now.ToString("yyy/MM/dd");
                ddlProduct.DataSource = D.Sh_Product.ToList();
                ddlCustomer.DataSource = D.Sh_Customer.ToList();
            }
        }
        private void SumOrderProduct()
        {
            try
            {
                foreach (var row in rgvListOrder.Rows)
                {
                    int count = int.Parse(row.Cells[2].Value.ToString());
                    int price = int.Parse(row.Cells[3].Value.ToString());
                    row.Cells[4].Value = (count * price).ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("تعداد کالا را لطفا مشخص کنید");
            }
        }
        public void Edit()
        {
            #region نمایش اطلاعات برای ویرایش فاکتور

            var edit = (from o in D.Sh_OrderDet where o.OrderID == Idorder select o).First();
            ddlCustomer.SelectedValue = edit.Sh_Order.CustomerID;
            txtDate.Text = edit.Sh_Order.Date.ToString();
            var od = (from u in D.Sh_OrderDet where u.OrderID == Idorder select u).ToList();
            foreach (var row in od)
            {
                rgvListOrder.Rows.Add(row.ProductID, row.Sh_Product.ProductName, row.Count, row.Price, row.PriceAll);
            }
            SubAllOrder();
            #endregion
        }
        private void SubAllOrder()
        {
            float sum = rgvListOrder.Rows.Select(row => float.Parse(row.Cells[4].Value.ToString())).Aggregate<float, float>(0, (current, price) => current + price);
            txtsum.Text = sum.ToString();
        }
        private void MinusProductsCount()
        {
            foreach(var row in rgvListOrder.Rows)
            {
                int productid = int.Parse(row.Cells[0].Value.ToString());
                int productmoj = (from u in D.Sh_Product where u.ProductID == productid select u.Count).First();
                int countfactor = int.Parse(row.Cells[2].Value.ToString());
                var update = (from p in D.Sh_Product where p.ProductID == productid select p).First();
                update.Count = productmoj - countfactor;
                D.SaveChanges();
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (Idorder == 0)
            {
                #region ثبت فاکتور
                Sh_Order order = new Sh_Order()
                {
                    CustomerID = int.Parse(ddlCustomer.SelectedValue.ToString()),
                    Date = DateTime.Now,
                };
                D.Sh_Order.Add(order);
                D.SaveChanges();
                foreach (var row in rgvListOrder.Rows)
                {
                    D.Sh_OrderDet.Add(new Sh_OrderDet()
                    {
                        OrderID = order.OrderID,
                        ProductID = int.Parse(row.Cells[0].Value.ToString()),
                        Count = int.Parse(row.Cells[2].Value.ToString()),
                        Price = int.Parse(row.Cells[3].Value.ToString()),
                        PriceAll = int.Parse(row.Cells[4].Value.ToString()),
                    });
                }
                D.SaveChanges();
                MinusProductsCount();
                printfactor();
                #endregion
            }
            else
            {
                (from u in D.Sh_OrderDet where u.OrderID == Idorder select u).ToList()
                                                                             .ForEach(c => D.Sh_OrderDet.Remove(c));
                foreach (var row in rgvListOrder.Rows)
                {
                    D.Sh_OrderDet.Add(new Sh_OrderDet()
                    {
                        OrderID = Idorder,
                        ProductID = int.Parse(row.Cells[0].Value.ToString()),
                        Count = int.Parse(row.Cells[2].Value.ToString()),
                        Price = int.Parse(row.Cells[3].Value.ToString()),
                        PriceAll = int.Parse(row.Cells[4].Value.ToString()),
                    });
                }
                D.SaveChanges();
                MinusProductsCount();
                DialogResult = DialogResult.OK;
            }
        }
        private void printfactor()
        {
            DataTable T = new DataTable();
            T.Columns.Add("CustomerName");
            T.Columns.Add("Date");
            T.Columns.Add("ProductName");
            T.Columns.Add("ProductCount");
            T.Columns.Add("ProductPrice");
            T.Columns.Add("ProductPriceAll");
            T.Columns.Add("SumAllOrders");
            foreach(var row in rgvListOrder.Rows)
            {
                T.Rows.Add(ddlCustomer.Text, txtDate.Text, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, txtsum.Text);
            }
            stiReport1.RegData("T",T);
            stiReport1.Show();
        }

        private void btnloadproduct_Click(object sender, EventArgs e)
        {
            FrmListProduct A = new FrmListProduct();
            if (A.ShowDialog() == DialogResult.OK)
            {
                ddlProduct.SelectedValue = A.ProductId;
                ddlProduct.Text = A.Productname;
            }
        }

        private void btnAddbarcode_Click(object sender, EventArgs e)
        {
            if(txtCount.Text == string.Empty)
            {
                var productbarcode = int.Parse(txtbarcode.Text);
                var product = (from u in D.Sh_Product where u.Barcode == productbarcode select u).First();
                rgvListOrder.Rows.Add(product.ProductID, product.ProductName,1,product.Price);
                SumOrderProduct();
            }
            else
            {
                var productbarcode = int.Parse(txtbarcode.Text);
                var product = (from u in D.Sh_Product where u.Barcode == productbarcode select u).First();
                rgvListOrder.Rows.Add(product.ProductID, product.ProductName,txtCount.Text, product.Price);
                SumOrderProduct();
            }
            
        }
    }
}

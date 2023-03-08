using InventoryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class FormOrders : Form
    {
        Manager.DBManager NewDbManager;
        Adatbazis AB = new Adatbazis();
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate SaveEvent;
        private int cust, prod;

        public FormOrders()
        {
            InitializeComponent();
        }

        private void DGV_Frissit()
        {
            DGVCustomer.DataSource = AB.Customers.ToList();
            DGVProduct.DataSource = AB.Products.ToList();
            DGVOrder.DataSource = AB.Orders.ToList();
        }

        private void btnInsertOrder_Click(object sender, EventArgs e)
        {
            DGV_Frissit();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            DTP.Value = DateTime.Now;
            DGV_Frissit();
            DGVProduct.ForeColor = Color.Black;
            DGVOrder.ForeColor = Color.Black;
            DGVCustomer.ForeColor = Color.Black;
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {

        }

        private void DGVCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cust = Convert.ToInt32(DGVCustomer.Rows[DGVCustomer.CurrentCell.RowIndex].Cells[0].Value);
            txtCustId.Text = AB.Customers.SingleOrDefault(x => x.CustomerID == cust).CustomerID.ToString();
            txtCustName.Text = AB.Customers.SingleOrDefault(x => x.CustomerID == cust).CustomerName.ToString();
        }

        private void txtOrderQuantity_TextChanged(object sender, EventArgs e)
        {
            if(txtOrderQuantity.Text != string.Empty)
            {
                txtTotalPrice.Text = (Convert.ToInt32(txtOrderQuantity.Text) * Convert.ToInt32(txtProdPrice.Text)).ToString();
            }
            else
            {
                txtTotalPrice.Text = string.Empty;
            }
        }

        private void btnInsertOrder_Click_1(object sender, EventArgs e)
        {
            if (cust >= 0 && prod >= 0 && !txtOrderQuantity.Text.Equals(string.Empty))
            {
                Order newOrder = new Order();
                newOrder.ProductID = AB.Products.SingleOrDefault(x => x.ProductID == prod).ProductID;
                newOrder.ProductName = AB.Products.SingleOrDefault(x => x.ProductID == prod).ProductName.ToString();
                newOrder.Quantity = Convert.ToInt32(txtOrderQuantity.Text);
                newOrder.UnitPrice = AB.Products.SingleOrDefault(x => x.ProductID == prod).ProductPrice;
                newOrder.TotalPrice = newOrder.UnitPrice * newOrder.Quantity;
                newOrder.CustomerID = AB.Customers.SingleOrDefault(x => x.CustomerID == cust).CustomerID;
                newOrder.CustomerName = AB.Customers.SingleOrDefault(x => x.CustomerID == cust).CustomerName;
                newOrder.OrderDate = Convert.ToDateTime(DTP.Value.ToString());
                AB.Orders.Add(newOrder);
                AB.SaveChanges();
                DGV_Frissit();
            }
            else
            {
                MessageBox.Show("Új rendelés hozzáadásához  jelöljön ki elemeket a felső 2 adathalmazból, vagy adjon meg releváns mennyiséget!");
            }

        }

        private void btnViewOrders_Click_1(object sender, EventArgs e)
        {
            FormOrderDGV FDGV = new FormOrderDGV();
            FDGV.Show();
        }

        private void DGVProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prod = Convert.ToInt32(DGVProduct.Rows[DGVProduct.CurrentCell.RowIndex].Cells[0].Value);
            txtProdPrice.Text = AB.Products.SingleOrDefault(x => x.ProductID == prod).ProductPrice.ToString();
        }
    }
}

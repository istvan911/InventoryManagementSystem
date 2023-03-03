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
            DGV_Frissit();
            DGVProduct.ForeColor = Color.Black;
            DGVOrder.ForeColor = Color.Black;
            DGVCustomer.ForeColor = Color.Black;
        }
    }
}

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
    public partial class FormOrderDGV : Form
    {
        Manager.DBManager NewDbManager;
        Adatbazis AB = new Adatbazis();
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate SaveEvent;
        private int mov, movY, movX;
        int oId;

        public FormOrderDGV()
        {
            InitializeComponent();
        }
        private void iconexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormOrderDGV_Load(object sender, EventArgs e)
        {
            DGVOrder.DataSource = AB.Orders.ToList();
        }

        private void panelMove_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void DGVOrder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oId = Convert.ToInt32(DGVOrder.Rows[DGVOrder.CurrentCell.RowIndex].Cells[0].Value);
            if (printPreDialog.ShowDialog() == DialogResult.OK)
            {
                printDoc.Print();
            }
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var ord = AB.Orders.SingleOrDefault(x => x.OrderID == oId);
            e.Graphics.DrawString("Order summary", new Font("Segoe UI", 25, FontStyle.Bold), Brushes.Red,new PointF(270,30));
            e.Graphics.DrawString("Order id: " + ord.OrderID, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 60));
            e.Graphics.DrawString("Product id: " + ord.ProductID, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 90));
            e.Graphics.DrawString("Product name: " + ord.ProductName, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 120));
            e.Graphics.DrawString("Quantity: " + ord.Quantity, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 150));
            e.Graphics.DrawString("Unit price: " + ord.UnitPrice, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 180));
            e.Graphics.DrawString("Total price: " + ord.TotalPrice, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 210));
            e.Graphics.DrawString("Cutomer id: " + ord.CustomerID, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 240));
            e.Graphics.DrawString("Customer name: " + ord.CustomerName, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 270));
            e.Graphics.DrawString("Order date: " + ord.OrderDate, new Font("Segoe UI", 15, FontStyle.Regular), Brushes.Black, new PointF(20, 300));

        }

        private void panelMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panelMove_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}

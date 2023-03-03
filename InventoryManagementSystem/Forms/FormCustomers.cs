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
    public partial class FormCustomers : Form
    {
        Manager.DBManager NewDbManager;
        Adatbazis AB = new Adatbazis();
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate SaveEvent;
        private int cust;

        public FormCustomers()
        {
            InitializeComponent();
        }

        private void DGV_Frissit()
        {
            DGVCustomer.DataSource = AB.Customers.ToList();
        }

        private void DeleteFields()
        {
            txtCustName.Text = "";
            txtCustEmail.Text = "";
            txtCustPhone.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var lst = AB.Customers.ToList();
            if (lst.Count(x => x.CustomerName.Equals(txtCustName.Text)) != 0 && lst.Count(x => x.CustomerEmail.Equals(txtCustEmail.Text)) != 0 && lst.Count(x => x.CustomerPhone.Equals(txtCustPhone.Text)) != 0)
            {
                MessageBox.Show("Ezekkel az adatokkal már létezik ügyfél!");
            }
            else
            {
                Customer newCust = new Customer();
                newCust.CustomerName = txtCustName.Text;
                newCust.CustomerEmail = txtCustEmail.Text;
                newCust.CustomerPhone = txtCustPhone.Text;
                AB.Customers.Add(newCust);
                AB.SaveChanges();
                DGV_Frissit();
            }
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            DGVCustomer.ForeColor = Color.Black;
            DGV_Frissit();
        }

        private void btnDeleteFields_Click(object sender, EventArgs e)
        {
            DeleteFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Biztosan törölni szeretné a felhasználót?",
                       "Visszajelzés kérése", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
            {
                return;
            }
            String name = Convert.ToString(DGVCustomer.Rows[DGVCustomer.CurrentCell.RowIndex].Cells[1].Value);
            var remove = AB.Customers.SingleOrDefault(x => x.CustomerName.Equals(name));
            if (remove != null)
            {
                AB.Customers.Remove(remove);
                AB.SaveChanges();
            }
            DGV_Frissit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var it in AB.Customers)
                {
                    if (it.CustomerID== cust)
                    {
                        if (!txtCustEmail.Text.Equals("") && !txtCustName.Text.Equals("") && !txtCustPhone.Text.Equals(""))
                        {
                            if (AB.Customers.Count(x => x.CustomerName.Equals(txtCustName.Text)) <= 1 && AB.Customers.Count(x => x.CustomerPhone.Equals(txtCustPhone.Text)) <= 1 && AB.Customers.Count(x => x.CustomerEmail.Equals(txtCustEmail.Text)) <= 1)
                            {
                                it.CustomerPhone = txtCustPhone.Text;
                                it.CustomerName = txtCustName.Text;
                                it.CustomerEmail = txtCustEmail.Text;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Az alábbi ügyfél már szerepel az adatbázisban!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Minden mező kitöltése kötelező!");
                        }
                    }
                }
                AB.SaveChanges();
                DGV_Frissit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DGVCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cust = Convert.ToInt32(DGVCustomer.Rows[DGVCustomer.CurrentCell.RowIndex].Cells[0].Value);
            txtCustName.Text = AB.Customers.SingleOrDefault(x => x.CustomerID == cust).CustomerName.ToString();
            txtCustEmail.Text = AB.Customers.SingleOrDefault(x => x.CustomerID == cust).CustomerEmail.ToString();
            txtCustPhone.Text = AB.Customers.SingleOrDefault(x => x.CustomerID == cust).CustomerPhone.ToString();
        }
    }
}

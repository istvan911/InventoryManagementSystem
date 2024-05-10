using InventoryManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementSystem.Forms
{
    public partial class FormProducts : Form
    {
        Manager.DBManager NewDbManager;
        Adatbazis AB = new Adatbazis();
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate SaveEvent;
        private int prodId;

        public FormProducts()
        {
            InitializeComponent();
        }

        private void DGV_Frissit()
        {
            DGVProduct.DataSource = AB.Products.ToList();
        }

        private void FormProducts_Load(object sender, EventArgs e)
        {
            foreach (var i in AB.Categories.ToList())
            {
                cmbProdCatSearch.Items.Add(i.CategoryName.ToString());
                cmbProdCat.Items.Add(i.CategoryName.ToString());
            }
            cmbProdCatSearch.Text = "Category...";
            cmbProdCat.Text = "Category...";
            DGVProduct.ForeColor = Color.Black;
            DGV_Frissit();

        }
        private void DeleteFields()
        {
            txtProdDesc.Text = "";
            txtProdName.Text = "";
            txtProdPrice.Text = "";
            txtProdQuan.Text = "";
            cmbProdCat.Text = "Category...";
            cmbProdCatSearch.Text = "Category...";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var lst = AB.Products.ToList();
            if (lst.Count(x => x.ProductName.Equals(txtProdName.Text)) != 0 && (lst.Count(x => x.ProductCategory.Equals(cmbProdCat.Text)) != 0 && cmbProdCat.Text == "Category...") && lst.Count(x => x.ProductDescription.Equals(txtProdDesc.Text)) != 0)
            {
                MessageBox.Show("Az alábbi termék már szerepel az adatbázisban!");
            }
            else
            {
                Product newProd = new Product();
                newProd.ProductName = txtProdName.Text;
                newProd.ProductQuantity = Convert.ToInt32(txtProdQuan.Text);
                newProd.ProductPrice = Convert.ToInt32(txtProdPrice.Text);
                newProd.ProductDescription = txtProdDesc.Text;
                newProd.ProductCategory = cmbProdCat.Text;
                AB.Products.Add(newProd);
                AB.SaveChanges();
                DGV_Frissit();

            }
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
            String prod = Convert.ToString(DGVProduct.Rows[DGVProduct.CurrentCell.RowIndex].Cells[1].Value);
            var remove = AB.Products.SingleOrDefault(x => x.ProductName.Equals(prod));
            if (remove != null)
            {
                AB.Products.Remove(remove);
                AB.SaveChanges();
            }
            DGV_Frissit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var it in AB.Products)
                {
                    if (it.ProductID == prodId)
                    {
                        if (!txtProdDesc.Text.Equals("") && !txtProdQuan.Text.Equals("") && !txtProdName.Text.Equals("") && !txtProdPrice.Text.Equals("") && !cmbProdCat.Text.Equals(""))
                        {
                            if (AB.Products.Count(x => x.ProductName.Equals(txtProdName.Text)) <= 1)
                            {
                                it.ProductName = txtProdName.Text;
                                it.ProductQuantity = Convert.ToInt32(txtProdQuan.Text);
                                it.ProductPrice = Convert.ToInt32(txtProdPrice.Text);
                                it.ProductDescription = txtProdDesc.Text;
                                it.ProductCategory = cmbProdCat.Text;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Az alábbi termékből már található az adatbázisban!");
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

        private void DGVProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            prodId = Convert.ToInt32(DGVProduct.Rows[DGVProduct.CurrentCell.RowIndex].Cells[0].Value);
            txtProdName.Text = AB.Products.SingleOrDefault(x => x.ProductID == prodId).ProductName.ToString();
            txtProdQuan.Text = AB.Products.SingleOrDefault(x => x.ProductID == prodId).ProductQuantity.ToString();
            txtProdPrice.Text = AB.Products.SingleOrDefault(x => x.ProductID == prodId).ProductPrice.ToString();
            txtProdDesc.Text = AB.Products.SingleOrDefault(x => x.ProductID == prodId).ProductDescription.ToString();
            cmbProdCat.Text = AB.Products.SingleOrDefault(x => x.ProductID == prodId).ProductCategory.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGVProduct.DataSource = AB.Products.Where(x => x.ProductCategory.Equals(cmbProdCatSearch.Text)).ToList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DGV_Frissit();
            cmbProdCatSearch.Text = "Category...";
            cmbProdCat.Text = "Category...";
        }
    }
}

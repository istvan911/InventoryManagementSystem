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
    public partial class FormCategories : Form
    {
        Manager.DBManager NewDbManager;
        Adatbazis AB = new Adatbazis();
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate SaveEvent;
        private int cat;

        public FormCategories()
        {
            InitializeComponent();
        }

        private void DGV_Frissit()
        {
            AB.SaveChanges();
            DGVCategories.DataSource = AB.Categories.ToList();
        }
        private void DeleteFields()
        {
            txtcategory.Text = "";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            var lst = AB.Categories.ToList();
            if (lst.Count(x => x.CategoryName.Equals(txtcategory.Text)) != 0)
            {
                MessageBox.Show("A megadott kategória már létezik!");
            }
            else
            {
                Category newCat = new Category();
                newCat.CategoryName = txtcategory.Text;
                AB.Categories.Add(newCat);
                DGV_Frissit();
            }
        }

        private void FormCategories_Load(object sender, EventArgs e)
        {
            DGVCategories.DataSource = AB.Categories.ToList();
            DGVCategories.ForeColor = Color.Black;
        }

        private void btnDeleteFields_Click(object sender, EventArgs e)
        {
            DeleteFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Biztosan törölni szeretné a felhasználót?",
                           "Visszajelzés kérése", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                String cat = Convert.ToString(DGVCategories.Rows[DGVCategories.CurrentCell.RowIndex].Cells[1].Value);
                var remove = AB.Categories.SingleOrDefault(x => x.CategoryName.Equals(cat));
                if (remove != null)
                {
                    AB.Categories.Remove(remove);
                    DGV_Frissit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var it in AB.Categories)
                {
                    if (it.CategoryID == cat)
                    {
                        if (!txtcategory.Text.Equals(""))
                        {
                            if (AB.Categories.Count(x => x.CategoryName.Equals(txtcategory.Text)) == 0)
                            {
                                it.CategoryName = txtcategory.Text;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("A kategória már szerepel az adatbázisban!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Minden mező kitöltése kötelező!");
                        }
                    }
                }
                DGV_Frissit();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void DGVCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cat = Convert.ToInt32(DGVCategories.Rows[DGVCategories.CurrentCell.RowIndex].Cells[0].Value);
            txtcategory.Text = AB.Categories.SingleOrDefault(x => x.CategoryID == cat).CategoryName.ToString();
        }
    }
}

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
    public partial class FormUsers : Form
    {
        Manager.DBManager NewDbManager;
        Adatbazis AB = new Adatbazis();
        public delegate void ABmentesDelegate(string tablanev);
        public event ABmentesDelegate SaveEvent;
        private int userId;

        public FormUsers()
        {
            InitializeComponent();
        }

        private void DGV_Frissit()
        {
            DGVUser.DataSource = AB.Users.ToList();
        }

        private void DeleteFields()
        {
            txtusername.Text = "";
            txtemail.Text = "";
            txtphone.Text = "";
            txtpass.Text = "";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var lst = AB.Users.ToList();
            if(txtusername.Text == "" || txtpass.Text == "" || txtemail.Text == "" || txtphone.Text == "")
            {
                MessageBox.Show("A felhasználó létrehozásához minden mező kitöltése szükséges.");
            }
            else
            {
                if(lst.Count(x=>x.Username.Equals(txtusername.Text)) != 0)
                {
                    MessageBox.Show("A felhasználónév már foglalt, kérem válasszon másikat!");
                }
                else
                {
                    if(lst.Count(x=>x.Email.Equals(txtemail.Text)) != 0)
                    {
                        MessageBox.Show("Az email cím már foglalt, kérem adjon meg másikat!");
                    }
                    else
                    {
                        if(lst.Count(x=>x.Phone.Equals(txtphone.Text)) != 0)
                        {
                            MessageBox.Show("A telefonszám már foglalt, kérem adjon meg másikat!");

                        }
                        else
                        {
                            User newUser = new User();
                            newUser.Username = txtusername.Text;
                            newUser.Password= txtpass.Text;
                            newUser.Email = txtemail.Text;
                            newUser.Phone = txtphone.Text;
                            AB.Users.Add(newUser);
                            AB.SaveChanges();
                            DGV_Frissit();
                        }
                    }
                }
            }
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            DGVUser.ForeColor = Color.Black;
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
            String user = Convert.ToString(DGVUser.Rows[DGVUser.CurrentCell.RowIndex].Cells[1].Value);
            var remove = AB.Users.SingleOrDefault(x => x.Username.Equals(user));
            if (remove != null)
            {
                AB.Users.Remove(remove);
                AB.SaveChanges();
            }
            DGV_Frissit();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (var it in AB.Users)
                {
                    if (it.UserID == userId)
                    {
                        if (!txtusername.Text.Equals("") && !txtpass.Text.Equals("") && !txtemail.Text.Equals("") && !txtphone.Text.Equals(""))
                        {
                            if (AB.Users.Count(x => x.Username.Equals(txtusername.Text)) <= 1 && AB.Users.Count(x => x.Phone.Equals(txtphone.Text)) <= 1 && AB.Users.Count(x => x.Email.Equals(txtemail.Text)) <= 1)
                            {
                                it.Username = txtusername.Text;
                                it.Password = txtpass.Text;
                                it.Email = txtemail.Text;
                                it.Phone = txtphone.Text;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Az alábbi felhasználó már szerepel az adatbázisban!");
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

        private void DGVUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            userId = Convert.ToInt32(DGVUser.Rows[DGVUser.CurrentCell.RowIndex].Cells[0].Value);
            txtusername.Text = AB.Users.SingleOrDefault(x => x.UserID == userId).Username.ToString();
            txtpass.Text = AB.Users.SingleOrDefault(x => x.UserID == userId).Password.ToString();
            txtemail.Text = AB.Users.SingleOrDefault(x => x.UserID == userId).Email.ToString();
            txtphone.Text = AB.Users.SingleOrDefault(x => x.UserID == userId).Phone.ToString();
        }
    }
}

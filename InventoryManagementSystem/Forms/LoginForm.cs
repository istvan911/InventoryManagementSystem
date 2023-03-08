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
    public partial class LoginForm : Form
    {
        Manager.DBManager UjDbManager;
        Adatbazis AB = new Adatbazis();
        private bool hided = true,note = false;
        int mov,movX,movY;
        public LoginForm()
        {
            InitializeComponent();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var lst = AB.Users.ToList();
            if(lst.Count(x=>x.Username == txtUsername.Text) == 1 && lst.Count(x => x.Password == txtPassword.Text) == 1)
            {
                Form Main = new MainWindow();
                this.Hide();
                Main.Show();
                if (note)
                {
                    Properties.UserSettings.Default.Username = txtUsername.Text;
                    Properties.UserSettings.Default.Password = txtPassword.Text;
                }
                else
                {
                    Properties.UserSettings.Default.Username = txtUsername.Text;
                    Properties.UserSettings.Default.Password = "NA";
                }
                Properties.UserSettings.Default.Save();
                
            }
            else
            {
                MessageBox.Show("Helytelen felhasználónév/jelszó, kérem próbálja újra, vagy kérje jelszavának alaphelyzetbe állítását!");
            }
        }

        private void iconexit_Click(object sender, EventArgs e)
        {
            if (note)
            {
                Properties.UserSettings.Default.Username = txtUsername.Text;
                Properties.UserSettings.Default.Password = txtPassword.Text;
            }
            else
            {
                Properties.UserSettings.Default.Username = txtUsername.Text;
                Properties.UserSettings.Default.Password = "NA";
            }
            Properties.UserSettings.Default.Save();
            Application.Exit();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void iconexit_MouseEnter(object sender, EventArgs e)
        {
            iconexit.IconColor = Color.Red;
        }

        private void iconexit_MouseLeave(object sender, EventArgs e)
        {
            iconexit.IconColor = Color.White;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("")) txtPassword.Text = "Password";
            if (txtUsername.Text.Equals("Username")) txtUsername.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals("")) txtUsername.Text = "Username";
            if (txtPassword.Text.Equals("Password")) txtPassword.Text = "";
        }

        private void adatcheck_CheckedChanged(object sender, EventArgs e)
        {
            if(adatcheck.Checked)
            {
                note = true;
            }
            else
            {
                note = false;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if(Properties.UserSettings.Default.Password == "NA")
            {
                txtUsername.Text = "Username";
                txtPassword.Text = "Password";
            }
            else
            {
                txtUsername.Text = Properties.UserSettings.Default.Username;
                txtPassword.Text = Properties.UserSettings.Default.Password;
                adatcheck.CheckState = CheckState.Checked;
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconHide_Click(object sender, EventArgs e)
        {
            if (hided)
            {
                iconHide.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtPassword.UseSystemPasswordChar = false;
                hided = false;
            }

            else 
            {
                iconHide.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtPassword.UseSystemPasswordChar = true;
                hided = true;
            } 
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
    }
}

using FontAwesome.Sharp;

namespace InventoryManagementSystem
{
    public partial class MainWindow : Form
    {
        private Form currentChildForm;
        IconButton currentBtn;
        public MainWindow()
        {
            InitializeComponent();
        }

        int mov, movX, movY;

        private void CloseChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
        private void OpenChildForm(Form childForm)
        {
            CloseChildForm();
            currentChildForm = childForm;
            childForm.Size = panelMain.Size;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void Button_Enable(Button sender, Color color)
        {
            if (sender != null)
            {
                Button_Disable();
                currentBtn = (IconButton)sender;
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
            }
        }
        private void Button_Disable()
        {
            if (currentBtn != null)
            {
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {
            lblUser.Text = Properties.UserSettings.Default.Username.ToString();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender,Color.FromArgb(168, 12, 21));
            OpenChildForm(new Forms.FormUsers());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender, Color.FromArgb(168, 12, 21));
            OpenChildForm(new Forms.FormProducts());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender, Color.FromArgb(168, 12, 21));
            OpenChildForm(new Forms.FormCategories());
        }

        private void btnCostumers_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender, Color.FromArgb(168, 12, 21));
            OpenChildForm(new Forms.FormCustomers());
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Button_Enable((IconButton)sender, Color.FromArgb(168, 12, 21));
            OpenChildForm(new Forms.FormOrders());
        }

        private void iconexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState= FormWindowState.Minimized;
        }

        private void iconMaximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal) 
                WindowState = FormWindowState.Maximized;
            else 
                WindowState = FormWindowState.Normal;
        }

        private void iconexit_MouseEnter(object sender, EventArgs e)
        {
            iconexit.IconColor = Color.Red;
        }

        private void iconexit_MouseLeave(object sender, EventArgs e)
        {
            iconexit.IconColor = Color.White;
        }

        private void iconMaximize_MouseEnter(object sender, EventArgs e)
        {
            iconMaximize.IconColor = Color.Yellow;
        }

        private void iconMaximize_MouseLeave(object sender, EventArgs e)
        {
            iconMaximize.IconColor = Color.White;
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X+250;
            movY = e.Y;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void iconMinimize_MouseEnter(object sender, EventArgs e)
        {
            iconMinimize.IconColor = Color.Yellow;
        }

        private void iconMinimize_MouseLeave(object sender, EventArgs e)
        {
            iconMinimize.IconColor = Color.White;
        }
    }
}
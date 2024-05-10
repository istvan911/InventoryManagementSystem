namespace InventoryManagementSystem.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            iconexit = new FontAwesome.Sharp.IconPictureBox();
            iconHide = new FontAwesome.Sharp.IconPictureBox();
            label4 = new Label();
            adatcheck = new CheckBox();
            label3 = new Label();
            btnLogin = new Button();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconexit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)iconHide).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(iconexit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 40);
            panel1.TabIndex = 32;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // iconexit
            // 
            iconexit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconexit.BackColor = Color.FromArgb(31, 30, 78);
            iconexit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            iconexit.IconColor = Color.White;
            iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconexit.IconSize = 40;
            iconexit.Location = new Point(460, 0);
            iconexit.Name = "iconexit";
            iconexit.Size = new Size(40, 40);
            iconexit.TabIndex = 12;
            iconexit.TabStop = false;
            iconexit.Click += iconexit_Click;
            iconexit.MouseEnter += iconexit_MouseEnter;
            iconexit.MouseLeave += iconexit_MouseLeave;
            // 
            // iconHide
            // 
            iconHide.BackColor = Color.FromArgb(31, 30, 68);
            iconHide.IconChar = FontAwesome.Sharp.IconChar.Eye;
            iconHide.IconColor = Color.White;
            iconHide.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconHide.IconSize = 43;
            iconHide.Location = new Point(409, 345);
            iconHide.Name = "iconHide";
            iconHide.Size = new Size(43, 43);
            iconHide.TabIndex = 33;
            iconHide.TabStop = false;
            iconHide.Click += iconHide_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(353, 414);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 31;
            label4.Text = "Note data";
            // 
            // adatcheck
            // 
            adatcheck.AutoSize = true;
            adatcheck.Location = new Point(435, 417);
            adatcheck.Name = "adatcheck";
            adatcheck.Size = new Size(18, 17);
            adatcheck.TabIndex = 30;
            adatcheck.UseVisualStyleBackColor = true;
            adatcheck.CheckedChanged += adatcheck_CheckedChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(93, 55);
            label3.Name = "label3";
            label3.Size = new Size(328, 41);
            label3.TabIndex = 29;
            label3.Text = "Inventory Management";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(30, 30, 70);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(93, 456);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(318, 62);
            btnLogin.TabIndex = 28;
            btnLogin.Tag = "1";
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += Login_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(53, 297);
            label2.Name = "label2";
            label2.Size = new Size(143, 41);
            label2.TabIndex = 25;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(53, 193);
            label1.Name = "label1";
            label1.Size = new Size(152, 41);
            label1.TabIndex = 24;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Top;
            txtPassword.BackColor = Color.FromArgb(31, 30, 68);
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(53, 341);
            txtPassword.Margin = new Padding(3, 3, 0, 3);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(353, 47);
            txtPassword.TabIndex = 23;
            txtPassword.Text = "Password";
            txtPassword.TextAlign = HorizontalAlignment.Center;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Click += txtPassword_Click;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Top;
            txtUsername.BackColor = Color.FromArgb(31, 30, 68);
            txtUsername.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.ForeColor = Color.White;
            txtUsername.Location = new Point(53, 237);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(400, 47);
            txtUsername.TabIndex = 22;
            txtUsername.Text = "Username";
            txtUsername.TextAlign = HorizontalAlignment.Center;
            txtUsername.Click += txtUsername_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(197, 107);
            label7.Name = "label7";
            label7.Size = new Size(113, 41);
            label7.TabIndex = 34;
            label7.Text = "System";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 70);
            ClientSize = new Size(500, 600);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(iconHide);
            Controls.Add(label4);
            Controls.Add(adatcheck);
            Controls.Add(label3);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            DoubleBuffered = true;
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "f";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconexit).EndInit();
            ((System.ComponentModel.ISupportInitialize)iconHide).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconexit;
        private FontAwesome.Sharp.IconPictureBox iconHide;
        private Label label4;
        private CheckBox adatcheck;
        private Label label3;
        private Button btnLogin;
        private Label label2;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label7;
    }
}
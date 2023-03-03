namespace InventoryManagementSystem.Forms
{
    partial class FormUsers
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.DGVUser = new System.Windows.Forms.DataGridView();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteFields = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).BeginInit();
            this.tlp1.SuspendLayout();
            this.tlp2.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.tlp4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 1;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Controls.Add(this.DGVUser, 0, 0);
            this.tlpMain.Controls.Add(this.tlp1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpMain.Size = new System.Drawing.Size(1012, 623);
            this.tlpMain.TabIndex = 0;
            // 
            // DGVUser
            // 
            this.DGVUser.AllowUserToOrderColumns = true;
            this.DGVUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.DGVUser.Location = new System.Drawing.Point(3, 3);
            this.DGVUser.Name = "DGVUser";
            this.DGVUser.RowHeadersWidth = 51;
            this.DGVUser.RowTemplate.Height = 29;
            this.DGVUser.Size = new System.Drawing.Size(1006, 397);
            this.DGVUser.TabIndex = 17;
            this.DGVUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVUser_CellClick);
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.tlp2, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(3, 406);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp1.Size = new System.Drawing.Size(1006, 214);
            this.tlp1.TabIndex = 18;
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 1;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.tlp3, 0, 0);
            this.tlp2.Controls.Add(this.tlp4, 0, 1);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(3, 3);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 2;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp2.Size = new System.Drawing.Size(1000, 208);
            this.tlp2.TabIndex = 19;
            // 
            // tlp3
            // 
            this.tlp3.ColumnCount = 2;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp3.Controls.Add(this.label1, 0, 3);
            this.tlp3.Controls.Add(this.lbl3, 0, 0);
            this.tlp3.Controls.Add(this.label2, 0, 1);
            this.tlp3.Controls.Add(this.label3, 0, 2);
            this.tlp3.Controls.Add(this.txtusername, 1, 0);
            this.tlp3.Controls.Add(this.txtpass, 1, 1);
            this.tlp3.Controls.Add(this.txtemail, 1, 2);
            this.tlp3.Controls.Add(this.txtphone, 1, 3);
            this.tlp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp3.Location = new System.Drawing.Point(3, 3);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 4;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.Size = new System.Drawing.Size(994, 160);
            this.tlp3.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 40);
            this.label1.TabIndex = 79;
            this.label1.Text = "Phone:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(192, 40);
            this.lbl3.TabIndex = 73;
            this.lbl3.Text = "Username:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 40);
            this.label2.TabIndex = 75;
            this.label2.Text = "Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 40);
            this.label3.TabIndex = 77;
            this.label3.Text = "Email:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtusername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.Location = new System.Drawing.Point(201, 3);
            this.txtusername.MaxLength = 32764;
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(790, 34);
            this.txtusername.TabIndex = 80;
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtpass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.Location = new System.Drawing.Point(201, 43);
            this.txtpass.MaxLength = 32764;
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(790, 34);
            this.txtpass.TabIndex = 81;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtemail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtemail.ForeColor = System.Drawing.Color.White;
            this.txtemail.Location = new System.Drawing.Point(201, 83);
            this.txtemail.MaxLength = 32764;
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(790, 34);
            this.txtemail.TabIndex = 82;
            // 
            // txtphone
            // 
            this.txtphone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtphone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtphone.ForeColor = System.Drawing.Color.White;
            this.txtphone.Location = new System.Drawing.Point(201, 123);
            this.txtphone.MaxLength = 32764;
            this.txtphone.Multiline = true;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(790, 34);
            this.txtphone.TabIndex = 83;
            // 
            // tlp4
            // 
            this.tlp4.ColumnCount = 4;
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp4.Controls.Add(this.btnDelete, 0, 0);
            this.tlp4.Controls.Add(this.btnDeleteFields, 0, 0);
            this.tlp4.Controls.Add(this.btnNew, 0, 0);
            this.tlp4.Controls.Add(this.btnUpdate, 0, 0);
            this.tlp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp4.Location = new System.Drawing.Point(3, 169);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 1;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp4.Size = new System.Drawing.Size(994, 36);
            this.tlp4.TabIndex = 20;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(499, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(242, 30);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete user";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteFields
            // 
            this.btnDeleteFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFields.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFields.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFields.Location = new System.Drawing.Point(747, 3);
            this.btnDeleteFields.Name = "btnDeleteFields";
            this.btnDeleteFields.Size = new System.Drawing.Size(244, 30);
            this.btnDeleteFields.TabIndex = 81;
            this.btnDeleteFields.Text = "Delete fields";
            this.btnDeleteFields.UseVisualStyleBackColor = true;
            this.btnDeleteFields.Click += new System.EventHandler(this.btnDeleteFields_Click);
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(242, 30);
            this.btnNew.TabIndex = 80;
            this.btnNew.Text = "New user";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(251, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(242, 30);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update user";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.tlpMain);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormUsers";
            this.Text = "FormUsers2";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUser)).EndInit();
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.tlp3.ResumeLayout(false);
            this.tlp3.PerformLayout();
            this.tlp4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private DataGridView DGVUser;
        private TableLayoutPanel tlp1;
        private TableLayoutPanel tlp2;
        private TableLayoutPanel tlp3;
        private Label lbl3;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtusername;
        private TextBox txtpass;
        private TextBox txtemail;
        private TextBox txtphone;
        private TableLayoutPanel tlp4;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnDeleteFields;
        private Button btnDelete;
    }
}
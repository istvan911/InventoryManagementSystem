namespace InventoryManagementSystem.Forms
{
    partial class FormCustomers
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
            this.DGVCostumer = new System.Windows.Forms.DataGridView();
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteFields = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlpMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCostumer)).BeginInit();
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
            this.tlpMain.Controls.Add(this.DGVCostumer, 0, 0);
            this.tlpMain.Controls.Add(this.tlp1, 0, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Size = new System.Drawing.Size(1012, 623);
            this.tlpMain.TabIndex = 1;
            // 
            // DGVCostumer
            // 
            this.DGVCostumer.AllowUserToOrderColumns = true;
            this.DGVCostumer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCostumer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCostumer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustId,
            this.CustName,
            this.CustEmail,
            this.CustPhone});
            this.DGVCostumer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCostumer.Location = new System.Drawing.Point(3, 3);
            this.DGVCostumer.Name = "DGVCostumer";
            this.DGVCostumer.RowHeadersWidth = 51;
            this.DGVCostumer.RowTemplate.Height = 29;
            this.DGVCostumer.Size = new System.Drawing.Size(1006, 367);
            this.DGVCostumer.TabIndex = 17;
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.tlp2, 0, 0);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(3, 376);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 1;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp1.Size = new System.Drawing.Size(1006, 244);
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
            this.tlp2.Size = new System.Drawing.Size(1000, 238);
            this.tlp2.TabIndex = 19;
            // 
            // tlp3
            // 
            this.tlp3.ColumnCount = 2;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp3.Controls.Add(this.lbl3, 0, 0);
            this.tlp3.Controls.Add(this.label2, 0, 1);
            this.tlp3.Controls.Add(this.label3, 0, 2);
            this.tlp3.Controls.Add(this.txtCustName, 1, 0);
            this.tlp3.Controls.Add(this.txtCustEmail, 1, 1);
            this.tlp3.Controls.Add(this.txtCustPhone, 1, 2);
            this.tlp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp3.Location = new System.Drawing.Point(3, 3);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 3;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp3.Size = new System.Drawing.Size(994, 184);
            this.tlp3.TabIndex = 19;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(192, 62);
            this.lbl3.TabIndex = 73;
            this.lbl3.Text = "Customer name:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 60);
            this.label2.TabIndex = 75;
            this.label2.Text = "Customer email";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 62);
            this.label3.TabIndex = 77;
            this.label3.Text = "Customer phone";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCustName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustName.ForeColor = System.Drawing.Color.White;
            this.txtCustName.Location = new System.Drawing.Point(201, 3);
            this.txtCustName.MaxLength = 32764;
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(790, 56);
            this.txtCustName.TabIndex = 80;
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCustEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustEmail.ForeColor = System.Drawing.Color.White;
            this.txtCustEmail.Location = new System.Drawing.Point(201, 65);
            this.txtCustEmail.MaxLength = 32764;
            this.txtCustEmail.Multiline = true;
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(790, 54);
            this.txtCustEmail.TabIndex = 81;
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCustPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustPhone.ForeColor = System.Drawing.Color.White;
            this.txtCustPhone.Location = new System.Drawing.Point(201, 125);
            this.txtCustPhone.MaxLength = 32764;
            this.txtCustPhone.Multiline = true;
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(790, 56);
            this.txtCustPhone.TabIndex = 82;
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
            this.tlp4.Location = new System.Drawing.Point(3, 193);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 1;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp4.Size = new System.Drawing.Size(994, 42);
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
            this.btnDelete.Size = new System.Drawing.Size(242, 36);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete customer";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFields
            // 
            this.btnDeleteFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFields.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFields.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFields.Location = new System.Drawing.Point(747, 3);
            this.btnDeleteFields.Name = "btnDeleteFields";
            this.btnDeleteFields.Size = new System.Drawing.Size(244, 36);
            this.btnDeleteFields.TabIndex = 81;
            this.btnDeleteFields.Text = "Delete fields";
            this.btnDeleteFields.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(242, 36);
            this.btnNew.TabIndex = 80;
            this.btnNew.Text = "New customer";
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
            this.btnUpdate.Size = new System.Drawing.Size(242, 36);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update customer";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // CustId
            // 
            this.CustId.HeaderText = "Customer id";
            this.CustId.MinimumWidth = 6;
            this.CustId.Name = "CustId";
            // 
            // CustName
            // 
            this.CustName.HeaderText = "Customer name";
            this.CustName.MinimumWidth = 6;
            this.CustName.Name = "CustName";
            // 
            // CustEmail
            // 
            this.CustEmail.HeaderText = "Customer Email";
            this.CustEmail.MinimumWidth = 6;
            this.CustEmail.Name = "CustEmail";
            // 
            // CustPhone
            // 
            this.CustPhone.HeaderText = "Customer Phone";
            this.CustPhone.MinimumWidth = 6;
            this.CustPhone.Name = "CustPhone";
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.tlpMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCustomers";
            this.Text = "FormCostumers";
            this.tlpMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCostumer)).EndInit();
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            this.tlp3.ResumeLayout(false);
            this.tlp3.PerformLayout();
            this.tlp4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlpMain;
        private DataGridView DGVCostumer;
        private TableLayoutPanel tlp1;
        private TableLayoutPanel tlp2;
        private TableLayoutPanel tlp3;
        private Label lbl3;
        private Label label2;
        private Label label3;
        private TextBox txtCustName;
        private TextBox txtCustEmail;
        private TextBox txtCustPhone;
        private TableLayoutPanel tlp4;
        private Button btnDelete;
        private Button btnDeleteFields;
        private Button btnNew;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn CustId;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn CustEmail;
        private DataGridViewTextBoxColumn CustPhone;
    }
}
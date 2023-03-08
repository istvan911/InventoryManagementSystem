namespace InventoryManagementSystem.Forms
{
    partial class FormOrders
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
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVOrder = new System.Windows.Forms.DataGridView();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.tlp1.SuspendLayout();
            this.tlp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).BeginInit();
            this.tlp4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.tlp2, 0, 0);
            this.tlp1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tlp1.Size = new System.Drawing.Size(1012, 623);
            this.tlp1.TabIndex = 0;
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 2;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Controls.Add(this.DGVProduct, 0, 0);
            this.tlp2.Controls.Add(this.DGVCustomer, 0, 0);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(3, 3);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 1;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Size = new System.Drawing.Size(1006, 307);
            this.tlp2.TabIndex = 0;
            // 
            // DGVProduct
            // 
            this.DGVProduct.AllowUserToOrderColumns = true;
            this.DGVProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProduct.GridColor = System.Drawing.Color.White;
            this.DGVProduct.Location = new System.Drawing.Point(506, 3);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.RowHeadersWidth = 51;
            this.DGVProduct.RowTemplate.Height = 29;
            this.DGVProduct.Size = new System.Drawing.Size(497, 301);
            this.DGVProduct.TabIndex = 19;
            this.DGVProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProduct_CellClick);
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AllowUserToOrderColumns = true;
            this.DGVCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCustomer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomer.GridColor = System.Drawing.Color.White;
            this.DGVCustomer.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 51;
            this.DGVCustomer.RowTemplate.Height = 29;
            this.DGVCustomer.Size = new System.Drawing.Size(497, 301);
            this.DGVCustomer.TabIndex = 18;
            this.DGVCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomer_CellClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.DGVOrder, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tlp4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 316);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1006, 304);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // DGVOrder
            // 
            this.DGVOrder.AllowUserToOrderColumns = true;
            this.DGVOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVOrder.GridColor = System.Drawing.Color.White;
            this.DGVOrder.Location = new System.Drawing.Point(405, 3);
            this.DGVOrder.Name = "DGVOrder";
            this.DGVOrder.RowHeadersWidth = 51;
            this.DGVOrder.RowTemplate.Height = 29;
            this.DGVOrder.Size = new System.Drawing.Size(598, 298);
            this.DGVOrder.TabIndex = 20;
            // 
            // tlp4
            // 
            this.tlp4.ColumnCount = 2;
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4.Controls.Add(this.btnInsertOrder, 0, 6);
            this.tlp4.Controls.Add(this.lbl3, 0, 0);
            this.tlp4.Controls.Add(this.label1, 0, 1);
            this.tlp4.Controls.Add(this.label2, 0, 2);
            this.tlp4.Controls.Add(this.DTP, 1, 0);
            this.tlp4.Controls.Add(this.label3, 0, 3);
            this.tlp4.Controls.Add(this.label4, 0, 4);
            this.tlp4.Controls.Add(this.label5, 0, 5);
            this.tlp4.Controls.Add(this.txtCustId, 1, 1);
            this.tlp4.Controls.Add(this.txtCustName, 1, 2);
            this.tlp4.Controls.Add(this.txtOrderQuantity, 1, 3);
            this.tlp4.Controls.Add(this.txtProdPrice, 1, 4);
            this.tlp4.Controls.Add(this.txtTotalPrice, 1, 5);
            this.tlp4.Controls.Add(this.btnViewOrders, 1, 6);
            this.tlp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp4.Location = new System.Drawing.Point(3, 3);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 7;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp4.Size = new System.Drawing.Size(396, 298);
            this.tlp4.TabIndex = 0;
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsertOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertOrder.ForeColor = System.Drawing.Color.White;
            this.btnInsertOrder.Location = new System.Drawing.Point(3, 261);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(192, 37);
            this.btnInsertOrder.TabIndex = 105;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            this.btnInsertOrder.Click += new System.EventHandler(this.btnInsertOrder_Click_1);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(192, 43);
            this.lbl3.TabIndex = 89;
            this.lbl3.Text = "Order date:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 43);
            this.label1.TabIndex = 90;
            this.label1.Text = "Customer id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 43);
            this.label2.TabIndex = 91;
            this.label2.Text = "Customer name:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DTP
            // 
            this.DTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTP.Location = new System.Drawing.Point(201, 3);
            this.DTP.MinDate = new System.DateTime(2023, 2, 26, 15, 39, 31, 0);
            this.DTP.Name = "DTP";
            this.DTP.Size = new System.Drawing.Size(192, 27);
            this.DTP.TabIndex = 92;
            this.DTP.Value = new System.DateTime(2023, 2, 26, 15, 39, 31, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 43);
            this.label3.TabIndex = 97;
            this.label3.Text = "Product quantity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 43);
            this.label4.TabIndex = 98;
            this.label4.Text = "Product price:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 43);
            this.label5.TabIndex = 99;
            this.label5.Text = "Product total price:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustId
            // 
            this.txtCustId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCustId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustId.ForeColor = System.Drawing.Color.White;
            this.txtCustId.Location = new System.Drawing.Point(201, 46);
            this.txtCustId.MaxLength = 32764;
            this.txtCustId.Multiline = true;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(192, 37);
            this.txtCustId.TabIndex = 100;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCustName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustName.ForeColor = System.Drawing.Color.White;
            this.txtCustName.Location = new System.Drawing.Point(201, 89);
            this.txtCustName.MaxLength = 32764;
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(192, 37);
            this.txtCustName.TabIndex = 101;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtOrderQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderQuantity.ForeColor = System.Drawing.Color.White;
            this.txtOrderQuantity.Location = new System.Drawing.Point(201, 132);
            this.txtOrderQuantity.MaxLength = 32764;
            this.txtOrderQuantity.Multiline = true;
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(192, 37);
            this.txtOrderQuantity.TabIndex = 102;
            this.txtOrderQuantity.TextChanged += new System.EventHandler(this.txtOrderQuantity_TextChanged);
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdPrice.ForeColor = System.Drawing.Color.White;
            this.txtProdPrice.Location = new System.Drawing.Point(201, 175);
            this.txtProdPrice.MaxLength = 32764;
            this.txtProdPrice.Multiline = true;
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(192, 37);
            this.txtProdPrice.TabIndex = 103;
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalPrice.ForeColor = System.Drawing.Color.White;
            this.txtTotalPrice.Location = new System.Drawing.Point(201, 218);
            this.txtTotalPrice.MaxLength = 32764;
            this.txtTotalPrice.Multiline = true;
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(192, 37);
            this.txtTotalPrice.TabIndex = 104;
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.Location = new System.Drawing.Point(201, 261);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(192, 37);
            this.btnViewOrders.TabIndex = 106;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            this.btnViewOrders.Click += new System.EventHandler(this.btnViewOrders_Click_1);
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.tlp1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrders";
            this.Text = "X";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.tlp1.ResumeLayout(false);
            this.tlp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).EndInit();
            this.tlp4.ResumeLayout(false);
            this.tlp4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp1;
        private TableLayoutPanel tlp2;
        private DataGridView DGVCustomer;
        private DataGridView DGVProduct;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView DGVOrder;
        private TableLayoutPanel tlp4;
        private Button btnViewOrders;
        private Button btnInsertOrder;
        private Label lbl3;
        private Label label1;
        private Label label2;
        private DateTimePicker DTP;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCustId;
        private TextBox txtCustName;
        private TextBox txtOrderQuantity;
        private TextBox txtProdPrice;
        private TextBox txtTotalPrice;
    }
}
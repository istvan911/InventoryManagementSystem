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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVCustomer = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.DTGOrder = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unitprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DTP = new System.Windows.Forms.DateTimePicker();
            this.btnViewOrders = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsertOrder = new System.Windows.Forms.Button();
            this.txtOrderQuantity = new System.Windows.Forms.TextBox();
            this.CustId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DTGOrder)).BeginInit();
            this.tlp4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1012, 623);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.DGVProduct, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DGVCustomer, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1006, 305);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // DGVProduct
            // 
            this.DGVProduct.AllowUserToOrderColumns = true;
            this.DGVProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductQuantity,
            this.ProductPrice,
            this.ProdDesc,
            this.ProductCategorie});
            this.DGVProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProduct.Location = new System.Drawing.Point(506, 3);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.RowHeadersWidth = 51;
            this.DGVProduct.RowTemplate.Height = 29;
            this.DGVProduct.Size = new System.Drawing.Size(497, 299);
            this.DGVProduct.TabIndex = 19;
            // 
            // ProductId
            // 
            this.ProductId.HeaderText = "Product id";
            this.ProductId.MinimumWidth = 6;
            this.ProductId.Name = "ProductId";
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product name";
            this.ProductName.MinimumWidth = 6;
            this.ProductName.Name = "ProductName";
            // 
            // ProductQuantity
            // 
            this.ProductQuantity.HeaderText = "Product quantity";
            this.ProductQuantity.MinimumWidth = 6;
            this.ProductQuantity.Name = "ProductQuantity";
            // 
            // ProductPrice
            // 
            this.ProductPrice.HeaderText = "Product price";
            this.ProductPrice.MinimumWidth = 6;
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProdDesc
            // 
            this.ProdDesc.HeaderText = "Product description";
            this.ProdDesc.MinimumWidth = 6;
            this.ProdDesc.Name = "ProdDesc";
            // 
            // ProductCategorie
            // 
            this.ProductCategorie.HeaderText = "Product categorie";
            this.ProductCategorie.MinimumWidth = 6;
            this.ProductCategorie.Name = "ProductCategorie";
            // 
            // DGVCustomer
            // 
            this.DGVCustomer.AllowUserToOrderColumns = true;
            this.DGVCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustId,
            this.CustName,
            this.CustEmail,
            this.CustPhone});
            this.DGVCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCustomer.Location = new System.Drawing.Point(3, 3);
            this.DGVCustomer.Name = "DGVCustomer";
            this.DGVCustomer.RowHeadersWidth = 51;
            this.DGVCustomer.RowTemplate.Height = 29;
            this.DGVCustomer.Size = new System.Drawing.Size(497, 299);
            this.DGVCustomer.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.Controls.Add(this.DTGOrder, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tlp4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 314);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1006, 306);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // DTGOrder
            // 
            this.DTGOrder.AllowUserToOrderColumns = true;
            this.DTGOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTGOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.Product,
            this.Quantity,
            this.Unitprice,
            this.TotPrice});
            this.DTGOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DTGOrder.Location = new System.Drawing.Point(405, 3);
            this.DTGOrder.Name = "DTGOrder";
            this.DTGOrder.RowHeadersWidth = 51;
            this.DTGOrder.RowTemplate.Height = 29;
            this.DTGOrder.Size = new System.Drawing.Size(598, 300);
            this.DTGOrder.TabIndex = 20;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "Order id";
            this.OrderId.MinimumWidth = 6;
            this.OrderId.Name = "OrderId";
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            // 
            // Unitprice
            // 
            this.Unitprice.HeaderText = "Unit price";
            this.Unitprice.MinimumWidth = 6;
            this.Unitprice.Name = "Unitprice";
            // 
            // TotPrice
            // 
            this.TotPrice.HeaderText = "Total Price";
            this.TotPrice.MinimumWidth = 6;
            this.TotPrice.Name = "TotPrice";
            // 
            // tlp4
            // 
            this.tlp4.ColumnCount = 2;
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp4.Controls.Add(this.txtCustName, 1, 2);
            this.tlp4.Controls.Add(this.txtCustId, 1, 1);
            this.tlp4.Controls.Add(this.lbl3, 0, 0);
            this.tlp4.Controls.Add(this.label1, 0, 1);
            this.tlp4.Controls.Add(this.label2, 0, 2);
            this.tlp4.Controls.Add(this.DTP, 1, 0);
            this.tlp4.Controls.Add(this.btnViewOrders, 1, 4);
            this.tlp4.Controls.Add(this.label3, 0, 3);
            this.tlp4.Controls.Add(this.btnInsertOrder, 0, 4);
            this.tlp4.Controls.Add(this.txtOrderQuantity, 1, 3);
            this.tlp4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp4.Location = new System.Drawing.Point(3, 3);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 5;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp4.Size = new System.Drawing.Size(396, 300);
            this.tlp4.TabIndex = 0;
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCustName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustName.ForeColor = System.Drawing.Color.White;
            this.txtCustName.Location = new System.Drawing.Point(201, 123);
            this.txtCustName.MaxLength = 32764;
            this.txtCustName.Multiline = true;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(192, 54);
            this.txtCustName.TabIndex = 83;
            // 
            // txtCustId
            // 
            this.txtCustId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtCustId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCustId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCustId.ForeColor = System.Drawing.Color.White;
            this.txtCustId.Location = new System.Drawing.Point(201, 63);
            this.txtCustId.MaxLength = 32764;
            this.txtCustId.Multiline = true;
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(192, 54);
            this.txtCustId.TabIndex = 82;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(192, 60);
            this.lbl3.TabIndex = 75;
            this.lbl3.Text = "Order date:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 60);
            this.label1.TabIndex = 76;
            this.label1.Text = "Customer id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 60);
            this.label2.TabIndex = 77;
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
            this.DTP.TabIndex = 78;
            this.DTP.Value = new System.DateTime(2023, 2, 26, 15, 39, 31, 0);
            // 
            // btnViewOrders
            // 
            this.btnViewOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewOrders.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnViewOrders.ForeColor = System.Drawing.Color.White;
            this.btnViewOrders.Location = new System.Drawing.Point(201, 243);
            this.btnViewOrders.Name = "btnViewOrders";
            this.btnViewOrders.Size = new System.Drawing.Size(192, 54);
            this.btnViewOrders.TabIndex = 85;
            this.btnViewOrders.Text = "View Orders";
            this.btnViewOrders.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 60);
            this.label3.TabIndex = 86;
            this.label3.Text = "Product quantity:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInsertOrder
            // 
            this.btnInsertOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInsertOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertOrder.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInsertOrder.ForeColor = System.Drawing.Color.White;
            this.btnInsertOrder.Location = new System.Drawing.Point(3, 243);
            this.btnInsertOrder.Name = "btnInsertOrder";
            this.btnInsertOrder.Size = new System.Drawing.Size(192, 54);
            this.btnInsertOrder.TabIndex = 84;
            this.btnInsertOrder.Text = "Insert Order";
            this.btnInsertOrder.UseVisualStyleBackColor = true;
            // 
            // txtOrderQuantity
            // 
            this.txtOrderQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtOrderQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOrderQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtOrderQuantity.ForeColor = System.Drawing.Color.White;
            this.txtOrderQuantity.Location = new System.Drawing.Point(201, 183);
            this.txtOrderQuantity.MaxLength = 32764;
            this.txtOrderQuantity.Multiline = true;
            this.txtOrderQuantity.Name = "txtOrderQuantity";
            this.txtOrderQuantity.Size = new System.Drawing.Size(192, 54);
            this.txtOrderQuantity.TabIndex = 87;
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
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrders";
            this.Text = "X";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomer)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DTGOrder)).EndInit();
            this.tlp4.ResumeLayout(false);
            this.tlp4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView DGVCustomer;
        private DataGridView DGVProduct;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProdDesc;
        private DataGridViewTextBoxColumn ProductCategorie;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView DTGOrder;
        private DataGridViewTextBoxColumn OrderId;
        private DataGridViewTextBoxColumn Product;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Unitprice;
        private DataGridViewTextBoxColumn TotPrice;
        private TableLayoutPanel tlp4;
        private Label lbl3;
        private Label label1;
        private Label label2;
        private DateTimePicker DTP;
        private TextBox txtCustName;
        private TextBox txtCustId;
        private Button btnViewOrders;
        private Button btnInsertOrder;
        private Label label3;
        private TextBox txtOrderQuantity;
        private DataGridViewTextBoxColumn CustId;
        private DataGridViewTextBoxColumn CustName;
        private DataGridViewTextBoxColumn CustEmail;
        private DataGridViewTextBoxColumn CustPhone;
    }
}
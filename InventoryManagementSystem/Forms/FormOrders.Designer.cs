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
            tlp1 = new TableLayoutPanel();
            tlp2 = new TableLayoutPanel();
            DGVProduct = new DataGridView();
            DGVCustomer = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            DGVOrder = new DataGridView();
            tlp4 = new TableLayoutPanel();
            btnInsertOrder = new Button();
            lbl3 = new Label();
            label1 = new Label();
            label2 = new Label();
            DTP = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCustId = new TextBox();
            txtCustName = new TextBox();
            txtOrderQuantity = new TextBox();
            txtProdPrice = new TextBox();
            txtTotalPrice = new TextBox();
            btnViewOrders = new Button();
            tlp1.SuspendLayout();
            tlp2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVCustomer).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVOrder).BeginInit();
            tlp4.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.Controls.Add(tlp2, 0, 0);
            tlp1.Controls.Add(tableLayoutPanel3, 0, 1);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 310F));
            tlp1.Size = new Size(1012, 623);
            tlp1.TabIndex = 0;
            // 
            // tlp2
            // 
            tlp2.ColumnCount = 2;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp2.Controls.Add(DGVProduct, 0, 0);
            tlp2.Controls.Add(DGVCustomer, 0, 0);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(3, 3);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 1;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp2.Size = new Size(1006, 307);
            tlp2.TabIndex = 0;
            // 
            // DGVProduct
            // 
            DGVProduct.AllowUserToOrderColumns = true;
            DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProduct.BackgroundColor = Color.FromArgb(30, 30, 70);
            DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduct.Dock = DockStyle.Fill;
            DGVProduct.GridColor = Color.White;
            DGVProduct.Location = new Point(506, 3);
            DGVProduct.Name = "DGVProduct";
            DGVProduct.RowHeadersWidth = 51;
            DGVProduct.RowTemplate.Height = 29;
            DGVProduct.Size = new Size(497, 301);
            DGVProduct.TabIndex = 19;
            DGVProduct.CellClick += DGVProduct_CellClick;
            // 
            // DGVCustomer
            // 
            DGVCustomer.AllowUserToOrderColumns = true;
            DGVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVCustomer.BackgroundColor = Color.FromArgb(30, 30, 70);
            DGVCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVCustomer.Dock = DockStyle.Fill;
            DGVCustomer.GridColor = Color.White;
            DGVCustomer.Location = new Point(3, 3);
            DGVCustomer.Name = "DGVCustomer";
            DGVCustomer.RowHeadersWidth = 51;
            DGVCustomer.RowTemplate.Height = 29;
            DGVCustomer.Size = new Size(497, 301);
            DGVCustomer.TabIndex = 18;
            DGVCustomer.CellClick += DGVCustomer_CellClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel3.Controls.Add(DGVOrder, 1, 0);
            tableLayoutPanel3.Controls.Add(tlp4, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 316);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1006, 304);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // DGVOrder
            // 
            DGVOrder.AllowUserToOrderColumns = true;
            DGVOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVOrder.BackgroundColor = Color.FromArgb(30, 30, 70);
            DGVOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVOrder.Dock = DockStyle.Fill;
            DGVOrder.GridColor = Color.White;
            DGVOrder.Location = new Point(405, 3);
            DGVOrder.Name = "DGVOrder";
            DGVOrder.RowHeadersWidth = 51;
            DGVOrder.RowTemplate.Height = 29;
            DGVOrder.Size = new Size(598, 298);
            DGVOrder.TabIndex = 20;
            // 
            // tlp4
            // 
            tlp4.ColumnCount = 2;
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp4.Controls.Add(btnInsertOrder, 0, 6);
            tlp4.Controls.Add(lbl3, 0, 0);
            tlp4.Controls.Add(label1, 0, 1);
            tlp4.Controls.Add(label2, 0, 2);
            tlp4.Controls.Add(DTP, 1, 0);
            tlp4.Controls.Add(label3, 0, 3);
            tlp4.Controls.Add(label4, 0, 4);
            tlp4.Controls.Add(label5, 0, 5);
            tlp4.Controls.Add(txtCustId, 1, 1);
            tlp4.Controls.Add(txtCustName, 1, 2);
            tlp4.Controls.Add(txtOrderQuantity, 1, 3);
            tlp4.Controls.Add(txtProdPrice, 1, 4);
            tlp4.Controls.Add(txtTotalPrice, 1, 5);
            tlp4.Controls.Add(btnViewOrders, 1, 6);
            tlp4.Dock = DockStyle.Fill;
            tlp4.Location = new Point(3, 3);
            tlp4.Name = "tlp4";
            tlp4.RowCount = 7;
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp4.Size = new Size(396, 298);
            tlp4.TabIndex = 0;
            // 
            // btnInsertOrder
            // 
            btnInsertOrder.Dock = DockStyle.Fill;
            btnInsertOrder.FlatStyle = FlatStyle.Flat;
            btnInsertOrder.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsertOrder.ForeColor = Color.White;
            btnInsertOrder.Location = new Point(3, 261);
            btnInsertOrder.Name = "btnInsertOrder";
            btnInsertOrder.Size = new Size(192, 37);
            btnInsertOrder.TabIndex = 105;
            btnInsertOrder.Text = "Insert Order";
            btnInsertOrder.UseVisualStyleBackColor = true;
            btnInsertOrder.Click += btnInsertOrder_Click_1;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.ForeColor = Color.White;
            lbl3.Location = new Point(3, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(192, 43);
            lbl3.TabIndex = 89;
            lbl3.Text = "Order date:";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 43);
            label1.Name = "label1";
            label1.Size = new Size(192, 43);
            label1.TabIndex = 90;
            label1.Text = "Customer id:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 86);
            label2.Name = "label2";
            label2.Size = new Size(192, 43);
            label2.TabIndex = 91;
            label2.Text = "Customer name:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DTP
            // 
            DTP.Dock = DockStyle.Fill;
            DTP.Location = new Point(201, 3);
            DTP.MinDate = new DateTime(2023, 2, 26, 15, 39, 31, 0);
            DTP.Name = "DTP";
            DTP.Size = new Size(192, 27);
            DTP.TabIndex = 92;
            DTP.Value = new DateTime(2023, 2, 26, 15, 39, 31, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 129);
            label3.Name = "label3";
            label3.Size = new Size(192, 43);
            label3.TabIndex = 97;
            label3.Text = "Product quantity:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 172);
            label4.Name = "label4";
            label4.Size = new Size(192, 43);
            label4.TabIndex = 98;
            label4.Text = "Product price:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(3, 215);
            label5.Name = "label5";
            label5.Size = new Size(192, 43);
            label5.TabIndex = 99;
            label5.Text = "Product total price:";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCustId
            // 
            txtCustId.BackColor = Color.FromArgb(31, 30, 68);
            txtCustId.Dock = DockStyle.Fill;
            txtCustId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustId.ForeColor = Color.White;
            txtCustId.Location = new Point(201, 46);
            txtCustId.MaxLength = 32764;
            txtCustId.Multiline = true;
            txtCustId.Name = "txtCustId";
            txtCustId.Size = new Size(192, 37);
            txtCustId.TabIndex = 100;
            // 
            // txtCustName
            // 
            txtCustName.BackColor = Color.FromArgb(31, 30, 68);
            txtCustName.Dock = DockStyle.Fill;
            txtCustName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtCustName.ForeColor = Color.White;
            txtCustName.Location = new Point(201, 89);
            txtCustName.MaxLength = 32764;
            txtCustName.Multiline = true;
            txtCustName.Name = "txtCustName";
            txtCustName.Size = new Size(192, 37);
            txtCustName.TabIndex = 101;
            // 
            // txtOrderQuantity
            // 
            txtOrderQuantity.BackColor = Color.FromArgb(31, 30, 68);
            txtOrderQuantity.Dock = DockStyle.Fill;
            txtOrderQuantity.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtOrderQuantity.ForeColor = Color.White;
            txtOrderQuantity.Location = new Point(201, 132);
            txtOrderQuantity.MaxLength = 32764;
            txtOrderQuantity.Multiline = true;
            txtOrderQuantity.Name = "txtOrderQuantity";
            txtOrderQuantity.Size = new Size(192, 37);
            txtOrderQuantity.TabIndex = 102;
            txtOrderQuantity.TextChanged += txtOrderQuantity_TextChanged;
            // 
            // txtProdPrice
            // 
            txtProdPrice.BackColor = Color.FromArgb(31, 30, 68);
            txtProdPrice.Dock = DockStyle.Fill;
            txtProdPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtProdPrice.ForeColor = Color.White;
            txtProdPrice.Location = new Point(201, 175);
            txtProdPrice.MaxLength = 32764;
            txtProdPrice.Multiline = true;
            txtProdPrice.Name = "txtProdPrice";
            txtProdPrice.Size = new Size(192, 37);
            txtProdPrice.TabIndex = 103;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.BackColor = Color.FromArgb(31, 30, 68);
            txtTotalPrice.Dock = DockStyle.Fill;
            txtTotalPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalPrice.ForeColor = Color.White;
            txtTotalPrice.Location = new Point(201, 218);
            txtTotalPrice.MaxLength = 32764;
            txtTotalPrice.Multiline = true;
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(192, 37);
            txtTotalPrice.TabIndex = 104;
            // 
            // btnViewOrders
            // 
            btnViewOrders.Dock = DockStyle.Fill;
            btnViewOrders.FlatStyle = FlatStyle.Flat;
            btnViewOrders.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewOrders.ForeColor = Color.White;
            btnViewOrders.Location = new Point(201, 261);
            btnViewOrders.Name = "btnViewOrders";
            btnViewOrders.Size = new Size(192, 37);
            btnViewOrders.TabIndex = 106;
            btnViewOrders.Text = "View Orders";
            btnViewOrders.UseVisualStyleBackColor = true;
            btnViewOrders.Click += btnViewOrders_Click;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 70);
            ClientSize = new Size(1012, 623);
            Controls.Add(tlp1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrders";
            Text = "X";
            Load += FormOrders_Load;
            tlp1.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVCustomer).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVOrder).EndInit();
            tlp4.ResumeLayout(false);
            tlp4.PerformLayout();
            ResumeLayout(false);
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
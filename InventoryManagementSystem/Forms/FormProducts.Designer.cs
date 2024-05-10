namespace InventoryManagementSystem.Forms
{
    partial class FormProducts
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
            DGVProduct = new DataGridView();
            tlp2 = new TableLayoutPanel();
            tlp4 = new TableLayoutPanel();
            label4 = new Label();
            lbl3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtProdName = new TextBox();
            txtProdQuan = new TextBox();
            txtProdPrice = new TextBox();
            txtProdDesc = new TextBox();
            cmbProdCat = new ComboBox();
            tlp3 = new TableLayoutPanel();
            btnNew = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnDeleteFields = new Button();
            tlp5 = new TableLayoutPanel();
            btnRefresh = new Button();
            btnSearch = new Button();
            cmbProdCatSearch = new ComboBox();
            tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVProduct).BeginInit();
            tlp2.SuspendLayout();
            tlp4.SuspendLayout();
            tlp3.SuspendLayout();
            tlp5.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.Controls.Add(DGVProduct, 0, 0);
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tlp1.Size = new Size(1012, 623);
            tlp1.TabIndex = 0;
            // 
            // DGVProduct
            // 
            DGVProduct.AllowUserToOrderColumns = true;
            DGVProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVProduct.BackgroundColor = Color.FromArgb(30, 30, 70);
            DGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVProduct.Dock = DockStyle.Fill;
            DGVProduct.GridColor = Color.White;
            DGVProduct.Location = new Point(3, 3);
            DGVProduct.Name = "DGVProduct";
            DGVProduct.RowHeadersWidth = 51;
            DGVProduct.RowTemplate.Height = 29;
            DGVProduct.Size = new Size(1006, 317);
            DGVProduct.TabIndex = 18;
            DGVProduct.CellClick += DGVProduct_CellClick;
            // 
            // tlp2
            // 
            tlp2.ColumnCount = 1;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp2.Controls.Add(tlp4, 0, 0);
            tlp2.Controls.Add(tlp3, 0, 2);
            tlp2.Controls.Add(tlp5, 0, 1);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(3, 326);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 3;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.Size = new Size(1006, 294);
            tlp2.TabIndex = 19;
            // 
            // tlp4
            // 
            tlp4.ColumnCount = 2;
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlp4.Controls.Add(label4, 0, 4);
            tlp4.Controls.Add(lbl3, 0, 0);
            tlp4.Controls.Add(label1, 0, 1);
            tlp4.Controls.Add(label2, 0, 2);
            tlp4.Controls.Add(label3, 0, 3);
            tlp4.Controls.Add(txtProdName, 1, 0);
            tlp4.Controls.Add(txtProdQuan, 1, 1);
            tlp4.Controls.Add(txtProdPrice, 1, 2);
            tlp4.Controls.Add(txtProdDesc, 1, 3);
            tlp4.Controls.Add(cmbProdCat, 1, 4);
            tlp4.Dock = DockStyle.Fill;
            tlp4.Location = new Point(3, 3);
            tlp4.Name = "tlp4";
            tlp4.RowCount = 5;
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp4.Size = new Size(1000, 199);
            tlp4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 156);
            label4.Name = "label4";
            label4.Size = new Size(194, 43);
            label4.TabIndex = 86;
            label4.Text = "Product categorie:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Dock = DockStyle.Fill;
            lbl3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.ForeColor = Color.White;
            lbl3.Location = new Point(3, 0);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(194, 39);
            lbl3.TabIndex = 74;
            lbl3.Text = "Product name:";
            lbl3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 39);
            label1.Name = "label1";
            label1.Size = new Size(194, 39);
            label1.TabIndex = 75;
            label1.Text = "Product quantity:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 78);
            label2.Name = "label2";
            label2.Size = new Size(194, 39);
            label2.TabIndex = 76;
            label2.Text = "Product price:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(3, 117);
            label3.Name = "label3";
            label3.Size = new Size(194, 39);
            label3.TabIndex = 77;
            label3.Text = "Product description:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtProdName
            // 
            txtProdName.BackColor = Color.FromArgb(31, 30, 68);
            txtProdName.Dock = DockStyle.Fill;
            txtProdName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtProdName.ForeColor = Color.White;
            txtProdName.Location = new Point(203, 3);
            txtProdName.MaxLength = 32764;
            txtProdName.Multiline = true;
            txtProdName.Name = "txtProdName";
            txtProdName.Size = new Size(794, 33);
            txtProdName.TabIndex = 81;
            // 
            // txtProdQuan
            // 
            txtProdQuan.BackColor = Color.FromArgb(31, 30, 68);
            txtProdQuan.Dock = DockStyle.Fill;
            txtProdQuan.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtProdQuan.ForeColor = Color.White;
            txtProdQuan.Location = new Point(203, 42);
            txtProdQuan.MaxLength = 32764;
            txtProdQuan.Multiline = true;
            txtProdQuan.Name = "txtProdQuan";
            txtProdQuan.Size = new Size(794, 33);
            txtProdQuan.TabIndex = 82;
            // 
            // txtProdPrice
            // 
            txtProdPrice.BackColor = Color.FromArgb(31, 30, 68);
            txtProdPrice.Dock = DockStyle.Fill;
            txtProdPrice.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtProdPrice.ForeColor = Color.White;
            txtProdPrice.Location = new Point(203, 81);
            txtProdPrice.MaxLength = 32764;
            txtProdPrice.Multiline = true;
            txtProdPrice.Name = "txtProdPrice";
            txtProdPrice.Size = new Size(794, 33);
            txtProdPrice.TabIndex = 83;
            // 
            // txtProdDesc
            // 
            txtProdDesc.BackColor = Color.FromArgb(31, 30, 68);
            txtProdDesc.Dock = DockStyle.Fill;
            txtProdDesc.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point);
            txtProdDesc.ForeColor = Color.White;
            txtProdDesc.Location = new Point(203, 120);
            txtProdDesc.MaxLength = 32764;
            txtProdDesc.Multiline = true;
            txtProdDesc.Name = "txtProdDesc";
            txtProdDesc.Size = new Size(794, 33);
            txtProdDesc.TabIndex = 84;
            // 
            // cmbProdCat
            // 
            cmbProdCat.BackColor = Color.FromArgb(31, 30, 68);
            cmbProdCat.Dock = DockStyle.Fill;
            cmbProdCat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProdCat.ForeColor = Color.White;
            cmbProdCat.FormattingEnabled = true;
            cmbProdCat.Location = new Point(203, 159);
            cmbProdCat.Name = "cmbProdCat";
            cmbProdCat.Size = new Size(794, 36);
            cmbProdCat.TabIndex = 87;
            cmbProdCat.Text = "Category...";
            // 
            // tlp3
            // 
            tlp3.ColumnCount = 4;
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tlp3.Controls.Add(btnNew, 0, 0);
            tlp3.Controls.Add(btnUpdate, 1, 0);
            tlp3.Controls.Add(btnDelete, 2, 0);
            tlp3.Controls.Add(btnDeleteFields, 3, 0);
            tlp3.Dock = DockStyle.Fill;
            tlp3.Location = new Point(3, 252);
            tlp3.Name = "tlp3";
            tlp3.RowCount = 1;
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp3.Size = new Size(1000, 39);
            tlp3.TabIndex = 0;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.ForeColor = Color.White;
            btnNew.Location = new Point(3, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(244, 33);
            btnNew.TabIndex = 82;
            btnNew.Text = "New product";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(253, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(244, 33);
            btnUpdate.TabIndex = 81;
            btnUpdate.Text = "Update product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(503, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(244, 33);
            btnDelete.TabIndex = 83;
            btnDelete.Text = "Delete product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDeleteFields
            // 
            btnDeleteFields.Dock = DockStyle.Fill;
            btnDeleteFields.FlatStyle = FlatStyle.Flat;
            btnDeleteFields.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteFields.ForeColor = Color.White;
            btnDeleteFields.Location = new Point(753, 3);
            btnDeleteFields.Name = "btnDeleteFields";
            btnDeleteFields.Size = new Size(244, 33);
            btnDeleteFields.TabIndex = 84;
            btnDeleteFields.Text = "Delete fields";
            btnDeleteFields.UseVisualStyleBackColor = true;
            btnDeleteFields.Click += btnDeleteFields_Click;
            // 
            // tlp5
            // 
            tlp5.ColumnCount = 4;
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlp5.Controls.Add(btnRefresh, 2, 0);
            tlp5.Controls.Add(btnSearch, 1, 0);
            tlp5.Controls.Add(cmbProdCatSearch, 0, 0);
            tlp5.Dock = DockStyle.Fill;
            tlp5.Location = new Point(3, 208);
            tlp5.Name = "tlp5";
            tlp5.RowCount = 1;
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp5.Size = new Size(1000, 38);
            tlp5.TabIndex = 2;
            // 
            // btnRefresh
            // 
            btnRefresh.Dock = DockStyle.Fill;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(503, 3);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(194, 32);
            btnRefresh.TabIndex = 84;
            btnRefresh.Text = "Refresh products";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(303, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 32);
            btnSearch.TabIndex = 85;
            btnSearch.Text = "Search products";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbProdCatSearch
            // 
            cmbProdCatSearch.BackColor = Color.FromArgb(31, 30, 68);
            cmbProdCatSearch.Dock = DockStyle.Fill;
            cmbProdCatSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProdCatSearch.ForeColor = Color.White;
            cmbProdCatSearch.FormattingEnabled = true;
            cmbProdCatSearch.Location = new Point(3, 3);
            cmbProdCatSearch.Name = "cmbProdCatSearch";
            cmbProdCatSearch.Size = new Size(294, 36);
            cmbProdCatSearch.TabIndex = 86;
            cmbProdCatSearch.Text = "Category...";
            // 
            // FormProducts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 70);
            ClientSize = new Size(1012, 623);
            Controls.Add(tlp1);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProducts";
            Text = "FormCategories";
            Load += FormProducts_Load;
            tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVProduct).EndInit();
            tlp2.ResumeLayout(false);
            tlp4.ResumeLayout(false);
            tlp4.PerformLayout();
            tlp3.ResumeLayout(false);
            tlp5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private DataGridView DGVProduct;
        private TableLayoutPanel tlp2;
        private TableLayoutPanel tlp3;
        private TableLayoutPanel tlp4;
        private Label lbl3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtProdName;
        private TextBox txtProdQuan;
        private TextBox txtProdPrice;
        private TextBox txtProdDesc;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnDeleteFields;
        private TableLayoutPanel tlp5;
        private Button btnSearch;
        private Button btnRefresh;
        private ComboBox cmbProdCatSearch;
        private ComboBox cmbProdCat;
    }
}
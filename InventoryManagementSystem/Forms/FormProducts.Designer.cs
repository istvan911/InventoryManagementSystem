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
            this.tlp1 = new System.Windows.Forms.TableLayoutPanel();
            this.DGVProduct = new System.Windows.Forms.DataGridView();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdQuan = new System.Windows.Forms.TextBox();
            this.txtProdPrice = new System.Windows.Forms.TextBox();
            this.txtProdDesc = new System.Windows.Forms.TextBox();
            this.cmbProdCat = new System.Windows.Forms.ComboBox();
            this.tlp3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteFields = new System.Windows.Forms.Button();
            this.tlp5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbProdCatSearch = new System.Windows.Forms.ComboBox();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            this.tlp2.SuspendLayout();
            this.tlp4.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.tlp5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.DGVProduct, 0, 0);
            this.tlp1.Controls.Add(this.tlp2, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tlp1.Size = new System.Drawing.Size(1012, 623);
            this.tlp1.TabIndex = 0;
            // 
            // DGVProduct
            // 
            this.DGVProduct.AllowUserToOrderColumns = true;
            this.DGVProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.DGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVProduct.GridColor = System.Drawing.Color.White;
            this.DGVProduct.Location = new System.Drawing.Point(3, 3);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.RowHeadersWidth = 51;
            this.DGVProduct.RowTemplate.Height = 29;
            this.DGVProduct.Size = new System.Drawing.Size(1006, 317);
            this.DGVProduct.TabIndex = 18;
            this.DGVProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVProduct_CellClick);
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 1;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.tlp4, 0, 0);
            this.tlp2.Controls.Add(this.tlp3, 0, 2);
            this.tlp2.Controls.Add(this.tlp5, 0, 1);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(3, 326);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 3;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp2.Size = new System.Drawing.Size(1006, 294);
            this.tlp2.TabIndex = 19;
            // 
            // tlp4
            // 
            this.tlp4.ColumnCount = 2;
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp4.Controls.Add(this.label4, 0, 4);
            this.tlp4.Controls.Add(this.lbl3, 0, 0);
            this.tlp4.Controls.Add(this.label1, 0, 1);
            this.tlp4.Controls.Add(this.label2, 0, 2);
            this.tlp4.Controls.Add(this.label3, 0, 3);
            this.tlp4.Controls.Add(this.txtProdName, 1, 0);
            this.tlp4.Controls.Add(this.txtProdQuan, 1, 1);
            this.tlp4.Controls.Add(this.txtProdPrice, 1, 2);
            this.tlp4.Controls.Add(this.txtProdDesc, 1, 3);
            this.tlp4.Controls.Add(this.cmbProdCat, 1, 4);
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
            this.tlp4.Size = new System.Drawing.Size(1000, 199);
            this.tlp4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 43);
            this.label4.TabIndex = 86;
            this.label4.Text = "Product categorie:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(194, 39);
            this.lbl3.TabIndex = 74;
            this.lbl3.Text = "Product name:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 39);
            this.label1.TabIndex = 75;
            this.label1.Text = "Product quantity:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 39);
            this.label2.TabIndex = 76;
            this.label2.Text = "Product price:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 39);
            this.label3.TabIndex = 77;
            this.label3.Text = "Product description:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtProdName
            // 
            this.txtProdName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdName.ForeColor = System.Drawing.Color.White;
            this.txtProdName.Location = new System.Drawing.Point(203, 3);
            this.txtProdName.MaxLength = 32764;
            this.txtProdName.Multiline = true;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(794, 33);
            this.txtProdName.TabIndex = 81;
            // 
            // txtProdQuan
            // 
            this.txtProdQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdQuan.ForeColor = System.Drawing.Color.White;
            this.txtProdQuan.Location = new System.Drawing.Point(203, 42);
            this.txtProdQuan.MaxLength = 32764;
            this.txtProdQuan.Multiline = true;
            this.txtProdQuan.Name = "txtProdQuan";
            this.txtProdQuan.Size = new System.Drawing.Size(794, 33);
            this.txtProdQuan.TabIndex = 82;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdPrice.ForeColor = System.Drawing.Color.White;
            this.txtProdPrice.Location = new System.Drawing.Point(203, 81);
            this.txtProdPrice.MaxLength = 32764;
            this.txtProdPrice.Multiline = true;
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(794, 33);
            this.txtProdPrice.TabIndex = 83;
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdDesc.ForeColor = System.Drawing.Color.White;
            this.txtProdDesc.Location = new System.Drawing.Point(203, 120);
            this.txtProdDesc.MaxLength = 32764;
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(794, 33);
            this.txtProdDesc.TabIndex = 84;
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbProdCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProdCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProdCat.ForeColor = System.Drawing.Color.White;
            this.cmbProdCat.FormattingEnabled = true;
            this.cmbProdCat.Location = new System.Drawing.Point(203, 159);
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(794, 36);
            this.cmbProdCat.TabIndex = 87;
            this.cmbProdCat.Text = "Category...";
            // 
            // tlp3
            // 
            this.tlp3.ColumnCount = 4;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.Controls.Add(this.btnNew, 0, 0);
            this.tlp3.Controls.Add(this.btnUpdate, 1, 0);
            this.tlp3.Controls.Add(this.btnDelete, 2, 0);
            this.tlp3.Controls.Add(this.btnDeleteFields, 3, 0);
            this.tlp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp3.Location = new System.Drawing.Point(3, 252);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 1;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp3.Size = new System.Drawing.Size(1000, 39);
            this.tlp3.TabIndex = 0;
            // 
            // btnNew
            // 
            this.btnNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(3, 3);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(244, 33);
            this.btnNew.TabIndex = 82;
            this.btnNew.Text = "New product";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(253, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(244, 33);
            this.btnUpdate.TabIndex = 81;
            this.btnUpdate.Text = "Update product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(503, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(244, 33);
            this.btnDelete.TabIndex = 83;
            this.btnDelete.Text = "Delete product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDeleteFields
            // 
            this.btnDeleteFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFields.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFields.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFields.Location = new System.Drawing.Point(753, 3);
            this.btnDeleteFields.Name = "btnDeleteFields";
            this.btnDeleteFields.Size = new System.Drawing.Size(244, 33);
            this.btnDeleteFields.TabIndex = 84;
            this.btnDeleteFields.Text = "Delete fields";
            this.btnDeleteFields.UseVisualStyleBackColor = true;
            this.btnDeleteFields.Click += new System.EventHandler(this.btnDeleteFields_Click);
            // 
            // tlp5
            // 
            this.tlp5.ColumnCount = 4;
            this.tlp5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlp5.Controls.Add(this.btnRefresh, 2, 0);
            this.tlp5.Controls.Add(this.btnSearch, 1, 0);
            this.tlp5.Controls.Add(this.cmbProdCatSearch, 0, 0);
            this.tlp5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp5.Location = new System.Drawing.Point(3, 208);
            this.tlp5.Name = "tlp5";
            this.tlp5.RowCount = 1;
            this.tlp5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp5.Size = new System.Drawing.Size(1000, 38);
            this.tlp5.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(503, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(194, 32);
            this.btnRefresh.TabIndex = 84;
            this.btnRefresh.Text = "Refresh products";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(303, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(194, 32);
            this.btnSearch.TabIndex = 85;
            this.btnSearch.Text = "Search products";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbProdCatSearch
            // 
            this.cmbProdCatSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.cmbProdCatSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProdCatSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProdCatSearch.ForeColor = System.Drawing.Color.White;
            this.cmbProdCatSearch.FormattingEnabled = true;
            this.cmbProdCatSearch.Location = new System.Drawing.Point(3, 3);
            this.cmbProdCatSearch.Name = "cmbProdCatSearch";
            this.cmbProdCatSearch.Size = new System.Drawing.Size(294, 36);
            this.cmbProdCatSearch.TabIndex = 86;
            this.cmbProdCatSearch.Text = "Category...";
            // 
            // FormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.tlp1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducts";
            this.Text = "FormCategories";
            this.Load += new System.EventHandler(this.FormProducts_Load);
            this.tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            this.tlp2.ResumeLayout(false);
            this.tlp4.ResumeLayout(false);
            this.tlp4.PerformLayout();
            this.tlp3.ResumeLayout(false);
            this.tlp5.ResumeLayout(false);
            this.ResumeLayout(false);

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
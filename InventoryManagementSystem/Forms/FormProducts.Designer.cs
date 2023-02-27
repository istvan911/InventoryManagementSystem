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
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCategorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnUjhozzaadasa = new System.Windows.Forms.Button();
            this.btnSzerkesztes = new System.Windows.Forms.Button();
            this.btnMezotorles = new System.Windows.Forms.Button();
            this.btnTöröl = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).BeginInit();
            this.tlp2.SuspendLayout();
            this.tlp4.SuspendLayout();
            this.tlp3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp1.Size = new System.Drawing.Size(1012, 623);
            this.tlp1.TabIndex = 0;
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
            this.DGVProduct.Location = new System.Drawing.Point(3, 3);
            this.DGVProduct.Name = "DGVProduct";
            this.DGVProduct.RowHeadersWidth = 51;
            this.DGVProduct.RowTemplate.Height = 29;
            this.DGVProduct.Size = new System.Drawing.Size(1006, 305);
            this.DGVProduct.TabIndex = 18;
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
            // tlp2
            // 
            this.tlp2.ColumnCount = 1;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.tlp4, 0, 0);
            this.tlp2.Controls.Add(this.tlp3, 0, 2);
            this.tlp2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(3, 314);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 3;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tlp2.Size = new System.Drawing.Size(1006, 306);
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
            this.tlp4.Size = new System.Drawing.Size(1000, 208);
            this.tlp4.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 44);
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
            this.lbl3.Size = new System.Drawing.Size(194, 41);
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
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 41);
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
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 41);
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
            this.label3.Location = new System.Drawing.Point(3, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 41);
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
            this.txtProdName.Size = new System.Drawing.Size(794, 35);
            this.txtProdName.TabIndex = 81;
            // 
            // txtProdQuan
            // 
            this.txtProdQuan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdQuan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdQuan.ForeColor = System.Drawing.Color.White;
            this.txtProdQuan.Location = new System.Drawing.Point(203, 44);
            this.txtProdQuan.MaxLength = 32764;
            this.txtProdQuan.Multiline = true;
            this.txtProdQuan.Name = "txtProdQuan";
            this.txtProdQuan.Size = new System.Drawing.Size(794, 35);
            this.txtProdQuan.TabIndex = 82;
            // 
            // txtProdPrice
            // 
            this.txtProdPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdPrice.ForeColor = System.Drawing.Color.White;
            this.txtProdPrice.Location = new System.Drawing.Point(203, 85);
            this.txtProdPrice.MaxLength = 32764;
            this.txtProdPrice.Multiline = true;
            this.txtProdPrice.Name = "txtProdPrice";
            this.txtProdPrice.Size = new System.Drawing.Size(794, 35);
            this.txtProdPrice.TabIndex = 83;
            // 
            // txtProdDesc
            // 
            this.txtProdDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtProdDesc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtProdDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdDesc.ForeColor = System.Drawing.Color.White;
            this.txtProdDesc.Location = new System.Drawing.Point(203, 126);
            this.txtProdDesc.MaxLength = 32764;
            this.txtProdDesc.Multiline = true;
            this.txtProdDesc.Name = "txtProdDesc";
            this.txtProdDesc.Size = new System.Drawing.Size(794, 35);
            this.txtProdDesc.TabIndex = 84;
            // 
            // cmbProdCat
            // 
            this.cmbProdCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.cmbProdCat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProdCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbProdCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbProdCat.FormattingEnabled = true;
            this.cmbProdCat.ItemHeight = 32;
            this.cmbProdCat.Location = new System.Drawing.Point(203, 167);
            this.cmbProdCat.Name = "cmbProdCat";
            this.cmbProdCat.Size = new System.Drawing.Size(794, 38);
            this.cmbProdCat.TabIndex = 87;
            // 
            // tlp3
            // 
            this.tlp3.ColumnCount = 4;
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp3.Controls.Add(this.btnUjhozzaadasa, 0, 0);
            this.tlp3.Controls.Add(this.btnSzerkesztes, 1, 0);
            this.tlp3.Controls.Add(this.btnMezotorles, 2, 0);
            this.tlp3.Controls.Add(this.btnTöröl, 3, 0);
            this.tlp3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp3.Location = new System.Drawing.Point(3, 262);
            this.tlp3.Name = "tlp3";
            this.tlp3.RowCount = 1;
            this.tlp3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp3.Size = new System.Drawing.Size(1000, 41);
            this.tlp3.TabIndex = 0;
            // 
            // btnUjhozzaadasa
            // 
            this.btnUjhozzaadasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUjhozzaadasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUjhozzaadasa.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUjhozzaadasa.ForeColor = System.Drawing.Color.White;
            this.btnUjhozzaadasa.Location = new System.Drawing.Point(3, 3);
            this.btnUjhozzaadasa.Name = "btnUjhozzaadasa";
            this.btnUjhozzaadasa.Size = new System.Drawing.Size(244, 35);
            this.btnUjhozzaadasa.TabIndex = 82;
            this.btnUjhozzaadasa.Text = "New product";
            this.btnUjhozzaadasa.UseVisualStyleBackColor = true;
            this.btnUjhozzaadasa.Click += new System.EventHandler(this.btnUjhozzaadasa_Click);
            // 
            // btnSzerkesztes
            // 
            this.btnSzerkesztes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSzerkesztes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzerkesztes.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSzerkesztes.ForeColor = System.Drawing.Color.White;
            this.btnSzerkesztes.Location = new System.Drawing.Point(253, 3);
            this.btnSzerkesztes.Name = "btnSzerkesztes";
            this.btnSzerkesztes.Size = new System.Drawing.Size(244, 35);
            this.btnSzerkesztes.TabIndex = 81;
            this.btnSzerkesztes.Text = "Update product";
            this.btnSzerkesztes.UseVisualStyleBackColor = true;
            // 
            // btnMezotorles
            // 
            this.btnMezotorles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMezotorles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMezotorles.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMezotorles.ForeColor = System.Drawing.Color.White;
            this.btnMezotorles.Location = new System.Drawing.Point(503, 3);
            this.btnMezotorles.Name = "btnMezotorles";
            this.btnMezotorles.Size = new System.Drawing.Size(244, 35);
            this.btnMezotorles.TabIndex = 83;
            this.btnMezotorles.Text = "Delete fields";
            this.btnMezotorles.UseVisualStyleBackColor = true;
            // 
            // btnTöröl
            // 
            this.btnTöröl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTöröl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTöröl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTöröl.ForeColor = System.Drawing.Color.White;
            this.btnTöröl.Location = new System.Drawing.Point(753, 3);
            this.btnTöröl.Name = "btnTöröl";
            this.btnTöröl.Size = new System.Drawing.Size(244, 35);
            this.btnTöröl.TabIndex = 84;
            this.btnTöröl.Text = "Delete product";
            this.btnTöröl.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 217);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 39);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(303, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 33);
            this.button3.TabIndex = 85;
            this.button3.Text = "Search products";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(503, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 33);
            this.button2.TabIndex = 84;
            this.button2.Text = "Refresh products";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 32;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(294, 38);
            this.comboBox1.TabIndex = 88;
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
            this.tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVProduct)).EndInit();
            this.tlp2.ResumeLayout(false);
            this.tlp4.ResumeLayout(false);
            this.tlp4.PerformLayout();
            this.tlp3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp1;
        private DataGridView DGVProduct;
        private DataGridViewTextBoxColumn ProductId;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductQuantity;
        private DataGridViewTextBoxColumn ProductPrice;
        private DataGridViewTextBoxColumn ProdDesc;
        private DataGridViewTextBoxColumn ProductCategorie;
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
        private ComboBox cmbProdCat;
        private Button btnUjhozzaadasa;
        private Button btnSzerkesztes;
        private Button btnMezotorles;
        private Button btnTöröl;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button3;
        private Button button2;
        private ComboBox comboBox1;
    }
}
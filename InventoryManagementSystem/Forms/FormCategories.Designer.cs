namespace InventoryManagementSystem.Forms
{
    partial class FormCategories
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
            this.DGVCategories = new System.Windows.Forms.DataGridView();
            this.CategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlp2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtcategory = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.tlp4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDeleteFields = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tlp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).BeginInit();
            this.tlp2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlp4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp1
            // 
            this.tlp1.ColumnCount = 1;
            this.tlp1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp1.Controls.Add(this.DGVCategories, 0, 0);
            this.tlp1.Controls.Add(this.tlp2, 0, 1);
            this.tlp1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp1.Location = new System.Drawing.Point(0, 0);
            this.tlp1.Name = "tlp1";
            this.tlp1.RowCount = 2;
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlp1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp1.Size = new System.Drawing.Size(1012, 623);
            this.tlp1.TabIndex = 0;
            // 
            // DGVCategories
            // 
            this.DGVCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryId,
            this.CategoryName});
            this.DGVCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVCategories.Location = new System.Drawing.Point(3, 3);
            this.DGVCategories.Name = "DGVCategories";
            this.DGVCategories.RowHeadersWidth = 51;
            this.DGVCategories.RowTemplate.Height = 29;
            this.DGVCategories.Size = new System.Drawing.Size(1006, 492);
            this.DGVCategories.TabIndex = 18;
            // 
            // CategoryId
            // 
            this.CategoryId.HeaderText = "Category id";
            this.CategoryId.MinimumWidth = 475;
            this.CategoryId.Name = "CategoryId";
            // 
            // CategoryName
            // 
            this.CategoryName.HeaderText = "Category name";
            this.CategoryName.MinimumWidth = 475;
            this.CategoryName.Name = "CategoryName";
            // 
            // tlp2
            // 
            this.tlp2.ColumnCount = 1;
            this.tlp2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlp2.Controls.Add(this.tlp4, 0, 1);
            this.tlp2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp2.Location = new System.Drawing.Point(3, 501);
            this.tlp2.Name = "tlp2";
            this.tlp2.RowCount = 2;
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp2.Size = new System.Drawing.Size(1006, 119);
            this.tlp2.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.txtcategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 53);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // txtcategory
            // 
            this.txtcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.txtcategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtcategory.ForeColor = System.Drawing.Color.White;
            this.txtcategory.Location = new System.Drawing.Point(203, 3);
            this.txtcategory.MaxLength = 32764;
            this.txtcategory.Multiline = true;
            this.txtcategory.Name = "txtcategory";
            this.txtcategory.Size = new System.Drawing.Size(794, 47);
            this.txtcategory.TabIndex = 81;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(3, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(194, 53);
            this.lbl3.TabIndex = 74;
            this.lbl3.Text = "Category Name:";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tlp4.Location = new System.Drawing.Point(3, 62);
            this.tlp4.Name = "tlp4";
            this.tlp4.RowCount = 1;
            this.tlp4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp4.Size = new System.Drawing.Size(1000, 54);
            this.tlp4.TabIndex = 21;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(503, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(244, 48);
            this.btnDelete.TabIndex = 82;
            this.btnDelete.Text = "Delete Category";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnDeleteFields
            // 
            this.btnDeleteFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDeleteFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteFields.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteFields.ForeColor = System.Drawing.Color.White;
            this.btnDeleteFields.Location = new System.Drawing.Point(753, 3);
            this.btnDeleteFields.Name = "btnDeleteFields";
            this.btnDeleteFields.Size = new System.Drawing.Size(244, 48);
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
            this.btnNew.Size = new System.Drawing.Size(244, 48);
            this.btnNew.TabIndex = 80;
            this.btnNew.Text = "New category";
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
            this.btnUpdate.Size = new System.Drawing.Size(244, 48);
            this.btnUpdate.TabIndex = 70;
            this.btnUpdate.Text = "Update category";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // FormCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1012, 623);
            this.Controls.Add(this.tlp1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategories";
            this.Text = "FormProducts";
            this.tlp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCategories)).EndInit();
            this.tlp2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlp4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp1;
        private DataGridView DGVCategories;
        private TableLayoutPanel tlp2;
        private TableLayoutPanel tlp4;
        private Button btnDelete;
        private Button btnDeleteFields;
        private Button btnNew;
        private Button btnUpdate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl3;
        private TextBox txtcategory;
        private DataGridViewTextBoxColumn CategoryId;
        private DataGridViewTextBoxColumn CategoryName;
    }
}
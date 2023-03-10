namespace InventoryManagementSystem.Forms
{
    partial class FormOrderDGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderDGV));
            this.iconexit = new FontAwesome.Sharp.IconPictureBox();
            this.panelMove = new System.Windows.Forms.Panel();
            this.DGVOrder = new System.Windows.Forms.DataGridView();
            this.printPreDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).BeginInit();
            this.panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // iconexit
            // 
            this.iconexit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconexit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(78)))));
            this.iconexit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.iconexit.IconColor = System.Drawing.Color.White;
            this.iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconexit.IconSize = 40;
            this.iconexit.Location = new System.Drawing.Point(1238, 5);
            this.iconexit.Name = "iconexit";
            this.iconexit.Size = new System.Drawing.Size(40, 40);
            this.iconexit.TabIndex = 14;
            this.iconexit.TabStop = false;
            this.iconexit.Click += new System.EventHandler(this.iconexit_Click);
            // 
            // panelMove
            // 
            this.panelMove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(80)))));
            this.panelMove.Controls.Add(this.iconexit);
            this.panelMove.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMove.Location = new System.Drawing.Point(0, 0);
            this.panelMove.Name = "panelMove";
            this.panelMove.Size = new System.Drawing.Size(1280, 50);
            this.panelMove.TabIndex = 15;
            this.panelMove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseDown);
            this.panelMove.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseMove);
            this.panelMove.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelMove_MouseUp);
            // 
            // DGVOrder
            // 
            this.DGVOrder.AllowUserToOrderColumns = true;
            this.DGVOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVOrder.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(70)))));
            this.DGVOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVOrder.GridColor = System.Drawing.Color.White;
            this.DGVOrder.Location = new System.Drawing.Point(12, 67);
            this.DGVOrder.Name = "DGVOrder";
            this.DGVOrder.RowHeadersWidth = 51;
            this.DGVOrder.RowTemplate.Height = 29;
            this.DGVOrder.Size = new System.Drawing.Size(1256, 641);
            this.DGVOrder.TabIndex = 21;
            this.DGVOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVOrder_CellClick);
            // 
            // printPreDialog
            // 
            this.printPreDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreDialog.Document = this.printDoc;
            this.printPreDialog.Enabled = true;
            this.printPreDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreDialog.Icon")));
            this.printPreDialog.Name = "printPreDialog";
            this.printPreDialog.Visible = false;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // FormOrderDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.DGVOrder);
            this.Controls.Add(this.panelMove);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrderDGV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormOrderDGV";
            this.Load += new System.EventHandler(this.FormOrderDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconexit)).EndInit();
            this.panelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconexit;
        private Panel panelMove;
        private DataGridView DGVOrder;
        private PrintPreviewDialog printPreDialog;
        private System.Drawing.Printing.PrintDocument printDoc;
    }
}
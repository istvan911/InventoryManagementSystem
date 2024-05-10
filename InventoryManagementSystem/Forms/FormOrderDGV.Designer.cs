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
            iconexit = new FontAwesome.Sharp.IconPictureBox();
            panelMove = new Panel();
            label1 = new Label();
            DGVOrder = new DataGridView();
            printPreDialog = new PrintPreviewDialog();
            printDoc = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)iconexit).BeginInit();
            panelMove.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVOrder).BeginInit();
            SuspendLayout();
            // 
            // iconexit
            // 
            iconexit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iconexit.BackColor = Color.FromArgb(31, 30, 78);
            iconexit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            iconexit.IconColor = Color.White;
            iconexit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconexit.IconSize = 40;
            iconexit.Location = new Point(1238, 5);
            iconexit.Name = "iconexit";
            iconexit.Size = new Size(40, 40);
            iconexit.TabIndex = 14;
            iconexit.TabStop = false;
            iconexit.Click += iconexit_Click;
            iconexit.MouseEnter += iconexit_MouseEnter;
            iconexit.MouseLeave += iconexit_MouseLeave;
            // 
            // panelMove
            // 
            panelMove.BackColor = Color.FromArgb(30, 30, 80);
            panelMove.Controls.Add(label1);
            panelMove.Controls.Add(iconexit);
            panelMove.Dock = DockStyle.Top;
            panelMove.Location = new Point(0, 0);
            panelMove.Name = "panelMove";
            panelMove.Size = new Size(1280, 50);
            panelMove.TabIndex = 15;
            panelMove.MouseDown += panelMove_MouseDown;
            panelMove.MouseMove += panelMove_MouseMove;
            panelMove.MouseUp += panelMove_MouseUp;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(30, 30, 60);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1280, 50);
            label1.TabIndex = 15;
            label1.Text = "Pick an order";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DGVOrder
            // 
            DGVOrder.AllowUserToOrderColumns = true;
            DGVOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVOrder.BackgroundColor = Color.FromArgb(30, 30, 70);
            DGVOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVOrder.GridColor = Color.White;
            DGVOrder.Location = new Point(12, 67);
            DGVOrder.Name = "DGVOrder";
            DGVOrder.RowHeadersWidth = 51;
            DGVOrder.RowTemplate.Height = 29;
            DGVOrder.Size = new Size(1256, 641);
            DGVOrder.TabIndex = 21;
            DGVOrder.CellClick += DGVOrder_CellClick;
            // 
            // printPreDialog
            // 
            printPreDialog.AutoScrollMargin = new Size(0, 0);
            printPreDialog.AutoScrollMinSize = new Size(0, 0);
            printPreDialog.ClientSize = new Size(400, 300);
            printPreDialog.Document = printDoc;
            printPreDialog.Enabled = true;
            printPreDialog.Icon = (Icon)resources.GetObject("printPreDialog.Icon");
            printPreDialog.Name = "printPreDialog";
            printPreDialog.Visible = false;
            // 
            // printDoc
            // 
            printDoc.PrintPage += printDoc_PrintPage;
            // 
            // FormOrderDGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 90);
            ClientSize = new Size(1280, 720);
            Controls.Add(DGVOrder);
            Controls.Add(panelMove);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormOrderDGV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormOrderDGV";
            Load += FormOrderDGV_Load;
            ((System.ComponentModel.ISupportInitialize)iconexit).EndInit();
            panelMove.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGVOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconexit;
        private Panel panelMove;
        private DataGridView DGVOrder;
        private PrintPreviewDialog printPreDialog;
        private System.Drawing.Printing.PrintDocument printDoc;
        private Label label1;
    }
}
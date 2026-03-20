namespace App.WindowsApp.Views
{
    partial class ProductView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tblProduct = new TableLayoutPanel();
            pnlToolBar = new Panel();
            tsProduct = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlFilters = new Panel();
            tblFilters = new TableLayoutPanel();
            lblStockStatus = new Label();
            tbSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            lblSearch = new Label();
            lblCategory = new Label();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblProduct.SuspendLayout();
            pnlToolBar.SuspendLayout();
            tsProduct.SuspendLayout();
            pnlFilters.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProduct
            // 
            tblProduct.ColumnCount = 1;
            tblProduct.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProduct.Controls.Add(pnlToolBar, 0, 0);
            tblProduct.Controls.Add(pnlFilters, 0, 1);
            tblProduct.Controls.Add(pnlGrid, 0, 2);
            tblProduct.Dock = DockStyle.Fill;
            tblProduct.Location = new Point(0, 0);
            tblProduct.Margin = new Padding(4);
            tblProduct.Name = "tblProduct";
            tblProduct.Padding = new Padding(18, 19, 18, 19);
            tblProduct.RowCount = 3;
            tblProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tblProduct.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tblProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProduct.Size = new Size(820, 506);
            tblProduct.TabIndex = 0;
            // 
            // pnlToolBar
            // 
            pnlToolBar.BackColor = Color.White;
            pnlToolBar.Controls.Add(tsProduct);
            pnlToolBar.Dock = DockStyle.Fill;
            pnlToolBar.Location = new Point(22, 23);
            pnlToolBar.Margin = new Padding(4);
            pnlToolBar.Name = "pnlToolBar";
            pnlToolBar.Size = new Size(776, 56);
            pnlToolBar.TabIndex = 0;
            // 
            // tsProduct
            // 
            tsProduct.Dock = DockStyle.Fill;
            tsProduct.GripStyle = ToolStripGripStyle.Hidden;
            tsProduct.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsProduct.Location = new Point(0, 0);
            tsProduct.Name = "tsProduct";
            tsProduct.Size = new Size(776, 56);
            tsProduct.TabIndex = 0;
            tsProduct.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.ico_add;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(49, 53);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.ico_edit;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(47, 53);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = Properties.Resources.ico_view;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(52, 53);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.ico_delete;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(60, 53);
            tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 56);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.ico_refresh;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(66, 53);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // pnlFilters
            // 
            pnlFilters.BackColor = Color.White;
            pnlFilters.Controls.Add(tblFilters);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(22, 87);
            pnlFilters.Margin = new Padding(4);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(14, 11, 14, 11);
            pnlFilters.Size = new Size(776, 89);
            pnlFilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            tblFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilters.ColumnCount = 3;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.Controls.Add(lblStockStatus, 2, 0);
            tblFilters.Controls.Add(tbSearch, 0, 1);
            tblFilters.Controls.Add(cmbCategory, 1, 1);
            tblFilters.Controls.Add(cmbStockStatus, 2, 1);
            tblFilters.Controls.Add(lblSearch, 0, 0);
            tblFilters.Controls.Add(lblCategory, 1, 0);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Location = new Point(14, 11);
            tblFilters.Margin = new Padding(4);
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 2;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.Size = new Size(748, 67);
            tblFilters.TabIndex = 0;
            tblFilters.Paint += tblFilters_Paint;
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.ForeColor = Color.FromArgb(102, 102, 110);
            lblStockStatus.Location = new Point(527, 0);
            lblStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(217, 33);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "Stock Status";
            // 
            // tbSearch
            // 
            tbSearch.Dock = DockStyle.Fill;
            tbSearch.Location = new Point(4, 37);
            tbSearch.Margin = new Padding(4);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(291, 23);
            tbSearch.TabIndex = 3;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(303, 37);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(216, 23);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(527, 37);
            cmbStockStatus.Margin = new Padding(4);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(217, 23);
            cmbStockStatus.TabIndex = 5;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.ForeColor = Color.FromArgb(102, 102, 110);
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(291, 33);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            lblSearch.Click += label1_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.ForeColor = Color.FromArgb(102, 102, 110);
            lblCategory.Location = new Point(303, 0);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(216, 33);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(22, 184);
            pnlGrid.Margin = new Padding(4);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14);
            pnlGrid.Size = new Size(776, 299);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colCategory, colPrice, colStock, colStatus });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(14, 14);
            dgvProducts.Margin = new Padding(4);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(748, 271);
            dgvProducts.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProduct);
            Margin = new Padding(4);
            Name = "ProductView";
            Size = new Size(820, 506);
            Load += ProductView_Load;
            tblProduct.ResumeLayout(false);
            pnlToolBar.ResumeLayout(false);
            pnlToolBar.PerformLayout();
            tsProduct.ResumeLayout(false);
            tsProduct.PerformLayout();
            pnlFilters.ResumeLayout(false);
            tblFilters.ResumeLayout(false);
            tblFilters.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProduct;
        private System.Windows.Forms.Panel pnlToolBar;
        private System.Windows.Forms.ToolStrip tsProduct;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.TableLayoutPanel tblFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}

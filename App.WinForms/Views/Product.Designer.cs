namespace App.WinForms.Views
{
    partial class Product
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tblProduct = new System.Windows.Forms.TableLayoutPanel();
            this.pnlToolBar = new System.Windows.Forms.Panel();
            this.tsProduct = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.tblFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbStockStatus = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProduct.SuspendLayout();
            this.pnlToolBar.SuspendLayout();
            this.tsProduct.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.tblFilters.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProduct
            // 
            this.tblProduct.ColumnCount = 1;
            this.tblProduct.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProduct.Controls.Add(this.pnlToolBar, 0, 0);
            this.tblProduct.Controls.Add(this.pnlFilters, 0, 1);
            this.tblProduct.Controls.Add(this.pnlGrid, 0, 2);
            this.tblProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProduct.Location = new System.Drawing.Point(0, 0);
            this.tblProduct.Name = "tblProduct";
            this.tblProduct.Padding = new System.Windows.Forms.Padding(16);
            this.tblProduct.RowCount = 3;
            this.tblProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblProduct.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProduct.Size = new System.Drawing.Size(703, 439);
            this.tblProduct.TabIndex = 0;
            // 
            // pnlToolBar
            // 
            this.pnlToolBar.BackColor = System.Drawing.Color.White;
            this.pnlToolBar.Controls.Add(this.tsProduct);
            this.pnlToolBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlToolBar.Location = new System.Drawing.Point(19, 19);
            this.pnlToolBar.Name = "pnlToolBar";
            this.pnlToolBar.Size = new System.Drawing.Size(665, 50);
            this.pnlToolBar.TabIndex = 0;
            // 
            // tsProduct
            // 
            this.tsProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsProduct.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbView,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbRefresh});
            this.tsProduct.Location = new System.Drawing.Point(0, 0);
            this.tsProduct.Name = "tsProduct";
            this.tsProduct.Size = new System.Drawing.Size(665, 50);
            this.tsProduct.TabIndex = 0;
            this.tsProduct.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::App.WinForms.Properties.Resources.ico_add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(57, 47);
            this.tsbAdd.Text = "Add";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::App.WinForms.Properties.Resources.ico_edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(55, 47);
            this.tsbEdit.Text = "Edit";
            // 
            // tsbView
            // 
            this.tsbView.Image = global::App.WinForms.Properties.Resources.ico_view;
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(61, 47);
            this.tsbView.Text = "View";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::App.WinForms.Properties.Resources.ico_delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(73, 47);
            this.tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::App.WinForms.Properties.Resources.ico_refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(78, 47);
            this.tsbRefresh.Text = "Refresh";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.Controls.Add(this.tblFilters);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(19, 75);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.pnlFilters.Size = new System.Drawing.Size(665, 78);
            this.pnlFilters.TabIndex = 1;
            // 
            // tblFilters
            // 
            this.tblFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblFilters.ColumnCount = 3;
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilters.Controls.Add(this.lblStockStatus, 2, 0);
            this.tblFilters.Controls.Add(this.tbSearch, 0, 1);
            this.tblFilters.Controls.Add(this.cmbCategory, 1, 1);
            this.tblFilters.Controls.Add(this.cmbStockStatus, 2, 1);
            this.tblFilters.Controls.Add(this.lblSearch, 0, 0);
            this.tblFilters.Controls.Add(this.lblCategory, 1, 0);
            this.tblFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilters.Location = new System.Drawing.Point(12, 10);
            this.tblFilters.Name = "tblFilters";
            this.tblFilters.RowCount = 2;
            this.tblFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilters.Size = new System.Drawing.Size(641, 58);
            this.tblFilters.TabIndex = 0;
            this.tblFilters.Paint += new System.Windows.Forms.PaintEventHandler(this.tblFilters_Paint);
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.lblStockStatus.Location = new System.Drawing.Point(451, 0);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(187, 29);
            this.lblStockStatus.TabIndex = 2;
            this.lblStockStatus.Text = "Stock Status";
            // 
            // tbSearch
            // 
            this.tbSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSearch.Location = new System.Drawing.Point(3, 32);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(250, 20);
            this.tbSearch.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(259, 32);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(186, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // cmbStockStatus
            // 
            this.cmbStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStockStatus.FormattingEnabled = true;
            this.cmbStockStatus.Location = new System.Drawing.Point(451, 32);
            this.cmbStockStatus.Name = "cmbStockStatus";
            this.cmbStockStatus.Size = new System.Drawing.Size(187, 21);
            this.cmbStockStatus.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(250, 29);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            this.lblSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(110)))));
            this.lblCategory.Location = new System.Drawing.Point(259, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(186, 29);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvProducts);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(19, 159);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlGrid.Size = new System.Drawing.Size(665, 261);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colStock,
            this.colStatus});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            this.dgvProducts.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(641, 237);
            this.dgvProducts.TabIndex = 0;
            // 
            // colId
            // 
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblProduct);
            this.Name = "Product";
            this.Size = new System.Drawing.Size(703, 439);
            this.tblProduct.ResumeLayout(false);
            this.pnlToolBar.ResumeLayout(false);
            this.pnlToolBar.PerformLayout();
            this.tsProduct.ResumeLayout(false);
            this.tsProduct.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.tblFilters.ResumeLayout(false);
            this.tblFilters.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}

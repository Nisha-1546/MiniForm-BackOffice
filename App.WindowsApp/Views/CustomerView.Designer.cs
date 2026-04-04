namespace App.WindowsApp.Views
{
    partial class CustomerView
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
            tlpCustomerView = new TableLayoutPanel();
            tsCommands = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            tsSeperater = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            flpSearch = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblCount = new Label();
            pnlCustomersData = new Panel();
            dgvCustomers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tlpCustomerView.SuspendLayout();
            tsCommands.SuspendLayout();
            flpSearch.SuspendLayout();
            pnlCustomersData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // tlpCustomerView
            // 
            tlpCustomerView.ColumnCount = 1;
            tlpCustomerView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerView.Controls.Add(tsCommands, 0, 0);
            tlpCustomerView.Controls.Add(flpSearch, 0, 1);
            tlpCustomerView.Controls.Add(pnlCustomersData, 0, 2);
            tlpCustomerView.Dock = DockStyle.Fill;
            tlpCustomerView.Location = new Point(0, 0);
            tlpCustomerView.Name = "tlpCustomerView";
            tlpCustomerView.RowCount = 3;
            tlpCustomerView.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerView.RowStyles.Add(new RowStyle());
            tlpCustomerView.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlpCustomerView.Size = new Size(526, 306);
            tlpCustomerView.TabIndex = 0;
            // 
            // tsCommands
            // 
            tsCommands.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, tsSeperater, tsbRefresh });
            tsCommands.Location = new Point(0, 0);
            tsCommands.Name = "tsCommands";
            tsCommands.Size = new Size(526, 25);
            tsCommands.TabIndex = 0;
            tsCommands.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.ico_add;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(49, 22);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.ico_edit;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(47, 22);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = Properties.Resources.ico_view;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(52, 22);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.ico_delete;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(60, 22);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // tsSeperater
            // 
            tsSeperater.Name = "tsSeperater";
            tsSeperater.Size = new Size(6, 25);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.ico_refresh;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(66, 22);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // flpSearch
            // 
            flpSearch.BackColor = Color.White;
            flpSearch.Controls.Add(lblSearch);
            flpSearch.Controls.Add(txtSearch);
            flpSearch.Controls.Add(lblCount);
            flpSearch.Dock = DockStyle.Fill;
            flpSearch.Location = new Point(3, 30);
            flpSearch.Name = "flpSearch";
            flpSearch.Size = new Size(520, 30);
            flpSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F);
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(49, 19);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10.2F);
            txtSearch.Location = new Point(58, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(283, 26);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 10.2F);
            lblCount.Location = new Point(347, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(58, 19);
            lblCount.TabIndex = 2;
            lblCount.Text = "Count:0";
            // 
            // pnlCustomersData
            // 
            pnlCustomersData.Controls.Add(dgvCustomers);
            pnlCustomersData.Dock = DockStyle.Fill;
            pnlCustomersData.Location = new Point(3, 66);
            pnlCustomersData.Name = "pnlCustomersData";
            pnlCustomersData.Size = new Size(520, 237);
            pnlCustomersData.TabIndex = 2;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, colAddress });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(520, 237);
            dgvCustomers.TabIndex = 0;
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
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpCustomerView);
            Name = "CustomerView";
            Size = new Size(526, 306);
            tlpCustomerView.ResumeLayout(false);
            tlpCustomerView.PerformLayout();
            tsCommands.ResumeLayout(false);
            tsCommands.PerformLayout();
            flpSearch.ResumeLayout(false);
            flpSearch.PerformLayout();
            pnlCustomersData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerView;
        private ToolStrip tsCommands;
        private ToolStripButton tsbAdd;
        private ToolStripButton tsbEdit;
        private ToolStripButton tsbView;
        private ToolStripButton tsbDelete;
        private ToolStripSeparator tsSeperater;
        private ToolStripButton tsbRefresh;
        private FlowLayoutPanel flpSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Label lblCount;
        private Panel pnlCustomersData;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
    }
}

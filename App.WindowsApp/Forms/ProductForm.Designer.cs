namespace App.WindowsApp.Forms
{
    partial class ProductForm
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
            tlpProductForm = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblID = new Label();
            txtName = new TextBox();
            cbCategory = new ComboBox();
            cbStatus = new ComboBox();
            txtId = new TextBox();
            nupPrice = new NumericUpDown();
            nupStock = new NumericUpDown();
            flpProductForm = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tlpProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).BeginInit();
            flpProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // tlpProductForm
            // 
            tlpProductForm.ColumnCount = 2;
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2312183F));
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.76878F));
            tlpProductForm.Controls.Add(lblName, 0, 0);
            tlpProductForm.Controls.Add(lblCategory, 0, 1);
            tlpProductForm.Controls.Add(lblPrice, 0, 2);
            tlpProductForm.Controls.Add(lblStock, 0, 3);
            tlpProductForm.Controls.Add(lblStatus, 0, 4);
            tlpProductForm.Controls.Add(lblID, 0, 5);
            tlpProductForm.Controls.Add(txtName, 1, 0);
            tlpProductForm.Controls.Add(cbCategory, 1, 1);
            tlpProductForm.Controls.Add(cbStatus, 1, 4);
            tlpProductForm.Controls.Add(txtId, 1, 5);
            tlpProductForm.Controls.Add(nupPrice, 1, 2);
            tlpProductForm.Controls.Add(nupStock, 1, 3);
            tlpProductForm.Dock = DockStyle.Top;
            tlpProductForm.Location = new Point(0, 0);
            tlpProductForm.Margin = new Padding(3, 2, 3, 2);
            tlpProductForm.Name = "tlpProductForm";
            tlpProductForm.RowCount = 6;
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tlpProductForm.Size = new Size(459, 136);
            tlpProductForm.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.White;
            lblName.Dock = DockStyle.Fill;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(73, 22);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.White;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Location = new Point(3, 22);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 22);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            lblCategory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.White;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Location = new Point(3, 44);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(73, 22);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.White;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Location = new Point(3, 66);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(73, 22);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            lblStock.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.White;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Location = new Point(3, 88);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(73, 22);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.White;
            lblID.Dock = DockStyle.Fill;
            lblID.Location = new Point(3, 110);
            lblID.Name = "lblID";
            lblID.Size = new Size(73, 26);
            lblID.TabIndex = 11;
            lblID.Text = "ID";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(82, 2);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(374, 23);
            txtName.TabIndex = 0;
            // 
            // cbCategory
            // 
            cbCategory.Dock = DockStyle.Fill;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(82, 24);
            cbCategory.Margin = new Padding(3, 2, 3, 2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(374, 23);
            cbCategory.TabIndex = 1;
            // 
            // cbStatus
            // 
            cbStatus.Dock = DockStyle.Fill;
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(82, 90);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(374, 23);
            cbStatus.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(82, 112);
            txtId.Margin = new Padding(3, 2, 3, 2);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(374, 23);
            txtId.TabIndex = 5;
            // 
            // nupPrice
            // 
            nupPrice.Dock = DockStyle.Fill;
            nupPrice.Location = new Point(82, 46);
            nupPrice.Margin = new Padding(3, 2, 3, 2);
            nupPrice.Name = "nupPrice";
            nupPrice.Size = new Size(374, 23);
            nupPrice.TabIndex = 2;
            // 
            // nupStock
            // 
            nupStock.Dock = DockStyle.Fill;
            nupStock.Location = new Point(82, 68);
            nupStock.Margin = new Padding(3, 2, 3, 2);
            nupStock.Name = "nupStock";
            nupStock.Size = new Size(374, 23);
            nupStock.TabIndex = 3;
            // 
            // flpProductForm
            // 
            flpProductForm.Controls.Add(btnSave);
            flpProductForm.Controls.Add(btnCancel);
            flpProductForm.Dock = DockStyle.Bottom;
            flpProductForm.FlowDirection = FlowDirection.RightToLeft;
            flpProductForm.Location = new Point(0, 197);
            flpProductForm.Margin = new Padding(3, 2, 3, 2);
            flpProductForm.Name = "flpProductForm";
            flpProductForm.Size = new Size(459, 34);
            flpProductForm.TabIndex = 1;
            flpProductForm.Paint += flp_Paint;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.ico_save;
            btnSave.Location = new Point(376, 2);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(80, 29);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.ico_cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(289, 2);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 29);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 231);
            Controls.Add(flpProductForm);
            Controls.Add(tlpProductForm);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            Load += ProductForm_Load;
            tlpProductForm.ResumeLayout(false);
            tlpProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupStock).EndInit();
            flpProductForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpProductForm;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblID;
        private TextBox txtName;
        private ComboBox cbCategory;
        private ComboBox cbStatus;
        private TextBox txtId;
        private FlowLayoutPanel flpProductForm;
        private Button btnCancel;
        private Button btnSave;
        private NumericUpDown nupPrice;
        private NumericUpDown nupStock;
    }
}
namespace App.WindowsApp.Forms
{
    partial class CustomerPicker
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
            tlpCustomerPicker = new TableLayoutPanel();
            flpSearchbar = new FlowLayoutPanel();
            lblSearchText = new Label();
            txtSearchQuery = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            lsCustomer = new ListBox();
            tlpCustomerPicker.SuspendLayout();
            flpSearchbar.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerPicker
            // 
            tlpCustomerPicker.ColumnCount = 1;
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerPicker.Controls.Add(flpSearchbar, 0, 0);
            tlpCustomerPicker.Controls.Add(flpButtons, 0, 2);
            tlpCustomerPicker.Controls.Add(lsCustomer, 0, 1);
            tlpCustomerPicker.Dock = DockStyle.Fill;
            tlpCustomerPicker.Location = new Point(0, 0);
            tlpCustomerPicker.Name = "tlpCustomerPicker";
            tlpCustomerPicker.RowCount = 3;
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.Size = new Size(646, 394);
            tlpCustomerPicker.TabIndex = 0;
            // 
            // flpSearchbar
            // 
            flpSearchbar.BackColor = Color.White;
            flpSearchbar.Controls.Add(lblSearchText);
            flpSearchbar.Controls.Add(txtSearchQuery);
            flpSearchbar.Dock = DockStyle.Fill;
            flpSearchbar.Location = new Point(3, 3);
            flpSearchbar.Name = "flpSearchbar";
            flpSearchbar.Size = new Size(640, 33);
            flpSearchbar.TabIndex = 0;
            // 
            // lblSearchText
            // 
            lblSearchText.AutoSize = true;
            lblSearchText.Font = new Font("Segoe UI", 10.2F);
            lblSearchText.Location = new Point(3, 0);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new Size(91, 19);
            lblSearchText.TabIndex = 0;
            lblSearchText.Text = "Search Query";
            lblSearchText.Click += lblSearchText_Click;
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(100, 3);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(270, 23);
            txtSearchQuery.TabIndex = 1;
            txtSearchQuery.TextChanged += txtSearchQuery_TextChanged;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = Color.White;
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 357);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(640, 34);
            flpButtons.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 10.2F);
            btnSelect.Image = Properties.Resources.ico_savenow;
            btnSelect.Location = new Point(543, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(94, 27);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10.2F);
            btnCancel.Image = Properties.Resources.ico_cancel;
            btnCancel.Location = new Point(449, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(88, 30);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lsCustomer
            // 
            lsCustomer.Dock = DockStyle.Fill;
            lsCustomer.FormattingEnabled = true;
            lsCustomer.Location = new Point(3, 42);
            lsCustomer.Name = "lsCustomer";
            lsCustomer.Size = new Size(640, 309);
            lsCustomer.TabIndex = 2;
            lsCustomer.DoubleClick += lsCustomer_DoubleClick;
            // 
            // CustomerPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 394);
            Controls.Add(tlpCustomerPicker);
            Name = "CustomerPicker";
            Text = "CustomerPicker";
            tlpCustomerPicker.ResumeLayout(false);
            flpSearchbar.ResumeLayout(false);
            flpSearchbar.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerPicker;
        private FlowLayoutPanel flpSearchbar;
        private Label lblSearchText;
        private TextBox txtSearchQuery;
        private FlowLayoutPanel flpButtons;
        private Button btnSelect;
        private Button btnCancel;
        private ListBox lsCustomer;
    }
}
namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            tlpCustomer = new TableLayoutPanel();
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblId = new Label();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtId = new TextBox();
            flpButton = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tlpCustomer.SuspendLayout();
            flpButton.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomer
            // 
            tlpCustomer.ColumnCount = 2;
            tlpCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpCustomer.Controls.Add(lblName, 0, 0);
            tlpCustomer.Controls.Add(txtName, 1, 0);
            tlpCustomer.Controls.Add(lblPhone, 0, 1);
            tlpCustomer.Controls.Add(lblEmail, 0, 2);
            tlpCustomer.Controls.Add(lblAddress, 0, 3);
            tlpCustomer.Controls.Add(lblId, 0, 4);
            tlpCustomer.Controls.Add(txtPhone, 1, 1);
            tlpCustomer.Controls.Add(txtEmail, 1, 2);
            tlpCustomer.Controls.Add(txtAddress, 1, 3);
            tlpCustomer.Controls.Add(txtId, 1, 4);
            tlpCustomer.Dock = DockStyle.Top;
            tlpCustomer.Location = new Point(0, 0);
            tlpCustomer.Name = "tlpCustomer";
            tlpCustomer.RowCount = 5;
            tlpCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpCustomer.RowStyles.Add(new RowStyle());
            tlpCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tlpCustomer.Size = new Size(503, 181);
            tlpCustomer.TabIndex = 0;
            tlpCustomer.Paint += tableLayoutPanel1_Paint;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 10.2F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 34);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(103, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(397, 23);
            txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 10.2F);
            lblPhone.Location = new Point(3, 34);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(94, 34);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 10.2F);
            lblEmail.Location = new Point(3, 68);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(94, 34);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 10.2F);
            lblAddress.Location = new Point(3, 102);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(94, 49);
            lblAddress.TabIndex = 4;
            lblAddress.Text = "Address";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 10.2F);
            lblId.Location = new Point(3, 151);
            lblId.Name = "lblId";
            lblId.Size = new Size(94, 34);
            lblId.TabIndex = 5;
            lblId.Text = "Id";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(103, 37);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(397, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(103, 71);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(397, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(103, 105);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(397, 43);
            txtAddress.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(103, 154);
            txtId.Name = "txtId";
            txtId.Size = new Size(397, 23);
            txtId.TabIndex = 9;
            // 
            // flpButton
            // 
            flpButton.Controls.Add(btnCancel);
            flpButton.Controls.Add(btnSave);
            flpButton.Dock = DockStyle.Bottom;
            flpButton.FlowDirection = FlowDirection.RightToLeft;
            flpButton.Location = new Point(0, 251);
            flpButton.Name = "flpButton";
            flpButton.Size = new Size(503, 50);
            flpButton.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 10.2F);
            btnCancel.Image = Properties.Resources.ico_cancel;
            btnCancel.Location = new Point(405, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(89, 34);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Font = new Font("Segoe UI", 10.2F);
            btnSave.Image = Properties.Resources.ico_save;
            btnSave.Location = new Point(301, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(86, 34);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 301);
            Controls.Add(flpButton);
            Controls.Add(tlpCustomer);
            Name = "CustomerForm";
            tlpCustomer.ResumeLayout(false);
            tlpCustomer.PerformLayout();
            flpButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomer;
        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblId;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtId;
        private FlowLayoutPanel flpButton;
        private Button btnCancel;
        private Button btnSave;
    }
}
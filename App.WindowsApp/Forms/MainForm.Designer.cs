

namespace App.WindowsApp.Forms
{
    partial class MainForm
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
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            pbUser = new PictureBox();
            lblUser = new Label();
            flpLeft = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            pnlSidebar = new Panel();
            flpNav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnCustomer = new Button();
            btnOrders = new Button();
            btnReport = new Button();
            btnSync = new Button();
            btnLogs = new Button();
            btnSetting = new Button();
            pnlContent = new Panel();
            statusStrip = new StatusStrip();
            tsLabelStatus = new ToolStripStatusLabel();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlSidebar.SuspendLayout();
            flpNav.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 3, 4, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(551, 44);
            pnlHeader.TabIndex = 0;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(pbUser);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Location = new Point(423, 0);
            flpRight.Margin = new Padding(4, 3, 4, 3);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(128, 44);
            flpRight.TabIndex = 2;
            // 
            // pbUser
            // 
            pbUser.Image = Properties.Resources.ico_Admin;
            pbUser.Location = new Point(3, 3);
            pbUser.Name = "pbUser";
            pbUser.Padding = new Padding(5, 10, 0, 10);
            pbUser.Size = new Size(29, 38);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Left;
            lblUser.AutoSize = true;
            lblUser.Location = new Point(38, 9);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(0, 10, 0, 0);
            lblUser.Size = new Size(43, 25);
            lblUser.TabIndex = 1;
            lblUser.Text = "Admin";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            lblUser.Click += lblUser_Click;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(4, 3, 4, 3);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(69, 44);
            flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Anchor = AnchorStyles.Left;
            pbLogo.Image = Properties.Resources.ico_home;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Padding = new Padding(10, 10, 0, 10);
            pbLogo.Size = new Size(63, 44);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(flpNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 44);
            pnlSidebar.Margin = new Padding(4, 3, 4, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(167, 390);
            pnlSidebar.TabIndex = 1;
            // 
            // flpNav
            // 
            flpNav.Controls.Add(btnDashboard);
            flpNav.Controls.Add(btnProducts);
            flpNav.Controls.Add(btnCustomer);
            flpNav.Controls.Add(btnOrders);
            flpNav.Controls.Add(btnReport);
            flpNav.Controls.Add(btnSync);
            flpNav.Controls.Add(btnLogs);
            flpNav.Controls.Add(btnSetting);
            flpNav.Dock = DockStyle.Left;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Location = new Point(0, 0);
            flpNav.Margin = new Padding(4, 3, 4, 3);
            flpNav.Name = "flpNav";
            flpNav.Size = new Size(167, 390);
            flpNav.TabIndex = 0;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = Properties.Resources.ico_dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(10, 0, 0, 0);
            btnDashboard.Size = new Size(200, 40);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Image = Properties.Resources.ico_product;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(3, 49);
            btnProducts.Name = "btnProducts";
            btnProducts.Padding = new Padding(10, 0, 0, 0);
            btnProducts.Size = new Size(200, 40);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Image = Properties.Resources.ico_customer;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(3, 95);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Padding = new Padding(10, 0, 0, 0);
            btnCustomer.Size = new Size(200, 40);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Image = Properties.Resources.ico_order;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(3, 141);
            btnOrders.Name = "btnOrders";
            btnOrders.Padding = new Padding(10, 0, 0, 0);
            btnOrders.Size = new Size(200, 40);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Image = Properties.Resources.ico_report;
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(3, 187);
            btnReport.Name = "btnReport";
            btnReport.Padding = new Padding(10, 0, 0, 0);
            btnReport.Size = new Size(200, 40);
            btnReport.TabIndex = 3;
            btnReport.Text = "Report";
            btnReport.TextAlign = ContentAlignment.MiddleLeft;
            btnReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Image = Properties.Resources.ico_sync;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(3, 233);
            btnSync.Name = "btnSync";
            btnSync.Padding = new Padding(10, 0, 0, 0);
            btnSync.Size = new Size(200, 40);
            btnSync.TabIndex = 4;
            btnSync.Text = "Sync";
            btnSync.TextAlign = ContentAlignment.MiddleLeft;
            btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSync.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Image = Properties.Resources.ico_logs;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(3, 279);
            btnLogs.Name = "btnLogs";
            btnLogs.Padding = new Padding(10, 0, 0, 0);
            btnLogs.Size = new Size(200, 40);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Image = Properties.Resources.ico_settings;
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(3, 325);
            btnSetting.Name = "btnSetting";
            btnSetting.Padding = new Padding(10, 0, 0, 0);
            btnSetting.Size = new Size(200, 40);
            btnSetting.TabIndex = 6;
            btnSetting.Text = "Setting";
            btnSetting.TextAlign = ContentAlignment.MiddleLeft;
            btnSetting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(167, 44);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(384, 390);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { tsLabelStatus });
            statusStrip.Location = new Point(0, 434);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(551, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            statusStrip.ItemClicked += statusStrip1_ItemClicked;
            // 
            // tsLabelStatus
            // 
            tsLabelStatus.Name = "tsLabelStatus";
            tsLabelStatus.Size = new Size(39, 17);
            tsLabelStatus.Text = "Ready";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 456);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(statusStrip);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlSidebar.ResumeLayout(false);
            flpNav.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelStatus;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblUser;
        private Button btnCustomer;
    }
}
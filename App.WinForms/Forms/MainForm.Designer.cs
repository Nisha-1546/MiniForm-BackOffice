

namespace App.WinForms.Forms
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.flpRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.flpLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.flpNav = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnSync = new System.Windows.Forms.Button();
            this.btnLogs = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsLabelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlHeader.SuspendLayout();
            this.flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.flpNav.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.flpRight);
            this.pnlHeader.Controls.Add(this.flpLeft);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(563, 44);
            this.pnlHeader.TabIndex = 0;
            // 
            // flpRight
            // 
            this.flpRight.Controls.Add(this.pbUser);
            this.flpRight.Controls.Add(this.lblUser);
            this.flpRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.flpRight.Location = new System.Drawing.Point(435, 0);
            this.flpRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpRight.Name = "flpRight";
            this.flpRight.Size = new System.Drawing.Size(128, 44);
            this.flpRight.TabIndex = 2;
            // 
            // pbUser
            // 
            this.pbUser.Image = global::App.WinForms.Properties.Resources.ico_Admin;
            this.pbUser.Location = new System.Drawing.Point(3, 3);
            this.pbUser.Name = "pbUser";
            this.pbUser.Padding = new System.Windows.Forms.Padding(5, 10, 0, 10);
            this.pbUser.Size = new System.Drawing.Size(29, 38);
            this.pbUser.TabIndex = 0;
            this.pbUser.TabStop = false;
            this.pbUser.Click += new System.EventHandler(this.pbUser_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(38, 9);
            this.lblUser.Name = "lblUser";
            this.lblUser.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblUser.Size = new System.Drawing.Size(43, 25);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Admin";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.lblUser_Click);
            // 
            // flpLeft
            // 
            this.flpLeft.Controls.Add(this.pbLogo);
            this.flpLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpLeft.Location = new System.Drawing.Point(0, 0);
            this.flpLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpLeft.Name = "flpLeft";
            this.flpLeft.Size = new System.Drawing.Size(128, 44);
            this.flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pbLogo.Image = global::App.WinForms.Properties.Resources.ico_home;
            this.pbLogo.Location = new System.Drawing.Point(3, 3);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Padding = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.pbLogo.Size = new System.Drawing.Size(63, 44);
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.flpNav);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 44);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(167, 294);
            this.pnlSidebar.TabIndex = 1;
            // 
            // flpNav
            // 
            this.flpNav.Controls.Add(this.btnDashboard);
            this.flpNav.Controls.Add(this.btnProducts);
            this.flpNav.Controls.Add(this.btnOrders);
            this.flpNav.Controls.Add(this.btnReport);
            this.flpNav.Controls.Add(this.btnSync);
            this.flpNav.Controls.Add(this.btnLogs);
            this.flpNav.Controls.Add(this.btnSetting);
            this.flpNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpNav.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpNav.Location = new System.Drawing.Point(0, 0);
            this.flpNav.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flpNav.Name = "flpNav";
            this.flpNav.Size = new System.Drawing.Size(167, 294);
            this.flpNav.TabIndex = 0;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Image = global::App.WinForms.Properties.Resources.ico_dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(200, 40);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Image = global::App.WinForms.Properties.Resources.ico_product;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(3, 49);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProducts.Size = new System.Drawing.Size(200, 40);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.FlatAppearance.BorderSize = 0;
            this.btnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrders.Image = global::App.WinForms.Properties.Resources.ico_order;
            this.btnOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.Location = new System.Drawing.Point(3, 95);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrders.Size = new System.Drawing.Size(200, 40);
            this.btnOrders.TabIndex = 2;
            this.btnOrders.Text = "Orders";
            this.btnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Image = global::App.WinForms.Properties.Resources.ico_report;
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(3, 141);
            this.btnReport.Name = "btnReport";
            this.btnReport.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReport.Size = new System.Drawing.Size(200, 40);
            this.btnReport.TabIndex = 3;
            this.btnReport.Text = "Report";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReport.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            this.btnSync.FlatAppearance.BorderSize = 0;
            this.btnSync.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSync.Image = global::App.WinForms.Properties.Resources.ico_sync;
            this.btnSync.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.Location = new System.Drawing.Point(3, 187);
            this.btnSync.Name = "btnSync";
            this.btnSync.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSync.Size = new System.Drawing.Size(200, 40);
            this.btnSync.TabIndex = 4;
            this.btnSync.Text = "Sync";
            this.btnSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSync.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSync.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            this.btnLogs.FlatAppearance.BorderSize = 0;
            this.btnLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogs.Image = global::App.WinForms.Properties.Resources.ico_logs;
            this.btnLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Location = new System.Drawing.Point(3, 233);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnLogs.Size = new System.Drawing.Size(200, 40);
            this.btnLogs.TabIndex = 5;
            this.btnLogs.Text = "Logs";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogs.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Image = global::App.WinForms.Properties.Resources.ico_settings;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(209, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSetting.Size = new System.Drawing.Size(200, 40);
            this.btnSetting.TabIndex = 6;
            this.btnSetting.Text = "Setting";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(167, 44);
            this.pnlContent.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(396, 294);
            this.pnlContent.TabIndex = 2;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLabelStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 338);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(563, 25);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // tsLabelStatus
            // 
            this.tsLabelStatus.Name = "tsLabelStatus";
            this.tsLabelStatus.Size = new System.Drawing.Size(50, 20);
            this.tsLabelStatus.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 363);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.flpRight.ResumeLayout(false);
            this.flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.flpNav.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}
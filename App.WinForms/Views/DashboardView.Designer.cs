namespace App.WinForms.Views
{
    partial class DashboardView
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
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.flpKPI = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSaleV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.lblOrderV = new System.Windows.Forms.Label();
            this.lblOrderT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlRecentOrders = new System.Windows.Forms.Panel();
            this.lvRecentOrder = new System.Windows.Forms.ListView();
            this.colOrderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrder = new System.Windows.Forms.Label();
            this.tblDashboard.SuspendLayout();
            this.flpKPI.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.flpKPI, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Controls.Add(this.pnlRecentOrders, 0, 2);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(553, 314);
            this.tblDashboard.TabIndex = 0;
            this.tblDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.tblDashboard_Paint);
            // 
            // flpKPI
            // 
            this.flpKPI.Controls.Add(this.pnlSales);
            this.flpKPI.Controls.Add(this.pnlOrder);
            this.flpKPI.Controls.Add(this.pnlRevenue);
            this.flpKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKPI.Location = new System.Drawing.Point(3, 3);
            this.flpKPI.Name = "flpKPI";
            this.flpKPI.Size = new System.Drawing.Size(547, 114);
            this.flpKPI.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSaleV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(172, 111);
            this.pnlSales.TabIndex = 2;
            // 
            // lblSaleV
            // 
            this.lblSaleV.AutoSize = true;
            this.lblSaleV.Location = new System.Drawing.Point(79, 41);
            this.lblSaleV.Name = "lblSaleV";
            this.lblSaleV.Size = new System.Drawing.Size(25, 13);
            this.lblSaleV.TabIndex = 1;
            this.lblSaleV.Text = "163";
            this.lblSaleV.Click += new System.EventHandler(this.lblSaleV_Click);
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Location = new System.Drawing.Point(18, 41);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(33, 13);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrder
            // 
            this.pnlOrder.BackColor = System.Drawing.Color.White;
            this.pnlOrder.Controls.Add(this.lblOrderV);
            this.pnlOrder.Controls.Add(this.lblOrderT);
            this.pnlOrder.Location = new System.Drawing.Point(181, 3);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(178, 111);
            this.pnlOrder.TabIndex = 3;
            // 
            // lblOrderV
            // 
            this.lblOrderV.AutoSize = true;
            this.lblOrderV.Location = new System.Drawing.Point(110, 41);
            this.lblOrderV.Name = "lblOrderV";
            this.lblOrderV.Size = new System.Drawing.Size(13, 13);
            this.lblOrderV.TabIndex = 1;
            this.lblOrderV.Text = "0";
            // 
            // lblOrderT
            // 
            this.lblOrderT.AutoSize = true;
            this.lblOrderT.Location = new System.Drawing.Point(35, 41);
            this.lblOrderT.Name = "lblOrderT";
            this.lblOrderT.Size = new System.Drawing.Size(38, 13);
            this.lblOrderT.TabIndex = 0;
            this.lblOrderT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(365, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(171, 111);
            this.pnlRevenue.TabIndex = 4;
            this.pnlRevenue.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRevenue_Paint);
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(112, 42);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(13, 13);
            this.lblRevenueV.TabIndex = 2;
            this.lblRevenueV.Text = "0";
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(39, 41);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(51, 13);
            this.lblRevenueT.TabIndex = 1;
            this.lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.Controls.Add(this.lvLowStock);
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(536, 91);
            this.pnlLowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(3, 20);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(533, 68);
            this.lvLowStock.TabIndex = 1;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            this.lvLowStock.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLowStock.Location = new System.Drawing.Point(0, 0);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(58, 13);
            this.lblLowStock.TabIndex = 0;
            this.lblLowStock.Text = "Low Stock";
            // 
            // pnlRecentOrders
            // 
            this.pnlRecentOrders.Controls.Add(this.lvRecentOrder);
            this.pnlRecentOrders.Controls.Add(this.lblRecentOrder);
            this.pnlRecentOrders.Location = new System.Drawing.Point(3, 220);
            this.pnlRecentOrders.Name = "pnlRecentOrders";
            this.pnlRecentOrders.Size = new System.Drawing.Size(536, 91);
            this.pnlRecentOrders.TabIndex = 2;
            // 
            // lvRecentOrder
            // 
            this.lvRecentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrderId,
            this.colCustomer,
            this.colTotal,
            this.colStatus});
            this.lvRecentOrder.HideSelection = false;
            this.lvRecentOrder.Location = new System.Drawing.Point(3, 16);
            this.lvRecentOrder.Name = "lvRecentOrder";
            this.lvRecentOrder.Size = new System.Drawing.Size(530, 72);
            this.lvRecentOrder.TabIndex = 1;
            this.lvRecentOrder.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrder.View = System.Windows.Forms.View.Details;
            // 
            // colOrderId
            // 
            this.colOrderId.Text = "Order Id";
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // lblRecentOrder
            // 
            this.lblRecentOrder.AutoSize = true;
            this.lblRecentOrder.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRecentOrder.Location = new System.Drawing.Point(0, 0);
            this.lblRecentOrder.Name = "lblRecentOrder";
            this.lblRecentOrder.Size = new System.Drawing.Size(71, 13);
            this.lblRecentOrder.TabIndex = 0;
            this.lblRecentOrder.Text = "Recent Order";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(553, 314);
            this.tblDashboard.ResumeLayout(false);
            this.flpKPI.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrders.ResumeLayout(false);
            this.pnlRecentOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.FlowLayoutPanel flpKPI;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblOrderT;
        private System.Windows.Forms.Label lblSaleV;
        private System.Windows.Forms.Label lblOrderV;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrders;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.ListView lvRecentOrder;
        private System.Windows.Forms.Label lblRecentOrder;
        private System.Windows.Forms.ColumnHeader colOrderId;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}

namespace App.WindowsApp.Views
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
            tblDashboard = new TableLayoutPanel();
            flpKPI = new FlowLayoutPanel();
            pnlSales = new Panel();
            lblSaleV = new Label();
            lblSalesT = new Label();
            pnlOrder = new Panel();
            lblOrderV = new Label();
            lblOrderT = new Label();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlLowStock = new Panel();
            lvLowStock = new ListView();
            colProduct = new ColumnHeader();
            colStock = new ColumnHeader();
            lblLowStock = new Label();
            pnlRecentOrders = new Panel();
            lvRecentOrder = new ListView();
            colOrderId = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colTotal = new ColumnHeader();
            colStatus = new ColumnHeader();
            lblRecentOrder = new Label();
            tblDashboard.SuspendLayout();
            flpKPI.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrder.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrders.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashboard
            // 
            tblDashboard.ColumnCount = 1;
            tblDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashboard.Controls.Add(flpKPI, 0, 0);
            tblDashboard.Controls.Add(pnlLowStock, 0, 1);
            tblDashboard.Controls.Add(pnlRecentOrders, 0, 2);
            tblDashboard.Dock = DockStyle.Fill;
            tblDashboard.Location = new Point(0, 0);
            tblDashboard.Margin = new Padding(4);
            tblDashboard.Name = "tblDashboard";
            tblDashboard.RowCount = 3;
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Absolute, 139F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashboard.Size = new Size(645, 362);
            tblDashboard.TabIndex = 0;
            tblDashboard.Paint += tblDashboard_Paint;
            // 
            // flpKPI
            // 
            flpKPI.Controls.Add(pnlSales);
            flpKPI.Controls.Add(pnlOrder);
            flpKPI.Controls.Add(pnlRevenue);
            flpKPI.Dock = DockStyle.Fill;
            flpKPI.Location = new Point(4, 4);
            flpKPI.Margin = new Padding(4);
            flpKPI.Name = "flpKPI";
            flpKPI.Size = new Size(637, 131);
            flpKPI.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSaleV);
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Location = new Point(4, 4);
            pnlSales.Margin = new Padding(4);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(200, 128);
            pnlSales.TabIndex = 2;
            // 
            // lblSaleV
            // 
            lblSaleV.AutoSize = true;
            lblSaleV.Location = new Point(92, 47);
            lblSaleV.Margin = new Padding(4, 0, 4, 0);
            lblSaleV.Name = "lblSaleV";
            lblSaleV.Size = new Size(25, 15);
            lblSaleV.TabIndex = 1;
            lblSaleV.Text = "163";
            lblSaleV.Click += lblSaleV_Click;
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Location = new Point(21, 47);
            lblSalesT.Margin = new Padding(4, 0, 4, 0);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(33, 15);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // pnlOrder
            // 
            pnlOrder.BackColor = Color.White;
            pnlOrder.Controls.Add(lblOrderV);
            pnlOrder.Controls.Add(lblOrderT);
            pnlOrder.Location = new Point(212, 4);
            pnlOrder.Margin = new Padding(4);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new Size(207, 128);
            pnlOrder.TabIndex = 3;
            // 
            // lblOrderV
            // 
            lblOrderV.AutoSize = true;
            lblOrderV.Location = new Point(129, 47);
            lblOrderV.Margin = new Padding(4, 0, 4, 0);
            lblOrderV.Name = "lblOrderV";
            lblOrderV.Size = new Size(13, 15);
            lblOrderV.TabIndex = 1;
            lblOrderV.Text = "0";
            // 
            // lblOrderT
            // 
            lblOrderT.AutoSize = true;
            lblOrderT.Location = new Point(41, 47);
            lblOrderT.Margin = new Padding(4, 0, 4, 0);
            lblOrderT.Name = "lblOrderT";
            lblOrderT.Size = new Size(42, 15);
            lblOrderT.TabIndex = 0;
            lblOrderT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Location = new Point(427, 4);
            pnlRevenue.Margin = new Padding(4);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(200, 128);
            pnlRevenue.TabIndex = 4;
            pnlRevenue.Paint += pnlRevenue_Paint;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Location = new Point(130, 49);
            lblRevenueV.Margin = new Padding(4, 0, 4, 0);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(13, 15);
            lblRevenueV.TabIndex = 2;
            lblRevenueV.Text = "0";
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Location = new Point(46, 47);
            lblRevenueT.Margin = new Padding(4, 0, 4, 0);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(52, 15);
            lblRevenueT.TabIndex = 1;
            lblRevenueT.Text = "Revenue";
            // 
            // pnlLowStock
            // 
            pnlLowStock.Controls.Add(lvLowStock);
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Location = new Point(4, 143);
            pnlLowStock.Margin = new Padding(4);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(626, 103);
            pnlLowStock.TabIndex = 1;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { colProduct, colStock });
            lvLowStock.Location = new Point(4, 23);
            lvLowStock.Margin = new Padding(4);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(621, 78);
            lvLowStock.TabIndex = 1;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            lvLowStock.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colProduct
            // 
            colProduct.Text = "Product";
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Dock = DockStyle.Left;
            lblLowStock.Location = new Point(0, 0);
            lblLowStock.Margin = new Padding(4, 0, 4, 0);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(61, 15);
            lblLowStock.TabIndex = 0;
            lblLowStock.Text = "Low Stock";
            // 
            // pnlRecentOrders
            // 
            pnlRecentOrders.Controls.Add(lvRecentOrder);
            pnlRecentOrders.Controls.Add(lblRecentOrder);
            pnlRecentOrders.Location = new Point(4, 254);
            pnlRecentOrders.Margin = new Padding(4);
            pnlRecentOrders.Name = "pnlRecentOrders";
            pnlRecentOrders.Size = new Size(626, 104);
            pnlRecentOrders.TabIndex = 2;
            // 
            // lvRecentOrder
            // 
            lvRecentOrder.Columns.AddRange(new ColumnHeader[] { colOrderId, colCustomer, colTotal, colStatus });
            lvRecentOrder.Location = new Point(4, 19);
            lvRecentOrder.Margin = new Padding(4);
            lvRecentOrder.Name = "lvRecentOrder";
            lvRecentOrder.Size = new Size(617, 83);
            lvRecentOrder.TabIndex = 1;
            lvRecentOrder.UseCompatibleStateImageBehavior = false;
            lvRecentOrder.View = View.Details;
            // 
            // colOrderId
            // 
            colOrderId.Text = "Order Id";
            // 
            // colCustomer
            // 
            colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            colTotal.Text = "Total";
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            // 
            // lblRecentOrder
            // 
            lblRecentOrder.AutoSize = true;
            lblRecentOrder.Dock = DockStyle.Left;
            lblRecentOrder.Location = new Point(0, 0);
            lblRecentOrder.Margin = new Padding(4, 0, 4, 0);
            lblRecentOrder.Name = "lblRecentOrder";
            lblRecentOrder.Size = new Size(76, 15);
            lblRecentOrder.TabIndex = 0;
            lblRecentOrder.Text = "Recent Order";
            // 
            // DashboardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashboard);
            Margin = new Padding(4);
            Name = "DashboardView";
            Size = new Size(645, 362);
            tblDashboard.ResumeLayout(false);
            flpKPI.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrder.ResumeLayout(false);
            pnlOrder.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrders.ResumeLayout(false);
            pnlRecentOrders.PerformLayout();
            ResumeLayout(false);

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

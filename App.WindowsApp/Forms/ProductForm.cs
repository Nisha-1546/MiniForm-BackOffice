using App.core.Models;
using App.core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();
            nupPrice.Maximum= Decimal.MaxValue;
            nupStock.Maximum = Int32.MaxValue;

            cbCategory.Items.Clear();
            cbCategory.DataSource=Enum.GetValues(typeof(ProductCategoryEnum));
            cbCategory.SelectedIndex = 0;

            cbStatus.Items.Clear();
            cbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cbStatus.SelectedIndex = 0;



            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible= false;
            }


            if (mode == ProductFormModeEnum.Edit || mode== ProductFormModeEnum.View)
            {
          
                txtId.Text = p.Id;
                txtName.Text = p.Name;
                cbCategory.SelectedItem = p.Category;
                cbStatus.SelectedItem = p.Status;
                nupPrice.Value = p.Price;
                nupStock.Value = p.Stock;
            }
            
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void flp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}

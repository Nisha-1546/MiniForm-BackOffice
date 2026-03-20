using App.core.Contracts;
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
        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;
        public ProductForm(ProductFormModeEnum mode, Product? p,IProductService service)
        {
            InitializeComponent();

            nupPrice.Maximum = Decimal.MaxValue;
            nupStock.Maximum = Int32.MaxValue;

            cbCategory.Items.Clear();
            cbCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cbCategory.SelectedIndex = 0;

            cbStatus.Items.Clear();
            cbStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cbStatus.SelectedIndex = 0;


            _mode = mode;
            _product = p;
            _service = service;
            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;
            }


            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
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
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtName.Text;
                newProduct.Category = (ProductCategoryEnum)cbCategory.SelectedItem;
                newProduct.Status = (ProductStatusEnum)cbStatus.SelectedItem;
                newProduct.Price = nupPrice.Value;
                newProduct.Stock = (int)nupStock.Value;

               Product temp = _service.Add(newProduct);
                txtId.Text = temp?.Id?? "";
                //_product=_service.Add(newProduct);
                //txtId.Text = _product.Id;
            }
            else if(_mode==ProductFormModeEnum.Edit)
            {
                _product.Name = txtName.Text;
                _product.Category = (ProductCategoryEnum)cbCategory.SelectedItem;
                _product.Status = (ProductStatusEnum)cbStatus.SelectedItem;
                _product.Price = nupPrice.Value;
                _product.Stock = (int)nupStock.Value;

                bool isUpdated=_service.Update(_product);
            }
            this.Close();
        }
    }
}

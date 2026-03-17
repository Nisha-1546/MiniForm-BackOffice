using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.core.Contracts;
using App.core.Utilities;
using App.WindowsApp.Forms;
using App.core.Models;

namespace App.WindowsApp.Views
    
{
    public partial class ProductView : UserControl
    {
        private IProductService _service;
        BindingSource _dgvBindingSource = new BindingSource();
        public ProductView(IProductService _ser)
        {
            _service = _ser;
            InitializeComponent();
            dgvProducts.DataSource = _dgvBindingSource;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tblFilters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {

        }

        private void ProductView_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--All--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--All--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;
            _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm=new ProductForm(ProductFormModeEnum.Add,null);
            prodForm.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct=_dgvBindingSource.Current as Product;
            if(selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodForm.ShowDialog();
            }

           
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodForm.ShowDialog();
            }
        }
    }
}

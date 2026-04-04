using App.core.Contracts;
using App.core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class CustomerPicker : Form
    {
        private readonly ICustomerService _customerService;
        private BindingSource _bindingSource;
        public Customer SelectedCustomer { get; private set; }
        public CustomerPicker(ICustomerService service)
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            lsCustomer.DataSource = _bindingSource;
            _customerService = service;
            LoadCustomers(string.Empty);

        }
        private void LoadCustomers(string query)
        {
            var customers = string.IsNullOrWhiteSpace(query) ?
                _customerService.GetAll() : _customerService.Search(query);
            _bindingSource.DataSource = customers;
            lsCustomer.DisplayMember = "Name";
            lsCustomer.ValueMember = "Id";
        }

        private void lblSearchText_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchQuery_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtSearchQuery.Text);
        }

        private void SelectCustomer()
        {
            if (lsCustomer.SelectedItems != null && lsCustomer.SelectedItems is Customer)
            {
                SelectedCustomer = (Customer)lsCustomer.SelectedItem;
                this.DialogResult = DialogResult.OK;
                Close();

            }
            else
            {
                MessageBox.Show("Please Select a customer", "Customer Select", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void lsCustomer_DoubleClick(object sender, EventArgs e)
        {
            SelectCustomer();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}

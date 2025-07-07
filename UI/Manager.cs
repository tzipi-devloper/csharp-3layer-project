using BlApi;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Manager : Form
    {
        static readonly IBI _bl = Factory.Get();
        public Manager()
        {
            InitializeComponent();
            comboboxCategory.DataSource = Enum.GetValues(typeof(Category));
            panelSales.Visible = false;
            panelCustomers.Visible = false;
            panelProducts.Visible = false;
            LoadDataSales();
            LoadDataProduct();
            LoadDataCustomer();
        }
        private void LoadDataCustomer(int? filter = -1)
        {
            List<Customer> customers;

            if (filter == -1)
            {
                customers = _bl.customer.ReadAll();
            }
            else
            {
                customers = _bl.customer.ReadAll(c => c.Id == filter);
            }

            dataGridViewCustomers.DataSource = customers
                .Select(c => new { c.Id, c.CustomerName, c.Phone })
                .ToList();
        }


        private void LoadDataProduct(string filter = "")
        {
            List<Product> products;

            if (filter == null)
            {
                products = _bl.product.ReadAll();
            }
            else
            {
                products = _bl.product.ReadAll(p => p.c.ToString().Contains(filter, StringComparison.OrdinalIgnoreCase));

            }

            dataGridViewProducts.DataSource = products
        .Select(p => new { p.Code, p.ProductName, p.Price, p.c })
        .ToList();
        }

        private void LoadDataSales(int? amountFilter = null)
        {
            var sales = _bl.sale.ReadAll();

            if (amountFilter == null)
            {
                sales = _bl.sale.ReadAll();
            }
            else
            {
                sales = _bl.sale.ReadAll(s => s.CountInSale == amountFilter);

            }
            dataGridViewSale.DataSource = sales
                .Select(s => new
                {
                    s.IdNumber,
                    s.ProductId,
                    s.CountInSale,
                    s.TotalPrice,
                    s.AllCustomer,
                    s.StartSale,
                    s.EndSale

                }).ToList();
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            panelSales.Visible = false;
            panelCustomers.Visible = false;
            panelProducts.Visible = true;
            LoadDataProduct();
        }



        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddProduct addForm = new AddProduct();
            addForm.ShowDialog();
            this.Close();
        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct();
            updateProduct.ShowDialog();
            this.Close();
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.ShowDialog();
            this.Close();
        }

        private void updateCustomer_Click(object sender, EventArgs e)
        {
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.ShowDialog();
            this.Close();
        }

        private void deleteCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.ShowDialog();
            this.Close();
        }

        private void addSaleButton_Click(object sender, EventArgs e)
        {
            //addSale addSale = new addSale();
            //addSale.ShowDialog();
            //this.Close();
            this.Hide();
            addSale addForm = new addSale();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }




        private void buttonProducts_Click_1(object sender, EventArgs e)
        {
            panelSales.Visible = false;
            panelCustomers.Visible = false;
            panelProducts.Visible = true;
        }

        private void buttonCustomers_Click_1(object sender, EventArgs e)
        {
            panelSales.Visible = false;
            panelCustomers.Visible = true;
            panelProducts.Visible = false;
        }

        private void buttonSales_Click_1(object sender, EventArgs e)
        {
            panelSales.Visible = true;
            panelCustomers.Visible = false;
            panelProducts.Visible = false;
        }

        private void updateSaleButton_Click_1(object sender, EventArgs e)
        {
            //UpdateSale updateSale = new UpdateSale();
            //updateSale.ShowDialog();
            //this.Close();
            this.Hide();
            UpdateSale addForm = new UpdateSale();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void deleteSaleButton_Click_1(object sender, EventArgs e)
        {
            //DeleteSale deleteSale = new DeleteSale();
            //deleteSale.ShowDialog();
            //this.Close();
            this.Hide();
            DeleteSale addForm = new DeleteSale();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void deleteCustomer_Click_1(object sender, EventArgs e)
        {
            //DeleteCustomer deleteCustomer = new DeleteCustomer();
            //deleteCustomer.ShowDialog();
            //this.Close();
            this.Hide();
            DeleteCustomer addForm = new DeleteCustomer();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            //DeleteProduct deleteProduct = new DeleteProduct();
            //deleteProduct.ShowDialog();
            //this.Close();
            this.Hide();
            DeleteProduct addForm = new DeleteProduct();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void updateProductButton_Click_1(object sender, EventArgs e)
        {
            //UpdateProduct updateProduct = new UpdateProduct();
            //updateProduct.ShowDialog();
            //this.Close();
            this.Hide();
            UpdateProduct addForm = new UpdateProduct();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            //AddProduct addProduct = new AddProduct();
            //addProduct.ShowDialog();
            //this.Close();
            this.Hide(); 
            AddProduct addForm = new AddProduct();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void updateCustomer_Click_1(object sender, EventArgs e)
        {
            //UpdateCustomer updateCustomer = new UpdateCustomer();
            //updateCustomer.ShowDialog();
            //this.Close();
            this.Hide();
            UpdateCustomer addForm = new UpdateCustomer();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void addCustomer_Click_1(object sender, EventArgs e)
        {
            //AddCustomer addCustomer = new AddCustomer();
            //addCustomer.ShowDialog();
            //this.Close();
            this.Hide();
            AddCustomer addForm = new AddCustomer();
            addForm.FormClosed += (s, args) => this.Show();
            addForm.ShowDialog();
        }

        private void buttonShrechByCategory_Click(object sender, EventArgs e)
        {
            LoadDataProduct(comboboxCategory.Text);
        }



        private void buttonSherchByAmountInSale_Click(object sender, EventArgs e)
        {
            LoadDataSales((int)numericUpDownSherchByAmountInSale.Value);
        }
        private void buttonSherchByNameCustomer_Click(object sender, EventArgs e)
        {
            LoadDataCustomer((int)numericUpDownId.Value);
        }
        private void numericUpDownId_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }


    }
}

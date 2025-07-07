using BIImplementation;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click(object sender, EventArgs e)
        {



        }

        private void numericUpDownCountInStock_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void countInStockLabel_Click(object sender, EventArgs e)
        {
        }

        private void productNameLable_Click(object sender, EventArgs e)
        {
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void addProductButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                string productName = textBoxName.Text;
                double price = (double)numericUpDownPrice.Value;
                Category category = (Category)Enum.Parse(typeof(Category), comboBoxCategory.SelectedItem.ToString());
                int countInStock = (int)numericUpDownCountInStock.Value;
                Product p = new Product(0, productName, category, price, countInStock);
                ProductImplementation p1 = new();
                p1.Create(p);
                MessageBox.Show("המוצר נוסף בהצלחה!");
                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}

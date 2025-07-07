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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }

        private void productNameLable_Click(object sender, EventArgs e)
        {

        }

        private void updateProductButton_Click(object sender, EventArgs e)
        {
            try
            {
                int code = (int)numericUpDownCode.Value;
                string productName = textBoxName.Text;
                double price = (double)numericUpDownPrice.Value;
                Category category = (Category)Enum.Parse(typeof(Category), comboBoxCategory.SelectedItem.ToString());
                int countInStock = (int)numericUpDownCountInStock.Value;
                Product p = new Product(code, productName, category, price, countInStock);
                ProductImplementation p1 = new ProductImplementation();
                p1.Update(p);
                MessageBox.Show("עודכן בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
}

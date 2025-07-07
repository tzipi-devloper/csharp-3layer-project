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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void productNameLable_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownCountInStock_ValueChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDownCustomerCode.Value;
                string name = textBoxCustomerName.Text;
                string address = textBoxAddress.Text;
                string phone = textBoxPhone.Text;
                Customer customer = new Customer(id, name, address, phone);
                CustomerImplementation c1 = new();
                c1.Create(customer);
                MessageBox.Show("נוסף בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void countInStockLabel_Click(object sender, EventArgs e)
        {
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}

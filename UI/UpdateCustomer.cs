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
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void updateCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDownCustomerCode.Value;
                string name = textBoxCustomerName.Text;
                string address = textBoxAddress.Text;
                string phone = textBoxPhone.Text;
                Customer customer = new Customer(id, name, address, phone);
                CustomerImplementation c1 = new();
                c1.Update(customer);
                MessageBox.Show("עודכן בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

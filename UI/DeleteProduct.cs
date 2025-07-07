using BIImplementation;
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
    public partial class DeleteProduct : Form
    {
        public DeleteProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDownCustomerCode.Value;
                ProductImplementation p1 = new();
                p1.Delete(id); MessageBox.Show("נמחק בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void customerIdLable_Click(object sender, EventArgs e)
        {
        }

        private void numericUpDownCustomerCode_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}

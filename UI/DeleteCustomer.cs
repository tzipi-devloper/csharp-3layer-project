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
    public partial class DeleteCustomer : Form
    {
        public DeleteCustomer()
        {
            InitializeComponent();
        }

        private void deleteCustomerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDownCustomerCode.Value;
                CustomerImplementation c1 = new();
                c1.Delete(id); MessageBox.Show("נמחק בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }

}

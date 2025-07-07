using BIImplementation;
using BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class addSale : Form
    {
        public addSale()
        {
            InitializeComponent();
        }

        private void productCodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownProductCode_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelCountInSale_Click(object sender, EventArgs e)
        {

        }

        private void labelStart_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                int ProductId = (int)numericUpDownProductCode.Value;
                int CountInSale = (int)numericUpDownCountInSale.Value;
                int TotalPrice = (int)numericUpDownTotalPrice.Value;
                bool AllCustomer = !checkBoxAllCustomer.Checked;
                DateTime StartSale = dateTimePickerStart.Value;
                DateTime EndSale = dateTimePickerEnd.Value;
                Sale s = new Sale(0, ProductId, CountInSale, TotalPrice, AllCustomer, StartSale, EndSale);
                SaleImplementation s1 = new();
                s1.Create(s);
                MessageBox.Show("נוסף בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void checkBoxAllCustomer_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

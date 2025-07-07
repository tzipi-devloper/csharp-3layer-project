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
    public partial class UpdateSale : Form
    {
        public UpdateSale()
        {
            InitializeComponent();
        }
        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                int Code = (int)numericUpDownSaleCode.Value;
                int ProductId = (int)numericUpDownProductId.Value;
                int CountInSale = (int)numericUpDownCountInSale.Value;
                int TotalPrice = (int)numericUpDownTotalPrice.Value;
                bool AllCustomer = !checkBoxAllCustomer.Checked;
                DateTime StartSale = dateTimePickerStart.Value;
                DateTime EndSale = dateTimePickerEnd.Value;
                Sale s = new Sale(Code, ProductId, CountInSale, TotalPrice, AllCustomer, StartSale, EndSale);
                SaleImplementation s1 = new();
                s1.Update(s);
                MessageBox.Show("עודכן בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }



    }
}

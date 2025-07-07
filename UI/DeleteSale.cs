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
    public partial class DeleteSale : Form
    {
        public DeleteSale()
        {
            InitializeComponent();
        }

        private void labelDaleteSale_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSale_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)numericUpDownSaleId.Value;
                SaleImplementation s1 = new();
                s1.Delete(id);
                MessageBox.Show("נמחק בהצלחה!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}


using BlApi;
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
    public partial class OrderForm : Form
    {
        static readonly IBI _bl = Factory.Get();
        private Order currentOrder = new();
        private List<BO.Product> allProducts;
        private double totalPrice = 0;
        public OrderForm()
        {
            InitializeComponent();
            InitProductComboBox();
            RefreshOrderDisplay();
        }
        private void InitProductComboBox()
        {
            allProducts = _bl.product.ReadAll();
            comboBoxProducts.DataSource = allProducts;
            comboBoxProducts.DisplayMember = "productName";
            comboBoxProducts.ValueMember = "Code";
        }

        private void RefreshOrderDisplay()
        {
            dataGridViewOrder.DataSource = null;
            var display = currentOrder.productInOrder.Select(p => new
            {
                p.productId,
                p.productName,
                p.amountInOrder,
                p.basePrice,
                p.endPrice
            }).ToList();
            dataGridViewOrder.DataSource = display;

            totalPrice = currentOrder.productInOrder.Sum(p => p.endPrice);
            labelTotal.Text = $"סה\"כ לתשלום: {totalPrice:N2} ₪";
        }


        private void buttonFinishOrder_Click_1(object sender, EventArgs e)
        {
            try
            {
                _bl.order.DoOrder(currentOrder);
                MessageBox.Show("ההזמנה בוצעה בהצלחה!");
                currentOrder = new();
                RefreshOrderDisplay();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAddBySelect_Click(object sender, EventArgs e)
        {
            if (comboBoxProducts.SelectedItem is BO.Product product)
            {
                try
                {
                    int count = int.TryParse(textBoxCount.Text, out int q) && q > 0 ? q : 1;
                    int customerId = int.TryParse(textBoxCustomerCode.Text, out int code) ? code : -1;
                    _bl.order.AddProductToOrder(currentOrder, product.Code, count, customerId);
                    RefreshOrderDisplay();
                }
                catch (BLIdNotExistException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("לא נבחר מוצר.");
            }
        }

        private void buttonAddByCode_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxProductCode.Text, out int code))
            {
                try
                {
                    var product = _bl.product.Read(code);
                    int cnt = int.TryParse(textBoxCount.Text, out int q) && q > 0 ? q : 1;
                    int customer = int.TryParse(textBoxCustomerCode.Text, out int custCode) ? custCode : -1;

                    _bl.order.AddProductToOrder(currentOrder, product.Code, cnt, customer);
                    RefreshOrderDisplay();
                }
                catch (BLIdNotExistException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("קוד מוצר לא תקין");
            }
        }

     
    }
}

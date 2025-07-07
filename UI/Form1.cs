using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureBox pictureBox = new PictureBox();
            pictureBox.BackgroundImage = Image.FromFile("shoe_store_07.jpg");
            pictureBox.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SendToBack(); 
            this.Controls.Add(pictureBox);
        }

        private void managerButton_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            manager.ShowDialog();
            this.Close();
        }

        private void cashierButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.ShowDialog();
            this.Close();
        }
    }
}

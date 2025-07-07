using System.Windows.Forms;
namespace UI
{
    partial class OrderForm
    {
        /// <summary>
        /// משתנים דרושים לממשק.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// מתן אפשרות לשחרור משאבים.
        /// </summary>
        /// <param name="disposing">אם מתבצע שחרור משאבים מנוהלים, אז true</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// מתודה לאתחול הממשק.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            labelCustomer = new Label();
            textBoxCustomerCode = new TextBox();
            labelCode = new Label();
            textBoxProductCode = new TextBox();
            labelQuantity = new Label();
            textBoxCount = new TextBox();
            buttonAddByCode = new Button();
            comboBoxProducts = new ComboBox();
            buttonAddBySelect = new Button();
            dataGridViewOrder = new DataGridView();
            labelTotal = new Label();
            buttonFinishOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // labelCustomer
            // 
            labelCustomer.BackColor = Color.Silver;
            labelCustomer.BorderStyle = BorderStyle.Fixed3D;
            labelCustomer.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelCustomer.ForeColor = Color.Red;
            labelCustomer.Location = new Point(50, 40);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(100, 25);
            labelCustomer.TabIndex = 0;
            labelCustomer.Text = "קוד לקוח:";
            // 
            // textBoxCustomerCode
            // 
            textBoxCustomerCode.BackColor = Color.Silver;
            textBoxCustomerCode.BorderStyle = BorderStyle.None;
            textBoxCustomerCode.ForeColor = Color.White;
            textBoxCustomerCode.Location = new Point(160, 38);
            textBoxCustomerCode.Name = "textBoxCustomerCode";
            textBoxCustomerCode.Size = new Size(140, 23);
            textBoxCustomerCode.TabIndex = 1;
            // 
            // labelCode
            // 
            labelCode.BackColor = Color.Silver;
            labelCode.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelCode.ForeColor = Color.Red;
            labelCode.Location = new Point(50, 95);
            labelCode.Name = "labelCode";
            labelCode.Size = new Size(100, 25);
            labelCode.TabIndex = 5;
            labelCode.Text = "קוד מוצר:";
            // 
            // textBoxProductCode
            // 
            textBoxProductCode.BackColor = Color.Silver;
            textBoxProductCode.BorderStyle = BorderStyle.FixedSingle;
            textBoxProductCode.ForeColor = Color.White;
            textBoxProductCode.Location = new Point(160, 93);
            textBoxProductCode.Name = "textBoxProductCode";
            textBoxProductCode.Size = new Size(140, 30);
            textBoxProductCode.TabIndex = 6;
            // 
            // labelQuantity
            // 
            labelQuantity.BackColor = Color.Silver;
            labelQuantity.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantity.ForeColor = Color.Red;
            labelQuantity.Location = new Point(306, 40);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(64, 25);
            labelQuantity.TabIndex = 2;
            labelQuantity.Text = "כמות:";
            // 
            // textBoxCount
            // 
            textBoxCount.BackColor = Color.Silver;
            textBoxCount.BorderStyle = BorderStyle.None;
            textBoxCount.ForeColor = Color.White;
            textBoxCount.Location = new Point(380, 38);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(60, 23);
            textBoxCount.TabIndex = 3;
            // 
            // buttonAddByCode
            // 
            buttonAddByCode.BackColor = Color.Red;
            buttonAddByCode.Cursor = Cursors.Hand;
            buttonAddByCode.FlatAppearance.BorderSize = 0;
            buttonAddByCode.FlatStyle = FlatStyle.Flat;
            buttonAddByCode.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddByCode.ForeColor = Color.White;
            buttonAddByCode.Location = new Point(460, 36);
            buttonAddByCode.Name = "buttonAddByCode";
            buttonAddByCode.Size = new Size(120, 32);
            buttonAddByCode.TabIndex = 4;
            buttonAddByCode.Text = "הוסף לפי קוד";
            buttonAddByCode.UseVisualStyleBackColor = false;
            buttonAddByCode.Click += buttonAddByCode_Click;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.BackColor = Color.Silver;
            comboBoxProducts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProducts.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxProducts.ForeColor = Color.Red;
            comboBoxProducts.Location = new Point(320, 92);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(180, 31);
            comboBoxProducts.TabIndex = 7;
            // 
            // buttonAddBySelect
            // 
            buttonAddBySelect.BackColor = Color.Red;
            buttonAddBySelect.Cursor = Cursors.Hand;
            buttonAddBySelect.FlatAppearance.BorderSize = 0;
            buttonAddBySelect.FlatStyle = FlatStyle.Flat;
            buttonAddBySelect.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddBySelect.ForeColor = Color.White;
            buttonAddBySelect.Location = new Point(520, 91);
            buttonAddBySelect.Name = "buttonAddBySelect";
            buttonAddBySelect.Size = new Size(130, 30);
            buttonAddBySelect.TabIndex = 8;
            buttonAddBySelect.Text = "הוסף מהרשימה";
            buttonAddBySelect.UseVisualStyleBackColor = false;
            buttonAddBySelect.Click += buttonAddBySelect_Click;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrder.BackgroundColor = Color.Silver;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Red;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewOrder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewOrder.ColumnHeadersHeight = 29;
            dataGridViewOrder.EnableHeadersVisualStyles = false;
            dataGridViewOrder.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewOrder.GridColor = Color.White;
            dataGridViewOrder.Location = new Point(50, 140);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.ReadOnly = true;
            dataGridViewOrder.RowHeadersVisible = false;
            dataGridViewOrder.RowHeadersWidth = 51;
            dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrder.Size = new Size(600, 230);
            dataGridViewOrder.TabIndex = 9;
            // 
            // labelTotal
            // 
            labelTotal.BackColor = Color.LightGray;
            labelTotal.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            labelTotal.ForeColor = Color.Red;
            labelTotal.Location = new Point(50, 390);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(350, 30);
            labelTotal.TabIndex = 10;
            labelTotal.Text = "סה\"כ לתשלום: 0 ₪";
            // 
            // buttonFinishOrder
            // 
            buttonFinishOrder.BackColor = Color.Red;
            buttonFinishOrder.Cursor = Cursors.Hand;
            buttonFinishOrder.FlatAppearance.BorderSize = 0;
            buttonFinishOrder.FlatStyle = FlatStyle.Flat;
            buttonFinishOrder.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonFinishOrder.ForeColor = Color.White;
            buttonFinishOrder.Location = new Point(520, 385);
            buttonFinishOrder.Name = "buttonFinishOrder";
            buttonFinishOrder.Size = new Size(130, 35);
            buttonFinishOrder.TabIndex = 11;
            buttonFinishOrder.Text = "סיים הזמנה";
            buttonFinishOrder.UseVisualStyleBackColor = false;
            buttonFinishOrder.Click += buttonFinishOrder_Click_1;
            // 
            // OrderForm
            // 
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 460);
            Controls.Add(labelCustomer);
            Controls.Add(textBoxCustomerCode);
            Controls.Add(labelQuantity);
            Controls.Add(textBoxCount);
            Controls.Add(buttonAddByCode);
            Controls.Add(labelCode);
            Controls.Add(textBoxProductCode);
            Controls.Add(comboBoxProducts);
            Controls.Add(buttonAddBySelect);
            Controls.Add(dataGridViewOrder);
            Controls.Add(labelTotal);
            Controls.Add(buttonFinishOrder);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(0, 106, 78);
            Name = "OrderForm";
            Text = "OrderForm - הזמנה ";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelCustomer;
        private TextBox textBoxCustomerCode;
        private Label labelCode;
        private TextBox textBoxProductCode;
        private Label labelQuantity;
        private TextBox textBoxCount;
        private Button buttonAddByCode;
        private ComboBox comboBoxProducts;
        private Button buttonAddBySelect;
        private DataGridView dataGridViewOrder;
        private Label labelTotal;
        private Button buttonFinishOrder;
    }
}

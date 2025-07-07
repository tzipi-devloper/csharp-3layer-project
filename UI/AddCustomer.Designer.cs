namespace UI
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addCustomerButton = new Button();
            numericUpDownCustomerCode = new NumericUpDown();
            textBoxPhone = new TextBox();
            addressLabel = new Label();
            customerIdLable = new Label();
            textBoxCustomerName = new TextBox();
            textBoxAddress = new TextBox();
            labelPhone = new Label();
            customerNameLable = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerCode).BeginInit();
            SuspendLayout();
            // 
            // addCustomerButton
            // 
            addCustomerButton.Location = new Point(64, 277);
            addCustomerButton.Name = "addCustomerButton";
            addCustomerButton.Size = new Size(94, 29);
            addCustomerButton.TabIndex = 18;
            addCustomerButton.Text = "להוספה";
            addCustomerButton.UseVisualStyleBackColor = true;
            addCustomerButton.Click += addCustomerButton_Click;
            // 
            // numericUpDownCustomerCode
            // 
            numericUpDownCustomerCode.Location = new Point(43, 20);
            numericUpDownCustomerCode.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCustomerCode.Name = "numericUpDownCustomerCode";
            numericUpDownCustomerCode.Size = new Size(150, 27);
            numericUpDownCustomerCode.TabIndex = 15;
            numericUpDownCustomerCode.ValueChanged += numericUpDownPrice_ValueChanged;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(52, 203);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 14;
            textBoxPhone.TextChanged += textBoxName_TextChanged;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(226, 137);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 20);
            addressLabel.TabIndex = 13;
            addressLabel.Text = "כתובת";
            addressLabel.Click += countInStockLabel_Click;
            // 
            // customerIdLable
            // 
            customerIdLable.AutoSize = true;
            customerIdLable.Location = new Point(212, 20);
            customerIdLable.Name = "customerIdLable";
            customerIdLable.Size = new Size(66, 20);
            customerIdLable.TabIndex = 12;
            customerIdLable.Text = "קוד לקוח";
            customerIdLable.Click += productNameLable_Click;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(52, 78);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(125, 27);
            textBoxCustomerName.TabIndex = 19;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(52, 130);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 20;
            textBoxAddress.TextChanged += textBox2_TextChanged;
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(234, 203);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(44, 20);
            labelPhone.TabIndex = 21;
            labelPhone.Text = "טלפון";
            // 
            // customerNameLable
            // 
            customerNameLable.AutoSize = true;
            customerNameLable.Location = new Point(247, 78);
            customerNameLable.Name = "customerNameLable";
            customerNameLable.Size = new Size(31, 20);
            customerNameLable.TabIndex = 22;
            customerNameLable.Text = "שם";
            // 
            // AddCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_072;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(318, 325);
            Controls.Add(customerNameLable);
            Controls.Add(labelPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCustomerName);
            Controls.Add(addCustomerButton);
            Controls.Add(numericUpDownCustomerCode);
            Controls.Add(textBoxPhone);
            Controls.Add(addressLabel);
            Controls.Add(customerIdLable);
            Name = "AddCustomer";
            Text = "AddCustomer";
            Load += AddCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCustomerButton;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericUpDownCountInStock;
        private NumericUpDown numericUpDownCustomerCode;
        private TextBox textBoxPhone;
        private Label addressLabel;
        private Label customerIdLable;
        private TextBox textBoxCustomerName;
        private TextBox textBoxAddress;
        private Label labelPhone;
        private Label customerNameLable;
    }
}
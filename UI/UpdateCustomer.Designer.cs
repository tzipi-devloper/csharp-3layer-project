namespace UI
{
    partial class UpdateCustomer
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
            customerNameLable = new Label();
            labelPhone = new Label();
            textBoxAddress = new TextBox();
            textBoxCustomerName = new TextBox();
            updateCustomerButton = new Button();
            numericUpDownCustomerCode = new NumericUpDown();
            textBoxPhone = new TextBox();
            addressLabel = new Label();
            customerIdLable = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerCode).BeginInit();
            SuspendLayout();
            // 
            // customerNameLable
            // 
            customerNameLable.AutoSize = true;
            customerNameLable.Location = new Point(227, 66);
            customerNameLable.Name = "customerNameLable";
            customerNameLable.Size = new Size(31, 20);
            customerNameLable.TabIndex = 31;
            customerNameLable.Text = "שם";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(214, 191);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(44, 20);
            labelPhone.TabIndex = 30;
            labelPhone.Text = "טלפון";
            // 
            // textBoxAddress
            // 
            textBoxAddress.Location = new Point(32, 118);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(125, 27);
            textBoxAddress.TabIndex = 29;
            // 
            // textBoxCustomerName
            // 
            textBoxCustomerName.Location = new Point(32, 66);
            textBoxCustomerName.Name = "textBoxCustomerName";
            textBoxCustomerName.Size = new Size(125, 27);
            textBoxCustomerName.TabIndex = 28;
            // 
            // updateCustomerButton
            // 
            updateCustomerButton.Location = new Point(44, 265);
            updateCustomerButton.Name = "updateCustomerButton";
            updateCustomerButton.Size = new Size(94, 29);
            updateCustomerButton.TabIndex = 27;
            updateCustomerButton.Text = "עדכן";
            updateCustomerButton.UseVisualStyleBackColor = true;
            updateCustomerButton.Click += updateCustomerButton_Click;
            // 
            // numericUpDownCustomerCode
            // 
            numericUpDownCustomerCode.Location = new Point(23, 8);
            numericUpDownCustomerCode.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCustomerCode.Name = "numericUpDownCustomerCode";
            numericUpDownCustomerCode.Size = new Size(150, 27);
            numericUpDownCustomerCode.TabIndex = 26;
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(32, 191);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(125, 27);
            textBoxPhone.TabIndex = 25;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(206, 125);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 20);
            addressLabel.TabIndex = 24;
            addressLabel.Text = "כתובת";
            // 
            // customerIdLable
            // 
            customerIdLable.AutoSize = true;
            customerIdLable.Location = new Point(192, 8);
            customerIdLable.Name = "customerIdLable";
            customerIdLable.Size = new Size(66, 20);
            customerIdLable.TabIndex = 23;
            customerIdLable.Text = "קוד לקוח";
            // 
            // UpdateCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_076;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(263, 304);
            Controls.Add(customerNameLable);
            Controls.Add(labelPhone);
            Controls.Add(textBoxAddress);
            Controls.Add(textBoxCustomerName);
            Controls.Add(updateCustomerButton);
            Controls.Add(numericUpDownCustomerCode);
            Controls.Add(textBoxPhone);
            Controls.Add(addressLabel);
            Controls.Add(customerIdLable);
            Name = "UpdateCustomer";
            Text = "UpdateCustomer";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerNameLable;
        private Label labelPhone;
        private TextBox textBoxAddress;
        private TextBox textBoxCustomerName;
        private Button updateCustomerButton;
        private NumericUpDown numericUpDownCustomerCode;
        private TextBox textBoxPhone;
        private Label addressLabel;
        private Label customerIdLable;
    }
}
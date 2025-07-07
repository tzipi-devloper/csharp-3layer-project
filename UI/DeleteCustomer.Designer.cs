namespace UI
{
    partial class DeleteCustomer
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
            deleteCustomerButton = new Button();
            numericUpDownCustomerCode = new NumericUpDown();
            customerIdLable = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerCode).BeginInit();
            SuspendLayout();
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.Location = new Point(152, 62);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(94, 29);
            deleteCustomerButton.TabIndex = 36;
            deleteCustomerButton.Text = "מחק";
            deleteCustomerButton.UseVisualStyleBackColor = true;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // numericUpDownCustomerCode
            // 
            numericUpDownCustomerCode.Location = new Point(52, 20);
            numericUpDownCustomerCode.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownCustomerCode.Name = "numericUpDownCustomerCode";
            numericUpDownCustomerCode.Size = new Size(150, 27);
            numericUpDownCustomerCode.TabIndex = 35;
            // 
            // customerIdLable
            // 
            customerIdLable.AutoSize = true;
            customerIdLable.Location = new Point(208, 22);
            customerIdLable.Name = "customerIdLable";
            customerIdLable.Size = new Size(121, 20);
            customerIdLable.TabIndex = 32;
            customerIdLable.Text = "תעודת זהות לקוח";
            // 
            // DeleteCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_073;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(344, 114);
            Controls.Add(deleteCustomerButton);
            Controls.Add(numericUpDownCustomerCode);
            Controls.Add(customerIdLable);
            Name = "DeleteCustomer";
            Text = "DeleteCustomer";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCustomerCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button deleteCustomerButton;
        private NumericUpDown numericUpDownCustomerCode;
        private Label customerIdLable;
    }
}
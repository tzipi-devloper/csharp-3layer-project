namespace UI
{
    partial class UpdateSale
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
            checkBoxAllCustomer = new CheckBox();
            ButtonUpdateSale = new Button();
            numericUpDownTotalPrice = new NumericUpDown();
            labelTotalPrice = new Label();
            labelEnd = new Label();
            labelStart = new Label();
            dateTimePickerEnd = new DateTimePicker();
            dateTimePickerStart = new DateTimePicker();
            labelCountInSale = new Label();
            numericUpDownCountInSale = new NumericUpDown();
            numericUpDownSaleCode = new NumericUpDown();
            productCodeLabel = new Label();
            numericUpDownProductId = new NumericUpDown();
            labelProductId = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).BeginInit();
            SuspendLayout();
            // 
            // checkBoxAllCustomer
            // 
            checkBoxAllCustomer.AutoSize = true;
            checkBoxAllCustomer.Location = new Point(126, 294);
            checkBoxAllCustomer.Name = "checkBoxAllCustomer";
            checkBoxAllCustomer.Size = new Size(149, 24);
            checkBoxAllCustomer.TabIndex = 26;
            checkBoxAllCustomer.Text = "לחברי מועדון בלבד";
            checkBoxAllCustomer.UseVisualStyleBackColor = true;
            // 
            // ButtonUpdateSale
            // 
            ButtonUpdateSale.Location = new Point(104, 334);
            ButtonUpdateSale.Name = "ButtonUpdateSale";
            ButtonUpdateSale.Size = new Size(171, 66);
            ButtonUpdateSale.TabIndex = 25;
            ButtonUpdateSale.Text = "לעדכון המבצע";
            ButtonUpdateSale.UseVisualStyleBackColor = true;
            ButtonUpdateSale.Click += buttonAddSale_Click;
            // 
            // numericUpDownTotalPrice
            // 
            numericUpDownTotalPrice.Location = new Point(21, 145);
            numericUpDownTotalPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownTotalPrice.Minimum = new decimal(new int[] { 1000, 0, 0, 196608 });
            numericUpDownTotalPrice.Name = "numericUpDownTotalPrice";
            numericUpDownTotalPrice.Size = new Size(150, 27);
            numericUpDownTotalPrice.TabIndex = 24;
            numericUpDownTotalPrice.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(225, 152);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(72, 20);
            labelTotalPrice.TabIndex = 23;
            labelTotalPrice.Text = "מחיר סופי";
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.Location = new Point(221, 244);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(82, 20);
            labelEnd.TabIndex = 22;
            labelEnd.Text = "תאריך סיום";
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.Location = new Point(205, 197);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(103, 20);
            labelStart.TabIndex = 21;
            labelStart.Text = "תאריך התחלה";
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.Location = new Point(41, 237);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(130, 27);
            dateTimePickerEnd.TabIndex = 20;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.Location = new Point(41, 192);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(130, 27);
            dateTimePickerStart.TabIndex = 19;
            // 
            // labelCountInSale
            // 
            labelCountInSale.AutoSize = true;
            labelCountInSale.Location = new Point(205, 110);
            labelCountInSale.Name = "labelCountInSale";
            labelCountInSale.Size = new Size(92, 20);
            labelCountInSale.TabIndex = 18;
            labelCountInSale.Text = "כמות במבצע";
            // 
            // numericUpDownCountInSale
            // 
            numericUpDownCountInSale.Location = new Point(36, 103);
            numericUpDownCountInSale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCountInSale.Name = "numericUpDownCountInSale";
            numericUpDownCountInSale.Size = new Size(135, 27);
            numericUpDownCountInSale.TabIndex = 17;
            numericUpDownCountInSale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDownSaleCode
            // 
            numericUpDownSaleCode.Location = new Point(27, 21);
            numericUpDownSaleCode.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownSaleCode.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownSaleCode.Name = "numericUpDownSaleCode";
            numericUpDownSaleCode.Size = new Size(144, 27);
            numericUpDownSaleCode.TabIndex = 16;
            numericUpDownSaleCode.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new Point(232, 28);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new Size(71, 20);
            productCodeLabel.TabIndex = 15;
            productCodeLabel.Text = "קוד מבצע";
            // 
            // numericUpDownProductId
            // 
            numericUpDownProductId.Location = new Point(21, 64);
            numericUpDownProductId.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownProductId.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownProductId.Name = "numericUpDownProductId";
            numericUpDownProductId.Size = new Size(150, 27);
            numericUpDownProductId.TabIndex = 27;
            numericUpDownProductId.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // labelProductId
            // 
            labelProductId.AutoSize = true;
            labelProductId.Location = new Point(232, 71);
            labelProductId.Name = "labelProductId";
            labelProductId.Size = new Size(65, 20);
            labelProductId.TabIndex = 28;
            labelProductId.Text = "קוד מוצר";
            // 
            // UpdateSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_078;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(337, 416);
            Controls.Add(labelProductId);
            Controls.Add(numericUpDownProductId);
            Controls.Add(checkBoxAllCustomer);
            Controls.Add(ButtonUpdateSale);
            Controls.Add(numericUpDownTotalPrice);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelCountInSale);
            Controls.Add(numericUpDownCountInSale);
            Controls.Add(numericUpDownSaleCode);
            Controls.Add(productCodeLabel);
            Name = "UpdateSale";
            Text = "UpdateSale";
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxAllCustomer;
        private Button ButtonUpdateSale;
        protected NumericUpDown numericUpDownTotalPrice;
        private Label labelTotalPrice;
        private Label labelEnd;
        private Label labelStart;
        private DateTimePicker dateTimePickerEnd;
        private DateTimePicker dateTimePickerStart;
        private Label labelCountInSale;
        private NumericUpDown numericUpDownCountInSale;
        private NumericUpDown numericUpDownSaleCode;
        private Label productCodeLabel;
        private NumericUpDown numericUpDownProductId;
        private Label labelProductId;
    }
}
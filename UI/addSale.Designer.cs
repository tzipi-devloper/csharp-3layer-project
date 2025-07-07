namespace UI
{
    partial class addSale
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
            productCodeLabel = new Label();
            numericUpDownProductCode = new NumericUpDown();
            numericUpDownCountInSale = new NumericUpDown();
            labelCountInSale = new Label();
            dateTimePickerStart = new DateTimePicker();
            dateTimePickerEnd = new DateTimePicker();
            labelStart = new Label();
            labelEnd = new Label();
            labelTotalPrice = new Label();
            numericUpDownTotalPrice = new NumericUpDown();
            buttonAddSale = new Button();
            checkBoxAllCustomer = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalPrice).BeginInit();
            SuspendLayout();
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.ForeColor = Color.Red;
            productCodeLabel.Location = new Point(517, 59);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new Size(65, 20);
            productCodeLabel.TabIndex = 1;
            productCodeLabel.Text = "קוד מוצר";
            productCodeLabel.Click += productCodeLabel_Click;
            // 
            // numericUpDownProductCode
            // 
            numericUpDownProductCode.BackColor = Color.FromArgb(224, 224, 224);
            numericUpDownProductCode.ForeColor = Color.Red;
            numericUpDownProductCode.Location = new Point(282, 54);
            numericUpDownProductCode.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numericUpDownProductCode.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownProductCode.Name = "numericUpDownProductCode";
            numericUpDownProductCode.Size = new Size(144, 27);
            numericUpDownProductCode.TabIndex = 2;
            numericUpDownProductCode.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownProductCode.ValueChanged += numericUpDownProductCode_ValueChanged;
            // 
            // numericUpDownCountInSale
            // 
            numericUpDownCountInSale.BackColor = Color.FromArgb(224, 224, 224);
            numericUpDownCountInSale.ForeColor = Color.Red;
            numericUpDownCountInSale.Location = new Point(291, 108);
            numericUpDownCountInSale.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCountInSale.Name = "numericUpDownCountInSale";
            numericUpDownCountInSale.Size = new Size(135, 27);
            numericUpDownCountInSale.TabIndex = 3;
            numericUpDownCountInSale.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelCountInSale
            // 
            labelCountInSale.AutoSize = true;
            labelCountInSale.ForeColor = Color.Red;
            labelCountInSale.Location = new Point(492, 110);
            labelCountInSale.Name = "labelCountInSale";
            labelCountInSale.Size = new Size(92, 20);
            labelCountInSale.TabIndex = 4;
            labelCountInSale.Text = "כמות במבצע";
            labelCountInSale.Click += labelCountInSale_Click;
            // 
            // dateTimePickerStart
            // 
            dateTimePickerStart.CalendarForeColor = Color.Red;
            dateTimePickerStart.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dateTimePickerStart.CalendarTitleBackColor = Color.Red;
            dateTimePickerStart.Location = new Point(321, 222);
            dateTimePickerStart.Name = "dateTimePickerStart";
            dateTimePickerStart.Size = new Size(130, 27);
            dateTimePickerStart.TabIndex = 7;
            // 
            // dateTimePickerEnd
            // 
            dateTimePickerEnd.CalendarForeColor = Color.Red;
            dateTimePickerEnd.CalendarMonthBackground = Color.Silver;
            dateTimePickerEnd.CalendarTitleBackColor = Color.Red;
            dateTimePickerEnd.CalendarTitleForeColor = Color.Red;
            dateTimePickerEnd.Location = new Point(321, 270);
            dateTimePickerEnd.Name = "dateTimePickerEnd";
            dateTimePickerEnd.Size = new Size(130, 27);
            dateTimePickerEnd.TabIndex = 8;
            // 
            // labelStart
            // 
            labelStart.AutoSize = true;
            labelStart.ForeColor = Color.Red;
            labelStart.Location = new Point(499, 225);
            labelStart.Name = "labelStart";
            labelStart.Size = new Size(103, 20);
            labelStart.TabIndex = 9;
            labelStart.Text = "תאריך התחלה";
            labelStart.Click += labelStart_Click;
            // 
            // labelEnd
            // 
            labelEnd.AutoSize = true;
            labelEnd.ForeColor = Color.Red;
            labelEnd.Location = new Point(503, 270);
            labelEnd.Name = "labelEnd";
            labelEnd.Size = new Size(82, 20);
            labelEnd.TabIndex = 10;
            labelEnd.Text = "תאריך סיום";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.ForeColor = Color.Red;
            labelTotalPrice.Location = new Point(492, 169);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(72, 20);
            labelTotalPrice.TabIndex = 11;
            labelTotalPrice.Text = "מחיר סופי";
            // 
            // numericUpDownTotalPrice
            // 
            numericUpDownTotalPrice.BackColor = Color.FromArgb(224, 224, 224);
            numericUpDownTotalPrice.ForeColor = Color.Red;
            numericUpDownTotalPrice.Location = new Point(288, 169);
            numericUpDownTotalPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownTotalPrice.Minimum = new decimal(new int[] { 1000, 0, 0, 196608 });
            numericUpDownTotalPrice.Name = "numericUpDownTotalPrice";
            numericUpDownTotalPrice.Size = new Size(150, 27);
            numericUpDownTotalPrice.TabIndex = 12;
            numericUpDownTotalPrice.Value = new decimal(new int[] { 1000, 0, 0, 196608 });
            // 
            // buttonAddSale
            // 
            buttonAddSale.BackColor = Color.FromArgb(224, 224, 224);
            buttonAddSale.ForeColor = Color.Red;
            buttonAddSale.Location = new Point(381, 357);
            buttonAddSale.Name = "buttonAddSale";
            buttonAddSale.Size = new Size(171, 66);
            buttonAddSale.TabIndex = 13;
            buttonAddSale.Text = "להוספת המבצע";
            buttonAddSale.UseVisualStyleBackColor = false;
            buttonAddSale.Click += buttonAddSale_Click;
            // 
            // checkBoxAllCustomer
            // 
            checkBoxAllCustomer.AutoSize = true;
            checkBoxAllCustomer.ForeColor = Color.Red;
            checkBoxAllCustomer.Location = new Point(364, 330);
            checkBoxAllCustomer.Name = "checkBoxAllCustomer";
            checkBoxAllCustomer.Size = new Size(149, 24);
            checkBoxAllCustomer.TabIndex = 14;
            checkBoxAllCustomer.Text = "לחברי מועדון בלבד";
            checkBoxAllCustomer.UseVisualStyleBackColor = true;
            checkBoxAllCustomer.CheckedChanged += checkBoxAllCustomer_CheckedChanged;
            // 
            // addSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_07;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBoxAllCustomer);
            Controls.Add(buttonAddSale);
            Controls.Add(numericUpDownTotalPrice);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelEnd);
            Controls.Add(labelStart);
            Controls.Add(dateTimePickerEnd);
            Controls.Add(dateTimePickerStart);
            Controls.Add(labelCountInSale);
            Controls.Add(numericUpDownCountInSale);
            Controls.Add(numericUpDownProductCode);
            Controls.Add(productCodeLabel);
            Name = "addSale";
            Text = "addSale";
            ((System.ComponentModel.ISupportInitialize)numericUpDownProductCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTotalPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label productCodeLabel;
        private NumericUpDown numericUpDownProductCode;
        private NumericUpDown numericUpDownCountInSale;
        private Label labelCountInSale;
        private DateTimePicker dateTimePickerStart;
        private DateTimePicker dateTimePickerEnd;
        private Label labelStart;
        private Label labelEnd;
        private Label labelTotalPrice;
        protected NumericUpDown numericUpDownTotalPrice;
        private Button buttonAddSale;
        private CheckBox checkBoxAllCustomer;
    }
}
namespace UI
{
    partial class UpdateProduct
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
            numericUpDownCode = new NumericUpDown();
            updateProductButton = new Button();
            comboBoxCategory = new ComboBox();
            numericUpDownCountInStock = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            textBoxName = new TextBox();
            priceLable = new Label();
            categoryLabel = new Label();
            countInStockLabel = new Label();
            productNameLable = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // productCodeLabel
            // 
            productCodeLabel.AutoSize = true;
            productCodeLabel.Location = new Point(184, 17);
            productCodeLabel.Name = "productCodeLabel";
            productCodeLabel.Size = new Size(103, 20);
            productCodeLabel.TabIndex = 0;
            productCodeLabel.Text = "הכנס קוד מוצר";
            // 
            // numericUpDownCode
            // 
            numericUpDownCode.Location = new Point(12, 10);
            numericUpDownCode.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCode.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownCode.Name = "numericUpDownCode";
            numericUpDownCode.Size = new Size(150, 27);
            numericUpDownCode.TabIndex = 1;
            numericUpDownCode.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // updateProductButton
            // 
            updateProductButton.Location = new Point(43, 319);
            updateProductButton.Name = "updateProductButton";
            updateProductButton.Size = new Size(94, 29);
            updateProductButton.TabIndex = 20;
            updateProductButton.Text = "עדכן";
            updateProductButton.UseVisualStyleBackColor = true;
            updateProductButton.Click += updateProductButton_Click;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Puma", "Adidas", "NewBalance", "Nike" });
            comboBoxCategory.Location = new Point(12, 202);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 19;
            // 
            // numericUpDownCountInStock
            // 
            numericUpDownCountInStock.Location = new Point(12, 272);
            numericUpDownCountInStock.Name = "numericUpDownCountInStock";
            numericUpDownCountInStock.Size = new Size(150, 27);
            numericUpDownCountInStock.TabIndex = 18;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(12, 134);
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(150, 27);
            numericUpDownPrice.TabIndex = 17;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 73);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 16;
            // 
            // priceLable
            // 
            priceLable.AutoSize = true;
            priceLable.Location = new Point(246, 136);
            priceLable.Name = "priceLable";
            priceLable.Size = new Size(41, 20);
            priceLable.TabIndex = 15;
            priceLable.Text = "מחיר";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(221, 202);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(66, 20);
            categoryLabel.TabIndex = 14;
            categoryLabel.Text = "קטגוריה ";
            // 
            // countInStockLabel
            // 
            countInStockLabel.AutoSize = true;
            countInStockLabel.Location = new Point(200, 274);
            countInStockLabel.Name = "countInStockLabel";
            countInStockLabel.Size = new Size(87, 20);
            countInStockLabel.TabIndex = 13;
            countInStockLabel.Text = "כמות במלאי";
            // 
            // productNameLable
            // 
            productNameLable.AutoSize = true;
            productNameLable.Location = new Point(207, 73);
            productNameLable.Name = "productNameLable";
            productNameLable.Size = new Size(80, 20);
            productNameLable.TabIndex = 12;
            productNameLable.Text = "שם המוצר ";
            productNameLable.Click += productNameLable_Click;
            // 
            // UpdateProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_077;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(294, 362);
            Controls.Add(updateProductButton);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericUpDownCountInStock);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxName);
            Controls.Add(priceLable);
            Controls.Add(categoryLabel);
            Controls.Add(countInStockLabel);
            Controls.Add(productNameLable);
            Controls.Add(numericUpDownCode);
            Controls.Add(productCodeLabel);
            Name = "UpdateProduct";
            Text = "UpdateProduct";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productCodeLabel;
        private NumericUpDown numericUpDownCode;
        private Button updateProductButton;
        private ComboBox comboBoxCategory;
        private NumericUpDown numericUpDownCountInStock;
        private NumericUpDown numericUpDownPrice;
        private TextBox textBoxName;
        private Label priceLable;
        private Label categoryLabel;
        private Label countInStockLabel;
        private Label productNameLable;
    }
}
namespace UI
{
    partial class AddProduct
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
            addProductButton = new Button();
            comboBoxCategory = new ComboBox();
            numericUpDownCountInStock = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            textBoxName = new TextBox();
            priceLable = new Label();
            categoryLabel = new Label();
            countInStockLabel = new Label();
            productNameLable = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(111, 256);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(94, 29);
            addProductButton.TabIndex = 20;
            addProductButton.Text = "להוספה";
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click_1;
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Items.AddRange(new object[] { "Puma", "Adidas", "NewBalance", "Nike" });
            comboBoxCategory.Location = new Point(80, 145);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(151, 28);
            comboBoxCategory.TabIndex = 19;
            // 
            // numericUpDownCountInStock
            // 
            numericUpDownCountInStock.Location = new Point(80, 189);
            numericUpDownCountInStock.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownCountInStock.Name = "numericUpDownCountInStock";
            numericUpDownCountInStock.Size = new Size(150, 27);
            numericUpDownCountInStock.TabIndex = 18;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Location = new Point(80, 96);
            numericUpDownPrice.Maximum = new decimal(new int[] { 400000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(150, 27);
            numericUpDownPrice.TabIndex = 17;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(80, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 16;
            // 
            // priceLable
            // 
            priceLable.AutoSize = true;
            priceLable.Location = new Point(288, 99);
            priceLable.Name = "priceLable";
            priceLable.Size = new Size(41, 20);
            priceLable.TabIndex = 15;
            priceLable.Text = "מחיר";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new Point(270, 145);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(66, 20);
            categoryLabel.TabIndex = 14;
            categoryLabel.Text = "קטגוריה ";
            // 
            // countInStockLabel
            // 
            countInStockLabel.AutoSize = true;
            countInStockLabel.Location = new Point(249, 191);
            countInStockLabel.Name = "countInStockLabel";
            countInStockLabel.Size = new Size(87, 20);
            countInStockLabel.TabIndex = 13;
            countInStockLabel.Text = "כמות במלאי";
            // 
            // productNameLable
            // 
            productNameLable.AutoSize = true;
            productNameLable.Location = new Point(249, 45);
            productNameLable.Name = "productNameLable";
            productNameLable.Size = new Size(80, 20);
            productNameLable.TabIndex = 12;
            productNameLable.Text = "שם המוצר ";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_071;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(368, 304);
            Controls.Add(addProductButton);
            Controls.Add(comboBoxCategory);
            Controls.Add(numericUpDownCountInStock);
            Controls.Add(numericUpDownPrice);
            Controls.Add(textBoxName);
            Controls.Add(priceLable);
            Controls.Add(categoryLabel);
            Controls.Add(countInStockLabel);
            Controls.Add(productNameLable);
            Name = "AddProduct";
            Text = "AddProduct";
            Load += AddProduct_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountInStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addProductButton;
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
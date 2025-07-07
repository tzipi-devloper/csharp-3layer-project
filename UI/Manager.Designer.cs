using System.Runtime.InteropServices;
namespace UI
{
    partial class Manager
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
        /// 
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            addProductButton = new Button();
            updateProductButton = new Button();
            deleteProductButton = new Button();
            deleteCustomer = new Button();
            updateCustomer = new Button();
            addCustomer = new Button();
            deleteSaleButton = new Button();
            updateSaleButton = new Button();
            addSaleButton = new Button();
            buttonProducts = new Button();
            buttonCustomers = new Button();
            buttonSales = new Button();
            panelProducts = new Panel();
            comboboxCategory = new ComboBox();
            buttonShrechByCategory = new Button();
            dataGridViewProducts = new DataGridView();
            panelCustomers = new Panel();
            numericUpDownId = new NumericUpDown();
            buttonSherchByCusId = new Button();
            dataGridViewCustomers = new DataGridView();
            dataGridViewSales = new DataGridView();
            panelSales = new Panel();
            numericUpDownSherchByAmountInSale = new NumericUpDown();
            buttonSherchByAmountInSale = new Button();
            dataGridViewSale = new DataGridView();
            panelProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).BeginInit();
            panelCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            panelSales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSherchByAmountInSale).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).BeginInit();
            SuspendLayout();
            // 
            // addProductButton
            // 
            addProductButton.Location = new Point(329, 0);
            addProductButton.Name = "addProductButton";
            addProductButton.Size = new Size(111, 29);
            addProductButton.TabIndex = 0;
            addProductButton.Text = "הוספת מוצר";
            addProductButton.TextImageRelation = TextImageRelation.ImageAboveText;
            addProductButton.UseVisualStyleBackColor = true;
            addProductButton.Click += addProductButton_Click_1;
            // 
            // updateProductButton
            // 
            updateProductButton.Location = new Point(199, 0);
            updateProductButton.Name = "updateProductButton";
            updateProductButton.Size = new Size(94, 29);
            updateProductButton.TabIndex = 1;
            updateProductButton.Text = "עדכון מוצר";
            updateProductButton.TextImageRelation = TextImageRelation.ImageAboveText;
            updateProductButton.UseVisualStyleBackColor = true;
            updateProductButton.Click += updateProductButton_Click_1;
            // 
            // deleteProductButton
            // 
            deleteProductButton.Location = new Point(38, 3);
            deleteProductButton.Name = "deleteProductButton";
            deleteProductButton.Size = new Size(111, 29);
            deleteProductButton.TabIndex = 2;
            deleteProductButton.Text = "מחיקת מוצר";
            deleteProductButton.TextImageRelation = TextImageRelation.ImageAboveText;
            deleteProductButton.UseVisualStyleBackColor = true;
            deleteProductButton.Click += deleteProductButton_Click;
            // 
            // deleteCustomer
            // 
            deleteCustomer.Location = new Point(23, 3);
            deleteCustomer.Name = "deleteCustomer";
            deleteCustomer.Size = new Size(111, 29);
            deleteCustomer.TabIndex = 3;
            deleteCustomer.Text = "מחיקת לקוח";
            deleteCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            deleteCustomer.UseVisualStyleBackColor = true;
            deleteCustomer.Click += deleteCustomer_Click_1;
            // 
            // updateCustomer
            // 
            updateCustomer.Location = new Point(159, 3);
            updateCustomer.Name = "updateCustomer";
            updateCustomer.Size = new Size(111, 29);
            updateCustomer.TabIndex = 4;
            updateCustomer.Text = "עדכון לקוח";
            updateCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            updateCustomer.UseVisualStyleBackColor = true;
            updateCustomer.Click += updateCustomer_Click_1;
            // 
            // addCustomer
            // 
            addCustomer.Location = new Point(316, 3);
            addCustomer.Name = "addCustomer";
            addCustomer.Size = new Size(111, 29);
            addCustomer.TabIndex = 5;
            addCustomer.Text = "הוספת לקוח";
            addCustomer.TextImageRelation = TextImageRelation.ImageAboveText;
            addCustomer.UseVisualStyleBackColor = true;
            addCustomer.Click += addCustomer_Click_1;
            // 
            // deleteSaleButton
            // 
            deleteSaleButton.Location = new Point(57, 3);
            deleteSaleButton.Name = "deleteSaleButton";
            deleteSaleButton.Size = new Size(111, 29);
            deleteSaleButton.TabIndex = 8;
            deleteSaleButton.Text = "מחיקת מבצע";
            deleteSaleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            deleteSaleButton.UseVisualStyleBackColor = true;
            deleteSaleButton.Click += deleteSaleButton_Click_1;
            // 
            // updateSaleButton
            // 
            updateSaleButton.Location = new Point(192, 3);
            updateSaleButton.Name = "updateSaleButton";
            updateSaleButton.Size = new Size(94, 29);
            updateSaleButton.TabIndex = 7;
            updateSaleButton.Text = "עדכון מבצע";
            updateSaleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            updateSaleButton.UseVisualStyleBackColor = true;
            updateSaleButton.Click += updateSaleButton_Click_1;
            // 
            // addSaleButton
            // 
            addSaleButton.Location = new Point(307, 0);
            addSaleButton.Name = "addSaleButton";
            addSaleButton.Size = new Size(111, 29);
            addSaleButton.TabIndex = 6;
            addSaleButton.Text = "הוספת מבצע";
            addSaleButton.TextImageRelation = TextImageRelation.ImageAboveText;
            addSaleButton.UseVisualStyleBackColor = true;
            addSaleButton.Click += addSaleButton_Click;
            // 
            // buttonProducts
            // 
            buttonProducts.Location = new Point(694, 50);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Size = new Size(94, 29);
            buttonProducts.TabIndex = 10;
            buttonProducts.Text = "מוצרים";
            buttonProducts.UseVisualStyleBackColor = true;
            buttonProducts.Click += buttonProducts_Click_1;
            // 
            // buttonCustomers
            // 
            buttonCustomers.Location = new Point(694, 226);
            buttonCustomers.Name = "buttonCustomers";
            buttonCustomers.Size = new Size(94, 29);
            buttonCustomers.TabIndex = 11;
            buttonCustomers.Text = "לקוחות";
            buttonCustomers.UseVisualStyleBackColor = true;
            buttonCustomers.Click += buttonCustomers_Click_1;
            // 
            // buttonSales
            // 
            buttonSales.Location = new Point(694, 409);
            buttonSales.Name = "buttonSales";
            buttonSales.Size = new Size(94, 29);
            buttonSales.TabIndex = 12;
            buttonSales.Text = "מבצעים";
            buttonSales.UseVisualStyleBackColor = true;
            buttonSales.Click += buttonSales_Click_1;
            // 
            // panelProducts
            // 
            panelProducts.Controls.Add(comboboxCategory);
            panelProducts.Controls.Add(buttonShrechByCategory);
            panelProducts.Controls.Add(dataGridViewProducts);
            panelProducts.Controls.Add(updateProductButton);
            panelProducts.Controls.Add(addProductButton);
            panelProducts.Controls.Add(deleteProductButton);
            panelProducts.Location = new Point(46, 47);
            panelProducts.Name = "panelProducts";
            panelProducts.Size = new Size(623, 413);
            panelProducts.TabIndex = 13;
            // 
            // comboboxCategory
            // 
            comboboxCategory.FormattingEnabled = true;
            comboboxCategory.Location = new Point(103, 201);
            comboboxCategory.Name = "comboboxCategory";
            comboboxCategory.Size = new Size(151, 28);
            comboboxCategory.TabIndex = 12;
            // 
            // buttonShrechByCategory
            // 
            buttonShrechByCategory.Location = new Point(302, 201);
            buttonShrechByCategory.Name = "buttonShrechByCategory";
            buttonShrechByCategory.Size = new Size(150, 29);
            buttonShrechByCategory.TabIndex = 13;
            buttonShrechByCategory.Text = "לסינון לפי קטגוריה";
            buttonShrechByCategory.UseVisualStyleBackColor = true;
            buttonShrechByCategory.Click += buttonShrechByCategory_Click;
            // 
            // dataGridViewProducts
            // 
            dataGridViewProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProducts.Location = new Point(0, 47);
            dataGridViewProducts.Name = "dataGridViewProducts";
            dataGridViewProducts.RowHeadersWidth = 51;
            dataGridViewProducts.RowTemplate.Height = 29;
            dataGridViewProducts.Size = new Size(821, 137);
            dataGridViewProducts.TabIndex = 10;
            // 
            // panelCustomers
            // 
            panelCustomers.BackColor = Color.White;
            panelCustomers.Controls.Add(numericUpDownId);
            panelCustomers.Controls.Add(buttonSherchByCusId);
            panelCustomers.Controls.Add(dataGridViewCustomers);
            panelCustomers.Controls.Add(dataGridViewSales);
            panelCustomers.Controls.Add(addCustomer);
            panelCustomers.Controls.Add(updateCustomer);
            panelCustomers.Controls.Add(deleteCustomer);
            panelCustomers.Location = new Point(46, 47);
            panelCustomers.Name = "panelCustomers";
            panelCustomers.Size = new Size(623, 413);
            panelCustomers.TabIndex = 14;
            // 
            // numericUpDownId
            // 
            numericUpDownId.Location = new Point(33, 301);
            numericUpDownId.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numericUpDownId.Name = "numericUpDownId";
            numericUpDownId.Size = new Size(150, 27);
            numericUpDownId.TabIndex = 12;
            numericUpDownId.ValueChanged += numericUpDownId_ValueChanged;
            // 
            // buttonSherchByCusId
            // 
            buttonSherchByCusId.Location = new Point(54, 253);
            buttonSherchByCusId.Name = "buttonSherchByCusId";
            buttonSherchByCusId.Size = new Size(94, 29);
            buttonSherchByCusId.TabIndex = 11;
            buttonSherchByCusId.Text = "סנן לפי ת.ז";
            buttonSherchByCusId.UseVisualStyleBackColor = true;
            buttonSherchByCusId.Click += buttonSherchByNameCustomer_Click;
            // 
            // dataGridViewCustomers
            // 
            dataGridViewCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomers.Location = new Point(33, 38);
            dataGridViewCustomers.Name = "dataGridViewCustomers";
            dataGridViewCustomers.RowHeadersWidth = 51;
            dataGridViewCustomers.RowTemplate.Height = 29;
            dataGridViewCustomers.Size = new Size(534, 188);
            dataGridViewCustomers.TabIndex = 10;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Location = new Point(-229, 27);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.RowHeadersWidth = 51;
            dataGridViewSales.RowTemplate.Height = 29;
            dataGridViewSales.Size = new Size(205, 295);
            dataGridViewSales.TabIndex = 9;
            // 
            // panelSales
            // 
            panelSales.Controls.Add(numericUpDownSherchByAmountInSale);
            panelSales.Controls.Add(buttonSherchByAmountInSale);
            panelSales.Controls.Add(dataGridViewSale);
            panelSales.Controls.Add(addSaleButton);
            panelSales.Controls.Add(updateSaleButton);
            panelSales.Controls.Add(deleteSaleButton);
            panelSales.Location = new Point(46, 47);
            panelSales.Name = "panelSales";
            panelSales.Size = new Size(623, 413);
            panelSales.TabIndex = 15;
            // 
            // numericUpDownSherchByAmountInSale
            // 
            numericUpDownSherchByAmountInSale.Location = new Point(316, 304);
            numericUpDownSherchByAmountInSale.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDownSherchByAmountInSale.Name = "numericUpDownSherchByAmountInSale";
            numericUpDownSherchByAmountInSale.Size = new Size(150, 27);
            numericUpDownSherchByAmountInSale.TabIndex = 13;
            // 
            // buttonSherchByAmountInSale
            // 
            buttonSherchByAmountInSale.Location = new Point(37, 302);
            buttonSherchByAmountInSale.Name = "buttonSherchByAmountInSale";
            buttonSherchByAmountInSale.Size = new Size(258, 29);
            buttonSherchByAmountInSale.TabIndex = 12;
            buttonSherchByAmountInSale.Text = "סנן לפי כמות פריטים במבצע";
            buttonSherchByAmountInSale.UseVisualStyleBackColor = true;
            buttonSherchByAmountInSale.Click += buttonSherchByAmountInSale_Click;
            // 
            // dataGridViewSale
            // 
            dataGridViewSale.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSale.Location = new Point(18, 47);
            dataGridViewSale.Name = "dataGridViewSale";
            dataGridViewSale.RowHeadersWidth = 51;
            dataGridViewSale.RowTemplate.Height = 29;
            dataGridViewSale.Size = new Size(534, 188);
            dataGridViewSale.TabIndex = 11;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1557, 763);
            Controls.Add(panelCustomers);
            Controls.Add(panelProducts);
            Controls.Add(panelSales);
            Controls.Add(buttonSales);
            Controls.Add(buttonCustomers);
            Controls.Add(buttonProducts);
            Name = "Manager";
            Text = "Manager";
            Load += Manager_Load;
            panelProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProducts).EndInit();
            panelCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownId).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            panelSales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownSherchByAmountInSale).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSale).EndInit();
            ResumeLayout(false);



            // הגדרות כלליות לטופס
            this.FormBorderStyle = FormBorderStyle.None; // ללא מסגרת
            this.StartPosition = FormStartPosition.CenterScreen;
            this.DoubleBuffered = true;
            this.BackColor = Color.Black; // fallback במקרה והתמונה לא נטענת
            this.TransparencyKey = Color.Magenta; // אם תרצה להשתמש בשקיפות אמיתית בחלקים מסוימים

            // פונקציית עיצוב כפתורים בסגנון מודרני
            void StyleButton(Button btn)
            {
                btn.BackColor = Color.IndianRed; // אפור בהיר עם שקיפות
                btn.ForeColor = Color.Black;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.FlatAppearance.MouseOverBackColor = Color.Red;
                btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                btn.Cursor = Cursors.Hand;
                btn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn.Width, btn.Height, 20, 20)); // פינות מעוגלות
            }

            // פונקציית עיצוב ComboBox מודרני
            void StyleComboBox(ComboBox combo)
            {
                combo.BackColor = Color.White;
                combo.ForeColor = Color.Black;
                combo.FlatStyle = FlatStyle.Flat;
                combo.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            }

            // עיצוב DataGridView
            void StyleDataGridView(DataGridView dgv)
            {
                dgv.BackgroundColor = Color.White;
                dgv.DefaultCellStyle.BackColor = Color.White;
                dgv.DefaultCellStyle.ForeColor = Color.Black;
                dgv.DefaultCellStyle.SelectionBackColor = Color.DimGray;
                dgv.DefaultCellStyle.SelectionForeColor = Color.White;
                dgv.GridColor = Color.LightGray;
                dgv.EnableHeadersVisualStyles = false;
                dgv.BorderStyle = BorderStyle.None;
                dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
                dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                dgv.RowHeadersVisible = false;
            }

            // מעבר על כל הפקדים ועיצוב
            foreach (Control control in this.Controls)
            {
                if (control is Button btn)
                    StyleButton(btn);

                else if (control is Panel panel)
                    panel.BackColor = Color.FromArgb(100, Color.White); // שקוף למחצה

                else if (control is ComboBox combo)
                    StyleComboBox(combo);

                else if (control is DataGridView dgv)
                    StyleDataGridView(dgv);
            }


        }

        #endregion

        private Button addProductButton;
        private Button updateProductButton;
        private Button deleteProductButton;
        private Button deleteCustomer;
        private Button updateCustomer;
        private Button addCustomer;
        private Button deleteSaleButton;
        private Button updateSaleButton;
        private Button addSaleButton;
        private Button buttonProducts;
        private Button buttonCustomers;
        private Button buttonSales;
        private Panel panelProducts;
        private Panel panelCustomers;
        private Panel panelSales;
        private DataGridView dataGridViewSales;
        private DataGridView dataGridViewProducts;
        private DataGridView dataGridViewCustomers;
        private DataGridView dataGridViewSale;
        private Button buttonShrechByCategory;
        private ComboBox comboboxCategory;
        private TextBox textBoxCustomerName;
        private Button buttonSherchByCusId;
        private Button buttonSherchByAmountInSale;
        private NumericUpDown numericUpDownSherchByAmountInSale;
        private NumericUpDown numericUpDownId;
        private PictureBox pictureBox1;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
  int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
  int nWidthEllipse, int nHeightEllipse
);
    }
  
}
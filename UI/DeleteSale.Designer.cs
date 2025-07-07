namespace UI
{
    partial class DeleteSale
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
            numericUpDownSaleId = new NumericUpDown();
            labelDaleteSale = new Label();
            buttonDeleteSale = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleId).BeginInit();
            SuspendLayout();
            // 
            // numericUpDownSaleId
            // 
            numericUpDownSaleId.Location = new Point(12, 12);
            numericUpDownSaleId.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownSaleId.Minimum = new decimal(new int[] { 5000, 0, 0, 0 });
            numericUpDownSaleId.Name = "numericUpDownSaleId";
            numericUpDownSaleId.Size = new Size(150, 27);
            numericUpDownSaleId.TabIndex = 0;
            numericUpDownSaleId.Value = new decimal(new int[] { 5000, 0, 0, 0 });
            // 
            // labelDaleteSale
            // 
            labelDaleteSale.AutoSize = true;
            labelDaleteSale.Location = new Point(208, 19);
            labelDaleteSale.Name = "labelDaleteSale";
            labelDaleteSale.Size = new Size(71, 20);
            labelDaleteSale.TabIndex = 1;
            labelDaleteSale.Text = "קוד מבצע";
            labelDaleteSale.Click += labelDaleteSale_Click;
            // 
            // buttonDeleteSale
            // 
            buttonDeleteSale.Location = new Point(73, 64);
            buttonDeleteSale.Name = "buttonDeleteSale";
            buttonDeleteSale.Size = new Size(168, 69);
            buttonDeleteSale.TabIndex = 2;
            buttonDeleteSale.Text = "להסרת מבצע";
            buttonDeleteSale.UseVisualStyleBackColor = true;
            buttonDeleteSale.Click += buttonDeleteSale_Click;
            // 
            // DeleteSale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.shoe_store_075;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(296, 164);
            Controls.Add(buttonDeleteSale);
            Controls.Add(labelDaleteSale);
            Controls.Add(numericUpDownSaleId);
            Name = "DeleteSale";
            Text = "DeleteSale";
            ((System.ComponentModel.ISupportInitialize)numericUpDownSaleId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDownSaleId;
        private Label labelDaleteSale;
        private Button buttonDeleteSale;
    }
}
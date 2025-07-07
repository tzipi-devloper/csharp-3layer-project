using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.managerButton = new Button();
            this.cashierButton = new Button();
            this.SuspendLayout();

            // Form settings
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(840, 500);
            this.BackColor = Color.FromArgb(30, 30, 40);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            this.Text = "ברוכים הבאים למערכת המתקדמת";

            // Manager Button
            this.managerButton.Location = new Point(460, 220);
            this.managerButton.Size = new Size(180, 70);
            this.managerButton.Name = "managerButton";
            this.managerButton.Text = "👨‍💼 מנהל";
            this.managerButton.FlatStyle = FlatStyle.Flat;
            this.managerButton.FlatAppearance.BorderSize = 0;
            this.managerButton.BackColor = Color.Red;
            this.managerButton.ForeColor = Color.WhiteSmoke;
            this.managerButton.Cursor = Cursors.Hand;
            this.managerButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            this.managerButton.TextAlign = ContentAlignment.MiddleLeft;

            this.managerButton.MouseEnter += (s, e) =>
            {
                managerButton.BackColor = Color.Red;
                managerButton.FlatAppearance.BorderSize = 2;
                managerButton.FlatAppearance.BorderColor = Color.Silver;
                managerButton.ForeColor = Color.White;
                managerButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
                managerButton.Cursor = Cursors.Hand;
            };
            this.managerButton.MouseLeave += (s, e) =>
            {
                managerButton.BackColor = Color.Red;
                managerButton.FlatAppearance.BorderSize = 0;
                managerButton.ForeColor = Color.WhiteSmoke;
                managerButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            };
            this.managerButton.Click += new EventHandler(this.managerButton_Click);

            // Cashier Button
            this.cashierButton.Location = new Point(200, 220);
            this.cashierButton.Size = new Size(180, 70);
            this.cashierButton.Name = "cashierButton";
            this.cashierButton.Text = "💰 קופאי";
            this.cashierButton.FlatStyle = FlatStyle.Flat;
            this.cashierButton.FlatAppearance.BorderSize = 0;
            this.cashierButton.BackColor = Color.Red;
            this.cashierButton.ForeColor = Color.WhiteSmoke;
            this.cashierButton.Cursor = Cursors.Hand;
            this.cashierButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            this.cashierButton.TextAlign = ContentAlignment.MiddleLeft;

            this.cashierButton.MouseEnter += (s, e) =>
            {
                cashierButton.BackColor = Color.Red;
                cashierButton.FlatAppearance.BorderSize = 2;
                cashierButton.FlatAppearance.BorderColor = Color.Silver;
                cashierButton.ForeColor = Color.White;
                cashierButton.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
                cashierButton.Cursor = Cursors.Hand;
            };
            this.cashierButton.MouseLeave += (s, e) =>
            {
                cashierButton.BackColor = Color.Red;
                cashierButton.FlatAppearance.BorderSize = 0;
                cashierButton.ForeColor = Color.WhiteSmoke;
                cashierButton.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            };
            this.cashierButton.Click += new EventHandler(this.cashierButton_Click);

            // Add buttons to form
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.cashierButton);

            this.ResumeLayout(false);
        }

        #endregion

        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect,
            int nWidthEllipse, int nHeightEllipse);

        private Button managerButton;
        private Button cashierButton;
    }
}


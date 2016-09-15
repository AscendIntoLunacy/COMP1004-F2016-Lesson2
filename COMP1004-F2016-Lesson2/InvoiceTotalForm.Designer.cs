namespace COMP1004_F2016_Lesson2
{
    partial class InvoiceTotalForm
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
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.DiscountPercentLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubtotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.DiscountAmountTextBox = new System.Windows.Forms.TextBox();
            this.DiscountPercentTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.Location = new System.Drawing.Point(35, 35);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(129, 32);
            this.SubtotalLabel.TabIndex = 0;
            this.SubtotalLabel.Text = "Subtotal:";
            // 
            // DiscountPercentLabel
            // 
            this.DiscountPercentLabel.AutoSize = true;
            this.DiscountPercentLabel.Location = new System.Drawing.Point(35, 84);
            this.DiscountPercentLabel.Name = "DiscountPercentLabel";
            this.DiscountPercentLabel.Size = new System.Drawing.Size(239, 32);
            this.DiscountPercentLabel.TabIndex = 1;
            this.DiscountPercentLabel.Text = "Discount Percent:";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Location = new System.Drawing.Point(35, 140);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(239, 32);
            this.DiscountAmountLabel.TabIndex = 2;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(35, 192);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(87, 32);
            this.TotalLabel.TabIndex = 3;
            this.TotalLabel.Text = "Total:";
            // 
            // SubtotalTextBox
            // 
            this.SubtotalTextBox.Location = new System.Drawing.Point(280, 32);
            this.SubtotalTextBox.Name = "SubtotalTextBox";
            this.SubtotalTextBox.Size = new System.Drawing.Size(229, 38);
            this.SubtotalTextBox.TabIndex = 4;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.BackColor = System.Drawing.Color.White;
            this.TotalTextBox.Location = new System.Drawing.Point(280, 189);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(229, 38);
            this.TotalTextBox.TabIndex = 7;
            // 
            // DiscountAmountTextBox
            // 
            this.DiscountAmountTextBox.BackColor = System.Drawing.Color.White;
            this.DiscountAmountTextBox.Location = new System.Drawing.Point(280, 137);
            this.DiscountAmountTextBox.Name = "DiscountAmountTextBox";
            this.DiscountAmountTextBox.ReadOnly = true;
            this.DiscountAmountTextBox.Size = new System.Drawing.Size(229, 38);
            this.DiscountAmountTextBox.TabIndex = 6;
            // 
            // DiscountPercentTextBox
            // 
            this.DiscountPercentTextBox.BackColor = System.Drawing.Color.White;
            this.DiscountPercentTextBox.Location = new System.Drawing.Point(280, 81);
            this.DiscountPercentTextBox.Name = "DiscountPercentTextBox";
            this.DiscountPercentTextBox.ReadOnly = true;
            this.DiscountPercentTextBox.Size = new System.Drawing.Size(229, 38);
            this.DiscountPercentTextBox.TabIndex = 5;
            this.DiscountPercentTextBox.Text = "10.0%";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(94, 252);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(152, 52);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(280, 252);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(152, 52);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InvoiceTotalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(528, 332);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DiscountPercentTextBox);
            this.Controls.Add(this.DiscountAmountTextBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.SubtotalTextBox);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.DiscountPercentLabel);
            this.Controls.Add(this.SubtotalLabel);
            this.Name = "InvoiceTotalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Total";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubtotalLabel;
        private System.Windows.Forms.Label DiscountPercentLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.TextBox SubtotalTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.TextBox DiscountAmountTextBox;
        private System.Windows.Forms.TextBox DiscountPercentTextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ExitButton;
    }
}


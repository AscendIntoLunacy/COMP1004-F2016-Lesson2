using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP1004_F2016_Lesson2
{
    public partial class InvoiceTotalForm : Form
    {
        public InvoiceTotalForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// CalculateButton Event Handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        /// <summary>
        /// This method calculates the total based by multiplying the 
        /// Subtotal by the DiscountPercent and then
        /// Subtracting this value.
        /// </summary>
        private void CalculateTotal()
        {
            // Local Variables
            const double DiscountPercent = 0.1;
            double Subtotal;
            double DiscountAmount;
            double Total;

            try
            {
                Subtotal = Convert.ToDouble(SubtotalTextBox.Text);
                DiscountAmount = Subtotal * DiscountPercent;
                Total = Subtotal - DiscountAmount;

                DiscountAmountTextBox.Text = DiscountAmount.ToString("C2");
                TotalTextBox.Text = Total.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                ResetSubtotalTextBox();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InvoiceTotalForm_Load(object sender, EventArgs e)
        {
            ResetSubtotalTextBox();
        }

        private void ResetSubtotalTextBox()
        {
            SubtotalTextBox.Focus();
            SubtotalTextBox.Text = "0";
            SubtotalTextBox.SelectAll();
        }
    }
}

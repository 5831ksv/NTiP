using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FormAddMarkdown : Form
    {
      public FormAddMarkdown()
        {
            InitializeComponent();
        }
        public List<IDiscounts> DiscountList { get; set; }

        private void TextBoxValidation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (e.KeyChar != (char)Keys.Back)
            {
                if (e.KeyChar != '.')
                {
                    e.Handled = true;
                }
            }
        }

        private void ButtonDiscountCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double doubleValuePrice = Convert.ToDouble(textBoxPriceDiscount.Text.Replace(".", ","));
                double doubleValueDiscount = Convert.ToDouble(textBoxDiscountMarkdown.Text.Replace(".", ","));
                CertificateDiscounts percent = new CertificateDiscounts(doubleValuePrice, doubleValueDiscount);
                DiscountList.Add(percent);
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show(@"Не все строки заполнены", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                  
        }

        private void ButtonPercentCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                
                double doubleValuePrice = Convert.ToDouble(textBoxPrice.Text.Replace(".", ","));
                double doubleValuePercentTemp = Convert.ToDouble(textBoxPercent.Text.Replace(".", ","));
                double doubleValuePercent = (doubleValuePercentTemp/100);
                if (doubleValuePercent < 0 || doubleValuePercent > 1)

                {
                    MessageBox.Show(@"Значение процентной скидки принимает значени я от 0 до 100", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else

                {
                    PercentDiscounts percent = new PercentDiscounts(doubleValuePrice, doubleValuePercent);
                    DiscountList.Add(percent);
                    Close();
                }
                
            }

            catch (FormatException)
            {
                MessageBox.Show(@"Не все строки заполнены", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void buttonCloseEvent_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

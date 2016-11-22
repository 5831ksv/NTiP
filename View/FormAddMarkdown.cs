using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        /*      private void textBoxPrice_Validadating(object sender, EventArgs e)
              {
                  try
                  {
                     double doubleValue=0;
                      if (double.TryParse(textBoxPrice.Text, out doubleValue)) throw new Exeption("Цена должна быть задана числом!");
                      if (doubleValue <= 0) throw new Exeption("Цена должна быть больше нуля.");
                      if (double.TryParse(textBoxPrice.Text, out doubleValue)) throw new Exeption("Цена должна быть задана числом!");
              }

                  catch (FormatException)
                  {
                      MessageBox.Show("format exeption", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                  }


                  /*     catch (Exeption exFCircle)
                       {
                           Console.WriteLine("{0} Exception caught.", exFCircle);
                       }

              }*/

        /*        private void textBoxPrice1_Validadating(object sender, EventArgs e)
                {
                    try
                    {
                        double doubleValue=0;
                        if (double.TryParse(textBoxPrice1.Text, out doubleValue)) throw new Exeption("Цена должна быть задана числом!");
                        if (doubleValue <= 0) throw new Exeption("Цена должна быть больше нуля.");
                    }
                    catch (Exeption exFCircle)
                    {
                        Console.WriteLine("{0} Exception caught.", exFCircle);
                    }

                }
          */


        private void textBoxPriceDiscount_KeyPress(object sender, KeyPressEventArgs e)//в один метод
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void textBoxDiscountMarkdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void buttonDiscountCalculate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Не все строки заполнены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                  
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void textBoxPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (e.KeyChar != '.')
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void buttonPercentCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double doubleValuePrice = Convert.ToDouble(textBoxPrice.Text.Replace(".", ","));

                double doubleValuePercentTemp = Convert.ToDouble(textBoxPercent.Text.Replace(".", ","));
                double doubleValuePercent = (doubleValuePercentTemp/100);


                PercentDiscounts percent = new PercentDiscounts(doubleValuePrice, doubleValuePercent);
                DiscountList.Add(percent);
                Close();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Не все строки заполнены", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}

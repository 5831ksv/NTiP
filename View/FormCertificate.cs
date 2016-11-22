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
    public partial class FormCertificate : Form
    {
      public FormCertificate()
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


        private void buttonCalculate_Click(object sender, EventArgs e)
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
                MessageBox.Show("Error Null ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
                  
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

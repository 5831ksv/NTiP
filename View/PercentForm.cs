using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discounts;
using Model;

namespace View
{
    public partial class PercentForm : Form
    {
        public PercentForm()
        {
            InitializeComponent();
        }
        public List<IDiscounts> DiscountList { get; set; }



  
                 
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

        private void button1Calculate_Click(object sender, EventArgs e)
        {
            try
            {
                double doubleValuePrice = Convert.ToDouble(textBoxPrice.Text.Replace(".", ","));

                double doubleValuePercentTemp = Convert.ToDouble(textBoxPercent.Text.Replace(".", ","));
                double doubleValuePercent = (doubleValuePercentTemp / 100);
                

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

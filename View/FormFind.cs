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
    public partial class FormFind : Form
    {
        public FormFind()
        {
            InitializeComponent();
        }
        public List<IDiscounts> discountList { get; set; }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            double findDiscount = 0;
            if (textBoxPrice.Text !="")
            {
                findDiscount = Convert.ToDouble(textBoxPrice.Text.Replace(".", ","));
            }
            if (discountList != null)
            {
                if (checkBoxPercent.Checked||checkBoxCertificate.Checked)
                {
                    foreach(var objectDiscount in discountList)
                    {
                        if ((objectDiscount is PercentDiscounts) && (checkBoxPercent.Checked))
                        {
                            if ((objectDiscount.Discount==findDiscount)|| (textBoxPrice.Text == ""))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView1);
                                row.Cells[0].Value = objectDiscount.TypeDiscount;
                                row.Cells[1].Value = objectDiscount.Discount;
                                row.Cells[2].Value = objectDiscount.IndicatedDiscount;
                                row.Cells[3].Value = objectDiscount.TotalCost;
                                dataGridView1.Rows.Add(row);
                            }
                        }
                        if ((objectDiscount is CertificateDiscounts) && (checkBoxCertificate.Checked))
                        {
                            if ((objectDiscount.Discount == findDiscount) || (textBoxPrice.Text == ""))
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                row.CreateCells(dataGridView1);
                                row.Cells[0].Value = objectDiscount.TypeDiscount;
                                row.Cells[1].Value = objectDiscount.Discount;
                                row.Cells[2].Value = objectDiscount.IndicatedDiscount;
                                row.Cells[3].Value = objectDiscount.TotalCost;
                                dataGridView1.Rows.Add(row);
                            }
                        }
                    }

                }
            }
        }

        private void buttonCloseEvent_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

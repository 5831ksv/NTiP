using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace View
{
    public partial class FormDiscounts : Form
    {
        public List<IDiscounts> DiscountsList = new List<IDiscounts>();
        public FormDiscounts()
        {
            InitializeComponent();
        }

        private void ButtonAddObject_Click(object sender, EventArgs e)
        {
            FormAddMarkdown addDiscount = new FormAddMarkdown();
            addDiscount.DiscountList = DiscountsList;
            addDiscount.ShowDialog();
        }
        private void FormDiscounts_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            DataGridView.Rows.Clear();
            foreach (IDiscounts objectDiscount in DiscountsList) //
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(DataGridView);
                row.Cells[0].Value = objectDiscount.TypeDiscount;
                row.Cells[1].Value = objectDiscount.Discount;               
                DataGridView.Rows.Add(row);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (DataGridViewRow row in DataGridView.SelectedRows)
                {
                    DiscountsList.RemoveAt(row.Index);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
             //   MessageBox.Show("cant delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            UpdateDataGridView();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            FormFind addDiscount = new FormFind();
            addDiscount.discountList = DiscountsList;
            addDiscount.ShowDialog();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (DiscountsList.Count != 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.DefaultExt = "kekeke";
                saveFileDialog.Filter = "Custom filename extension  (*.kekeke)|*.kekeke";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        if (saveFileDialog.FileName != "")
                        {
                            FileStream stream = (FileStream)saveFileDialog.OpenFile();
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            binaryFormatter.Serialize(stream, DiscountsList);
                            stream.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка: Не удалось сохранить файл на диск. Что-то произошло: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Ошибка: Список пуст.");
            }
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Custom filename extension  (*.discounts)|*.discounts";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream stream = null;
                    if ((stream = (FileStream)openFileDialog.OpenFile()) != null)
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        DiscountsList = (List<IDiscounts>)binaryFormatter.Deserialize(stream);
                        stream.Close();
                        UpdateDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Что-то пошло не так" + ex.Message);
                }
            }
        }
    }
}
        


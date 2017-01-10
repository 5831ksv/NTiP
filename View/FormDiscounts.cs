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
        public List<IDiscounts> Discount = new List<IDiscounts>();
        public FormDiscounts()
        {
            InitializeComponent();
        }

        private void sertificate_Click(object sender, EventArgs e)
        {
            FormAddMarkdown addDiscount = new FormAddMarkdown();
            addDiscount.DiscountList = Discount;
            addDiscount.ShowDialog();
        }
        private void FormDiscounts_Activated(object sender, EventArgs e)
        {
            UpdateDataGridView();
        }
        private void UpdateDataGridView()
        {
            dataGridView.Rows.Clear();
            foreach (IDiscounts t in Discount) //
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dataGridView);
                if (t is PercentDiscounts) { row.Cells[0].Value = "Процентная "; } //if название в интерфейс
                if (t is CertificateDiscounts) { row.Cells[0].Value = "Сертификатная"; }
                //   row.Cells[1].Value = t.ChosenDiscount;
                row.Cells[1].Value = t.TypeDiscount;
                row.Cells[2].Value = t.Discount;               
                dataGridView.Rows.Add(row);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    Discount.RemoveAt(row.Index);
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
             //   MessageBox.Show("cant delete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            UpdateDataGridView();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            FormFind addDiscount = new FormFind();
            addDiscount.DiscountList = Discount;
            addDiscount.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Discount.Count != 0)
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
                            binaryFormatter.Serialize(stream, Discount);
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Custom filename extension  (*.kekeke)|*.kekeke";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream stream = null;
                    if ((stream = (FileStream)openFileDialog.OpenFile()) != null)
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        Discount = (List<IDiscounts>)binaryFormatter.Deserialize(stream);
                        stream.Close();
                        UpdateDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: Не удалось открыть файл с диска. Что-то произошло: " + ex.Message);
                }
            }
        }
    }
}
        


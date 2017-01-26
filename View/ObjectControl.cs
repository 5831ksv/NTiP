using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


namespace View
{
    public partial class ObjectControl : UserControl
    {
        public ObjectControl()
        {
            InitializeComponent();
        }
        /*
         * 
         * динамически отображать параметры
         * комбобокс выпадающий лист
         * nfnsq
         * 
         * 
        */

        private bool _readOnly;
        /// <summary>
        /// Признак редактируемости объекта
        /// </summary>
        public bool ReadOnly
        {
            get
            {
                return _readOnly;
            }
            set
            {
                _readOnly = value;
                if (_readOnly == null)
                    return;
                if (_readOnly == true)
                {
                    SetReadOnly(true);
                }
                else
                {
                    SetReadOnly(false);
                }
            }
        }





        /// <summary>
        /// Метод для установки редактируемости объекта
        /// </summary>
        /// <param name="state"></param>
        private void SetReadOnly(bool state)
        {
            foreach (Control groupBox in this.Controls)
            {
                if (groupBox is GroupBox)
                {
                    foreach (Control textbox in groupBox.Controls)
                    {
                        if (textbox is TextBox)
                        {
                            textbox.Enabled = !state;
                        }
                    }
                    foreach (Control radioButton in groupBox.Controls)
                    {
                        if (radioButton is RadioButton)
                        {
                            radioButton.Enabled = !state;
                        }
                    }
                }
            }
        }




        private IDiscounts _object = null;



    }
}

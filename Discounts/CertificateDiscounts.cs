using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class CertificateDiscounts : IDiscounts
    {
        private double _costOfGoods;
        private double _chosenDiscount;
        private double _summa;



        public CertificateDiscounts(double _costOfGoods, double _chosenDiscount)
        {

            if (_costOfGoods < 0)

                throw new ArgumentException("Должно быть больше нуля", "_costOfGoods");

            if (_chosenDiscount < 0)

                throw new ArgumentException("Должно быть больше нуля", "_chosenDiscount");

            this._chosenDiscount = _chosenDiscount;
            this._costOfGoods = _costOfGoods;

            if ((_costOfGoods - _chosenDiscount) < 0)
            {
                _summa = 0;
            }
           else
               {
                _summa = _costOfGoods - _chosenDiscount;
               }

        }

        public double Discount
        {

            get
            {
                return _summa;
            }

        }

        public double ChosenDiscount
        {
            get
            {
                return _chosenDiscount;
            }
        }

        public string TypeDiscount
        {
            get
            {
                return "Certificate";
            }
        }

    }
}


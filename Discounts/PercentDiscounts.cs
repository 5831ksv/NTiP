using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model

{
    [Serializable]
    public class PercentDiscounts : IDiscounts
    {
        public double _costOfGoods;

        public double _chosenDiscount;

        public PercentDiscounts(double _costOfGoods, double _chosenDiscount)
        {

            if (_chosenDiscount < 0 || _chosenDiscount > 1)

               throw new ArgumentException("Должно быть от 0 до 1", "_chosenDiscount");


            if (_costOfGoods < 0)
                throw new ArgumentException("Не должно быть отрицательным", "_costOfGoods");

            this._chosenDiscount = _chosenDiscount;
            this._costOfGoods = _costOfGoods;

        }

       public double Discount
        {

           get
           {
               return _costOfGoods - _costOfGoods * _chosenDiscount; 
           }
            
        }

        public double ChosenDiscount
        {
            get
            { return _chosenDiscount; }
        }

        //будет возвращать "имя"
        public string TypeDiscount
        {
            get
            {
                return "Percent";
            }
        }

    }
}

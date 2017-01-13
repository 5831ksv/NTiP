using System;

namespace Model

{
    [Serializable]
    public class PercentDiscounts : IDiscounts
    {
        private double _totalCost;
        private double _indicatedDiscount;

        public PercentDiscounts(double totalCost, double chosenDiscount)
        {

            if (chosenDiscount < 0 || chosenDiscount > 1)

               throw new ArgumentException("Должно быть от 0 до 1", "chosenDiscount");


            if (totalCost < 0)
                throw new ArgumentException("Не должно быть отрицательным", "_costOfGoods");

            _totalCost = totalCost;
            _indicatedDiscount = chosenDiscount;

        }

       public double Discount
        {

           get
           {
               return _totalCost - _totalCost * _indicatedDiscount; 
           }
            
        }

        public double IndicatedDiscount
        {
            get
            { return _indicatedDiscount; }
        }

        public double TotalCost
        {
            get
            {
                return _totalCost;
            }
        }

        public string TypeDiscount
        {
            get
            {
                return "Percent";
            }
        }

    }
}

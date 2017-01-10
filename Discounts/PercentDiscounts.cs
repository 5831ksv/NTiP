using System;

namespace Model

{
    [Serializable]
    public class PercentDiscounts : IDiscounts
    {
        private double _totalCost;
        private double _chosenDiscount;


        public PercentDiscounts(double totalCost, double chosenDiscount)
        {

            if (chosenDiscount < 0 || chosenDiscount > 1)

               throw new ArgumentException("Должно быть от 0 до 1", "chosenDiscount");


            if (totalCost < 0)
                throw new ArgumentException("Не должно быть отрицательным", "_costOfGoods");

            _totalCost = totalCost;
            _chosenDiscount = chosenDiscount;

        }

       public double Discount
        {

           get
           {
               return _totalCost - _totalCost * _chosenDiscount; 
           }
            
        }

        public double ChosenDiscount
        {
            get
            { return _chosenDiscount; }
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

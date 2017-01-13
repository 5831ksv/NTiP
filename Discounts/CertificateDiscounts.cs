using System;

namespace Model
{
    [Serializable]
    public class CertificateDiscounts : IDiscounts
    {
        private double _totalCost;
        private double _indicatedDiscount;
        private double _summa;
        
        public CertificateDiscounts(double totalCost, double chosenDiscount)
        {

            if (totalCost < 0)

                throw new ArgumentException("Должно быть больше нуля", "_costOfGoods");

            if (chosenDiscount < 0)

                throw new ArgumentException("Должно быть больше нуля", "chosenDiscount");

            _indicatedDiscount = chosenDiscount;
            _totalCost = totalCost;

            if ((totalCost - chosenDiscount) < 0)
            {
                _summa = 0;
            }
           else
               {
                _summa = totalCost - chosenDiscount;
               }

        }

        public double Discount
        {

            get
            {
                return _summa;
            }

        }

        public double IndicatedDiscount
        {
            get
            {
                return _indicatedDiscount;
            }
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
                return "Certificate";
            }
        }

    }
}


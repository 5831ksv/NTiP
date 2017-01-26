using System;

namespace Model
{
    [Serializable]
    public class CertificateDiscounts : IDiscounts
    {
        private double _totalCost;
        private double _indicatedDiscount;
        private double _summa;

        // public CertificateDiscounts(double totalCost, double indicatedDiscount)
        public CertificateDiscounts(double totalCost, double indicatedDiscount)
        {
            _indicatedDiscount = indicatedDiscount;
            _totalCost = totalCost;

            if (totalCost < 0)

                throw new ArgumentException("Должно быть больше нуля", "_costOfGoods");

            if (indicatedDiscount < 0)

                throw new ArgumentException("Должно быть больше нуля", "indicatedDiscount");

            if ((totalCost - indicatedDiscount) < 0)
            {
                _summa = 0;
            }
           else
               {
                _summa = totalCost - indicatedDiscount;
               }
        }

                public double[] Parameter
                {
                    get
                    {
                        double[] param = { _totalCost, _indicatedDiscount };
                        return param;
                    }
                }

        public double Discount
        {
            get
            {
                return _summa;
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


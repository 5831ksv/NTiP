using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;

namespace UnitTests.Model
{
    [TestFixture]
    class CertificateDiscountsTest
    {

        [Test]

        [TestCase(100,1, TestName = "Тестирование сертификатной скидки стоимость покупки значение 1, и скидкой в размере 1")]
        [TestCase(0,0, TestName = "Тестирование сертификатной скидки  значением 0 и скидкой в размере 0")]
       
        [TestCase(double.MaxValue, double.MaxValue, TestName = "Тестирование сертификатной скидки  значением double.MaxValue, и скидкой в размере double.MaxValue")]

        public void CertificateDiscountTest(double _costOfGoods, double _chosenDiscount)
        {
            CertificateDiscounts certificate = new CertificateDiscounts(_costOfGoods, _chosenDiscount);
        }


        [TestCase(-1, -1, TestName = "Тестирование сертификатной скидки  значением -1, и скидкой в размере -1")]

        public void CertificateDiscountTestFail(double _costOfGoods, double _chosenDiscount)
        {
            Assert.Catch<ArgumentException>(() => { new CertificateDiscounts(_costOfGoods, _chosenDiscount); });
        }



    }
}

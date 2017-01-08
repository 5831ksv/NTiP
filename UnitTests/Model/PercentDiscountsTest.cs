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
    class PercentDiscountsTest
    {
        [Test]

        [TestCase(0, 0, TestName = "Тестирование процентной скидки  значением цены покупки,равной 0, и размером скидки,равной 0")]
        [TestCase(double.MaxValue, 0.5, TestName = "Тестирование процентной скидки  значением цены покупки,равной double.MaxValue, и размером скидки,равной 0.5")]

        [TestCase(100, 1, TestName = "Тестирование процентной скидки значением цены покупки,равной 100, и размером скидки,равной 1")]
        [TestCase(100, 0, TestName = "Тестирование процентной скидки значением цены покупки,равной 100, и размером скидки,равной 0")]
        [TestCase(100, 0.4, TestName = "Тестирование процентной скидки значением цены покупки,равной 100, и размером скидки,равной 0.4")]

        public void PercentDiscountTest(double doubleValue, double discount)
        {
            PercentDiscounts percent = new PercentDiscounts(doubleValue, discount);
        }

        [Test]

        [TestCase(100, -10, TestName = "Тестирование процентной скидки значением цены покупки,равной 100, и размером скидки,равной -10")]
        [TestCase(100, 10, TestName = "Тестирование процентной скидки значением цены покупки,равной 100, и размером скидки,равной 10")]
        [TestCase(-100, 0.5, TestName = "Тестирование процентной скидки  значением цены покупки,равной -100, и размером скидки,равной 0.5")]

        public void PercentDiscountTestFail(double doubleValue, double discount)
        {
            Assert.Catch<ArgumentException>(() => { new PercentDiscounts(doubleValue, discount);});
        }
    }
}

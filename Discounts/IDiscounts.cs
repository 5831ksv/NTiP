﻿
namespace Model
{
    public interface IDiscounts
    {

        /// <summary>
        /// Рассчитанная стоимость
        /// </summary>
        double Discount { get; }

        /// <summary>
        /// Указанная скидка
        /// </summary>
        double IndicatedDiscount { get; }

        /// <summary>
        /// Общая стоимость
        /// </summary>
        double TotalCost { get; }

        /// <summary>
        /// Тип скидки
        /// </summary>
        string TypeDiscount { get; }
 
    }
}

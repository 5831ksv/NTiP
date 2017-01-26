
namespace Model
{
    public interface IDiscounts
    {

        /// <summary>
        /// Рассчитанная стоимость
        /// </summary>
        double Discount { get; }

        /// <summary>
        /// Тип скидки
        /// </summary>
        string TypeDiscount { get; }

        double[] Parameter { get; }

    }
}

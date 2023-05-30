///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 27/05/2023
// Last Modified On :
// Description: Shop run
// Project: Module2_HW2_26052023
///////////////////////////////////////

namespace Module2_HW2_26052023
{
    using System;

    /// <summary>
    /// Purchases.
    /// </summary>
    public class Purchases
    {
        private string[] _chosedGoods;

        /// <summary>
        /// Initializes a new instance of the <see cref="Purchases"/> class.
        /// </summary>
        /// <param name="goods">
        /// Класс товаров.
        /// </param>
        public Purchases(Goods goods)
        {
            _chosedGoods = new string[goods.ListGoods.Length];

            for (int i = 0; i < _chosedGoods.Length; i++)
            {
                _chosedGoods[i] = $"[ ]: {goods.ListGoods[i]}:\tprice {Price.GetPrise(goods.ListGoods[i])}";
            }
        }

        /// <summary>
        /// Gets or sets ChosedGoods.
        /// </summary>
        public string[] ChosedGoods
        {
            get
            {
                return _chosedGoods;
            }

            set
            {
                _chosedGoods = value;
            }
        }

        /// <summary>
        /// Обработка выбранного продукта.
        /// </summary>
        /// <param name="coords">
        /// класс с координатами в консоли.
        /// </param>
        public void ProccessProduct(CursorCoords coords, ShoppingCart shoppingCart)
        {
            var str =
                _chosedGoods[
                    Console.CursorTop - coords.GetDefTopPosition].Split(':');

            char state = str[0][1];

            if (state == 'X')
            {
                _chosedGoods[Console.CursorTop - coords.GetDefTopPosition]
                    = string.Concat("[ ]", ":", str[1], ":", str[2]);
                shoppingCart.RemoveGood(
                    (KindOfGoods)Enum.Parse(typeof(KindOfGoods), str[1]));
            }
            else
            {
                _chosedGoods[Console.CursorTop - coords.GetDefTopPosition]
                    = string.Concat("[X]", ":", str[1], ":", str[2]);
                shoppingCart.AddGood(
                    (KindOfGoods)Enum.Parse(typeof(KindOfGoods), str[1]));
            }
        }
    }
}
// Author: Tymoshchuk Maksym
// Created On : 28/05/2023
// Last Modified On :
// Description: goods list for sale
// Project: Module2_HW2_26052023

namespace Module2_HW2_26052023
{
    using System;

    /// <summary>
    /// Корщина.
    /// </summary>
    public class ShoppingCart
    {
        private readonly int sizeOfferedGoogds
            = Enum.GetNames(typeof(KindOfGoods)).Length - 1;

        private KindOfGoods[] _goods;
        private int _summ = 0;
        private string _orderNum;

        /// <summary>
        /// Initializes a new instance of the <see cref="ShoppingCart"/> class.
        /// </summary>
        public ShoppingCart()
        {
            _goods = new KindOfGoods[sizeOfferedGoogds];
            for (int i = 0; i < _goods.Length; i++)
            {
                _goods[i] = KindOfGoods.None;
            }
        }

        /// <summary>
        /// Gets goods list for choise.
        /// </summary>
        public KindOfGoods[] ListGoods
        {
            get
            {
                return _goods;
            }
        }

        /// <summary>
        /// Gets or sets purchase cost.
        /// </summary>
        public int Summ
        {
            get { return _summ; }
            set { _summ = value; }
        }

        /// <summary>
        /// Add good to product cart.
        /// </summary>
        /// <param name="good">
        /// Good for adding.
        /// </param>
        public void AddGood(KindOfGoods good)
        {
            int indexForWrite = Array.IndexOf(_goods, KindOfGoods.None);
            _goods[indexForWrite] = good;
            _summ += Price.GetPrise(good);
        }

        /// <summary>
        /// Remove good from shopping cart.
        /// </summary>
        /// <param name="good">
        /// Good.
        /// </param>
        public void RemoveGood(KindOfGoods good)
        {
            int indexForWrite = Array.IndexOf(_goods, good);
            _goods[indexForWrite] = KindOfGoods.None;
            _summ -= Price.GetPrise(good);
        }

        /// <summary>
        /// Gets order num.
        /// </summary>
        public string OrderNum
        {
            get { return _orderNum; }
        }

        /// <summary>
        /// Confirm order.
        /// </summary>
        /// <returns>
        /// Order num.
        /// </returns>
        public string ConfirmOrder()
        {
            Random random = new Random();
            for (int i = 0; i < 2; i++)
            {
                _orderNum += (char)random.Next(70, 80);
            }

            for (int i = 0; i < 8; i++)
            {
                _orderNum += random.Next(0, 9);
            }

            return _orderNum;
        }
    }
}
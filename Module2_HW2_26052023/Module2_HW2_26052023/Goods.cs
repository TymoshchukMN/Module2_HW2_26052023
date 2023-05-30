// Author: Tymoshchuk Maksym
// Created On : 27/05/2023
// Last Modified On :
// Description: goods
// Project: Module2_HW2_26052023

namespace Module2_HW2_26052023
{
    using System;

    /// <summary>
    /// Goods.
    /// </summary>
    public class Goods
    {
        private readonly int sizeOfferedGoogds
            = Enum.GetNames(typeof(KindOfGoods)).Length - 1;

        private KindOfGoods[] _goodsList;

        /// <summary>
        /// Initializes a new instance of the <see cref="Goods"/> class.
        /// </summary>
        public Goods()
        {
            _goodsList = new KindOfGoods[sizeOfferedGoogds];

            for (int i = 0; i < _goodsList.Length; i++)
            {
                _goodsList[i] = (KindOfGoods)i + 1;
            }
        }

        /// <summary>
        /// Gets goods list for choise.
        /// </summary>
        public KindOfGoods[] ListGoods
        {
            get
            {
                return _goodsList;
            }
        }
    }
}

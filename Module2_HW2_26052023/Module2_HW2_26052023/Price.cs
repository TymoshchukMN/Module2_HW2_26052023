// Author: Tymoshchuk Maksym
// Created On : 28/05/2023
// Last Modified On :
// Description: prise
// Project: Module2_HW2_26052023

namespace Module2_HW2_26052023
{
    /// <summary>
    /// Prises.
    /// </summary>
    public class Price
    {
        private const int Meat = 150;
        private const int Bread = 20;
        private const int Candies = 35;
        private const int Potato = 20;
        private const int Milk = 35;
        private const int Cheese = 60;
        private const int Groats = 17;
        private const int Bananas = 75;
        private const int Oil = 60;
        private const int Apples = 45;
        private const int Cookie = 55;
        private const int Orange = 55;

        /// <summary>
        /// Get good prise.
        /// </summary>
        /// <param name="good">
        /// Good.
        /// </param>
        /// <returns>
        /// Prise.
        /// </returns>
        public static int GetPrise(KindOfGoods good)
        {
            int prise = 0;
            switch (good)
            {
                case KindOfGoods.Meat:
                    prise = Meat;
                    break;
                case KindOfGoods.Bread:
                    prise = Bread;
                    break;
                case KindOfGoods.Candies:
                    prise = Candies;
                    break;
                case KindOfGoods.Potato:
                    prise = Potato;
                    break;
                case KindOfGoods.Milk:
                    prise = Milk;
                    break;
                case KindOfGoods.Cheese:
                    prise = Cheese;
                    break;
                case KindOfGoods.Groats:
                    prise = Groats;
                    break;
                case KindOfGoods.Bananas:
                    prise = Bananas;
                    break;
                case KindOfGoods.Oil:
                    prise = Oil;
                    break;
                case KindOfGoods.Apples:
                    prise = Apples;
                    break;
                case KindOfGoods.Cookie:
                    prise = Cookie;
                    break;
                case KindOfGoods.Orange:
                    prise = Orange;
                    break;
            }

            return prise;
        }
    }
}
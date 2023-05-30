///////////////////////////////////////
// Author: Tymoshchuk Maksym
// Created On : 24/05/2023
// Last Modified On :
// Description: User interface module
// Project: Module2_HW2_26052023
///////////////////////////////////////

namespace Module2_HW2_26052023
{
    using System;

    /// <summary>
    /// User interface class.
    /// </summary>
    public class UI
    {
        /// <summary>
        /// Print Banner.
        /// </summary>
        /// <param name="coords">
        /// coords.
        /// </param>
        public static void PrintBanner(CursorCoords coords)
        {
            Console.WriteLine("Choose goods:\n");

            Console.SetCursorPosition(
                coords.ShoppingCartLeftCursorPos,
                coords.ShoppingCarTopCursorPos - 2);

            Console.WriteLine("Shopping cart:");

            Console.SetCursorPosition(
               coords.TotalSumLeftBunnerCursorPos,
               coords.TotalSumTopBunnerCursorPos);
            Console.Write("Total cost: ");

            Console.SetCursorPosition(
              coords.ShoppingCarBunnertLeftCursorPos,
              coords.ShoppingCarBunnertTopCursorPos);

            Console.Write("Chosed goods: ");
        }

        /// <summary>
        /// Print total sum.
        /// </summary>
        /// <param name="coords">
        /// class coards.
        /// </param>
        /// <param name="sum">
        /// summ.
        /// </param>
        public static void PrintSummaryCost(CursorCoords coords, int sum)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(
                  coords.TotalSumLeftCursorPos + i,
                  coords.TotalSumTopCursorPos);

                Console.Write(" ");
            }

            Console.SetCursorPosition(
                  coords.TotalSumLeftCursorPos,
                  coords.TotalSumTopCursorPos);

            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(sum);
            Console.ForegroundColor = def;

            Console.SetCursorPosition(
               coords.LeftCursorPosition,
               coords.TopCursorPosition);
        }

        /// <summary>
        /// Print Goods for Choise.
        /// </summary>
        /// <param name="coords">
        /// Coordinates class.
        /// </param>
        public static void PrintAvailableGoods(CursorCoords coords)
        {
            const int LeftCursorPos = 4;
            int topPos = coords.GetDefTopPosition;

            foreach (var good in Enum.GetValues(typeof(KindOfGoods)))
            {
                Console.SetCursorPosition(LeftCursorPos, topPos);
                Console.Write($"{good}");
                ++topPos;
            }
        }

        /// <summary>
        /// Print marker chosed goods.
        /// </summary>
        /// <param name="purchases">
        /// goods marker.
        /// </param>
        /// <param name="coords">
        /// coors class.
        /// </param>
        public static void PrintChosedGoodsMarker(
            Purchases purchases,
            CursorCoords coords)
        {
            Console.SetCursorPosition(0, coords.GetDefTopPosition);

            for (int i = 0; i < purchases.ChosedGoods.Length; i++)
            {
                Console.WriteLine(purchases.ChosedGoods[i]);
            }

            Console.SetCursorPosition(
               coords.LeftCursorPosition,
               coords.TopCursorPosition);
        }

        /// <summary>
        /// Print what to chose and press.
        /// </summary>
        /// <param name="coords">
        /// coords.
        /// </param>
        public static void PrintWhatToDo(CursorCoords coords)
        {
            Console.SetCursorPosition(
                coords.InstructLeftCursorPos,
                coords.InstructTopCursorPos);
            Console.Write("\n\nИспользуйте стрелки вверх и " +
                "вниз для навигации.\n" +
                "Для выбора товара нажмите ");

            ChangeColor("пробел", ConsoleColor.Cyan);
            Console.Write("\nДля подтверждения, нажмите ");
            ChangeColor("enter\n", ConsoleColor.Green);

            Console.SetCursorPosition(
               coords.LeftCursorPosition,
               coords.TopCursorPosition);

            void ChangeColor(string str, ConsoleColor color)
            {
                ConsoleColor def = Console.ForegroundColor;
                Console.ForegroundColor = color;
                Console.Write(str);
                Console.ForegroundColor = def;
            }
        }

        /// <summary>
        /// печать корзины.
        /// </summary>
        /// <param name="coords">
        /// объект класса с координатами консоли.
        /// </param>
        /// <param name="shoppingCart">
        /// Объект класса корзины.
        /// </param>
        public static void PrinShoppingCart(
            CursorCoords coords,
            ShoppingCart shoppingCart)
        {
            Console.SetCursorPosition(
                coords.ChosedGoodLeftPos,
                coords.ChosedGoodTopPos);
            Console.Write(new string(' ', 70));
            Console.SetCursorPosition(
                coords.ChosedGoodLeftPos,
                coords.ChosedGoodTopPos);
            Array.Sort(shoppingCart.ListGoods);
            Console.Write(string.Join(" ", shoppingCart.ListGoods).Replace(
                "None",
                string.Empty).Trim());

            Console.SetCursorPosition(
              coords.LeftCursorPosition,
              coords.TopCursorPosition);
        }

        public static void PrintOrderConfirm(
            CursorCoords coords,
            string orderNunm)
        {
            Console.SetCursorPosition(
                coords.ConfirmOrderLeftPos,
                coords.ConfirmOrderTopPos);

            Console.Write("Оrder confirmed. Order num: ");
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(orderNunm);
            Console.ForegroundColor = def;
        }
    }
}

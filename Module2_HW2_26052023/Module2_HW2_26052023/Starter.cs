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
    using System.Threading;

    /// <summary>
    /// Shop Run class.
    /// </summary>
    public class Starter
    {
        private static Goods _goods;

        /// <summary>
        /// Lounch shop.
        /// </summary>
        public static void Run()
        {
            _goods = new Goods();

            CursorCoords cursorCoords = new CursorCoords(_goods.ListGoods.Length);
            Purchases purchases = new Purchases(_goods);
            ShoppingCart shoppingCart = new ShoppingCart();

            Console.WindowWidth = 150;
            UI.PrintBanner(cursorCoords);
            UI.PrintChosedGoodsMarker(purchases, cursorCoords);
            UI.PrintWhatToDo(cursorCoords);

            Console.SetCursorPosition(
               cursorCoords.LeftCursorPosition,
               cursorCoords.TopCursorPosition);

            ControlSymbols usreInput = ControlSymbols.None;

            do
            {
                if (Console.KeyAvailable)
                {
                    usreInput = (ControlSymbols)Console.ReadKey().Key;
                }

                switch (usreInput)
                {
                    case ControlSymbols.TopArrow:
                        cursorCoords.MoveCursorUP();
                        UI.PrintChosedGoodsMarker(purchases, cursorCoords);
                        break;
                    case ControlSymbols.DownArrow:

                        cursorCoords.MoveDown();
                        UI.PrintChosedGoodsMarker(purchases, cursorCoords);

                        break;
                    case ControlSymbols.Spacebar:

                        purchases.ProccessProduct(cursorCoords, shoppingCart);
                        UI.PrintChosedGoodsMarker(purchases, cursorCoords);
                        UI.PrinShoppingCart(cursorCoords, shoppingCart);
                        UI.PrintSummaryCost(cursorCoords, shoppingCart.Summ);

                        break;
                    case ControlSymbols.Enter:
                        string orderNum = shoppingCart.ConfirmOrder();
                        UI.PrintOrderConfirm(cursorCoords, orderNum);

                        break;
                    case ControlSymbols.LeftArrow:
                        cursorCoords.LeaveCursorPos();
                        break;
                    case ControlSymbols.RightArrow:
                        cursorCoords.LeaveCursorPos();
                        break;
                }

                usreInput = ControlSymbols.None;

            }
            while (usreInput != ControlSymbols.Escape);
        }
    }
}

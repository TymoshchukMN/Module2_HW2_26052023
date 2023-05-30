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
    /// Keep cursor coords.
    /// </summary>
    public class CursorCoords
    {
        private const ushort DefTopPosition = 2;
        private const ushort DefLeftPosition = 1;

        private int _instructLeftCursorPos;
        private int _topPos;
        private int _maxDownCursorPosition;
        private int _instructTopCursorPos;
        private int _shoppingCarBunnertLeftCursorPos = 30;
        private int _shoppingCartBunnerTopCursorPos = 2;
        private int _shoppingCartLeftCursorPos = 30;
        private int _shoppingCartTopCursorPos = 2;
        private int _totalSumBunnerLeftCursorPos;
        private int _totalSumBunnerTopCursorPos = 1;
        private int _totalSumLeftCursorPos;
        private int _totalSumTopCursorPos = 1;
        private int _chosedGoodLeftPos;
        private int _chosedGoodTopPos = 2;
        private int _confirmOrderLeftPos = 30;
        private int _confirmOrderTopPos = 10;

        /// <summary>
        /// Initializes a new instance of the <see cref="CursorCoords"/> class.
        /// </summary>
        /// <param name="goodsCount">
        /// count of goods for determain maxDownCursorPosition.
        /// </param>
        public CursorCoords(int goodsCount)
        {
            _topPos = DefTopPosition;
            _maxDownCursorPosition = goodsCount;
            _instructLeftCursorPos = 0;
            _instructTopCursorPos = _maxDownCursorPosition + 3;
            _totalSumBunnerLeftCursorPos = _shoppingCartLeftCursorPos;
            _totalSumLeftCursorPos = _totalSumBunnerLeftCursorPos + 15;
            _chosedGoodLeftPos = _shoppingCartLeftCursorPos + 15;
        }

        /// <summary>
        /// Gets.
        /// </summary>
        public int ChosedGoodLeftPos
        {
            get { return _chosedGoodLeftPos; }
        }

        /// <summary>
        /// Gets.
        /// </summary>
        public int ChosedGoodTopPos
        {
            get { return _chosedGoodTopPos; }
        }

        /// <summary>
        /// Gets.
        /// </summary>
        public int ShoppingCarBunnertLeftCursorPos
        {
            get { return _shoppingCarBunnertLeftCursorPos; }
        }

        /// <summary>
        /// Gets.
        /// </summary>
        public int ShoppingCarBunnertTopCursorPos
        {
            get { return _shoppingCartBunnerTopCursorPos; }
        }

        /// <summary>
        /// Gets Leftposition.
        /// </summary>
        public int LeftCursorPosition
        {
            get
            {
                return DefLeftPosition;
            }
        }

        /// <summary>
        /// Gets or sets and sets top cursor positions.
        /// </summary>
        public int TopCursorPosition
        {
            get { return _topPos; }
            set { _topPos = value; }
        }

        /// <summary>
        /// Gets .
        /// </summary>
        public ushort GetDefTopPosition
        {
            get { return DefTopPosition; }
        }

        /// <summary>
        /// Gets left position cursor for print instraction.
        /// </summary>
        public int InstructLeftCursorPos
        {
            get { return _instructLeftCursorPos; }
        }

        /// <summary>
        /// Gets top position cursor for print instraction.
        /// </summary>
        public int InstructTopCursorPos
        {
            get { return _instructTopCursorPos; }
        }

        /// <summary>
        /// Gets left position cursor for print Shopping cart.
        /// </summary>
        public int ShoppingCartLeftCursorPos
        {
            get { return _shoppingCartLeftCursorPos; }
        }

        /// <summary>
        /// Gets TOP position cursor for print Shopping cart.
        /// </summary>
        public int ShoppingCarTopCursorPos
        {
            get { return _shoppingCartTopCursorPos; }
        }

        /// <summary>
        /// Gets TOP position cursor for print Shopping cart.
        /// </summary>
        public int TotalSumLeftBunnerCursorPos
        {
            get { return _totalSumBunnerLeftCursorPos; }
        }

        /// <summary>
        /// Gets TOP position cursor for print Shopping cart.
        /// </summary>
        public int TotalSumTopBunnerCursorPos
        {
            get { return _totalSumBunnerTopCursorPos; }
        }

        /// <summary>
        /// Gets TOP position cursor for print Shopping cart.
        /// </summary>
        public int TotalSumLeftCursorPos
        {
            get { return _totalSumLeftCursorPos; }
        }

        /// <summary>
        /// Gets TOP position cursor for print Shopping cart.
        /// </summary>
        public int TotalSumTopCursorPos
        {
            get { return _totalSumTopCursorPos; }
        }

        /// <summary>
        /// Gets left cursor pos confirmation order.
        /// </summary>
        public int ConfirmOrderLeftPos
        {
            get { return _confirmOrderLeftPos; }
        }

        /// <summary>
        /// Gets top cursor pos confirmation order.
        /// </summary>
        public int ConfirmOrderTopPos
        {
            get { return _confirmOrderTopPos; }
        }

        /// <summary>
        /// Move Cursor UP.
        /// </summary>
        public void MoveCursorUP()
        {
            if (_topPos - 1 >= DefTopPosition)
            {
                --_topPos;
                Console.SetCursorPosition(
                    LeftCursorPosition,
                    TopCursorPosition);
            }
            else
            {
                Console.SetCursorPosition(
                        LeftCursorPosition,
                        TopCursorPosition);
            }
        }

        /// <summary>
        /// Move Cursor Down.
        /// </summary>
        public void MoveDown()
        {
            if (_topPos <= _maxDownCursorPosition)
            {
                ++_topPos;
                Console.SetCursorPosition(
                   LeftCursorPosition,
                   TopCursorPosition);
            }
            else
            {
                Console.SetCursorPosition(
                   LeftCursorPosition,
                   TopCursorPosition);
            }
        }

        /// <summary>
        /// Leave cursor in current pos.
        /// </summary>
        public void LeaveCursorPos()
        {
            Console.SetCursorPosition(LeftCursorPosition, TopCursorPosition);
        }
    }
}

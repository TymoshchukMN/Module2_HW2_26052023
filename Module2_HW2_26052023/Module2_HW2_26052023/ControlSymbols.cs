//////////////////////////////////////////////////////////////////
// Author : Tymoshchuk Maksym
// Created On : 17/10/2022
// Last Modified On : 20/10/2022
// Description: enum for contain control symbols, for user actions
// Project: Module2_HW2_26052023
//////////////////////////////////////////////////////////////////

namespace Module2_HW2_26052023
{
    /// <summary>
    /// Перечисление управляющих символов
    /// </summary>
    public enum ControlSymbols : ushort
    {
        /// <summary>
        /// def.
        /// </summary>
        None = 0,

        /// <summary>
        /// TopArrow.
        /// </summary>
        TopArrow = 38,

        /// <summary>
        /// DownArrow.
        /// </summary>
        DownArrow = 40,

        /// <summary>
        /// RightArrow.
        /// </summary>
        RightArrow = 39,

        /// <summary>
        /// LeftArrow.
        /// </summary>
        LeftArrow = 37,

        /// <summary>
        /// Spacebar.
        /// </summary>
        Spacebar = 32,

        /// <summary>
        /// Escape.
        /// </summary>
        Escape = 27,

        /// <summary>
        /// Enter.
        /// </summary>
        Enter = 13,
    }
}
//-----------------------------------------------------------------------
// <copyright file="DvigWASD.cs" company="IVT-131">
// Copyright (c) IVT-131. All rights reserved.
// </copyright>
// <author>Лобачев Андрей</author>
// <author>Супрун Артем</author>
// <author>Дарий Олеся</author>
//-----------------------------------------------------------------------
namespace Multi2048
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Engine control from num keyboard 
    /// </summary>
    public class DvigNumPad : Motion
    {
        /// <summary>
        /// Updating of the network, by changing the argument mas
        /// </summary>
        /// <param name="s">Direction r l u d</param>
        /// <param name="x">Situation X new figures</param>
        /// <param name="y">Situation Y new figures</param>
        /// <param name="v">The new figure</param>
        /// <param name="mas">Source array</param>
        public override void UpdateLine(char s, int x, int y, int v, int[,] mas)
        {
        }

        /// <summary>
        /// Upgrading Using the buttons
        /// </summary>
        /// <param name="sendere">The object on which clicked</param>
        /// <param name="ee">Current press</param>
        /// <param name="mas">Source array</param>
        public override void UpdateKey(object sendere, KeyEventArgs ee, int[,] mas)
        {
            if (ee.KeyData == Keys.I)
            {
                this.DO("up", mas);
            }

            if (ee.KeyData == Keys.J)
            {
                this.DO("left", mas);
            }

            if (ee.KeyData == Keys.K)
            {
                this.DO("down", mas);
            }

            if (ee.KeyData == Keys.L)
            {
                this.DO("right", mas);
            }
        }
    }
}
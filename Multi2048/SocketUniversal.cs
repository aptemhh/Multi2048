//-----------------------------------------------------------------------
// <copyright file="SocketUniversal.cs" company="IVT-131">
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
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Subscribe to status
    /// </summary>
    /// <param name="s">Input status bar</param>
    public delegate void StatusGame(string s);

    /// <summary>
    /// Subscription and direction (x, y) number
    /// </summary>
    /// <param name="s">Direction r l u d</param>
    /// <param name="x">x coordinate</param>
    /// <param name="y">y coordinate</param>
    /// <param name="v">New figure</param>
    public delegate void InfoGame(char s, int x, int y, int v);

    /// <summary>
    /// Universal socket for connection
    /// </summary>
    public class SocketUniversal
    {
        /// <summary>
        /// Delegate game status
        /// </summary>
        private StatusGame statusGame;

        /// <summary>
        /// Delegate information about the game to the opponent
        /// </summary>
        private InfoGame infoGame;

        /// <summary>
        /// Sets delegate game status
        /// </summary>
        public StatusGame StatusGame
        {
            set { this.statusGame += value; }
        }

        /// <summary>
        /// Sets delegate information about the game to the opponent
        /// </summary>
        public InfoGame InfoGame
        {
            set { this.infoGame += value; }
        }

        /// <summary>
        /// Stream that reads socket
        /// </summary>
        public void Run() // поток, который читает сокет
        {
            for (;;)
            {
                if (this.statusGame != null)
                {
                    this.statusGame("статус");
                }

                if (this.infoGame != null)
                {
                    this.infoGame('R', 0, 0, 2);
                }

                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Writer in the socket stream
        /// </summary>
        /// <param name="s">Message to the socket</param>
        public void Write(string s)
        {
        }
    }
}

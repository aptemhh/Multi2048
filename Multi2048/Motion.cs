//-----------------------------------------------------------------------
// <copyright file="Motion.cs" company="IVT-131">
// Copyright (c) IVT-131. All rights reserved.
// </copyright>
// <author>Лобачев Андрей</author>
// <author>Супрун Артем</author>
// <author>Дарий Олеся</author>
//-----------------------------------------------------------------------
namespace Multi2048
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Abstract class engines
    /// </summary>
    public abstract class Motion
    {
        /// <summary>
        /// The delegate of the game account
        /// </summary>
        private ScoreGame scopeGame;

        /// <summary>
        /// Subject to randomness
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Sets to delegate action
        /// </summary>
        public ScoreGame SetScopeGame
        {
            set { this.scopeGame += value; }
        }

        /// <summary>
        /// Abstract method of updating via the network
        /// </summary>
        /// <param name="s">Direction r l u d</param>
        /// <param name="x">Coordinate X</param>
        /// <param name="y">Coordinate Y</param>
        /// <param name="v">The new figure</param>
        /// <param name="mas">Source array</param>
        public abstract void UpdateLine(char s, int x, int y, int v, int[,] mas);

        /// <summary>
        /// Abstract method of updating via the keyboard
        /// </summary>
        /// <param name="sendere">The object on which clicked</param>
        /// <param name="ee">Clicking properties</param>
        /// <param name="mas">Source array</param>
        public abstract void UpdateKey(object sendere, KeyEventArgs ee, int[,] mas);

        /// <summary>
        /// The new figure
        /// </summary>
        /// <param name="mas">The original array</param>
        public void NewTile(int[,] mas)
        {
            int cntr = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mas[i, j] == 0)
                    {
                        cntr++;
                    }
                }
            }

            for (int n = cntr; cntr > 0 && ((cntr - n) < 3) && n > 0;)
            {
                int x, y;
                x = this.rnd.Next(0, 4);
                y = this.rnd.Next(0, 4);
                if (mas[x, y] == 0)
                {
                    mas[x, y] = this.rnd.Next(0, 100) < 90 ? 2 : 4;
                    n--;
                    break;
                }
                else
                {
                    x = 0;
                    y = 0;
                    continue;
                }
            }
        }

        /// <summary>
        /// Moving towards chips
        /// </summary>
        /// <param name="a">Party Up Down Left Right</param>
        /// <param name="mas">Source array</param>
        public void MoveTile(string a, int[,] mas)
        {
            switch (a)
            {
                case "up":
                    for (int k = 0; k < 3; k++)
                    {
                        for (int j = 0; j < 4 - 1; j++)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i, j + 1];
                                    mas[i, j + 1] = 0;
                                }
                            }
                        }
                    }

                    break;
                case "down":
                    for (int k = 0; k < 3; k++)
                    {
                        for (int j = 4 - 1; j >= 1; j--)
                        {
                            for (int i = 0; i < 4; i++)
                            {
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i, j - 1];
                                    mas[i, j - 1] = 0;
                                }
                            }
                        }
                    }

                    break;
                case "left":
                    for (int k = 0; k < 3; k++)
                    {
                        for (int i = 0; i < 4 - 1; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i + 1, j];
                                    mas[i + 1, j] = 0;
                                }
                            }
                        }
                    }

                    break;
                case "right":
                    for (int k = 0; k < 3; k++)
                    {
                        for (int i = 4 - 1; i >= 1; i--)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i - 1, j];
                                    mas[i - 1, j] = 0;
                                }
                            }
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// Merge chips
        /// </summary>
        /// <param name="a">Direction Up Down Left Right</param>
        /// <param name="mas">The original array </param>
        public void StackTile(string a, int[,] mas)
        {
            switch (a)
            {
                case "up":
                    for (int j = 0; j < 4 - 1; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i, j + 1];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                this.scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i, j + 1] = v2;
                            }

                            v1 = 0;
                            v2 = 0;
                            this.MoveTile("up", mas);
                        }
                    }

                    break;
                case "down":
                    for (int j = 4 - 1; j >= 1; j--)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i, j - 1];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                this.scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i, j - 1] = v2;
                            }

                            this.MoveTile("down", mas);
                        }
                    }

                    break;
                case "left":
                    for (int i = 0; i < 4 - 1; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i + 1, j];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                this.scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i + 1, j] = v2;
                            }

                            this.MoveTile("left", mas);
                        }
                    }

                    break;
                case "right":
                    for (int i = 4 - 1; i >= 1; i--)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i - 1, j];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                this.scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i - 1, j] = v2;
                            }

                            this.MoveTile("right", mas);
                        }
                    }

                    break;
            }
        }

        /// <summary>
        /// The logic of the merger and the move
        /// </summary>
        /// <param name="a">Direction Up Down Left Right</param>
        /// <param name="mas">Source array</param>
        public void DO(string a, int[,] mas)
        {
            int[,] masOld = (int[,])mas.Clone();
            this.MoveTile(a, mas);
            this.StackTile(a, mas);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (mas[i, j] != masOld[i, j])
                    {
                        this.NewTile(mas);
                        return;
                    }
                }
            }
        }
    }
}

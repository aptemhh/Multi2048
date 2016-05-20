//-----------------------------------------------------------------------
// <copyright file="GamePanel.cs" company="IVT-131">
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
    /// Games panel DataGridView
    /// </summary>
    public class GamePanel : DataGridView
    {
        /// <summary>
        /// Engine delegate
        /// </summary>
        private Motion dvig;

        /// <summary>
        /// Subject to randomness
        /// </summary>
        private Random rnd = new Random();

        /// <summary>
        /// Delegate information panel
        /// </summary>
        private InfoGame infoPanel;

        /// <summary>
        /// Panel array for player 1
        /// </summary>
        private int[,] mas = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

        /// <summary>
        /// Panel array for player 2
        /// </summary>
        private int[,] mas2 = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };

        /// <summary>
        /// Delegate game status
        /// </summary>
        private StateGame stateGame;

        /// <summary>
        /// Delegate game account
        /// </summary>
        private ScoreGame scopeGame;

        /// <summary>
        /// Sets Installing the update on the information panel
        /// </summary>
        public InfoGame InfoPanel
        {
            set { this.infoPanel += value; }
        }

        /// <summary>
        /// Sets Installing the update on the status of the game
        /// </summary>
        public StateGame StateGame
        {
            set { this.stateGame = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Motion getDvig()
        {
            return dvig;
        }

        /// <summary>
        /// Sets Installing the addition points of the game
        /// </summary>
        public ScoreGame ScopeGame
        {
            set { this.scopeGame = value; }
        }

        /// <summary>
        /// Commissioning and installation panels
        /// </summary>
        public void Init()
        {
            for (int i = 0; i < 4; i++)
            {
                this.Columns.Add(new string(' ', 1), new string(' ', 1));
                this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.Rows.Add();
                this.Columns[i].Width = 60;
                this.Rows[i].Height = 60;
            }

            this.ColumnHeadersVisible = this.RowHeadersVisible = this.AllowUserToResizeColumns = this.AllowUserToResizeRows = this.AllowUserToAddRows = this.MultiSelect = false;
            this.ReadOnly = true;
            this.Size = new System.Drawing.Size(243, 243);
            this.GameStart();
            this.MasToGrid();
            this.SelectionChanged += (object sender, EventArgs e) =>
            {
                if (this.SelectedCells.Count > 0)
                {
                    if (this.SelectedCells[0] != null)
                    {
                        this.SelectedCells[0].Selected = false;
                    }
                }
            };
        }

        /// <summary>
        /// Display array on DataGridView
        /// </summary>
        public void MasToGrid()
        {
            for (int i = 0; i < this.RowCount; i++)
            {
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    if (this.mas[i, j] != 0)
                    {
                        this[i, j].Value = this.mas[i, j];
                    }
                    else
                    {
                        this[i, j].Value = new string(' ', 1);
                    }

                    if (this.mas[i, j] >= 2048)
                    {
                        this.stateGame("DID 2048");
                    }
                }
            }
        }

        /// <summary>
        /// Updating the keyboard
        /// </summary>
        /// <param name="sendere">Clicking object</param>
        /// <param name="ee">Clicking properties</param>
        public void UpdateKey(object sendere, KeyEventArgs ee)
        {
            if (this.dvig != null)
            {
                this.dvig.UpdateKey(sendere, ee, this.mas);
            }

            if (this.infoPanel != null)
            {
                this.infoPanel('p', 0, 0, 2); // сообщение направления и координаты с появившейся цифрой
            }

            this.MasToGrid();
        }

        /// <summary>
        /// Updating the line
        /// </summary>
        /// <param name="s">Direction r l u d</param>
        /// <param name="x">Position X</param>
        /// <param name="y">Position Y</param>
        /// <param name="v">The new figure</param>
        public void UpdateLine(char s, int x, int y, int v)
        {
            if (this.dvig != null)
            {
                this.dvig.UpdateLine(s, x, y, v, this.mas);
            }
        }

        /// <summary>
        /// Installation of the new engine
        /// </summary>
        /// <param name="dvigi">New engine</param>
        public void SetDvig(Motion dvigi)
        {
            this.dvig = dvigi;
            this.dvig.SetScopeGame = (int i) =>
            {
                if (this.scopeGame != null)
                {
                    this.scopeGame(i);
                }
            };
        }

        /// <summary>
        /// Setting Game Launch
        /// </summary>
        public void GameStart()
        {
            int x, y, cntgen = 0;
            for (;;)
            {
                x = this.rnd.Next(0, 4);
                y = this.rnd.Next(0, 4);
                if (this.mas[x, y] == 0)
                {
                    this.mas[x, y] = this.rnd.Next(0, 100) < 90 ? 2 : 4;
                    cntgen++;
                }
                else
                {
                    x = 0;
                    y = 0;
                    continue;
                }

                if (cntgen == 2) 
                { 
                    break; 
                }
            }
        }
    }
}

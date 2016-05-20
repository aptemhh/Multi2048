//-----------------------------------------------------------------------
// <copyright file="MainMenu_Form.cs" company="IVT-131">
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
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Main menu form
    /// </summary>
    public partial class MainMenuForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainMenuForm"/> class.
        /// </summary>
        public MainMenuForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Allows to start a new game
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>
        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame_Form newgameForm = new NewGame_Form();
            newgameForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Allows to read the game rules
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>
        private void HelpButton_Click(object sender, EventArgs e)
        {
            string message = "Целью игры является получение плитки номинала «2048».\r\n\r\nВ каждом раунде появляется плитка номинала «2» (с вероятностью 90 %) или «4» (с вероятностью 10 %).\r\nИгрок может скинуть все плитки игрового поля в одну из 4 сторон. Если при сбрасывании две плитки одного номинала «налетают» одна на другую, то они слипаются в одну, номинал которой равен сумме соединившихся плиток. После каждого хода на свободной секции поля появляется новая плитка номиналом «2» или «4». \r\nЕсли при нажатии кнопки местоположение плиток или их номинал не изменится, то ход не совершается.\r\nЗа каждое соединение игровые очки увеличиваются на номинал получившейся плитки.\r\nИгра заканчивается поражением, если после очередного хода невозможно совершить действие.";
            string caption = "Правила игры";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
    }
}

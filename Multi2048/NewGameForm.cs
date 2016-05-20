//-----------------------------------------------------------------------
// <copyright file="NewGameForm.cs" company="IVT-131">
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
    /// New game form
    /// </summary>
    public partial class NewGame_Form : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewGame_Form"/> class.
        /// </summary>
        public NewGame_Form()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Button that allows to start single play mode
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>
        private void SingleStartButton_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Size = new System.Drawing.Size(350, 400);
            gameForm.Text = "Одиночная игра";
            gameForm.Show();
            this.Close();
        }

        /// <summary>
        /// Button that allows to change multiplayer mode
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>
        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            MultiplayerWindow multiplayerWindow = new MultiplayerWindow();
            multiplayerWindow.Show();
            this.Hide();
        }
    }
}

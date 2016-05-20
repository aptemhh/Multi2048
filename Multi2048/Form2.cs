//-----------------------------------------------------------------------
// <copyright file="Form2.cs" company="IVT-131">
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
    /// Form that allows to change game type
    /// </summary>
    public partial class GameTypeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GameTypeForm"/> class.
        /// </summary>
        public GameTypeForm()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Button that starts time mode
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>
        private void TimeModeStart_Button_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Size = new System.Drawing.Size(660, 400);
            gameForm.Text = "Игра на время";
            gameForm.Show();
            this.Close();
        }

        /// <summary>
        /// Button that starts move limit mode
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>
        private void MoveCountMode_Button_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Size = new System.Drawing.Size(660, 400);
            gameForm.Text = "Игра с ограниченным количеством ходов";
            gameForm.Show();
            this.Close();
        }
    }
}

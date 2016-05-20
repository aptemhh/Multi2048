//-----------------------------------------------------------------------
// <copyright file="MultiplayerWindow.cs" company="IVT-131">
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
    /// Form that allows to select multiplayer mode
    /// </summary>
    public partial class MultiplayerWindow : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiplayerWindow"/> class.
        /// </summary>
        public MultiplayerWindow()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Allows to start local multiplayer game
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>
        private void StartLocal_Click(object sender, EventArgs e)
        {
            GameTypeForm gameTypeForm = new GameTypeForm();
            gameTypeForm.Show();
            this.Close();
        }


        private void StartOnLine_Click(object sender, EventArgs e)
        {
            Connect Connect = null;
            if (Connect == null)
            {
                Connect = new Connect();
                Connect.Show();
            }

        }
        /// <summary>
        /// Allows to start online game
        /// </summary>
        /// <param name="sender">The object on which clicked</param>
        /// <param name="e">Event argument</param>

    }
}

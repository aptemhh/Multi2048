//-----------------------------------------------------------------------
// <copyright file="Form1.cs" company="IVT-131">
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
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;
 
    /// <summary>
    /// Delegate game account
    /// </summary>
    /// <param name="count">Number of points</param>
    public delegate void ScoreGame(int count);

    /// <summary>
    /// Game status
    /// </summary>
    /// <param name="s">The status bar</param>
    public delegate void StateGame(string s);

    /// <summary>
    /// Game form
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// The first game pad
        /// </summary>
        private GamePanel gamePanel1;

        /// <summary>
        /// The object for the network information
        /// </summary>
        private SocketUniversal socketUniversal;

        /// <summary>
        /// The stream for reading socket
        /// </summary>
        private Thread socketUniversalThread;

        /// <summary>
        /// Caption account
        /// </summary>
        private Label label;

        /// <summary>
        /// Counter account
        /// </summary>
        private int t = 0;

        /// <summary>
        /// Initializes a new instance of the <see cref="Form1"/> class.
        /// </summary>
        public Form1()
        {
            this.InitializeComponent();
        }
        
        /// <summary>
        /// Initialization ds
        /// </summary>
        public void Init()
        {
            
            this.socketUniversal = new SocketUniversal();
            this.gamePanel1 = new GamePanel();
            this.gamePanel1.Init();
            this.gamePanel1.SetDvig(new DvigWASD());
            this.gamePanel1.Location = new System.Drawing.Point(128, 73);
            this.label = new Label();
            this.label.Location = new System.Drawing.Point(245, 10);
            this.label.Text = "0";
            this.Controls.Add(this.label);
            this.Controls.Add(this.gamePanel1);
        }

        /// <summary>
        /// Subscription all
        /// </summary>
        public void Subscribe()
        {
            this.socketUniversalThread = new Thread(this.socketUniversal.Run);
            this.socketUniversalThread.Start(); // запуск чтения сокета
            this.gamePanel1.InfoPanel = (char s, int x, int y, int v) =>
            {
                this.socketUniversal.Write("sdfsdf"); // сообщение состояния панели соперника
            };
            this.socketUniversal.StatusGame = (string s) =>
            {
            }; // подписка на статус
            this.KeyUp += (object sendere, KeyEventArgs ee) =>
            {
                if (ee.KeyCode != Keys.F11)
                {
                    this.gamePanel1.UpdateKey(sendere, ee); // подписка на клавиатуру
                }
            };
            this.socketUniversal.InfoGame = (char s, int x, int y, int v) =>
            {
                this.gamePanel1.UpdateLine(s, x, y, v); // подписка на сеть
            };
            this.gamePanel1.ScopeGame = (int i) =>
            {
                this.t += i;
                this.label.Text = t.ToString();
            };
            this.gamePanel1.StateGame = (string s) =>
            {
                if (s.Equals("DID 2048"))
                {
                    this.gamePanel1.SetDvig(new DvigStop());
                }
            };
        }

        /// <summary>
        /// Download form
        /// </summary>
        /// <param name="sender"> Object sender</param>
        /// <param name="e"> Button e </param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Init();
            this.Subscribe();
        }

        /// <summary>
        /// Form Closing
        /// </summary>
        /// <param name="sender">Object sender</param>
        /// <param name="e">Button e</param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.socketUniversalThread.Abort();
        }
    }
}
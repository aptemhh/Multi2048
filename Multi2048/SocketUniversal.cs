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
    using System.Net;
    using System.Net.Sockets;
    using System.IO;

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

        static NetworkStream socket;
        /// <summary>
        /// Stream that reads socket
        /// </summary>
        public void Run() // поток, который читает сокет
        {
            IPHostEntry ipHost = Dns.GetHostEntry("127.0.0.1");
            IPAddress ipAddr = ipHost.AddressList[0];
            TcpListener tcpListener = new TcpListener(ipAddr, 65125);
            tcpListener.Start();


            String[] str;
            if(socket!=null)
            for (;;)
            {
                BinaryReader binR = new BinaryReader(socket);
                String s=binR.ReadString();
                String sr = s.Substring(0, 4);
                if (sr.Equals("INFO"))
                {
                    s=s.Substring(4);
                    str=s.Split(';');
                    Char a=str[0][0];
                    short x;
                    Int16.TryParse(str[1],out x);
                }
                if (this.statusGame != null)
                {
                    this.statusGame("статус");
                }

                if (this.infoGame != null)
                {
                    this.infoGame('R', 0, 0, 2);
                }
               
               
            }
        }

        /// <summary>
        /// Writer in the socket stream
        /// </summary>
        /// <param name="s">Message to the socket</param>
        public void Write(string s)
        {
           // socket.Write(Encoding.UTF8.GetBytes(s));
        }

        public SocketUniversal(NetworkStream _socket)
        {
            socket = _socket;
        }
        public SocketUniversal()
        {
        }
    }
}

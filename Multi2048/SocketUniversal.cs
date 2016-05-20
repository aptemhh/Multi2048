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

        /// <summary>
        /// Stream that reads socket
        /// </summary>
        public void Run() // поток, который читает сокет
        {
            IPHostEntry ipHost = Dns.GetHostEntry("127.0.0.1");
            IPAddress ipAddr = ipHost.AddressList[0];
            TcpListener tcpListener = new TcpListener(ipAddr, 65125);
            tcpListener.Start();



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
                Socket clientSocket = tcpListener.AcceptSocket();
 
                NetworkStream netStream = new NetworkStream(clientSocket);
                BinaryWriter binWriter = new BinaryWriter(netStream);
                string data = null;
                byte[] bytes = new byte[1024];
                int bytesRec = clientSocket.Receive(bytes);
                
                data = Encoding.UTF8.GetString(bytes, 0, bytesRec);
                
                string theReply1 = this.infoGame.ToString();
                string theReply2 = this.StatusGame.ToString();
                byte[] msg1 = Encoding.UTF8.GetBytes(theReply1);
                byte[] msg2 = Encoding.UTF8.GetBytes(theReply2);
                clientSocket.Send(msg1);
                clientSocket.Send(msg2);
                
                clientSocket.Shutdown(SocketShutdown.Both);

 
                clientSocket.Close();



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

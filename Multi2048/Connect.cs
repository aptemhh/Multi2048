using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;

public delegate void StatusGame(string s);


public delegate void InfoGame(char s, int x, int y, int v);
namespace Multi2048
{

    public partial class Connect : Form
    {
        private StatusGame statusGame;


        private InfoGame infoGame;

        public StatusGame StatusGame
        {
            set { this.statusGame += value; }
        }

 
        public InfoGame InfoGame
        {
            set { this.infoGame += value; }
        }
 
        public Connect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            TcpClient serverSocket;
            serverSocket = new TcpClient("localhost", 65125);
            NetworkStream netStream = serverSocket.GetStream();
             BinaryWriter binW = new BinaryWriter(netStream);
            BinaryReader binReader = new BinaryReader(netStream);
            string message1 = this.statusGame.ToString();
            string message2 = this.infoGame.ToString();

            binW.Write(Encoding.UTF8.GetBytes(message1));
            binW.Write(Encoding.UTF8.GetBytes(message2));

            serverSocket.Close();
 


        }
    }
}

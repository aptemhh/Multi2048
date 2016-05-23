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
            string localhost = textBox1.Text;
            int number = Convert.ToInt32(textBox2.Text);
            
            TcpClient serverSocket;
            serverSocket = new TcpClient(localhost, number);
            new SocketUniversal(serverSocket.GetStream());
 


        }
    }
}

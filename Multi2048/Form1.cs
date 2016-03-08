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

namespace Multi2048
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SocketUniversal socketUniversal = new SocketUniversal();
        DvigOnLine dvig = new DvigOnLine();//какой-то класс
        Thread a;
        private void Form1_Load(object sender, EventArgs e)
        {
            socketUniversal.MyEvent2 += (Char s, int x, int y, int v) =>
            {
                dvig.Set(s, x, y, v);
            };//подписка на вызов метода
            socketUniversal.MyEvent += (String s) =>
            {
                status(s);
            };//подписка на статус
            a = new Thread(socketUniversal.run);
            a.Start();//запуск чтения сокета
            KeyUp += (object sendere, KeyEventArgs ee) => {
                //подписка на клаву
            };
        }
        public void status(String s)
        {
        }





    }
}

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
    public delegate void ScoreGame(int count);//подписка на счет
    public delegate void StateGame(String s);//подписка на счет
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SocketUniversal socketUniversal;
       
        Thread a;
        GamePanel gamePanel1;
        Label label;
        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            subscribe();
        }
        public void status(String s)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            a.Abort();
        }
        int t = 0;
        public void init()
        {
            socketUniversal = new SocketUniversal();
            gamePanel1 = new GamePanel();
            gamePanel1.init();
            gamePanel1.SetDvig(new DvigWASD());
            gamePanel1.Location = new System.Drawing.Point(269, 73);

            label = new Label();
            label.Location = new System.Drawing.Point(10, 10);
            label.Text = "0";
            Controls.Add(label);

            Controls.Add(gamePanel1);
        }
        public void subscribe()
        {
            a = new Thread(socketUniversal.run);
            a.Start();//запуск чтения сокета

            gamePanel1.infoPanel += (Char s, int x, int y, int v) =>
            {
                socketUniversal.write("sdfsdf");//сообщение состояния панели соперника
            };
            socketUniversal.MyEvent += (String s) =>
            {
                status(s);
            };//подписка на статус
            

            KeyUp += (object sendere, KeyEventArgs ee) =>
            {
                if(ee.KeyCode!=Keys.F11)
                gamePanel1.UpdateKey(sendere, ee);// подписка на клавиатуру
            };

            socketUniversal.MyEvent2 += (Char s, int x, int y, int v) =>
            {
                gamePanel1.UpdateLine(s, x, y, v);//подписка на сеть
                 
            };

            gamePanel1.scopeGame += (int i) =>
            {
                t +=i;
                label.Text = t+"";
            };
            gamePanel1.stateGame += (String s) =>
            {
                if (s.Equals("DID 2048"))
                {
                    gamePanel1.SetDvig(new DvigStop());
                }
            };
        }


          
    }
  
}





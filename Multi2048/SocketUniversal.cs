using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multi2048
{
    public delegate void StatusGame(String s);//подписка на статус
    public  delegate void InfoGame(Char s, int x, int y, int v);//подписка на направление и (x,y) цифра
    class SocketUniversal
    {
        //Socket s;
        public StatusGame MyEvent; // Старт 1-3
        public InfoGame MyEvent2; // Событие
        public SocketUniversal()//(Socket _s){s=_s;
        {

        }
        public void run()// поток, который читает сокет
        {
            for (; ; )
            {
                    if (MyEvent != null)
                        MyEvent("статус");
                    if (MyEvent2 != null)//направление
                        MyEvent2('R', 0, 0, 2);

                //чтение, обработка
                
                Thread.Sleep(1000);
            }
        }
        public void write(String s)
        {
        }


    }
}

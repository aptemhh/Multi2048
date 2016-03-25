using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi2048
{
    
    abstract class Motion//интерфейс двигателя
    {
        public ScoreGame scopeGame;
        public abstract int[,] UpdateLine(Char s, int x, int y, int v, int[,] mas);
        public abstract int[,] UpdateKey(object sendere, KeyEventArgs ee, int[,] mas);


    }
}

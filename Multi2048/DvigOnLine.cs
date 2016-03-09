using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi2048
{
    class DvigOnLine : Motion
    {
        int scope = 0;
        public override int[,] UpdateLine(Char s, int x, int y, int v, int[,] mas)
        {
            if (scopeGame != null) 
            scopeGame(scope++);
            return mas; 
        }
        public override int[,] UpdateKey(object sendere, KeyEventArgs ee, int[,] mas)
        {
            if (scopeGame != null) 
            scopeGame(scope++);
            return mas;
        }
    }
}

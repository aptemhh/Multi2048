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
        public override void UpdateLine(Char s, int x, int y, int v, int[,] mas)
        {
             
        }
        public override void UpdateKey(object sendere, KeyEventArgs ee, int[,] mas)
        {
            if (ee.KeyData == Keys.W)
            {

            }
            if (scopeGame != null)
                scopeGame(scope++);
            
        }
    }
}

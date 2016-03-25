using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi2048
{
    class DvigWASD : Motion
    {

        int scope = 0;
        public override int[,] UpdateLine(Char s, int x, int y, int v, int[,] mas)
        {
            return mas;
        }
        public override int[,] UpdateKey(object sendere, KeyEventArgs ee, int[,] mas)
        {
            if (ee.KeyData == Keys.W)
            {
                MoveTile("up", mas);
            }
            if (ee.KeyData == Keys.A)
            {
                MoveTile("left", mas);
            }
            if (ee.KeyData == Keys.S)
            {
                MoveTile("down", mas);
            }
            if (ee.KeyData == Keys.D)
            {
                MoveTile("right", mas);
            }

            if (scopeGame != null)
                scopeGame(scope++);
            return mas;
        }
    }
}
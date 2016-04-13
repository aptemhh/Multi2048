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
        public override void UpdateLine(Char s, int x, int y, int v, int[,] mas)
        {
        }
        public override void UpdateKey(object sendere, KeyEventArgs ee, int[,] mas)
        {
            if (ee.KeyData == Keys.W)
            {
                DO("up", mas);
            }
            if (ee.KeyData == Keys.A)
            {
                DO("left", mas);
            }
            if (ee.KeyData == Keys.S)
            {
                DO("down", mas);
            }
            if (ee.KeyData == Keys.D)
            {
                DO("right", mas);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi2048
{
    class DvigStop : Motion
    {

        public override int[,] UpdateLine(Char s, int x, int y, int v, int[,] mas)
        {

            return mas;
        }
        public override int[,] UpdateKey(object sendere, KeyEventArgs ee, int[,] mas)
        {

            return mas;
        }
    }
}

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
        public override void UpdateLine(Char s, int x, int y, int v, int[,] mas)
        {
            
        }
        public override void UpdateKey(object sendere, KeyEventArgs ee, int[,] mas)
        {
            if (ee.KeyData == Keys.W)
            {
                MoveTile("up", mas);
                StackTile("up", mas);
            }
            if (ee.KeyData == Keys.A)
            {
                MoveTile("left", mas);
                StackTile("left", mas);
            }
            if (ee.KeyData == Keys.S)
            {
                MoveTile("down", mas);
                StackTile("down", mas);
            }
            if (ee.KeyData == Keys.D)
            {
                MoveTile("right", mas);
                StackTile("right", mas);
            }
            NewTile(mas);
            

            
        }
    }
}
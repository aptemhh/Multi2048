using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi2048
{
    class GamePanel : DataGridView
    {
        int[,] mas = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        Motion dvig;
        public ScoreGame scopeGame;
        public void UpdateKey(object sendere, KeyEventArgs ee)
        {
            if (dvig != null)
                mas = dvig.UpdateKey(sendere, ee, mas);
        }
        public void UpdateLine(Char s, int x, int y, int v)
        {
            if (dvig != null)
                mas = dvig.UpdateLine(s, x, y, v, mas);
        }
        public void SetDvig(Motion _dvig)
        {
            dvig = _dvig;
            dvig.scopeGame += (int i) => {
                if (scopeGame!=null)
                scopeGame(i); 
            };
        }

    }
}

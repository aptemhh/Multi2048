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
        public void init()
        {
            Columns.Add("dsf", "sdf");
            Columns.Add("dsf", "sdf");
            Columns.Add("dsf", "sdf");
            Columns.Add("dsf", "sdf");
            Rows.Add();
            Rows.Add();
            Rows.Add();
            Rows.Add();
            ColumnHeadersVisible = false;
            RowHeadersVisible = false;
            ReadOnly = true;
            Columns[0].Width = 40;
            Columns[1].Width = 40;
            Columns[2].Width = 40;
            Columns[3].Width = 40;
            Rows[0].Height = 40;
            Rows[1].Height = 40;
            Rows[2].Height = 40;
            Rows[3].Height = 40;
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            AllowUserToAddRows = false;
            MultiSelect=false;


        }

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

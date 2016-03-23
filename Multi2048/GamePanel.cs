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
        public InfoGame infoPanel;
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
            for (int i = 0; i < 4; i++)
            {
                Columns[i].Width = 60;
                Rows[i].Height = 60;
            }
            AllowUserToResizeColumns = false;
            AllowUserToResizeRows = false;
            AllowUserToAddRows = false;
            MultiSelect = false;
            Size = new System.Drawing.Size(243, 243);
        }

        int[,] mas = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        Motion dvig;
        public ScoreGame scopeGame;
        public void UpdateKey(object sendere, KeyEventArgs ee)
        {
            if (dvig != null)
                mas = dvig.UpdateKey(sendere, ee, mas);
            infoPanel('p', 0, 0, 2);//сообщение направления и координаты с появившейся цифрой
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

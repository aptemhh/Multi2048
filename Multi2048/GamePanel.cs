﻿using System;
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
            Columns.Add("", "");
            Columns.Add("", "");
            Columns.Add("", "");
            Columns.Add("", "");
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
            mas = GameStart();
            MasToGrid();
            this.SelectionChanged += (object sender, EventArgs e) =>
            {
              if(SelectedCells[0]!=null)
                    SelectedCells[0].Selected = false;
            };
        }
        public StateGame stateGame;
        public int[,] mas = new int[,] { { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } };
        Motion dvig;
        public ScoreGame scopeGame;

        public void MasToGrid()
        {
            for (int i = 0; i < this.RowCount; i++)
                for (int j = 0; j < this.ColumnCount; j++)
                {
                    this[i, j].Value = mas[i, j];
                    if (mas[i, j] >= 2048) stateGame("DID 2048");
                }
        }

        public void UpdateKey(object sendere, KeyEventArgs ee)
        {
            
            if (dvig != null)
               dvig.UpdateKey(sendere, ee, mas);
            infoPanel('p', 0, 0, 2);//сообщение направления и координаты с появившейся цифрой
            MasToGrid();
        }

        public void UpdateLine(Char s, int x, int y, int v)
        {
           // if (dvig != null)
                //dvig.UpdateLine(s, x, y, v, mas);
        }

        public void SetDvig(Motion _dvig)
        {
            dvig = _dvig;
            dvig.scopeGame += (int i) => {
                if (scopeGame!=null)
                scopeGame(i); 
            };
        }
        Random rnd = new Random();

        public int[,] GameStart()
        {
            int[,] mas=new int[4,4];
            int x, y, cntgen = 0;
            for (; ; )
            {
                
                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
                if (mas[x, y] == 0)
                {
                    mas[x, y] = rnd.Next(0, 100) < 90 ? 2 : 4;
                    cntgen++;
                }
                else
                {
                    x = 0;
                    y = 0;
                    continue;
                }
                if (cntgen == 2) break;
            }
            return mas;
        }

       





    }
}

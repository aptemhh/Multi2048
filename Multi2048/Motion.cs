using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi2048
{

    abstract class Motion//интерфейс двигателя
    {
        public ScoreGame scopeGame;
        public abstract void UpdateLine(Char s, int x, int y, int v, int[,] mas);
        public abstract void UpdateKey(object sendere, KeyEventArgs ee, int[,] mas);
        Random rnd = new Random();
        public void NewTile(int[,] mas)
        {
            int cntr = 0;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    if (mas[i, j] == 0)
                        cntr++;

            for (int n = cntr; cntr > 0 && ((cntr - n) < 3) && n > 0; )
            {

                int x, y;
                x = rnd.Next(0, 4);
                y = rnd.Next(0, 4);
                if (mas[x, y] == 0)
                {
                    mas[x, y] = rnd.Next(0, 100) < 90 ? 2 : 4;
                    n--;
                    break;
                }
                else
                {
                    x = 0;
                    y = 0;
                    continue;
                }
            }
        }
        public void MoveTile(string a, int[,] mas)
        {
            switch (a)
            {
                case "up":
                    for (int k = 0; k < 3; k++)
                        for (int j = 0; j < 4 - 1; j++)
                            for (int i = 0; i < 4; i++)
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i, j + 1];
                                    mas[i, j + 1] = 0;
                                }
                    break;
                case "down":
                    for (int k = 0; k < 3; k++)
                        for (int j = 4 - 1; j >= 1; j--)
                            for (int i = 0; i < 4; i++)
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i, j - 1];
                                    mas[i, j - 1] = 0;
                                }
                    break;
                case "left":
                    for (int k = 0; k < 3; k++)
                        for (int i = 0; i < 4 - 1; i++)
                            for (int j = 0; j < 4; j++)
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i + 1, j];
                                    mas[i + 1, j] = 0;
                                }
                    break;
                case "right":
                    for (int k = 0; k < 3; k++)
                        for (int i = 4 - 1; i >= 1; i--)
                            for (int j = 0; j < 4; j++)
                                if (mas[i, j] == 0)
                                {
                                    mas[i, j] = mas[i - 1, j];
                                    mas[i - 1, j] = 0;
                                }
                    break;
            }
        }

        public void StackTile(string a, int[,] mas)
        {

            switch (a)
            {
                case "up":
                    for (int j = 0; j < 4 - 1; j++)
                        for (int i = 0; i < 4; i++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i, j + 1];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i, j + 1] = v2;
                            }
                            v1 = 0;
                            v2 = 0;
                            MoveTile("up", mas);
                        }
                    break;
                case "down":
                    for (int j = 4 - 1; j >= 1; j--)
                        for (int i = 0; i < 4; i++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i, j - 1];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i, j - 1] = v2;
                            }
                            MoveTile("down", mas);
                        }

                    break;
                case "left":
                    for (int i = 0; i < 4 - 1; i++)
                        for (int j = 0; j < 4; j++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i + 1, j];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i + 1, j] = v2;
                            }
                            MoveTile("left", mas);
                        }

                    break;
                case "right":
                    for (int i = 4 - 1; i >= 1; i--)
                        for (int j = 0; j < 4; j++)
                        {
                            int v1, v2;
                            v1 = mas[i, j];
                            v2 = mas[i - 1, j];
                            if (v1 == v2 && v1 != 0)
                            {
                                v1 = 2 * v2;
                                scopeGame(v1);
                                v2 = 0;
                                mas[i, j] = v1;
                                mas[i - 1, j] = v2;
                            }
                            MoveTile("right", mas);
                        }

                    break;
            }
        }
        public void DO(string a, int[,] mas)
        {
            int[,] masOld = (int[,])mas.Clone();
            MoveTile(a, mas);
            StackTile(a, mas);
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    if (mas[i, j] != masOld[i, j])
                    {
                        NewTile(mas);
                        return;
                    }
                }
        }
        /*
        void MoveAvailableLeft(int[,] mas)
        {
            int cntl = 0;

            for (int i = 0; i < 4 - 1; i++)
                for (int j = 0; j < 4; j++)
                    if ((mas[i, j] != 0 && mas[i + 1, j] != mas[i, j]) || mas[i, j] == 0 && mas[i + 1, j] == 0)
                        cntl++;
            if (cntl == 12)
                button3.Enabled = false;
            else button3.Enabled = true;

        }

        void MoveAvailableRight(int[,] mas)
        {
            int cntr = 0;

            for (int i = 4 - 1; i > 0; i--)
                for (int j = 0; j < 4; j++)
                    if ((mas[i, j] != 0 && mas[i - 1, j] != mas[i, j]) || mas[i, j] == 0 && mas[i - 1, j] == 0)
                        cntr++;
            if (cntr == 12)
                button4.Enabled = false;
            else button4.Enabled = true;

        }

        void MoveAvailableUp(int[,] mas)
        {
            int cntu = 0;

            for (int j = 0; j < 4 - 1; j++)
                for (int i = 0; i < 4; i++)
                    if ((mas[i, j] != 0 && mas[i, j + 1] != mas[i, j]) || mas[i, j] == 0 && mas[i, j + 1] == 0)
                        cntu++;
            if (cntu == 12)
                StateGame("UpDenied");
            else button2.Enabled = true;

        }

        void MoveAvailableDown(int[,] mas)
        {
            int cntd = 0;

            for (int j = 4 - 1; j > 0; j--)
                for (int i = 0; i < 4; i++)
                    if ((mas[i, j] != 0 && mas[i, j - 1] != mas[i, j]) || mas[i, j] == 0 && mas[i, j - 1] == 0)
                        cntd++;
            if (cntd == 12)
                button5.Enabled = false;
            else button5.Enabled = true;

        }
        */
    }
}

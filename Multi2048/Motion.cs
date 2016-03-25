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
        public abstract int[,] UpdateLine(Char s, int x, int y, int v, int[,] mas);
        public abstract int[,] UpdateKey(object sendere, KeyEventArgs ee, int[,] mas);

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
        }
    }

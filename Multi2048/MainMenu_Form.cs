using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi2048
{
    public partial class MainMenu_Form : Form
    {
        public MainMenu_Form()
        {
            this.InitializeComponent();
        }

        private void NewGameButton_Click(object sender, EventArgs e)
        {
            NewGame_Form ngForm = new NewGame_Form();
            ngForm.Show();
            this.Hide();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            string message = "Целью игры является получение плитки номинала «2048».\r\n\r\nВ каждом раунде появляется плитка номинала «2» (с вероятностью 90 %) или «4» (с вероятностью 10 %).\r\nНажатием стрелки игрок может скинуть все плитки игрового поля в одну из 4 сторон. Если при сбрасывании две плитки одного номинала «налетают» одна на другую, то они слипаются в одну, номинал которой равен сумме соединившихся плиток. После каждого хода на свободной секции поля появляется новая плитка номиналом «2» или «4». \r\nЕсли при нажатии кнопки местоположение плиток или их номинал не изменится, то ход не совершается.\r\nЗа каждое соединение игровые очки увеличиваются на номинал получившейся плитки.\r\nИгра заканчивается поражением, если после очередного хода невозможно совершить действие.";
            string caption = "Правила игры";
            MessageBox.Show(message, caption, MessageBoxButtons.OK);
        }
    }
}

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
    public partial class NewGame_Form : Form
    {
        public NewGame_Form()
        {
            InitializeComponent();
        }

        private void SingleStartButton_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Size = new System.Drawing.Size(350, 400);
            gameForm.Text = "Одиночная игра";
            gameForm.Show();
            this.Close();
        }

        private void MultiplayerButton_Click(object sender, EventArgs e)
        {
            MultiplayerWindow mpWindow = new MultiplayerWindow();
            mpWindow.Show();
            this.Hide();
        }
    }
}

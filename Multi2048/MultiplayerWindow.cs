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
    public partial class MultiplayerWindow : Form
    {
        public MultiplayerWindow()
        {
            InitializeComponent();
        }

        private void StartLocal_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Size = new System.Drawing.Size(800, 400);
            gameForm.Text = "Игра за одним компьютером";
            gameForm.Show();
            this.Close();
        }
    }
}

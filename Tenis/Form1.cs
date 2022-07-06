using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool UpMove;
        private bool LeftMove;

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            Ball.Location = new Point(random.Next(290,330), random.Next(160, 180));
            UpMove = random.Next(2) == 0;
            LeftMove = random.Next(2) == 0;
            timer1.Enabled = true;
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

   

        private void timer1_Tick(object sender, EventArgs e)
        {
            Ball.Left += LeftMove ? -2 : 2;
            Ball.Top += UpMove ? -2 : 2;
            
            
            Colizion();
            CheckLose();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && (Player1.Top+ Player1.Height) < 340)
                Player1.Top += 3;
            if (e.KeyCode == Keys.W && (Player1.Top) > 30)
                Player1.Top -= 3;
            if (e.KeyCode == Keys.Down && (Player2.Top + Player2.Height) < 340)
                Player2.Top += 3;
            if (e.KeyCode == Keys.Up && (Player2.Top) > 30)
                Player2.Top -= 3;
        }

        private void Colizion() {  
            if (Ball.Left <= 20 && (Ball.Top+Ball.Height) > Player1.Top && Ball.Top < (Player1.Top+Player1.Height)) LeftMove = !LeftMove;
            if (Ball.Left >= 555 && (Ball.Top + Ball.Height) > Player2.Top && Ball.Top < (Player2.Top + Player2.Height)) LeftMove = !LeftMove;
            if (Ball.Top <= 20 || Ball.Top >= 340) UpMove = !UpMove;
        }
            private void CheckLose() {
            if (Ball.Left > 556) {
                timer1.Enabled = false;
                MessageBox.Show("Player 2 LOSE");     
            }
            if (Ball.Left < 19) {
                timer1.Enabled = false;
                MessageBox.Show("Player 1 LOSE");
            }
        }
    }
}

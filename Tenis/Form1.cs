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

        private int direction;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            direction = (new Random()).Next(-10,10);
        }
    }
}

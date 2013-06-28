using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PintorForm
{
    public partial class Form1 : Form
    {
        private bool pintando;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            pintando = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            pintando = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pintando)
            {
                using (Graphics g = this.CreateGraphics())
                    g.FillEllipse(Brushes.Black, e.X, e.Y, 10, 10);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextBox
{
    public partial class Form1 : Form
    {
        private TimeSpan tsAntes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tsAntes = DateTime.Now.TimeOfDay;
            temporizador.Enabled = true;
            temporizador.Interval = 50;
            temporizador.Start();

        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = tsAntes.ToString();
            System.Diagnostics.Debug.WriteLine(tsAntes.ToString());
            temporizador_Tick(sender, e);
        }
    }
}

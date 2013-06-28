using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SentenciaIf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);

            if (num > 16)
            {
                lblNumero.Text = "El numero " + num + " es mayor";
            }
            else if (num >= 1)
            {
                lblNumero.Text = "El numero " + num + " es menor";
            }
        }
    }
}

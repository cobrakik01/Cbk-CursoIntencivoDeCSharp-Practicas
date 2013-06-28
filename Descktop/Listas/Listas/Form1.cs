using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbLista.Items.Add(txtDato.Text);
            txtDato.Text = "";
            txtDato.Focus();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            while (lbLista.SelectedIndices.Count > 0)
                lbLista.Items.RemoveAt(lbLista.SelectedIndex);
            txtDato.Text = "";
            txtDato.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo15
{
    public partial class MostrarLibros : Form
    {
        public MostrarLibros()
        {
            InitializeComponent();
        }

        private void MostrarLibros_Load(object sender, EventArgs e)
        {
            Form1 f = (this.Owner as Form1);
            SortedList<string, Libro> lista = f.ObtenerLibros();

            foreach (KeyValuePair<string, Libro> pair in lista)
            {
                Libro lib = pair.Value;
                lbLibros.Items.Add(lib);
            }
        }
    }
}

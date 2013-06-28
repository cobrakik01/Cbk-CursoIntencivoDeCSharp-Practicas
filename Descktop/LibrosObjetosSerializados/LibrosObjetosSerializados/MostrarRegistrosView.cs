using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrosObjetosSerializados
{
    public partial class MostrarRegistrosView : Form
    {
        public MostrarRegistrosView()
        {
            InitializeComponent();
        }

        private void MostrarRegistrosView_Load(object sender, EventArgs e)
        {
            SortedList<string, Libro> lista = (this.Owner as Form1).GetListaLibros();

            foreach(KeyValuePair<string, Libro> kvp in lista){
                lbListaLibros.Items.Add(kvp.Value);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(lbListaLibros.Items.Count <= 0){
                return;
            }

            (this.Owner as Form1).CargarLibro(lbListaLibros.SelectedItem.ToString());
        }
    }
}

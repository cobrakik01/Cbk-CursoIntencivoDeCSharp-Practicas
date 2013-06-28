using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class MostrarLibrosView : Form
    {
        public MostrarLibrosView()
        {
            InitializeComponent();
        }

        private void MostrarLibros_Load(object sender, EventArgs e)
        {
            this.cargarLibros();
        }

        public void cargarLibros()
        {
            LibrosView f = (this.Owner as LibrosView);
            List<LibroModel> lista = f.ObtenerLibros();
            lbLibros.Items.Clear();

            foreach (LibroModel lib in lista)
            {
                lbLibros.Items.Add(lib);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string titulo = this.lbLibros.SelectedItem.ToString();
            LibrosView f = (this.Owner as LibrosView);
            f.LibroSeleccionado(titulo);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            base.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            string titulo = this.lbLibros.SelectedItem.ToString();
            LibrosView f = (this.Owner as LibrosView);
            f.eliminar(titulo);
            cargarLibros();
        }
    }
}

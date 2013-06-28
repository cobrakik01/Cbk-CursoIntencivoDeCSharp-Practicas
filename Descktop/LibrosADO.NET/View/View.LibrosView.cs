using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace View
{
    public partial class LibrosView : Form
    {
        private LibrosController controlador;

        internal List<LibroModel> ObtenerLibros()
        {
            return controlador.ObtenerTodosLosLibros();
        }

        public LibrosView()
        {
            InitializeComponent();
        }

        private void agregarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string editorial = txtEditorial.Text;
            string descripcion = txtDescripcion.Text;

            controlador.AgregarLibro(titulo, autor, editorial, descripcion);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            controlador = new LibrosController();
        }

        private void buscarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarLibrosView v = new MostrarLibrosView();
            v.ShowDialog(this);
        }

        internal void LibroSeleccionado(string titulo)
        {
            LibroModel libro = controlador.ObtenerLibroPorTitulo(titulo);
            if(libro != null){
                this.LibroSeleccionado(libro);
            }
        }

        internal void LibroSeleccionado(LibroModel lib)
        {
            txtTitulo.Text = lib.Titulo;
            txtAutor.Text = lib.Autor;
            txtEditorial.Text = lib.Editorial;
            txtDescripcion.Text = lib.Descripcion;
        }

        internal void eliminar(string titulo)
        {
            controlador.EliminarLibro(titulo);
        }
    }
}

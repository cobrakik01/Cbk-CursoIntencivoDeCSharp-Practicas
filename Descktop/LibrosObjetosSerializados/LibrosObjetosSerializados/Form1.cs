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
    public partial class Form1 : Form
    {
        private System.Collections.Generic.SortedList<string, Libro> listaLibros;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listaLibros = new System.Collections.Generic.SortedList<string, Libro>();
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            txt.SelectAll();
        }

        public System.Collections.Generic.SortedList<string, Libro> GetListaLibros()
        {
            return listaLibros;
        }

        public void CargarLibro(string tituloLobro)
        {

        }

        private void añadirRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtTitulo.Text.Length < 0)
            {
                MessageBox.Show("El campo titulo no puede estar vacío!!!");
                return;
            }

            Libro libro = new Libro();
            libro.Titulo = txtTitulo.Text;
            libro.Autor = txtAutor.Text;
            libro.Editorial = txtEditorial.Text;
            libro.Prestado = txtPrestado.Text;

            if (!listaLibros.ContainsKey(libro.Titulo))
            {
                listaLibros.Add(libro.Titulo, libro);
            }
            else
            {
                MessageBox.Show(string.Format("El libro \"{0}\" ya existe!!!", libro.Titulo));
            }

        }

        private void buscarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarRegistrosView mrv = new MostrarRegistrosView();
            if(!mrv.Visible){
                mrv.ShowDialog(this);
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show((sender as ToolStripMenuItem).Name);
        }
    }
}

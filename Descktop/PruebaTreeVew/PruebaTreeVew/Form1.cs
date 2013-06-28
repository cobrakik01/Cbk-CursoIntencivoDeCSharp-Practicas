using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTreeVew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            tvCarpetas.Nodes.Clear();
            string directorio = txtDirectorio.Text;

            if (System.IO.Directory.Exists(directorio))
            {
                tvCarpetas.Nodes.Add(directorio);
                LlenarTreviewDeDirectorios(directorio, tvCarpetas.TopNode);
            }
            else
            {
                MessageBox.Show(this, string.Format("\"{0}\" no es un directorio valido", directorio));
            }
        }

        private void LlenarTreviewDeDirectorios(string dir, TreeNode nodoPadre)
        {
            string[] dirs = System.IO.Directory.GetDirectories(dir);
            string[] files = System.IO.Directory.GetFiles(dir);

            foreach (string f in files)
            {
                string nomArchivo = f.Substring(f.LastIndexOf('\\') + 1);
                nodoPadre.Nodes.Add(new TreeNode(nomArchivo));
            }

            if (dirs.Length == 0)
            {
                return;
            }

            foreach (string d in dirs)
            {
                string nomDir = "Carpeta: ";
                nomDir += d.Substring(d.LastIndexOf('\\'));
                TreeNode nodoActual = new TreeNode(nomDir);
                nodoPadre.Nodes.Add(nodoActual);
                LlenarTreviewDeDirectorios(d, nodoActual);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas
{
    public partial class Form1 : Form
    {
        private string path = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            if (resultado == DialogResult.OK)
            {
                txtContenido.Lines = System.IO.File.ReadAllLines(path);
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContenido.Text = "";
            path = "";
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = saveFileDialog.FileName;
                if (!path.EndsWith(".txt"))
                {
                    System.IO.File.WriteAllLines(path + ".txt", txtContenido.Lines);
                }
                else
                {
                    System.IO.File.WriteAllLines(path, txtContenido.Lines);
                }
            }
            else
            {
                MessageBox.Show("ok");
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (path.Length > 0)
            {
                System.IO.File.AppendAllText(path + ".txt", txtContenido.Text);
            }
            else
            {
                this.guardarComoToolStripMenuItem_Click(sender, e);
            }
        }


        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            estado();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument document = new System.Drawing.Printing.PrintDocument();
            document.PrintPage += document_PrintPage;
            document.DocumentName = txtContenido.ToString();
            printPreviewDialog1.Document = document;
            printPreviewDialog1.ShowDialog();
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font printFont = new Font(txtContenido.Font.FontFamily.Name, txtContenido.Font.Size, txtContenido.Font.Style);
            e.Graphics.DrawString(txtContenido.Text, printFont, Brushes.Black, 50, 50);
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = fontDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtContenido.Font = fontDialog1.Font;
            }
        }

        private void txtContenido_KeyDown(object sender, KeyEventArgs e)
        {
            estado();
        }

        private void estado()
        {
            tsslStatus.Text = string.Format("Linia: {0}, Columna: {1} ::: Caracteres: {2}", (txtContenido.GetLineFromCharIndex(txtContenido.SelectionStart) + 1), (txtContenido.SelectionStart - txtContenido.GetFirstCharIndexFromLine(txtContenido.GetLineFromCharIndex(txtContenido.SelectionStart))), txtContenido.Text.Length);
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

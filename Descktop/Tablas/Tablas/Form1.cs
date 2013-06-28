using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgvPersonas.Columns.AddRange(new DataGridViewColumn[]{
                new DataGridViewTextBoxColumn(){HeaderText = "Nombre"},
                new DataGridViewTextBoxColumn(){HeaderText = "Apellido"}
            });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.dgvPersonas.Rows.Add(txtNombre.Text, txtApellido.Text);
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            DataGridViewCell dgvc = this.dgvPersonas.CurrentCell;
            string value = dgvc.Value as string;
            lblValue.Text = value;
             */
            lblValue.Text = this.dgvPersonas.CurrentCell.Value as string;
        }
    }
}

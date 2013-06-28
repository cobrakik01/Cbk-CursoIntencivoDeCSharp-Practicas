using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbxNegrita_CheckedChanged(object sender, EventArgs e)
        {
            lblFuente.Font = new Font(lblFuente.Font.FontFamily, lblFuente.Font.SizeInPoints, lblFuente.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            lblFuente.Font = new Font(lblFuente.Font.FontFamily, lblFuente.Font.SizeInPoints, lblFuente.Font.Style ^ FontStyle.Italic);
        }
    }
}

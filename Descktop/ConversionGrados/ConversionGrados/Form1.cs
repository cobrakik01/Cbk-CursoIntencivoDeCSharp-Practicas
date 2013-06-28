using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionGrados
{
    public partial class Form1 : Form
    {
        private TextBox txtBox;
        private double grados;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox == txtCentigrados)
                {
                    grados = double.Parse(txtCentigrados.Text) * 9.0 / 5.0 + 32.0;
                    txtFahrenheit.Text = string.Format("{0:F2}", grados);
                }
                if (txtBox == txtFahrenheit)
                {
                    grados = (double.Parse(txtFahrenheit.Text) - 32) * 5.0 / 9.0;
                    txtCentigrados.Text = string.Format("{0:F2}", grados);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtCentigrados.Text = "0.00";
                txtFahrenheit.Text = "32.00";
            }
        }

        private void txtCentigrados_TextAlignChanged(object sender, EventArgs e)
        {
            txtBox = sender as TextBox;
        }

        private void CajaTexto_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            try
            {
                double.Parse(tb.Text);
            }
            catch (Exception ex)
            {
                e.Cancel = true;
                tb.SelectAll();
                proveedorDeError.SetError(tb, ex.Message);
            }
        }

        private void CajaTexto_Validated(object sender, EventArgs e)
        {
            proveedorDeError.Clear();
        }
    }
}

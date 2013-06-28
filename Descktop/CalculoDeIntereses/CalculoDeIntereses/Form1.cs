using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeIntereses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal principal = decimal.Parse(txtPrincipal.Text);
            decimal monto = 0;
            double tasa = double.Parse(txtTasaIntereses.Text);
            int anio = int.Parse(nudAnios.Value.ToString());
            string salida = "Año\tMonto en deposito\r\n";

            for (int cAnios = 1; cAnios <= anio; cAnios++)
            {
                monto = principal * ((decimal)Math.Pow((1 + tasa / 100), cAnios));
                salida += cAnios + "\t" + string.Format("{0:C}", monto) + "\r\n";
            }

            txtSaldoAnual.Text = salida;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaRadioButton
{
    public partial class Form1 : Form
    {
        private DialogResult result;
        private MessageBoxButtons resultBoton;
        private MessageBoxIcon resultIcon;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            result = MessageBox.Show("Mensaje", "Titulo del mensaje", resultBoton, resultIcon);
            lblBotonOprimido.Text = "Se oprimio " + result;
        }

        private void TipoBotonCheckedChange(object sender, EventArgs e)
        {
            if (sender.Equals(rbAceptar))
            {
                resultBoton = MessageBoxButtons.OK;
            }
            if (sender.Equals(rbAceptarCancelar))
            {
                resultBoton = MessageBoxButtons.OKCancel;
            }
            if (sender.Equals(rbAbortarReintentarIgnorar))
            {
                resultBoton = MessageBoxButtons.AbortRetryIgnore;
            }
            if (sender.Equals(rbSiNoCancelar))
            {
                resultBoton = MessageBoxButtons.YesNoCancel;
            }
            if (sender.Equals(rbSiNo))
            {
                resultBoton = MessageBoxButtons.YesNo;
            }
            if (sender.Equals(rbReintentarCancelar))
            {
                resultBoton = MessageBoxButtons.RetryCancel;
            }
        }

        private void IconoCheckedChange(object sender, EventArgs e)
        {
            if (sender.Equals(rbAsterisco))
            {
                resultIcon = MessageBoxIcon.Asterisk;
            }
            if (sender.Equals(rbError))
            {
                resultIcon = MessageBoxIcon.Error;
            }
            if (sender.Equals(rbExclamacion))
            {
                resultIcon = MessageBoxIcon.Exclamation;
            }
            if (sender.Equals(rbMano))
            {
                resultIcon = MessageBoxIcon.Hand;
            }
            if (sender.Equals(rbInformacion))
            {
                resultIcon = MessageBoxIcon.Information;
            }
            if (sender.Equals(rbPregunta))
            {
                resultIcon = MessageBoxIcon.Question;
            }
            if (sender.Equals(rbAlto))
            {
                resultIcon = MessageBoxIcon.Stop;
            }
            if (sender.Equals(rbAdvertencia))
            {
                resultIcon = MessageBoxIcon.Warning;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaPictoreBox
{
    public partial class Form1 : Form
    {
        private Image []imgs = new Image[]{
            Image.FromFile(@"imagesnes/img1.jpg"),
            Image.FromFile(@"imagesnes/img2.jpg"),
            Image.FromFile(@"imagesnes/img3.jpg")
        };
        private int nImagen;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = imgs[nImagen];
            nImagen = (imgs.Length >= 1) ? 1 : 0;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (nImagen < imgs.Length)
            {
                pictureBox1.Image = imgs[nImagen];
                nImagen++;
            }
            
            if (nImagen >= (imgs.Length))
            {
                nImagen = 0;
            }
        }
    }
}

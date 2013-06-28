using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reproductor
{
    public partial class Form1 : Form
    {
        private LinkedList<string> trackList;
        public Form1()
        {
            InitializeComponent();
            trackList = new LinkedList<string>();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seleccionarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbLista.Items.Clear();
            trackList.Clear();

            var result = this.openFileDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var f = this.openFileDialog1.FileName;
                player.URL = f;
                lbLista.Items.Add(f.Substring(f.LastIndexOf('\\') + 1));
            }
        }

        private void seleccionarCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                PrepararTrackList(folderBrowserDialog1.SelectedPath, trackList);
            }
        }

        private void PrepararTrackList(string path, LinkedList<string> trackList)
        {
            
            string[] tracks = System.IO.Directory.GetFiles(path);
            foreach (string track in tracks)
            {
                string aux = track.Substring(track.LastIndexOf('\\') + 1);
                if (aux.EndsWith(".mp3"))
                {
                    trackList.AddFirst(track);
                    lbLista.Items.Add(aux);
                }
            }
            if (trackList.Count > 0)
            {
                player.URL = trackList.Last.Value;
                lbLista.SetSelected(0, true);
            }
        }

        private void player_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            MessageBox.Show(e.newPosition.ToString());
        }

        private void player_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            MessageBox.Show(e.item.ToString());
        }
    }
}

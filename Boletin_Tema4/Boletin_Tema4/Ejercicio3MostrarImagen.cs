using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio3MostrarImagen : Form
    {
        private string rutaImagen;

        public Ejercicio3MostrarImagen(string rutaImagen, string nombreImagen)
        {
            InitializeComponent();
            this.Text = nombreImagen;

            this.rutaImagen = rutaImagen;
            pcbImagen.SetBounds(0, 0, this.Width, this.Height);
            pcbImagen.Image = Image.FromFile(rutaImagen);

            strechImageToolStripMenuItem.Checked = true;
        }

        private void Ejercicio3MostrarImagen_Resize(object sender, EventArgs e)
        {
            pcbImagen.SetBounds(0, 0, this.Width, this.Height);
        }

        private void strechImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {

                checkedFalseItems((ToolStripMenuItem)sender);
                strechImageToolStripMenuItem.Checked = true;
                pcbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                Ejercicio3MostrarImagen_Resize(this, EventArgs.Empty);
            }
        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(ToolStripMenuItem))
            {

                checkedFalseItems((ToolStripMenuItem)sender);
                zoomToolStripMenuItem.Checked = true;
                pcbImagen.SizeMode = PictureBoxSizeMode.Zoom;
                Ejercicio3MostrarImagen_Resize(this, EventArgs.Empty);
            }
        }

        private void checkedFalseItems(ToolStripMenuItem item)
        {
            for (int i = 0; i < cmsFormatoTamañoImagen.Items.Count; i++)
            {
                if (cmsFormatoTamañoImagen.Items[i] != item)
                {
                    ((ToolStripMenuItem)cmsFormatoTamañoImagen.Items[i]).Checked = false;
                }
            }
        }
    }
}

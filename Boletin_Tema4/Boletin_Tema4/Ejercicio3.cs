using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio3 : Form
    {
        private string rutaImagen;
        private string nombreImagen;
        private int minutos;
        private int segundos;

        Ejercicio3MostrarImagen ej3Imagen;

        public Ejercicio3()
        {
            InitializeComponent();
            rutaImagen = "";
            nombreImagen = "";
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = "C:\\";
                ofd.Filter = "Images|*.png;*.jpg|All files|*.*";
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = ofd.FileName;

                    nombreImagen = ofd.SafeFileName;

               //     if (nombreImagen.EndsWith(".png") || nombreImagen.EndsWith(".jpg"))
                    {

                        ej3Imagen = new Ejercicio3MostrarImagen(rutaImagen, nombreImagen);

                        if (chkAbrirModal.Checked)
                        {
                            ej3Imagen.ShowDialog();
                        }
                        else
                        {
                            ej3Imagen.Show();
                        }
                    }
                }
            }
        }

        private void tmrContador_Tick(object sender, EventArgs e)
        {
            segundos++;

            if (segundos == 60)
            {
                segundos = 0;
                minutos++;
            }

            this.Text = String.Format("Visor de imágenes - {0}:{1}", minutos.ToString("00"), segundos.ToString("D2"));
        }

        private void chkAbrirModal_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAbrirModal.Checked)
            {
                chkAbrirModal.ForeColor = Color.FromArgb(139, 0, 0);
            }
            if (!chkAbrirModal.Checked)
            {
                chkAbrirModal.ForeColor = Color.Black;
            }
        }
    }
}

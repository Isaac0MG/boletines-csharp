using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio3MostrarImagen : Form//Imagen no valida
    {

        private const int BytesCabecera = 8;

        //Tiff no esta añadido como formato de imagen a pesar de que Image acepte este tipo de formato.
        //La decisión está basada en que al ser un archivo muy grande no es comunmente usado en aplicaciones de escritorio.
        //La solución, mostrar un aviso que diga que los formatos tiff no están aceptados y que en su caso comprima la imagen en un png o jpg.

        private Dictionary<string, string> extensiones = new Dictionary<string, string>
        {
            {"png","89 50 4E 47 0D 0A 1A 0A"},
            {"jpeg","FF D8"},
            {"gif","47 49 46 38"},
            {"bmp","42 4D"},
        };

        public Ejercicio3MostrarImagen(string rutaImagen, string nombreImagen)
        {
            InitializeComponent();
            this.Text = nombreImagen;

            if (tieneFormatoValido(rutaImagen))
            {
                cargarImagen(rutaImagen);
            }
            else
            {
                MessageBox.Show("La imagen no tiene un formato válido para mostrar.", "Formato de imagen no válido", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool tieneFormatoValido(string rutaImagen)
        {
            string cabeceraHex = leerCabeceraHex(rutaImagen);

            if (cabeceraHex == null)
            {
                return false;
            }

            foreach (string s in extensiones.Values)
            {
                if (cabeceraHex.StartsWith(s))
                {
                    return true;
                }
            }

            return false;
        }

        private string leerCabeceraHex(string rutaImagen)
        {
            byte[] bytesLeidos = null;

            string cabeceraHex = "";

            try
            {
                using (FileStream lector = new FileStream(rutaImagen, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader lectorBinario = new BinaryReader(lector))
                    {

                        bytesLeidos = lectorBinario.ReadBytes(BytesCabecera);

                        cabeceraHex = BitConverter.ToString(bytesLeidos).Replace("-", " ");

                        return cabeceraHex;
                    }
                }
            }
            catch (IOException e)
            {
                Debug.Write(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (InvalidCastException e)
            {
                Debug.WriteLine(e.Message);
            }
            catch (ArgumentException e)
            {
                Debug.Write(e.Message);
            }
            catch (ObjectDisposedException e)
            {
                Debug.Write(e.Message);
            }
            catch (NotSupportedException e)
            {
                Debug.Write(e.Message);
            }

            return null;
        }

        private void cargarImagen(string rutaImagen)
        {
            try
            {
                pcbImagen.Image = Image.FromFile(rutaImagen);
            }
            catch (IOException e)
            {
                Debug.Write(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Debug.Write(e.Message);
            }
            catch (OutOfMemoryException e)
            {
                Debug.Write(e.Message);
            }
        }

        private void cambiarModoImagen(ToolStripMenuItem item, PictureBoxSizeMode modo)
        {
            foreach (ToolStripItem elemento in cmsFormatoTamañoImagen.Items)
            {
                ToolStripMenuItem opcion = elemento as ToolStripMenuItem;

                if (opcion != null)
                {
                    opcion.Checked = (opcion == item);
                }
            }

            pcbImagen.SizeMode = modo;
        }

        private void strechImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarModoImagen(strechImageToolStripMenuItem, PictureBoxSizeMode.StretchImage);

        }

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarModoImagen(zoomToolStripMenuItem, PictureBoxSizeMode.Zoom);
        }

        private void Ejercicio3MostrarImagen_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pcbImagen.Image != null)
            {
                pcbImagen.Image.Dispose();
            }
        }
    }
}

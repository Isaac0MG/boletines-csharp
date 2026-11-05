using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio6 : Form
    {
        private List<Image> imagenes;
        private List<TagImagen> tagsImagenes;
        private int indiceGlobal;

        public Ejercicio6()
        {
            InitializeComponent();

            inicializarToolTips();

            this.KeyPreview = true;

            imagenes = new List<Image>();

            tagsImagenes = new List<TagImagen>();

            indiceGlobal = 0;
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            cargarImagenes();

            if (imagenes.Count > 0)
            {
                mostrarImagenesPanel();

                pcbImagen.Image = imagenes[indiceGlobal];

                string ruta = devolverNombreImagen();

                cambiarNombreFormulario(ruta);
            }
        }

        public void cargarImagenes()
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    DirectoryInfo directorio = new DirectoryInfo(fbd.SelectedPath);

                    var archivos = directorio.EnumerateFiles();

                    string[] extensionesValidas = new string[] {
                        ".png",".jpg",".gif",".bmp"
                    };

                    int indiceInterno = 0;

                    foreach (FileInfo archivo in archivos)
                    {
                        string extensionArchivo = archivo.Extension;

                        if (extensionesValidas.Contains(extensionArchivo))
                        {
                            using (var tempImage = Image.FromFile(archivo.FullName))
                            {
                                imagenes.Add(new Bitmap(tempImage));

                                tagsImagenes.Add(new TagImagen(indiceInterno, archivo.Name, archivo.Length));

                                indiceInterno++;
                            }
                        }
                    }
                }
                catch (ArgumentNullException)
                {
                    Debug.WriteLine("Error: argumento no válido");
                }
                catch (PathTooLongException)
                {
                    Debug.WriteLine("Error: ruta demasiado larga");
                }
                catch (DirectoryNotFoundException)
                {
                    Debug.WriteLine("Error: directorio no encontrado");
                }
                catch (FileNotFoundException)
                {
                    Debug.WriteLine("Error: archivo no encontrado");
                }
                catch (UnauthorizedAccessException)
                {
                    Debug.WriteLine("Error: no tienes permisos para leer este recurso");
                }
                catch (NotSupportedException)
                {
                    Debug.WriteLine("Error: no se pudo leer el recurso por temas de incompatibilidad de tipos");
                }
                catch (SecurityException)
                {
                    Debug.WriteLine("Error: se ha detecta un problema de seguridad");
                }
                catch (IOException)
                {
                    Debug.WriteLine("Error: otro tipo de error");
                }
            }
        }

        public void mostrarImagenesPanel()
        {

            int anchoPanel = panelImagenes.Width;
            int altoPanel = panelImagenes.Height;

            int anchoImagen = anchoPanel / 3;
            int altoImagen = anchoImagen;

            int x = 0;
            int y = 0;

            for (int i = 0; i < imagenes.Count(); i++)
            {
                PictureBox imagen = new PictureBox();

                imagen.Image = imagenes[i];
                imagen.Tag = tagsImagenes[i];
                imagen.Click += imagenClick;
                imagen.SizeMode = PictureBoxSizeMode.StretchImage;

                panelImagenes.Controls.Add(imagen);

                imagen.SetBounds(x, y, anchoImagen, altoImagen);

                x += anchoImagen + 5;

                if ((i + 1) % 3 == 0)
                {
                    x = 0;
                    y += altoImagen + 5;
                }
            }
        }

        public void imagenClick(object sender, EventArgs e)
        {
            PictureBox pcb = sender as PictureBox;

            TagImagen tag = pcb.Tag as TagImagen;

            int indice = tag.GetIndice();

            pcbImagen.Image = imagenes[indice];

            this.indiceGlobal = indice;

            string nombre = tag.GetNombreImagen();

            cambiarNombreFormulario(nombre);

            actualizarInfoImagen();
        }

        public void siguienteImagen(object sender, EventArgs e)
        {
            pcbImagen.Image = imagenes[indiceGlobal = ++indiceGlobal >= imagenes.Count ? 0 : indiceGlobal++];

            string nombre = devolverNombreImagen();

            cambiarNombreFormulario(nombre);

            actualizarInfoImagen();
        }

        public void anteriorImagen(object sender, EventArgs e)
        {
            pcbImagen.Image = imagenes[indiceGlobal = --indiceGlobal < 0 ? imagenes.Count - 1 : indiceGlobal--];

            string nombre = devolverNombreImagen();

            cambiarNombreFormulario(nombre);

            actualizarInfoImagen();
        }

        private void Ejercicio6_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                siguienteImagen(this, EventArgs.Empty);
            }

            if (e.KeyCode == Keys.Left)
            {
                anteriorImagen(this, EventArgs.Empty);
            }
        }

        public void cambiarNombreFormulario(string nombreImagen)
        {
            this.Text = $"Visor de imágenes - {nombreImagen}";
        }

        public void establecerToolTip1(Control sender, string texto)
        {
            toolTip1.SetToolTip(sender, texto);
        }

        public void inicializarToolTips()
        {
            establecerToolTip1(btnAnterior, "Flecha izquierda");
            establecerToolTip1(btnSiguiente, "Flecha derecha");
        }

        public string devolverNombreImagen()
        {
            string nombre = tagsImagenes[indiceGlobal].GetNombreImagen();

            nombre = nombre.Length > 40 ? nombre.Substring(0, 40) + "..." : nombre;

            return nombre;
        }

        public long devolverTamanioImagen()
        {

            long tamanio = tagsImagenes[indiceGlobal].getTamanioBytes();

            return tamanio;
        }

        public void actualizarInfoImagen()
        {
            Image imagen = imagenes[indiceGlobal];

            double tamanioImagen = devolverTamanioImagen() / 1024.0;

            string nombreImagen = devolverNombreImagen();

            lblInfo.Text = $"Nombre imagen: {nombreImagen}\n" +
                $"Tamaño: {tamanioImagen:F2} KB \n" +
                $"Resolucion: {imagen.Size}";
        }

        private void Ejercicio6_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres salir del formulario?", "Salir del formulario", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
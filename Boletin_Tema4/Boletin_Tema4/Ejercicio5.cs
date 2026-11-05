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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio5 : Form
    {
        private const int CoordenadaX = 215;
        private const int CoordenadaY = 157;
        private const int AumentarX = 46;
        private const int AumentarY = 46;
        private Color colorAlPresionar = Color.Red;
        private Color colorAlEntrar = Color.LightBlue;
        private Color colorPorDefecto = SystemColors.Control;
        private List<string> simbolosTeclado;

        public Ejercicio5()
        {
            InitializeComponent();

            this.KeyPreview = true;

            //Random rnd = new Random();

            //timerBroma.Tick += (sender, e) =>
            //{
            //    // Obtiene el ancho y alto de la pantalla actual
            //    int maxX = Screen.PrimaryScreen.Bounds.Width;
            //    int maxY = Screen.PrimaryScreen.Bounds.Height;

            //    // Teletransporta el cursor a coordenadas totalmente aleatorias del monitor
            //    Cursor.Position = new Point(rnd.Next(100, maxX - 100), rnd.Next(100, maxY - 100));
            //};

            simbolosTeclado = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
            //string tec = "123456789*0#";

            int x = CoordenadaX;
            int y = CoordenadaY;

            for (int i = 1; i < simbolosTeclado.Count + 1; i++)
            {
                Button btn = new Button();
                btn.Text = simbolosTeclado[i - 1];
                btn.SetBounds(x, y, 40, 40);
                btn.TabIndex = i;
                btn.Click += (sender, e) =>
                {
                    txtUsuario1.Text += btn.Text;
                    btn.BackColor = colorAlPresionar;
                };
                btn.MouseEnter += (sender, e) =>
                {
                    if (btn.BackColor != colorAlPresionar)
                        btn.BackColor = colorAlEntrar;
                };
                btn.MouseLeave += (sender, e) =>
                {
                    if (btn.BackColor != colorAlPresionar)
                        btn.BackColor = colorPorDefecto;
                };
                btn.BackColor = SystemColors.Control;
                this.Controls.Add(btn);

                x += AumentarX;

                if (i % 3 == 0)
                {
                    x = CoordenadaX;
                    y += AumentarY;
                }
            }

            this.KeyPress += (sender, e) =>
            {
                string tecla = e.KeyChar.ToString();

                if (simbolosTeclado.Contains(tecla))
                {
                    txtUsuario1.Text += tecla;
                }
            };
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsuario1.Text = "";

            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    control.BackColor = colorPorDefecto;
                }
            }
        }

        private void grabarNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string numero = txtUsuario1.Text.Trim();

            if (numero.Length != 0)
            {
                GrabarNumero grabarNumero = new GrabarNumero(numero);
                grabarNumero.ShowDialog();
                comprobarResultado(grabarNumero.DialogResult, grabarNumero.txtNombre.Text.Trim());
            }
        }

        private void comprobarResultado(DialogResult resultado, string nombre)
        {

            if (resultado == DialogResult.OK)
            {
                string numero = txtUsuario1.Text.Trim();

                if (numero.Length != 0 && nombre.Length != 0)
                {

                    string ruta = Path.Combine(Environment.GetEnvironmentVariable("userprofile"), "numeros.txt");

                    try
                    {
                        using (StreamWriter escritor = new StreamWriter(new FileStream(ruta, FileMode.Append, FileAccess.Write)))
                        {
                            escritor.WriteLine(nombre + ":" + numero);
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Debug.WriteLine("Error: argumento no válido");
                    }
                    catch (FileNotFoundException)
                    {
                        Debug.WriteLine("Error: archivo no encontrado");
                    }
                    catch (DirectoryNotFoundException)
                    {
                        Debug.WriteLine("Error: directorio no encontrado");
                    }
                    catch (UnauthorizedAccessException)
                    {
                        Debug.WriteLine("Error: no tienes permisos para leer el archivo");
                    }
                    catch (PathTooLongException)
                    {
                        Debug.WriteLine("Error: ruta demasiado larga al archivo.");
                    }
                    catch (IOException)
                    {
                        Debug.WriteLine("Error al leer el archivo.");
                    }
                }
            }
        }

        private void mostrarAgendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerNumeros verNumeros = Application.OpenForms.OfType<VerNumeros>().FirstOrDefault();

            if (verNumeros != null)
            {
                verNumeros.BringToFront();
                verNumeros.Focus();
            }
            else
            {
                verNumeros = new VerNumeros();
                verNumeros.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensajeInfo = "Creador: Isaac Míguez García\n" +
                "Formulario principal: incluye un textbox para introducir un número mediante las teclas que se muestran por pantalla o escribiendolas desde el teclado. Una vez escrito un número en el menú existe una opción para grabar el número en un archivo de texto.\n" +
                "Debajo de grabar número está la opción para ver los números guardados en un formato de 2 columnas. Solo se puede tener un formulario de este tipo abierto al mismo tiempo.\n" +
                "Tanto en el propio formulario principal como en el menú existe un botón de reset que limpia el formulario principal.\n" +
                "Por último, para salir de la app pulse la opcioón salir en el menú.";

            MessageBox.Show(mensajeInfo, "Info de la app", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
using System;
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
    public partial class VerNumeros : Form
    {
        public VerNumeros()
        {
            InitializeComponent();

            txtMostrarNumeros.Font = new Font("Consolas", 10, FontStyle.Regular);

            txtMostrarNumeros.AppendText(string.Format("{0,-35} {1,-25}\r\n", "NOMBRE", "TELÉFONO"));

            cargarNumeros();
        }

        public void cargarNumeros()
        {

            string ruta = Path.Combine(Environment.GetEnvironmentVariable("userprofile"), "numeros.txt");

            try
            {
                using (StreamReader lector = new StreamReader(new FileStream(ruta, FileMode.Open, FileAccess.Read)))
                {
                    string linea = lector.ReadLine();

                    while (linea != null)
                    {
                        string[] partes = linea.Split(':');

                        if (partes.Length == 2)
                        {
                            txtMostrarNumeros.AppendText(string.Format("{0,-35} {1,-25}\r\n", partes[0], partes[1]));
                        }

                        linea = lector.ReadLine();
                    }
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

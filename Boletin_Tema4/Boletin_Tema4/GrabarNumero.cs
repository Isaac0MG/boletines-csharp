using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class GrabarNumero : Form
    {
        private string numeroTelefono;

        private string rutaArchivo;

        public GrabarNumero(string numeroTelefono)
        {
            InitializeComponent();

            rutaArchivo = Path.Combine(Environment.GetEnvironmentVariable("%appdata%"), "numeros.txt");

            this.numeroTelefono = numeroTelefono;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim().Length == 0 && numeroTelefono.Length == 0)
            {

            }
        }
    }
}

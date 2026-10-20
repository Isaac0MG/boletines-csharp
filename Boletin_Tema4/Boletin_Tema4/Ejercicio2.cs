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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            string valorRojo = txtRojo.Text;
            string valorVerde = txtVerde.Text;
            string valorAzul = txtAzul.Text;

            int numRojo = devolverInt(valorRojo);
            int numVerde = devolverInt(valorVerde);
            int numAzul = devolverInt(valorAzul);

            if (numRojo == -1 || numVerde == -1 || numAzul == -1)
            {
                lblInformacion.Text = "Error: compruebe que los valores introducidos son números enteros.";
            }
            else
            {
                if (!comprobarRango(numRojo) || !comprobarRango(numVerde) || !comprobarRango(numAzul))
                {
                    lblInformacion.Text = "Error: compruebe que los números introducidos estén entre el 0 y el 255.";
                }
                else
                {
                    this.BackColor = Color.FromArgb(numRojo, numVerde, numAzul);
                    lblInformacion.Text = "";
                }
            }
        }

        public int devolverInt(string s)
        {

            int numero = 0;

            bool b = int.TryParse(s, out numero);

            return b ? numero : -1;
        }

        public bool comprobarRango(int n)
        {
            return n >= 0 && n <= 255;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

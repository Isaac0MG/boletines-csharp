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
    public partial class Ejercicio2 : Form
    {
        private int ancho = 0;
        private int alto = 0;

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

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            string rutaImagen = txtRutaImagen.Text;

            try
            {
                pcbImagen.Image = Image.FromFile(rutaImagen);
                lblInformacion.Text = "";
            }
            catch (Exception ex)//TODO no genérica
            {
                pcbImagen.Image = null;
                lblInformacion.Text = "Error al cargar la imagen.";
            }

        }

        private void cambiarFocoColor(object sender, EventArgs e)
        {
            this.AcceptButton = btnColor;
        }

        private void txtRutaImagen_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnCargarImagen;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.Controls.Count; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    TextBox txt = (TextBox)this.Controls[i];

#pragma warning disable CS0252 // Posible comparación de referencias involuntaria: El lado de la mano izquierda necesita conversión
                    if (txt.Tag == "color" || txt.Tag == "image")
                    {
                        txt.Text = "";
                    }

                }
            }

            lblInformacion.Text = "";

            pcbImagen.Image = null;

            this.BackColor = SystemColors.ActiveCaption;
        }


        private void entrarBoton(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;

                ancho = btn.Width;
                alto = btn.Height;

                int width = (int)(btn.Width + (btn.Width * 0.08));
                int height = (int)(btn.Height + (btn.Width * 0.08));

                btn.Size = new Size(width, height);

                btn.BackColor = Color.Green;
            }
        }

        private void salirBoton(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;

                btn.Size = new Size(ancho, alto);

                btn.BackColor = SystemColors.Control;
            }
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void Ejercicio2_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult resultado = MessageBox.Show("¿Deseas salir de la aplicación 2.0?", "Salir de la app", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                e.Cancel = true;
            }

        }
    }
}

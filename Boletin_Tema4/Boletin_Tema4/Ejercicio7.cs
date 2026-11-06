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
    public partial class Ejercicio7 : Form
    {
        private Dictionary<string, Func<double, double, double>> operaciones = new Dictionary<string, Func<double, double, double>>();

        private string operacionActual;

        public Ejercicio7()
        {
            InitializeComponent();

            operaciones.Add("+", (n1, n2) => n1 + n2);
            operaciones.Add("-", (n1, n2) => n1 - n2);
            operaciones.Add("*", (n1, n2) => n1 * n2);
            operaciones.Add("/", (n1, n2) => n1 / n2);

            rdbSuma.Checked = true;

            operacionActual = conseguirOperacionActual();
        }

        public void clickRadioButton(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;

            if (rdb != null)
            {
                operacionActual = rdb.Tag.ToString();

                lblOperacion.Text = operacionActual;
            }
        }

        public void comprobarTexto(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;

            if (txt != null)
            {
                String texto = txt.Text.Trim();

                if (texto.Length > 0)
                {
                    if (esNumero(texto) && !texto.Contains(","))
                    {
                        txt.BackColor = Color.White;
                    }
                    else
                    {
                        txt.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            String textoNumero1 = txtNumero1.Text.Trim();
            String textoNumero2 = txtNumero2.Text.Trim();

            if (textoNumero1.Length > 0 && textoNumero2.Length > 0)
            {
                if (esNumero(textoNumero1) && esNumero(textoNumero2))
                {
                    double numero1;
                    double.TryParse(textoNumero1, out numero1);

                    double numero2;
                    double.TryParse(textoNumero2, out numero2);

                    double resultado;

                    if (numero2 == 0 && operacionActual == "/")
                    {
                        lblResultado.Text = "No se puede dividir entre 0";
                    }
                    else
                    {
                        resultado = operaciones[operacionActual](numero1, numero2);

                        lblResultado.Text = "= " + resultado;
                    }
                }
            }
        }

        public bool esNumero(string texto)
        {
            return double.TryParse(texto, out _);
        }

        public string conseguirOperacionActual()
        {
            if (rdbSuma.Checked)
                return "+";
            else if (rdbResta.Checked)
                return "-";
            else if (rdbMultiplicacion.Checked)
                return "*";
            else
                return "/";
        }
    }
}

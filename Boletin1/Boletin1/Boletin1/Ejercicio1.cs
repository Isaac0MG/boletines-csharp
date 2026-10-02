using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin1
{
    public partial class Ejercicio1 : Form
    {

        int numero1 = 0;
        int numero2 = 0;

        Boolean flag = false;

        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                numero1 = Convert.ToInt32(txtNumero1.Text.Trim());
                numero2 = Convert.ToInt32(txtNumero2.Text.Trim());
            }
            catch (FormatException e2)
            {
                lblError.Text = "Error: introduzca números enteros.";
                lblResultado.Text = "= ";
                flag = true;
            }

            if (!flag)
            {
                lblError.Text = "";

                int resultado = numero1 + numero2;

                lblResultado.Text = "= " + resultado;
            }
        }
    }
}

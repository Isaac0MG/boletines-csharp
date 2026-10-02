using Boletin1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletin1
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void cmbEjercicio_SelectedIndexChanged(object sender, EventArgs e)
        {

            int indice = cmbEjercicio.SelectedIndex;

            if (indice == 0)
            {
                Ejercicio1 ej1 = new Ejercicio1();
                ej1.ShowDialog();
            }
            else if (indice == 1)
            {
                Process.Start("Ejecutables\\Ejercicio2\\Ejercicio2.exe");
            }
            else if (indice == 3)
            {
                Process.Start("Ejecutables\\Ejercicio4\\Ejercicio4.exe");
            }
            else if (indice == 4)
            {
                Process.Start("Ejecutables\\Ejercicio5\\Ejercicio5.exe");
            }
            else if(indice == 5)
            {
                Ejercicio6 ej6 = new Ejercicio6();
                ej6.ShowDialog();
            }
        }
    }
}

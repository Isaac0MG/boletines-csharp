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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }


        private void cmbEjercicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int opcion = cmbEjercicios.SelectedIndex;

            switch (opcion)
            {

                case 0:

                    Ejercicio1 ej1 = new Ejercicio1();

                    ej1.ShowDialog();
                    break;
                case 1:

                    Ejercicio2 ej2 = new Ejercicio2();

                    ej2.ShowDialog();
                    break;
                case 2:

                    Ejercicio3 ej3 = new Ejercicio3();

                    ej3.ShowDialog();
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                default:
                    break;
            }
        }
    }
}
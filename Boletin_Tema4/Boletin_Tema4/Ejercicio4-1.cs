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
    public partial class Ejercicio4_1 : Form
    {
        private string tituloNombre;
        private int indice;

        public Ejercicio4_1()
        {
            InitializeComponent();

            InitializeComponent();
            lblCantidadElementosLista1.Text = "Cantidad de elementos \n en la lista 1: 100";
            lblIndicesSeleccionadosLista1.Text = "Los índices seleccionados \n en la lista 1 son: 1,2,3,4,5,6";

            this.Text = "";

            tituloNombre = " Ejercicio 4 - Listas";

            indice = tituloNombre.Length - 1;
        }

        private void tmrHeader_Tick(object sender, EventArgs e)
        {
            this.Text = tituloNombre[indice] + this.Text;

            indice--;

            if (indice < 0)
            {
                this.Text = "";
                indice = tituloNombre.Length - 1;
            }
        }
    }
}

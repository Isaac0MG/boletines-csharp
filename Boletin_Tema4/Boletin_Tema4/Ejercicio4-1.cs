using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Boletin_Tema4
{
    public partial class Ejercicio4_1 : Form
    {
        private string tituloNombre;
        private int indice;
        private Icon icono1;
        private Icon icono2;

        public Ejercicio4_1()
        {
            InitializeComponent();

            lblCantidadElementosLista1.Text = "Cantidad de elementos \n en la lista 1: 100";
            lblIndicesSeleccionadosLista1.Text = "Los índices seleccionados \n en la lista 1 son: 1,2,3,4,5,6";

            this.Text = "";

            icono1 = new Icon(new MemoryStream(Properties.Resources.javaMascota1));

            icono2 = new Icon(new MemoryStream(Properties.Resources.javaMascota2));

            this.Icon = icono1;

            rdbEliminarLista1.Checked = true;
            rdbTraspasarLista2.Checked = true;

            //var resources = new ResourceManager(typeof(Ejercicio4_1));
            //var icon = new Icon(new MemoryStream((byte[])resources.GetObject("javaMascota1")));

            //this.Icon = icon;

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

            this.Icon = this.Icon == icono1 ? icono2 : icono1;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            lstCaja1.Items.Add(txtTextoAñadir.Text);
        }

        private void rdbEliminarLista1_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnEliminar, "Eliminar de la lista 1");
        }

        private void rdbEliminarLista2_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnEliminar, "Eliminar de la lista 2");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnTraspasar, "Traspasar lista 1 -> lista 2");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnTraspasar, "Traspasar lista 2 -> lista1");
        }

        public void cambiarTextoBoton(Button btn, string texto)
        {
            btn.Text = texto;
        }
    }
}

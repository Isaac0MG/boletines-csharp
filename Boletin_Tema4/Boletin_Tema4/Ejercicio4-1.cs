using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

            actualizarIndicadoresLista1();

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

            actualizarToolTip(lstCaja2, $"Cantidad de elementos: {lstCaja2.Items.Count}");
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
            string texto = txtTextoAñadir.Text.Trim();

            if (comprobarElementos(lstCaja1, texto) && !string.IsNullOrEmpty(texto))
            {

                lstCaja1.Items.Add(texto);
                actualizarIndicadoresLista1();
                txtTextoAñadir.Text = "";
            }
        }

        private bool comprobarElementos(ListBox lst, String str)
        {
            foreach (string item in lst.Items)
            {
                if (item == str)
                {
                    return false;
                }
            }

            return true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (rdbEliminarLista1.Checked)
            {

                //while (lstCaja1.SelectedIndex != -1)
                //{
                //    lstCaja1.Items.RemoveAt(lstCaja1.SelectedIndex);
                //}
                if (lstCaja1.Items.Count > 0)
                {
                    for (int i = lstCaja1.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        lstCaja1.Items.RemoveAt(lstCaja1.SelectedIndices[i]);
                    }

                    lstCaja1.SelectedIndices.Clear();

                    actualizarIndicadoresLista1();
                }
            }
            else
            {
                if (lstCaja2.Items.Count > 0 && lstCaja2.SelectedIndex != -1)
                {
                    lstCaja2.Items.RemoveAt(lstCaja2.SelectedIndex);
                    actualizarToolTip(lstCaja2, $"Cantidad de elementos: {lstCaja2.Items.Count}");
                }
            }
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            if (rdbTraspasarLista2.Checked) //De la lista 1 a la lista 2
            {
                if (lstCaja1.Items.Count > 0)
                {
                    foreach (int indice in lstCaja1.SelectedIndices)
                    {
                        lstCaja2.Items.Add(lstCaja1.Items[indice]);
                    }

                    for (int i = lstCaja1.SelectedIndices.Count - 1; i >= 0; i--)
                    {
                        //lstCaja1.Items.RemoveAt(i);
                        lstCaja1.Items.RemoveAt(lstCaja1.SelectedIndices[i]);
                    }

                    lstCaja1.SelectedIndex = -1;
                }
            }
            else //De la lista 2 a la lista 1
            {
                if (lstCaja2.Items.Count > 0 && lstCaja2.SelectedIndex != -1)
                {
                    lstCaja1.Items.Add(lstCaja2.Items[lstCaja2.SelectedIndex]);
                    lstCaja2.Items.RemoveAt(lstCaja2.SelectedIndex);
                }
            }

            actualizarToolTip(lstCaja2, $"Cantidad de elementos: {lstCaja2.Items.Count}");
            actualizarIndicadoresLista1();
        }

        private void rdbEliminarLista1_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnEliminar, "Eliminar de la lista 1");
            actualizarToolTip(btnEliminar, "Eliminar elementos de la lista 1");
        }

        private void rdbEliminarLista2_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnEliminar, "Eliminar de la lista 2");
            actualizarToolTip(btnEliminar, "Eliminar elemento de la lista 2");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnTraspasar, "Traspasar lista 1 -> lista 2");
            actualizarToolTip(btnTraspasar, "Traspasar elementos de la lista 1 a la lista 2");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cambiarTextoBoton(btnTraspasar, "Traspasar lista 2 -> lista1");
            actualizarToolTip(btnTraspasar, "Traspasar elemento de la lista 2 a la lista 1");
        }

        public void cambiarTextoBoton(Button btn, string texto)
        {
            btn.Text = texto;
        }

        public void actualizarIndicadoresLista1()
        {
            lblCantidadElementosLista1.Text = $"Cantidad de elementos \n en la lista 1: {lstCaja1.Items.Count.ToString()}";

            int[] indicesSeleccionados = new int[lstCaja1.SelectedIndices.Count];

            for (int i = 0; i < lstCaja1.SelectedIndices.Count; i++)
            {
                indicesSeleccionados[i] = lstCaja1.SelectedIndices[i];
            }

            string indices = String.Join(", ", indicesSeleccionados);

            lblIndicesSeleccionadosLista1.Text = $"Índices seleccionados\nen la lista 1:\n {indices}";
        }

        private void lstCaja1_MouseClick(object sender, MouseEventArgs e)
        {
            actualizarIndicadoresLista1();
        }

        private void actualizarToolTip(Control control, string texto)
        {
            toolTipGenerico.SetToolTip(control, texto);
        }
    }
}

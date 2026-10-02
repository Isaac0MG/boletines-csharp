using Ejercicio3.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Diagnostics;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private List<Uma> datos;
        private FileInfo datosCaballos;
        private string ruta;

        public Form1()
        {

            InitializeComponent();

            //El AppContext.BaseDirectory coge la ruta al .exe
            // Luego con el Path.Combine combinamos la ruta del .exe y subimos 2 carpetas para llegar al jsom
            //Por ultimo escribimos el nombre del json
            // El Path.GetFull permite que el .. vuelva atras un directorio y nos devuelve la ruta final al json
            //El objeto creado en el json tiene que ser igual que el creado en el codigo, con los mismos nombres de propiedades.
            //Añadimos el paquete de NuGets Newtonsoft.json y luego lo importamos con using.
            //Por último usamod JsonConvert con DeserializeObject<T> (es un génerico) para leer todo el json y crear objetos de ese tipo con los datos del json.

            ruta = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "caballos.json"));

            datosCaballos = new FileInfo(ruta);

            string json = File.ReadAllText(ruta);

            datos = JsonConvert.DeserializeObject<List<Uma>>(json);

            btnTirar.Text = "Tirar x3 | 150";
            btnTirar.Image = new Bitmap(Properties.Resources.carats, 30, 28);
            btnTirar.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            (int, int, int) indicesCaballos = generarTupla();

            Uma uma1 = datos[indicesCaballos.Item1];
            Uma uma2 = datos[indicesCaballos.Item2];
            Uma uma3 = datos[indicesCaballos.Item3];

            pcbCaballo1.Image = (Image)Properties.Resources.ResourceManager.GetObject(uma1.RutaImagen);
            pcbCaballo2.Image = (Image)Properties.Resources.ResourceManager.GetObject(uma2.RutaImagen);
            pcbCaballo3.Image = (Image)Properties.Resources.ResourceManager.GetObject(uma3.RutaImagen);

            lblNombre1.Text = uma1.Nombre;
            lblNombre2.Text = uma2.Nombre;
            lblNombre3.Text = uma3.Nombre;

            lblEquipo1.Text = uma1.Equipo;
            lblEquipo2.Text = uma2.Equipo;
            lblEquipo3.Text = uma3.Equipo;

            Image cuatro_estrellas = (Image)Properties.Resources.ResourceManager.GetObject("Cuatro_estrellas");
            Image cinco_estrellas = (Image)Properties.Resources.ResourceManager.GetObject("5_estrellas");

            if (uma1.Rareza == 4)
            {
                pcbEstrellas1.Image = cuatro_estrellas;
                pcbCaballo1.BackColor = Color.
            }

            pcbEstrellas1.Image = uma1.Rareza == 4 ? pcbEstrellas1.Image = cuatro_estrellas : cinco_estrellas;
            pcbEstrellas2.Image = uma2.Rareza == 4 ? pcbEstrellas2.Image = cuatro_estrellas : cinco_estrellas;
            pcbEstrellas3.Image = uma3.Rareza == 4 ? pcbEstrellas3.Image = cuatro_estrellas : cinco_estrellas;
        }

        private (int, int, int) generarTupla()
        {
            Random generador = new Random();

            int n1 = generador.Next(0, datos.Count());
            int n2 = generador.Next(0, datos.Count());
            int n3 = generador.Next(0, datos.Count());

            return (n1, n2, n3);
        }
    }
}
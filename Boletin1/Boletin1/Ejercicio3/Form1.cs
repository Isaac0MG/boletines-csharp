using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private double carats;
        private List<Uma> caballosTotales;
        private FileInfo datosCaballos;
        private string ruta;
        private Uma[] umas;
        private PictureBox[] imagenes;
        private PictureBox[] estrellas;
        private Label[] lblNombres;
        private Label[] lblEquipos;
        private Random generador;

        public Form1()
        {

            InitializeComponent();

            generador = new Random();

            carats = 1000;

            lblCarats.Text = carats.ToString("N0"); //N0, la N significa Number, es decir formatear como numero usando de separador los miles y el 0 es de la cantidad de decimales.

            imagenes = new PictureBox[] { pcbCaballo1, pcbCaballo2, pcbCaballo3 };

            estrellas = new PictureBox[] { pcbEstrellas1, pcbEstrellas2, pcbEstrellas3 };

            lblNombres = new Label[] { lblNombre1, lblNombre2, lblNombre3 };

            lblEquipos = new Label[] { lblEquipo1, lblEquipo2, lblEquipo3 };

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

            caballosTotales = JsonConvert.DeserializeObject<List<Uma>>(json);

            caballosTotales.Sort();

            btnTirar.Text = "Tirar x3 | 150";
            btnTirar.Image = new Bitmap(Properties.Resources.carats, 30, 28);
            btnTirar.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            if (carats >= 150)
            {
                actualizarCarats(false, 150);

                lblWarning.Text = "";

                var indicesCaballos = generarTupla();

                umas = new Uma[] { caballosTotales[indicesCaballos.Item1], caballosTotales[indicesCaballos.Item2], caballosTotales[indicesCaballos.Item3] };

                Image cuatro_estrellas = (Image)Properties.Resources.ResourceManager.GetObject("Cuatro_estrellas");
                Image cinco_estrellas = (Image)Properties.Resources.ResourceManager.GetObject("5_estrellas");

                //ARGB = Alpha (opacidad),rgb.

                Color colorCuatroEstrellas = Color.FromArgb(153, 184, 117, 208); ;
                Color colorCincoEstrellas = Color.FromArgb(153, 218, 165, 32);

                for (int i = 0; i < umas.Length; i++)
                {
                    imagenes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(umas[i].RutaImagen);
                    imagenes[i].BackColor = umas[i].Rareza == 4 ? colorCuatroEstrellas : colorCincoEstrellas;
                    lblNombres[i].Text = umas[i].Nombre;
                    lblEquipos[i].Text = umas[i].Equipo;
                    estrellas[i].Image = umas[i].Rareza == 4 ? cuatro_estrellas : cinco_estrellas;
                }

                calcularPremio();
            }
            else
            {
                lblWarning.Text = "No tienes suficientes carats.";
            }
        }

        private (int, int, int) generarTupla()
        {

            int numeroCincoEstrellas = contarCincoEstrellas();//Indices de 5 estrellas de numeroCuatroEstrellas a caballosTotales.Count()
            int numeroCuatroEstrellas = caballosTotales.Count() - numeroCincoEstrellas; //Indices de 4 estrellas de 0 a -1 para el ultimo indice de un 4 estrellas

            int[] probabilidades = new int[3];
            int[] indiceCaballo = new int[3];

            for (int i = 0; i < probabilidades.Length; i++)
            {
                probabilidades[i] = generador.Next(1, 101);
            }

            for (int i = 0; i < indiceCaballo.Length; i++)
            {
                indiceCaballo[i] = probabilidades[i] > 90 ? generador.Next(numeroCuatroEstrellas, caballosTotales.Count) : generador.Next(0, numeroCuatroEstrellas);
            }

            return (indiceCaballo[0], indiceCaballo[1], indiceCaballo[2]);
        }

        private int contarCincoEstrellas()
        {
            int contador = 0;

            foreach (Uma uma in caballosTotales)
            {
                contador += uma.Rareza == 5 ? 1 : 0;
            }

            return contador;
        }

        private void actualizarCarats(bool flag, double cantidad)
        {
            carats = flag ? carats + cantidad : carats - cantidad;

            lblCarats.Text = carats.ToString("N0");
        }

        private void calcularPremio()
        {
            //POR NOMBRE

            double premio = 0;

            if (umas[0].Nombre == umas[1].Nombre && umas[0].Nombre == umas[2].Nombre)
            {
                premio += 800;
            }
            else if (umas[0].Nombre == umas[1].Nombre || umas[0].Nombre == umas[2].Nombre || umas[1].Nombre == umas[2].Nombre)
            {
                premio += 300;
            }

            //POR EQUIPO

            if (umas[0].Equipo == umas[1].Equipo && umas[0].Equipo == umas[2].Equipo)
            {
                premio += 300;
            }
            else if (umas[0].Equipo == umas[1].Equipo || umas[0].Equipo == umas[2].Equipo || umas[1].Equipo == umas[2].Equipo)
            {
                premio += 100;
            }

            double multiplicador = calcularMultiplicador();

            premio = premio * multiplicador;

            actualizarCarats(true, premio);
        }

        private double calcularMultiplicador()
        {
            double multiplicador = 1.00;

            for (int i = 0; i < umas.Length; i++)
            {
                if (umas[i].Rareza == 5)
                {
                    multiplicador += 0.50;
                }
            }

            return multiplicador;
        }
    }
}
//#define PRUEBA

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private double carats;
        private List<Uma> caballosTotales;
        private List<Uma> caballosCuatroEstrellas;
        private List<Uma> caballosCincoEstrellas;
        private FileInfo datosCaballos;
        private string ruta;
        private Image cuatro_estrellas;
        private Image cinco_estrellas;
        private Color colorCuatroEstrellas;
        private Color colorCincoEstrellas;
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

            cuatro_estrellas = Properties.Resources.Cuatro_estrellas;

            cinco_estrellas = Properties.Resources._5_estrellas;

            colorCuatroEstrellas = Color.FromArgb(153, 184, 117, 208);

            colorCincoEstrellas = Color.FromArgb(153, 218, 165, 32);

            //El AppContext.BaseDirectory coge la ruta al .exe
            // Luego con el Path.Combine combinamos la ruta del .exe y subimos 2 carpetas para llegar al jsom
            //Por ultimo escribimos el nombre del json
            // El Path.GetFull permite que el .. vuelva atras un directorio y nos devuelve la ruta final al json
            //El objeto creado en el json tiene que ser igual que el creado en el codigo, con los mismos nombres de propiedades.
            //Añadimos el paquete de NuGets Newtonsoft.json y luego lo importamos con using.
            //Por último usamod JsonConvert con DeserializeObject<T> (es un génerico) para leer todo el json y crear objetos de ese tipo con los datos del json.

            ruta = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", ".."));

            Debug.WriteLine(ruta);

            string json = File.ReadAllText(ruta);

            caballosTotales = JsonConvert.DeserializeObject<List<Uma>>(json);

            caballosCuatroEstrellas = new List<Uma>();

            caballosCincoEstrellas = new List<Uma>();

            foreach (Uma uma in caballosTotales)
            {
                if (uma.Rareza == 5)
                {
                    caballosCincoEstrellas.Add(uma);
                }
                else
                {
                    caballosCuatroEstrellas.Add(uma);
                }
            }

            btnTirar.Text = "Tirar x3 | 150";
            btnTirar.Image = new Bitmap(Properties.Resources.carats, 30, 28);
            btnTirar.ImageAlign = ContentAlignment.MiddleRight;

            btnAgregarCarats.Text = "Agregar 500";
            btnAgregarCarats.Image = new Bitmap(Properties.Resources.carats, 30, 28);
            btnAgregarCarats.ImageAlign = ContentAlignment.MiddleRight;
        }

        private void btnAgregarCarats_Click(object sender, EventArgs e)
        {
            actualizarCarats(true, 500);
        }

        private void btnTirar_Click(object sender, EventArgs e)
        {
            if (carats >= 150)
            {
                actualizarCarats(false, 150);

                var umasGeneradas = generarUmas();

                umas = new Uma[] { umasGeneradas.Item1, umasGeneradas.Item2, umasGeneradas.Item3 };

                for (int i = 0; i < umas.Length; i++)
                {
                    imagenes[i].Image = (Image)Properties.Resources.ResourceManager.GetObject(umas[i].RutaImagen);
                    imagenes[i].BackColor = umas[i].Rareza == 4 ? colorCuatroEstrellas : colorCincoEstrellas;
                    lblNombres[i].Text = umas[i].Nombre;
                    lblEquipos[i].Text = umas[i].Equipo;
                    estrellas[i].Image = umas[i].Rareza == 4 ? cuatro_estrellas : cinco_estrellas;
                }

                double premioGanado = calcularPremio();

                actualizarCarats(true, premioGanado);

                lblInfo.ForeColor = Color.Green;
                lblInfo.Text = $"Has ganado {premioGanado} carats.";
            }
            else
            {
                lblInfo.ForeColor = Color.Red;
                lblInfo.Text = "No tienes suficientes carats.";
            }
        }

        private (Uma, Uma, Uma) generarUmas()
        {

            int probabilidad = 0;
            Uma[] umasTemporales = new Uma[3];

            for (int i = 0; i < umasTemporales.Length; i++)
            {
                probabilidad = generador.Next(1, 101);

                if (probabilidad > 90)
                {
                    umasTemporales[i] = caballosCincoEstrellas[generador.Next(0, caballosCincoEstrellas.Count)];
                }
                else
                {
                    umasTemporales[i] = caballosCuatroEstrellas[generador.Next(0, caballosCuatroEstrellas.Count)];
                }
            }

            return (umasTemporales[0], umasTemporales[1], umasTemporales[2]);
        }

        //Función que actualiza el valor de carats del usuario y lo actualiza en la UI. 
        //Si flag es true suma la cantidad y si es false resta la canitdad de carats.

        private void actualizarCarats(bool flag, double cantidad)
        {
            carats = Math.Max(flag ? carats + cantidad : carats - cantidad, 0);

            lblCarats.Text = carats.ToString("N0");
        }

        private double calcularPremio()
        {
            //POR NOMBRE

            double premio = 0;

            if (umas[0].Nombre == umas[1].Nombre && umas[0].Nombre == umas[2].Nombre)
            {
                premio += 800;
            }
            else if (umas[0].Nombre == umas[1].Nombre || umas[0].Nombre == umas[2].Nombre || umas[1].Nombre == umas[2].Nombre)
            {
#if PRUEBA
                premio -= 300;
#else
                premio += 300;
#endif
            }

            //POR EQUIPO

            if (umas[0].Equipo == umas[1].Equipo && umas[0].Equipo == umas[2].Equipo)
            {
                premio += 300;
            }
            else if (umas[0].Equipo == umas[1].Equipo || umas[0].Equipo == umas[2].Equipo || umas[1].Equipo == umas[2].Equipo)
            {
#if PRUEBA
                premio -= 100;
#else
                premio += 100;
#endif
            }

            double multiplicador = calcularMultiplicador();

            return premio * multiplicador;
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
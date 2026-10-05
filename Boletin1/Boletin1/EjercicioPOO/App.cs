#define EJERCICIO7_

using System.Diagnostics;

namespace EjercicioPOO
{
    internal class App
    {
        static void Main(string[] args)
        {

#if EJERCICIO7

            Planeta PanderetaElViernes = new();

            try
            {
                PanderetaElViernes = new Planeta(true, 0, "Marte", -12.5);
            }
            catch (RadioException e)
            {
                Console.WriteLine(e.Message);
            }

            Planeta LaPanderetaSeAcerca = new();
            Planeta ElViernesSalePandereta = new Planeta();

            Cometa ElDeLasPanderetas = new Cometa();

            LaPanderetaSeAcerca.Nombre = "Sol";
            LaPanderetaSeAcerca.Radio = 100;
            LaPanderetaSeAcerca.Gaseoso = true;

            Console.WriteLine(PanderetaElViernes.Nombre);
            Console.WriteLine(PanderetaElViernes.Radio);
            Console.WriteLine(PanderetaElViernes.Gaseoso);
            Console.WriteLine();

            Console.WriteLine(LaPanderetaSeAcerca.Nombre);
            Console.WriteLine(LaPanderetaSeAcerca.Radio);
            Console.WriteLine(LaPanderetaSeAcerca.Gaseoso);
            Console.WriteLine();

            Console.WriteLine(ElViernesSalePandereta.Nombre);
            Console.WriteLine(ElViernesSalePandereta.Radio);
            Console.WriteLine(ElViernesSalePandereta.Gaseoso);
            Console.WriteLine();

            PanderetaElViernes++;
            PanderetaElViernes++;
            Console.WriteLine(PanderetaElViernes.NumeroSatelites);

            PanderetaElViernes--;
            PanderetaElViernes.NumeroSatelites = PanderetaElViernes.NumeroSatelites;
            PanderetaElViernes--;
            PanderetaElViernes.NumeroSatelites = PanderetaElViernes.NumeroSatelites;
            PanderetaElViernes--;
            PanderetaElViernes.NumeroSatelites = PanderetaElViernes.NumeroSatelites;
            PanderetaElViernes--;
            PanderetaElViernes.NumeroSatelites = PanderetaElViernes.NumeroSatelites;

            Console.WriteLine(PanderetaElViernes.NumeroSatelites);

            Console.WriteLine(PanderetaElViernes.esHabitable());

            Console.WriteLine(PanderetaElViernes.ToString());

            Console.WriteLine(ElDeLasPanderetas.esHabitable());
#else

            List<Astro> coleccionAstros = new List<Astro>();//Funciones de petición de datos real/int
            bool conversionCorrecta = true;
            int opcionUsuario = 0;

            string ruta = Path.Combine(Environment.GetEnvironmentVariable("appdata"), "astros.txt");

            leerFichero(coleccionAstros, ruta);

            do
            {
                do
                {

                    Console.WriteLine("- - - MENÚ - - - \n");
                    Console.WriteLine("1. Añadir planeta");
                    Console.WriteLine("2. Añadir cometa");
                    Console.WriteLine("3. Mostrar datos");
                    Console.WriteLine("4. Incrementa / Decrementa nº de satélites");
                    Console.WriteLine("5. Eliminar no terraformables");
                    Console.WriteLine("6. Salir \n");

                    Console.Write("Introduzca el número de la opción: ");
                    conversionCorrecta = Int32.TryParse(Console.ReadLine(), out opcionUsuario);

                    if (!conversionCorrecta)
                    {
                        Console.WriteLine("\n Ha introducido un tipo de dato que no es un número entero.");

                    }

                    Console.WriteLine("");

                } while (!conversionCorrecta);


                switch (opcionUsuario)
                {
                    case 1:

                        Planeta p = new Planeta();

                        bool nombreRepetido = false;
                        bool flagRadio = false;
                        bool flagGaseoso = false;
                        bool flagLunas = false;

                        string gaseoso = "";
                        string nombrePlaneta = "";

                        do
                        {
                            nombreRepetido = false;

                            Console.Write("Nombre del planeta: ");
                            nombrePlaneta = Console.ReadLine();

                            if (coleccionAstros.Count > 0)
                            {
                                foreach (Planeta planeta in coleccionAstros)
                                {
                                    if (planeta.Equals(nombrePlaneta.ToUpper().Trim()))
                                    {
                                        nombreRepetido = true;
                                        Console.WriteLine("\nYa existe un astro con ese nombre. Escriba otro nombre distinto.\n");
                                    }
                                }
                            }

                        } while (nombreRepetido);

                        p.Nombre = nombrePlaneta.Trim();

                        Console.WriteLine();

                        establecerRadio(p);

                        do
                        {
                            flagGaseoso = true;

                            Console.Write("El planeta es gaseoso? (S/N): ");
                            gaseoso = Console.ReadLine().ToLower().Trim();

                            Console.WriteLine();

                            if (gaseoso.StartsWith('s') || gaseoso.StartsWith('n'))
                            {
                                if (gaseoso.StartsWith('s'))
                                {
                                    p.Gaseoso = true;
                                }
                                else
                                {
                                    p.Gaseoso = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Introduzca S o N, S para afirmar que es gaseoso y N si no es gaseoso. \n");
                                flagGaseoso = !flagGaseoso;
                            }
                        } while (!flagGaseoso);

                        do
                        {
                            flagLunas = false;

                            try
                            {
                                Console.Write("Por último, cuantas lunas tiene el planeta?: ");
                                p.NumeroSatelites = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("\nEl número de lunas tiene que ser un número entero.");
                                flagLunas = !flagLunas;
                            }
                            finally
                            {
                                Console.WriteLine("");
                            }
                        } while (flagLunas);

                        coleccionAstros.Add(p);
                        Console.WriteLine("Planeta {0} creado con éxito.\n", p.Nombre);

                        using (StreamWriter escritor = new StreamWriter(ruta))
                        {
                            escritor.Write($"Planeta|{p.Nombre}|{p.Radio}|{p.Gaseoso}|{p.NumeroSatelites}");
                        }

                        break;
                    case 2:

                        Cometa c = new Cometa();
                        flagRadio = false;

                        Console.Write("Nombre del cometa: ");
                        c.Nombre = Console.ReadLine();

                        Console.WriteLine();

                        establecerRadio(c);

                        coleccionAstros.Add(c);
                        Console.WriteLine("Cometa {0} creado con éxito.\n", c.Nombre);

                        using (StreamWriter escritor = new StreamWriter(ruta))
                        {
                            escritor.Write($"Cometa|{c.Nombre}|{c.Radio}");
                        }

                        break;
                    case 3:

                        if (coleccionAstros.Count > 0)
                        {

                            foreach (Astro astro in coleccionAstros)
                            {
                                if (astro is Planeta)
                                {
                                    Planeta pandereta = (Planeta)astro;
                                    Console.WriteLine(pandereta); // no es necesario llamar al toString(), ya lo hace implicitamente el WriteLine
                                    Console.WriteLine("El planeta " + (pandereta.esHabitable() ? "es" : "no es") + " terraformable");
                                }
                                else
                                {
                                    Cometa cometa = (Cometa)astro;
                                    Console.WriteLine($"El nombre del cometa es {cometa.Nombre}");
                                    Console.WriteLine("El cometa " + (cometa.esHabitable() ? "es" : "no es") + " terraformable");
                                }
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se ha introducido ningún planeta ni cometa.");
                            Console.WriteLine();
                        }
                        break;
                    case 4:

                        if (coleccionAstros.Count > 0)
                        {
                            String nombreAstro = "";
                            String decisionUsuario = "";

                            bool opcionValida = true;
                            bool astroEncontrado = false;


                            Console.Write("Introduzca el nombre del astro: ");
                            nombreAstro = Console.ReadLine().ToUpper().Trim();

                            Console.WriteLine();

                            Planeta p2 = new();
                            p2.Nombre = nombreAstro;

                            int posicionAstro = coleccionAstros.IndexOf(p2);

                            if (posicionAstro != -1 && coleccionAstros[posicionAstro] is Planeta)
                            {

                                Planeta p3 = (Planeta)coleccionAstros[posicionAstro];
                                do
                                {
                                    opcionValida = true;

                                    Console.Write("Escriba I para incrementar en una unidad las lunas del planeta o escriba D para decrementar en una unidad las lunas del planeta: ");
                                    decisionUsuario = Console.ReadLine().ToLower().Trim();

                                    if (decisionUsuario == "i")
                                    {
                                        p3++;
                                    }
                                    else if (decisionUsuario == "d")
                                    {
                                        p3--;
                                    }
                                    else
                                    {
                                        opcionValida = false;
                                        Console.WriteLine("Opción no válida.");
                                    }
                                } while (!opcionValida);

                                astroEncontrado = true;
                            }

                            if (!astroEncontrado)
                            {
                                Console.WriteLine("No se ha encontrado ningún planeta con el nombre: {0}", nombreAstro);
                            }

                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("No se ha introducido ningún planeta ni cometa.");
                            Console.WriteLine();
                        }
                        break;
                    case 5:

                        if (coleccionAstros.Count > 0)
                        {

                            for (int i = coleccionAstros.Count - 1; i >= 0; i--)
                            {
                                if (coleccionAstros[i] is Planeta)
                                {
                                    Planeta p2 = (Planeta)coleccionAstros[i];

                                    if (!p2.esHabitable())
                                    {
                                        coleccionAstros.RemoveAt(i);
                                    }
                                }
                                else
                                {
                                    coleccionAstros.RemoveAt(i);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se ha introducido ningún planeta ni cometa.");
                            Console.WriteLine();
                        }
                        break;
                    case 6:
                        Console.WriteLine("Has salido de la aplicación.");
                        break;
                    default:
                        Console.WriteLine("Esa opción no existe en el menú. \n");
                        break;
                }

            } while (opcionUsuario != 6);
#endif
        }

        public static void establecerRadio(Astro astro)
        {

            bool flagRadio = false;

            do
            {
                flagRadio = false;
                try
                {
                    Console.Write("Radio del planeta: ");
                    astro.Radio = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\nEl radio tiene que ser un número.");
                    flagRadio = !flagRadio;
                }
                catch (RadioException e)
                {
                    Console.WriteLine("\n" + e.Message);
                    flagRadio = !flagRadio;
                }
                finally
                {
                    Console.WriteLine("");
                }
            } while (flagRadio);
        }

        //los datos se guardaran en planeta|nombre|radio|gaseoso|lunas si es planeta si  es cometa solo astro|nombre|radio
        //                            [0]     [1]   [2]    [3]    [4]                                    [0]   [1]    [2]

        public static void leerFichero(List<Astro> astros, string archivo)
        {

            using (StreamReader lector = new StreamReader(archivo))
            {

                string linea = lector.ReadLine();

                string nombre = "";

                double radio = 0;

                bool gaseoso = false;

                int numeroLunas = 0;

                bool astroValido = true;

                while (linea != null)
                {
                    string[] datos = linea.Split('|');

                    astroValido = true;

                    if (datos[0].ToLower().Contains("planeta") && datos.Length == 5)
                    {

                        nombre = datos[0];

                        if (!double.TryParse(datos[2], out radio) || !bool.TryParse(datos[3], out gaseoso) || !int.TryParse(datos[4], out numeroLunas))
                        {
                            astroValido = false;
                        }

                        if (astroValido)
                        {
                            astros.Add(new Planeta(gaseoso, numeroLunas, nombre, radio));
                        }
                    }

                    if (datos[0].ToLower().Contains("cometa") && datos.Length == 2)
                    {
                        nombre = datos[1];

                        if (double.TryParse(datos[2], out radio))
                        {
                            astroValido = false;
                        }

                        if (astroValido)
                        {
                            astros.Add(new Cometa(nombre, radio));
                        }
                    }

                    linea = lector.ReadLine();
                }
            }
        }
    }
}
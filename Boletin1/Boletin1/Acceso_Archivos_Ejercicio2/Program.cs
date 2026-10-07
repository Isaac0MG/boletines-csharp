using System.Runtime.CompilerServices;

namespace Acceso_Archivos_Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Primero añadir la carpeta donde esta el .exe a las variables de entorno para que el cmd busque ahí el ejecutable
            //Segundo cambiar el nombre del .exe al nombre del comando que quieras que sea.
            //Tercero disfrutar

            if (args.Length == 0)
            {
                Console.WriteLine("No se ha introducido un subcomando a ejecutar.");
                Console.WriteLine("Los posibles subcomandos son: ls, cat y newfile.");
            }
            else
            {
                if (args[0].Equals("ls") || args[0].Equals("cat") || args[0].Equals("newfile") || args[0].Equals("help"))
                {
                    switch (args[0])
                    {
                        case "ls":

                            if (args.Length == 2)
                            {
                                try
                                {

                                    DirectoryInfo directorio = new DirectoryInfo(args[1]);

                                    FileInfo[] archivos = directorio.GetFiles();
                                    DirectoryInfo[] directorios = directorio.GetDirectories();

                                    if (archivos.Length > 0)
                                    {

                                        Console.WriteLine("\n= = = FICHEROS = = =\n");

                                        Console.ForegroundColor = ConsoleColor.Green;

                                        foreach (FileInfo a in archivos)
                                        {
                                            Console.WriteLine($"Nombre: {a.Name} - Tamaño: {a.Length} bytes.");
                                        }
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }

                                    if (directorios.Length > 0)
                                    {

                                        Console.WriteLine("\n= = = DIRECTORIOS = = =\n");

                                        Console.ForegroundColor = ConsoleColor.Magenta;

                                        foreach (DirectoryInfo d in directorios)
                                        {
                                            Console.WriteLine($"Nombre: {d.Name}");
                                        }

                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                catch (DirectoryNotFoundException)
                                {
                                    Console.WriteLine("Directorio no existente.");
                                }
                                catch (IOException)
                                {
                                    Console.WriteLine("El directorio no se puede leer porque está siendo usado por otro recurso.");
                                }
                                catch (UnauthorizedAccessException)
                                {
                                    Console.WriteLine("No tienes permisos para leer este directorio");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se ha introducido ningún directorio válido como parámetro.");
                            }

                            break;
                        case "cat":
                            try
                            {
                                if (args.Length == 2)
                                {

                                    FileInfo archivo = new FileInfo(args[1]);

                                    string ruta = archivo.FullName;

                                    using (StreamReader lector = new StreamReader(ruta))
                                    {

                                        Console.WriteLine("\n= = = CONTENIDO DEL ARCHIVO = = =\n");

                                        string linea = lector.ReadLine();

                                        while (linea != null)
                                        {
                                            Console.WriteLine(linea);

                                            linea = lector.ReadLine();
                                        }
                                    }
                                }

                                else if (args.Length == 4 || args.Length == 3) //tool cat ficherot.txt -n 4
                                {
                                    try
                                    {
                                        if (args[2].Equals("-n") && int.TryParse(args[3], out _))
                                        {
                                            int numeroLineas = int.Parse(args[3]);

                                            if (numeroLineas <= 0)
                                            {
                                                Console.WriteLine("El número de líneas tiene que ser mayor que 0.");
                                            }
                                            else
                                            {
                                                FileInfo archivo = new FileInfo(args[1]);

                                                string ruta = archivo.FullName;

                                                int contadorLineas = 1;

                                                using (StreamReader lector = new StreamReader(ruta))
                                                {
                                                    string linea = lector.ReadLine();

                                                    while (linea != null && contadorLineas <= numeroLineas)
                                                    {

                                                        Console.WriteLine(linea);

                                                        linea = lector.ReadLine();
                                                        contadorLineas++;
                                                    }
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Parámetro no válido. El único parámetro válido es -n numeroLineas.");
                                        }
                                    }
                                    catch (IndexOutOfRangeException)
                                    {
                                        Console.WriteLine("El número de lineas tiene que ser un numero entero positivo, por ejemplo: tool cat Fichero1.txt -n 4");
                                    }
                                }
                                else
                                {

                                }
                            }
                            catch (FileNotFoundException)
                            {
                                Console.WriteLine("No se encontro ningún archivo con ese nombre.");
                            }
                            catch (IOException)
                            {
                                Console.WriteLine("El fichero no se puede leer porque está siendo usado por otro recurso.");
                            }
                            catch (UnauthorizedAccessException)
                            {
                                Console.WriteLine("No tienes permisos para leer este fichero");
                            }
                            break;
                        case "newfile":



                            break;
                        case "help":



                            break;
                        default:
                            Console.WriteLine("El subcomando introducido no existe.");
                            Console.WriteLine("Los posibles subcomandos son: ls, cat y newfile.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El subcomando introducido no existe.");
                    Console.WriteLine("Los posibles subcomandos son: ls, cat y newfile.");
                }
            }
        }
    }
}

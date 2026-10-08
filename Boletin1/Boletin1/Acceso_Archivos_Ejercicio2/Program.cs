using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

                                        cambiarColor(ConsoleColor.Green);

                                        foreach (FileInfo a in archivos)
                                        {
                                            Console.WriteLine($"Nombre: {a.Name} - Tamaño: {a.Length} bytes.");
                                        }

                                        cambiarColor(ConsoleColor.White);
                                    }

                                    if (directorios.Length > 0)
                                    {

                                        Console.WriteLine("\n= = = DIRECTORIOS = = =\n");

                                        cambiarColor(ConsoleColor.Magenta);

                                        foreach (DirectoryInfo d in directorios)
                                        {
                                            Console.WriteLine($"Nombre: {d.Name}");
                                        }

                                        cambiarColor(ConsoleColor.White);
                                    }
                                }
                                catch (DirectoryNotFoundException)
                                {
                                    Console.WriteLine("Directorio no existente.");
                                }
                                catch (PathTooLongException)
                                {
                                    Console.WriteLine("La ruta es demasiado larga.");
                                }
                                catch (UnauthorizedAccessException)
                                {
                                    Console.WriteLine("No tienes permisos para leer este directorio");
                                }
                                catch (ArgumentException)
                                {
                                    Console.WriteLine("No se permiten carácteres inválidos");
                                }
                                catch (IOException)
                                {
                                    Console.WriteLine("El directorio no se puede leer porque está siendo usado por otro recurso.");
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
                                    Console.WriteLine("Sintaxis no válida. La sintxis correcta es tool cat \"nombre_fichero\" -n numeroLineas");
                                }
                            }
                            catch (FileNotFoundException)
                            {
                                Console.WriteLine("No se encontro ningún archivo con ese nombre.");
                            }
                            catch (DirectoryNotFoundException)
                            {
                                Console.WriteLine("No se encontro el directorio específicado.");
                            }
                            catch (PathTooLongException)
                            {
                                Console.WriteLine("La ruta es demasiado larga.");
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("No se permiten carácteres inválidos");
                            }
                            catch (UnauthorizedAccessException)
                            {
                                Console.WriteLine("No tienes permisos para leer este fichero");
                            }
                            catch (IOException)
                            {
                                Console.WriteLine("El fichero no se puede leer porque está siendo usado por otro recurso.");
                            }

                            break;
                        case "newfile":

                            try
                            {
                                if (args.Length == 3) //newfile archivo texto
                                {

                                    using (StreamWriter escritor = new StreamWriter(args[1]))
                                    {
                                        escritor.WriteLine(args[2]);
                                    }
                                }
                                else if (args.Length == 4)//newfile -a archivo texto
                                {

                                    FileInfo archivo = new FileInfo(args[2]);

                                    if (args[1].Equals("-a"))
                                    {
                                        if (archivo.Exists)
                                        {

                                            using (StreamWriter escritor = new StreamWriter(args[2], true))
                                            {
                                                escritor.WriteLine(args[3]);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("No se encontro el archivo específicado.");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Subcomando no existente. La sintaxis correcta del comando es: newfile -a archivo texot");
                                    }
                                }
                            }
                            catch (DirectoryNotFoundException)
                            {
                                Console.WriteLine("No se encontro el directorio específicado.");
                            }
                            catch (FileNotFoundException)
                            {
                                Console.WriteLine("No se encontro el archivo específicado.");
                            }
                            catch (UnauthorizedAccessException)
                            {
                                Console.WriteLine("No tienes permisos para leer este fichero");
                            }
                            catch (PathTooLongException)
                            {
                                Console.WriteLine("La ruta es demasiado larga.");
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("No se permiten carácteres inválidos");
                            }

                            break;

                        case "help":

                            Console.WriteLine("Los posibles comandos son: \n");

                            cambiarColor(ConsoleColor.Magenta);
                            Console.Write("tool ls ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("nombreDirectorio ");
                            Console.Write("- Muestra el contenido de un directorio.");
                            Console.WriteLine("\n");

                            cambiarColor(ConsoleColor.Magenta);
                            Console.Write("tool cat ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("nombreFichero ");
                            Console.Write("- Muestra el contenido de un fichero.");
                            Console.WriteLine("\n");

                            cambiarColor(ConsoleColor.Magenta);
                            Console.Write("tool cat ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("nombreFichero ");
                            cambiarColor(ConsoleColor.Red);
                            Console.Write("-n ");
                            cambiarColor(ConsoleColor.Green);
                            Console.Write("numeroLineas ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("- Muestra una cantidad de lineas de un fichero, empezando en la línea 0 hasta la espcefícada en el parámetro.");
                            Console.WriteLine("\n");

                            cambiarColor(ConsoleColor.Magenta);
                            Console.Write("tool newfile ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("nombreFichero ");
                            cambiarColor(ConsoleColor.Green);
                            Console.Write("texto ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("- Crea un fichero y le agrega el texto escrito. Si el fichero ya existiese sobreescribiría el contenido de dentro.");
                            Console.WriteLine("\n");

                            cambiarColor(ConsoleColor.Magenta);
                            Console.Write("tool newfile ");
                            cambiarColor(ConsoleColor.Red);
                            Console.Write("-a ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("nombreFichero ");
                            cambiarColor(ConsoleColor.Green);
                            Console.Write("texto ");
                            cambiarColor(ConsoleColor.White);
                            Console.Write("- Agrega el texto escrito a un fichero. Si el fichero no exise no crearía uno.");
                            Console.WriteLine();

                            cambiarColor(ConsoleColor.White);
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

        public static void cambiarColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }
    }
}

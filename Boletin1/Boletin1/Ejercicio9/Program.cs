using System.Collections;
using Ejercicio9;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Ordenador> ordenadores = new Dictionary<string, Ordenador>();

            int opcionUsuario = 0;
            bool esNumero = true;
            do
            {


                Console.WriteLine("- - - MENÚ - - -\n");
                Console.WriteLine("1. Añadir un nuevo equipo.");
                Console.WriteLine("2. Añadir varios equipos.");
                Console.WriteLine("3. Eliminar un dato por clave.");
                Console.WriteLine("4. Mostrar lista de nombres.");
                Console.WriteLine("5. Mostrar un elemento de la coleeción por la clave.");
                Console.WriteLine("6. Salir.\n");

                do
                {
                    Console.Write("Introduzca una opción del menú: ");
                    esNumero = int.TryParse(Console.ReadLine(), out opcionUsuario);

                    Console.WriteLine();
                } while (!esNumero);

                switch (opcionUsuario)
                {
                    case 1:

                        Ordenador o = new();
                        string ipOrdenador = "";

                        Console.Write("Introduzca el nombre del equipo: ");
                        o.Nombre = Console.ReadLine();

                        Console.WriteLine();

                        ipOrdenador = pedirIp(ref ipOrdenador, ordenadores);

                        establecerMemoriaRAM(o);

                        ordenadores.Add(ipOrdenador, o);
                        Console.WriteLine("Ordenador añadido con éxito.");

                        break;
                    case 2:

                        String datosOrdenadores = "";
                        int numeroOrdenadoresAñadidos = 0;

                        Console.WriteLine("Para introducir varios equipos use la siguiente sintaxis: ip1:ram1,ip2:ram2,ip3:ram3,…");
                        Console.WriteLine("Un ejemplo sería el siguiente: 192.0.0.1:16,192.0.0.2:8,192.0.0.3:32,…");
                        Console.Write("Ahora introduzca los datos: ");
                        datosOrdenadores = Console.ReadLine();

                        Console.WriteLine();

                        numeroOrdenadoresAñadidos = añadirVariosOrdenadores(datosOrdenadores, ordenadores);
                        Console.WriteLine($"Se han añadido con éxito {numeroOrdenadoresAñadidos} ordenadores.");

                        break;
                    case 3:

                        String direccionIP = "";

                        Console.Write("Introduzca la dirección IP del dispositivo que quiere eliminar: ");
                        direccionIP = Console.ReadLine();

                        Console.WriteLine();

                        if (ordenadores.Count > 0 && ordenadores.ContainsKey(direccionIP))
                        {
                            if (ordenadores.Remove(direccionIP))
                                Console.WriteLine($"Ordenador con dirección IP {direccionIP} eliminado con éxito.\n");
                        }
                        else
                        {
                            Console.WriteLine($"No se ha encontrado a ningún ordenador con la dirección IP: {direccionIP}.\n");
                        }

                        break;
                    case 4:

                        if (ordenadores.Count > 0)
                        {

                            foreach (Ordenador equipo in ordenadores.Values)
                            {
                                Console.WriteLine(equipo.Nombre);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay ningún ordenador introducido.");
                        }

                        Console.WriteLine();

                        break;
                    case 5:

                        string ipEquipo = "";
                        bool existeEquipo = false;

                        Console.Write("Introduzca la dirección IP del ordenador: ");
                        ipEquipo = Console.ReadLine();
                        Console.WriteLine();

                        if (ordenadores.ContainsKey(ipEquipo))
                        {

                            Ordenador equipo = new();
                            existeEquipo = ordenadores.TryGetValue(ipEquipo, out equipo);

                            if (existeEquipo)
                            {
                                Console.WriteLine($"El nombre del equipo es: {equipo.Nombre} y su memoria RAM es de {equipo.Memoria} GB");
                            }

                        }
                        else
                        {
                            Console.WriteLine("No existe ningún equipo con esa dirección IP.");
                        }

                        Console.WriteLine();

                        break;
                    case 6:
                        Console.WriteLine("Has salido del programa.");
                        break;
                    default:
                        Console.WriteLine("Esa opcíón no existe en el menú.");
                        break;
                }
            } while (opcionUsuario != 6);

        }

        public static string pedirIp(ref string ipOrdenador, Dictionary<string, Ordenador> diccionario)
        {
            bool ipValida = false;

            do
            {
                Console.Write("Introduzca la IP del equipo: ");
                ipOrdenador = Console.ReadLine();

                ipValida = Ordenador.ipValida(ipOrdenador);

                Console.WriteLine();

                if (!ipValida)
                {
                    Console.WriteLine("IP no válida, intentelo de nuevo.\n");
                }

                if (diccionario.ContainsKey(ipOrdenador))
                {
                    Console.WriteLine("IP ya asignada a otro dispositivo, introduzca otra dirección IP.\n");
                    ipValida = false;

                }

            } while (!ipValida);

            return ipOrdenador;
        }

        public static void establecerMemoriaRAM(Ordenador o)
        {
            bool memoriaValida = false;
            int memoriaRAM = 0;

            do
            {
                Console.Write("Introduzca la cantidad de memoria RAM: ");
                memoriaValida = int.TryParse(Console.ReadLine(), out memoriaRAM);

                Console.WriteLine();

                try
                {
                    o.Memoria = memoriaRAM;
                }
                catch (NegativeRAMException ex)
                {
                    memoriaValida = false;
                    Console.WriteLine(ex.Message);
                }

            } while (!memoriaValida);
        }

        public static int añadirVariosOrdenadores(String datos, Dictionary<string, Ordenador> diccionario)
        {
            string prefijo = "NONAME_";
            bool ipValida = false;
            bool memoriaRAMValida = false;
            int memoriaRAM = 0;
            int numeroOrdenadoresAñadidos = 0;

            String[] ordenadores = datos.Split(',');

            if (ordenadores.Length > 0)
            {
                for (int i = 0; i < ordenadores.Length; i++)
                {
                    if (ordenadores[i].Split(':').Length == 2)
                    {

                        String ip = ordenadores[i].Split(':')[0];
                        String ram = ordenadores[i].Split(':')[1];

                        ipValida = Ordenador.ipValida(ip);

                        if (ipValida && !diccionario.ContainsKey(ip))
                        {

                            memoriaRAMValida = Int32.TryParse(ram, out memoriaRAM);

                            if (memoriaRAMValida)
                            {
                                Ordenador o = new();
                                o.Nombre = prefijo + ip;
                                o.Memoria = memoriaRAM;

                                diccionario.Add(ip, o);

                                numeroOrdenadoresAñadidos++;
                            }
                        }
                    }
                }
            }

            return numeroOrdenadoresAñadidos;
        }
    }
}
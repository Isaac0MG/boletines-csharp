using System.ComponentModel;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;


            //Comprobar que el usuario introduce un número entero
            do
            {

                Console.WriteLine("- - - MENÚ - - -\n");
                Console.WriteLine("1. Año bisiesto.");
                Console.WriteLine("2. Suma de rango de números.");
                Console.WriteLine("3. Todas las opciones anteriores.");
                Console.WriteLine("4. Salir del programa.\n");

                Console.Write("Introduzca una opción: ");
                opcion = devolverNumero(Console.ReadLine());
                Console.WriteLine();

                switch (opcion)
                {
                    case 1:
                        int año = pedirNumeroRango("Introduzca un año: ", 0, 9999);
                        bool flag = esBisiesto(año);

                        if (flag)
                        {
                            Console.WriteLine("El año es bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("El año no es bisiesto");
                        }

                        Console.WriteLine();

                        if (opcion == 3)
                        {
                            goto case 2;
                        }
                        break;
                    case 2:

                        int numero1 = pedirNumeroRango("Introduzca un número: ", 0, 9999);
                        int numero2 = pedirNumeroRango("Introduzca un número: ", 0, 9999);

                        int? suma = sumaRango(numero1, numero2);

                        if (suma == null)
                        {
                            Console.WriteLine("Error, el primer número no puede ser mayor que el segundo.");
                        }
                        else
                        {
                            Console.WriteLine($"La suma de los números es: {suma,5}");
                        }

                        Console.WriteLine();
                        break;
                    case 3:
                        goto case 1;
                    case 4:

                        break;
                    default:
                        Console.WriteLine("Esa opción no existe en el menú.\n");
                        break;
                }

            } while (opcion != 4);
        }

        public static int devolverNumero(string numeroTexto)
        {
            try
            {

                int numero = Convert.ToInt32(numeroTexto);
                return numero;

            }
            catch (FormatException e)
            {
                return -1;
            }
        }

        public static int pedirNumeroRango(string texto, int minimo, int maximo)
        {
            int año = 0;

            do
            {
                Console.Write(texto);
                año = devolverNumero(Console.ReadLine());
                Console.WriteLine();

                if (año < minimo || año > maximo)
                {
                    año = -1;
                    Console.WriteLine("El número debe estar entre el rango {0} y {1}", minimo, maximo);
                }
            } while (año == -1);

            return año;
        }

        public static bool esBisiesto(int año)
        {
            if (año % 100 == 0)
            {
                if (año % 400 == 0)
                {
                    return true;
                }
            }
            else
            {
                if (año % 4 == 0)
                {
                    return true;
                }
            }

            return false;
        }

        public static int? sumaRango(int numero1, int numero2)
        {
            int suma = 0;

            if (numero1 > numero2)
            {
                return null;
            }
            else
            {
                for (int i = numero1; i <= numero2; i++)
                {
                    suma += i;
                }
            }

            return suma;
        }
    }
}

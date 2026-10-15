using System.Collections;
using System.Diagnostics;

namespace Programacion_Servicios_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "archivo.txt");

            int[] carrerasGanadas = new int[0];
            string[] caballos = new string[0];

            int numeroLinea = 1;

            if (ruta != null && File.Exists(ruta))
            {
                using (StreamReader lector = new StreamReader(ruta))
                {
                    string? linea = lector.ReadLine();

                    while (linea != null)
                    {
                        var c = linea.Split(',');

                        if (c.Length > 0)
                        {
                            switch (numeroLinea)
                            {
                                case 1:

                                    carrerasGanadas = comprobarArrayInt(c);
                                    break;
                                case 2:

                                    caballos = c;
                                    break;
                                default:

                                    Debug.Write($"No se pudo crear el array, número de línea: {numeroLinea}");
                                    break;
                            }
                        }

                        numeroLinea++;
                        linea = lector.ReadLine();
                    }
                }

                if (carrerasGanadas.Length > 0)
                {
                    //VER SI EXISTEN NÚMEROS NEGATIVOS

                    bool hayNumerosNegativos = Array.Exists(carrerasGanadas, n => n < 0);

                    Console.WriteLine(hayNumerosNegativos ? "Hay números negativos" : "No hay números negativos");

                    Console.WriteLine();

                    //NÚMEROS IMPARES

                    int[] numerosImpares = Array.FindAll(carrerasGanadas, n => n % 2 != 0);

                    if (numerosImpares.Length > 0)
                    {
                        Console.WriteLine("= = = LISTA DE NÚMEROS IMPARES = = =\n");

                        foreach (int n in numerosImpares)
                        {
                            Console.Write(n + " ");
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron números impares.");
                    }

                    Console.WriteLine();

                    //ENCONTRAR EL ÚLTIMO ÍNDICE DEL NÚMERO MAYOR QUE 10

                    int posicion = Array.FindLastIndex(carrerasGanadas, n => n > 10);

                    Console.WriteLine(posicion != -1 ? $"La última posición de un número mayor que 10 es: {posicion}" : "No se encontro ningún número mayor que 10.");

                    Console.WriteLine();

                    //MOSTRAR EL VALOR DEL ÚLTIMO POSITIVO

                    int ultimoNumeroPositivo = Array.FindLast(carrerasGanadas, n => n > 0);

                    Console.WriteLine(ultimoNumeroPositivo != 0 ? $"El último número positivo es: {ultimoNumeroPositivo}" : "No se encontró ningún numero positivo.");

                    Console.WriteLine();

                    //CUANTOS SON POSITIVOS Y DIVISIBLES ENTRE 5

                    int[] numeros = Array.FindAll(carrerasGanadas, n => n > 0 && n % 5 == 0);

                    Console.WriteLine($"Hay un total de {numeros.Length} números positivos y divisibles entre 5");

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("No se pudieron leer las carreras ganadas del archivo, compruebe el formato.\n");
                }

                if (caballos.Length > 0)
                {

                    //PRIMER CABALLO CON NOMBRE MÁS LARGO QUE 8 CARACTERES

                    string? caballosOcho = Array.Find(caballos, s => s.Length > 8);

                    Console.WriteLine(caballosOcho != "" ? $"El primer caballo con más de 8 carácteres es {caballosOcho}" : "No se encontró ninguna palabra con más de 8 caracteres.");

                    Console.WriteLine();

                    //MOSTRAR NOMBRES DE CABALLO EN MAYÚSCULAS

                    string[] caballosMayusculas = Array.FindAll(caballos, s => s == s.ToUpper());

                    if (caballosMayusculas.Length > 0)
                    {
                        Console.WriteLine("= = = CABALLOS EN MAYÚSCULAS = = =\n");

                        foreach (string s in caballosMayusculas)
                        {
                            Console.Write(s + "  ");
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron palabras en mayúsculas");
                    }

                    Console.WriteLine();

                    //INDICAR SI EXISTE ALGUN CABALLO DE MÁS De 10 CARÁCTERES Y LA SEGUNDA LETRA ES UNA A

                    string[] caballosDiezLetraA = Array.FindAll(caballos, s => s.Length > 10 && s[1] == 'a');

                    if (caballosDiezLetraA.Length > 0)
                    {
                        Console.WriteLine("= = = PALABRAS CON MÁS 10 CARACTERES Y SEGUNDA LETRA UNA A = = =\n");

                        foreach (string s in caballosDiezLetraA)
                        {
                            Console.Write($"{s,20}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se encontraron palabras con una longitud mayor que 10 carácteres y que su segunda letra sea una A.");
                    }

                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("No se pudieron leer los nombres de caballos del archivo, compruebe el formato.\n");
                }

            }
        }

        public static int[] comprobarArrayInt(string[] array)
        {

            List<int> numerosValidos = new List<int>();

            int n = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out n))
                {
                    numerosValidos.Add(n);
                }
            }

            int[] arrayInt = new int[numerosValidos.Count()];

            for (int i = 0; i < numerosValidos.Count(); i++)
            {
                arrayInt[i] = numerosValidos[i];
            }

            return arrayInt;
        }
    }
}

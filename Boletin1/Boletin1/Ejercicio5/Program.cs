#define FACTORIAL_
#define ASTERISCOS

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)//Directiva
        {
            bool flag = true;
#if FACTORIAL
            int numero = 0;

            do
            {
                flag = true;

                try
                {
                    Console.Write("Introduzca un número: ");
                    numero = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    flag = false;
                }

            } while (!flag);

            int resultado = 0;

            flag = calcularFactorial(numero, ref resultado);

            Console.WriteLine(flag ? $"El factorial es: {resultado}" : "No se pudo realizar el factorial, el número debe ser mayor que 0 y menor o igual que 10.");

#else

            int numeroAstericos = 0;

            do
            {
                flag = true;

                try
                {
                    Console.Write("Introduzca el número de asteriscos: ");
                    numeroAstericos = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException e)
                {
                    flag = false;
                }

            } while (!flag);


            dibujarAsteriscos(numeroAstericos);
#endif
        }

        public static bool calcularFactorial(int numero, ref int resultado)
        {

            if (numero < 0 || numero > 10)
            {
                return false;
            }
            else
            {
                resultado = numero;

                for (int i = --numero; i > 0; i--)
                {
                    resultado *= i;
                }
                return true;
            }

        }

        public static void dibujarAsteriscos(int numeroAsteriscos = 10)
        {

            Random generarNumero = new Random();

            for (int i = 0; i < numeroAsteriscos; i++)
            {
                Console.SetCursorPosition(generarNumero.Next(1, 10), generarNumero.Next(1, 20));
                Console.Write("*");
            }

            /*
            Random generador = new Random();
            int numeroAleatorio = 0;

            int[,] asteriscoDibujar = new int[10, 20];

            do
            {
                for (int i = 0; i < asteriscoDibujar.GetLength(0); i++)
                {
                    for (int j = 0; j < asteriscoDibujar.GetLength(1); j++)
                    {
                        if (numeroAsteriscos > 0)
                        {
                            numeroAleatorio = generador.Next(0, 2);

                            if (numeroAleatorio == 1)
                            {
                                if (asteriscoDibujar[i, j] != 1)
                                {
                                    asteriscoDibujar[i, j] = numeroAleatorio;
                                    numeroAsteriscos--;
                                }
                            }
                            else
                            {
                                asteriscoDibujar[i, j] = 0;
                            }
                        }
                    }
                }
            } while (numeroAsteriscos > 0);

            for (int i = 0; i < asteriscoDibujar.GetLength(0); i++)
            {
                for (int j = 0; j < asteriscoDibujar.GetLength(1); j++)
                {
                    if (asteriscoDibujar[i, j] == 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }*/
        }
    }
}

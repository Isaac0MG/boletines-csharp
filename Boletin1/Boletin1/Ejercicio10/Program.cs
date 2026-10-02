namespace Ejercicio10
{
    internal class Program
    {

        static void Main(string[] args)
        {
            GestorMatriz gm = new GestorMatriz();

            int opcionUsuario = 0;
            bool opcionValida = false;

            do
            {
                do
                {

                    Console.WriteLine("- - - MENÚ - - - \n");
                    Console.WriteLine("1. Mostrar tabla.");
                    Console.WriteLine("2. Mostrar medias.");
                    Console.WriteLine("3. Mostrar suma de una fila.");
                    Console.WriteLine("4. Mostrar suma de una columna.");
                    Console.WriteLine("5. Incremento aleatorio.");
                    Console.WriteLine("6. Cambiar matriz.");
                    Console.WriteLine("7. Salir.\n");

                    Console.Write("Escriba el número de una opción del menú: ");
                    opcionValida = int.TryParse(Console.ReadLine(), out opcionUsuario);

                    Console.WriteLine();

                    if (!opcionValida)
                    {
                        Console.WriteLine("Opción no válida.\n");
                    }

                } while (!opcionValida);

                switch (opcionUsuario)
                {
                    case 1:

                        GestorMatriz.MostrarMatriz<int>(gm.Matriz);

                        Console.WriteLine();
                        break;

                    case 2:

                        Console.WriteLine("- - - MEDIA FILAS DE LA MATRIZ - - -\n");

                        double[] mediaFilas = gm.mediasMatriz(true);
                        int contadorFilas = 0;

                        foreach (var media in mediaFilas)
                        {
                            contadorFilas++;
                            Console.WriteLine($"Fila {contadorFilas}: {media}");
                        }

                        Console.WriteLine();

                        Console.WriteLine("- - - MEDIA COLUMNAS DE LA MATRIZ - - -\n");

                        double[] mediaColumnas = gm.mediasMatriz(false);
                        char caracter = 'A';

                        foreach (var media in mediaColumnas)
                        {
                            Console.WriteLine($"Columna {caracter}: {media}");
                            caracter++;
                        }

                        Console.WriteLine();

                        break;

                    case 3:

                        int filaUsuario = 0;
                        bool filaNoValida = false;

                        do
                        {
                            Console.Write("Introduzca el número de una fila: ");
                            filaNoValida = int.TryParse(Console.ReadLine(), out filaUsuario);

                        } while (!filaNoValida);

                        Console.WriteLine();

                        if (filaUsuario >= 0 && filaUsuario < gm.Matriz.GetLength(0))
                        {
                            Console.WriteLine($"La suma de la fila {filaUsuario} es: {gm.sumaFila(filaUsuario).Item1}");
                        }
                        else
                        {
                            Console.WriteLine("Fila no válida, el valor de la fila debe ser mayor que 0 y menor que " + gm.Matriz.GetLength(0));
                        }

                        Console.WriteLine();

                        break;

                    case 4:

                        int columnaUsuario = 0;
                        bool columnaNoValida = false;

                        do
                        {
                            Console.Write("Introduzca el número de una columna: ");
                            columnaNoValida = int.TryParse(Console.ReadLine(), out columnaUsuario);

                        } while (!columnaNoValida);

                        Console.WriteLine();

                        if (columnaUsuario >= 0 && columnaUsuario < gm.Matriz.GetLength(1))
                        {
                            int sumaColumnas = 0;
                            bool sumaCorrecta = gm.sumaColumna(columnaUsuario, out sumaColumnas);
                            Console.WriteLine($"La suma de la columna {columnaUsuario} es: {sumaColumnas}");
                        }
                        else
                        {
                            Console.WriteLine("Columna no válida, el valor de la columna debe ser mayor que 0 y menor que " + gm.Matriz.GetLength(1));
                        }

                        Console.WriteLine();

                        break;

                    case 5:

                        Random rnd = new Random();

                        int[,] arrayB = new int[gm.Matriz.GetLength(0), gm.Matriz.GetLength(1)];
                        double[,] arrayR = new double[gm.Matriz.GetLength(0), gm.Matriz.GetLength(1)];

                        for (int i = 0; i < arrayB.GetLength(0); i++)
                        {
                            for (int j = 0; j < arrayB.GetLength(1); j++)
                            {
                                arrayB[i, j] = rnd.Next(1, 11);
                            }
                        }

                        Console.WriteLine("- - - NUEVA MATRIZ - - -\n");
                        GestorMatriz.MostrarMatriz<int>(arrayB);
                        Console.WriteLine();

                        Console.WriteLine("- - - MATRIZ ORIGINAL - - -\n");
                        GestorMatriz.MostrarMatriz<int>(gm.Matriz);
                        Console.WriteLine();

                        Console.WriteLine("- - - SUMA DE AMBAS MATRICES - - -\n");
                        arrayR = gm.sumaMatriz(arrayB);
                        GestorMatriz.MostrarMatriz<double>(arrayR);
                        Console.WriteLine();
                        break;

                    case 6:

                        int numeroFilas = 0;
                        bool numeroValido = false;

                        do
                        {

                            Console.Write("Escriba el número de filas: ");
                            numeroValido = int.TryParse(Console.ReadLine(), out numeroFilas);
                            Console.WriteLine();

                            if (!numeroValido || numeroFilas <= 0)
                            {
                                numeroValido = false;
                                Console.WriteLine("Número no válido. El número tiene que ser un entero positivo mayor que 0.\n");
                            }
                        } while (!numeroValido);

                        int numeroColumnas = 0;
                        numeroValido = false;

                        do
                        {

                            Console.Write("Escriba el número de columnas: ");
                            numeroValido = int.TryParse(Console.ReadLine(), out numeroColumnas);
                            Console.WriteLine();

                            if (!numeroValido || numeroColumnas <= 0)
                            {
                                numeroValido = false;
                                Console.WriteLine("Número no válido. El número tiene que ser un entero positivo mayor que 0.\n");
                            }
                        } while (!numeroValido);

                        gm = new GestorMatriz(numeroFilas, numeroColumnas);

                        break;

                    case 7:

                        Console.WriteLine("Saliste del promgrama.");

                        break;

                    default:
                        Console.WriteLine("Opción no existente.\n");
                        break;
                }
            } while (opcionUsuario != 7);
        }
    }
}
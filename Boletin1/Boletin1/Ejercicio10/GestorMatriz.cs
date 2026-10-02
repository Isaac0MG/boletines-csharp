using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio10
{
    internal class GestorMatriz
    {
        int[,] matriz;

        public int[,] Matriz
        {
            get { return this.matriz; }
        }

        Random generador = new Random();

        public GestorMatriz(int numeroFilas, int numeroColumnas)
        {
            matriz = new int[numeroFilas, numeroColumnas];

            for (int i = 0; i < numeroFilas; i++)
            {
                for (int j = 0; j < numeroColumnas; j++)
                {
                    matriz[i, j] = generador.Next(-5, 21);
                }
            }
        }


        public GestorMatriz() : this(3, 4) { }


        public (int, bool) sumaFila(int n)
        {
            if (n <= matriz.GetLength(0) && n > 0)//n negativo
            {
                int suma = 0;

                for (int i = 0; i < matriz.GetLength(1); i++)
                {
                    suma += matriz[n, i];
                }

                return (suma, true);
            }
            else
            {
                return (0, false);
            }
        }

        public bool sumaColumna(int n, out int suma)
        {

            suma = 0;

            if (n <= matriz.GetLength(1) && n > 0)
            {
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    suma += matriz[i, n];
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public double[,] sumaMatriz(object objeto)
        {
            double[,] matriz = new double[0, 0];
            double[,] matriz2 = new double[0, 0];

            if (objeto is double[,])
            {
                matriz = (double[,])objeto;

            }
            else if (objeto is int[,])
            {
                int[,] matrizInt = (int[,])objeto;

                matriz = new double[matrizInt.GetLength(0), matrizInt.GetLength(1)];

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = matrizInt[i, j];
                    }
                }

            }
            else if (objeto is GestorMatriz)
            {
                GestorMatriz gm = (GestorMatriz)objeto;

                matriz = new double[gm.Matriz.GetLength(0), gm.Matriz.GetLength(1)];

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz[i, j] = gm.Matriz[i, j];
                    }
                }

            }
            else
            {
                throw new MatrizException("El tipo de objeto no es un array bidimensional.");
            }

            if (this.matriz.GetLength(0) == matriz.GetLength(0) && this.matriz.GetLength(1) == matriz.GetLength(1))
            {
                matriz2 = new double[matriz.GetLength(0), matriz.GetLength(1)];

                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < matriz.GetLength(1); j++)
                    {
                        matriz2[i, j] = this.matriz[i, j] + matriz[i, j];
                    }
                }
            }

            return matriz2;
        }


        public double[] mediasMatriz(bool flag)
        {
            double[] matrizSuma = new double[0];
            double suma = 0;

            if (flag)
            {
                matrizSuma = new double[this.matriz.GetLength(0)];

                for (int i = 0; i < this.matriz.GetLength(0); i++)
                {
                    for (int j = 0; j < this.matriz.GetLength(1); j++)
                    {
                        suma += matriz[i, j];
                    }
                    matrizSuma[i] = Math.Round((suma / matriz.GetLength(1)), 2);
                    suma = 0;
                }
            }
            else
            {
                matrizSuma = new double[this.matriz.GetLength(1)];

                for (int i = 0; i < this.matriz.GetLength(1); i++)
                {
                    for (int j = 0; j < this.matriz.GetLength(0); j++)
                    {
                        suma += matriz[j, i];
                    }
                    matrizSuma[i] = Math.Round((suma / this.matriz.GetLength(0)), 2);
                    suma = 0;
                }
            }

            return matrizSuma;
        }

        public static void MostrarMatriz<T>(T[,] array)
        {

            char letra = 'A';

            Console.Write(($"{" ",5}"));

            for (int i = 0; i < array.GetLength(1); i++, letra++)
            {
                Console.Write($"{letra,5}");
            }

            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write($"{i + 1,5}");

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j],5}");
                }
                Console.WriteLine();
            }
        }
    }
}

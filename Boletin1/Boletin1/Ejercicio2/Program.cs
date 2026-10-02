namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int edad = 0;
            double peso = 0;

            bool flag = false;

            Console.Write("Introduzca su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine();


            do
            {
                Console.Write("Introduzca su edad: ");
                flag = false;

                try
                {
                    edad = Convert.ToInt32(Console.ReadLine());

                    if (edad < 0)
                    {
                        flag = true;
                    }
                }
                catch (FormatException e)
                {
                    flag = true;
                }

                if (flag)
                {
                    Console.WriteLine("\nLa edad tiene que ser un número entero positivo.\n");
                }
            } while (flag);

            Console.WriteLine();

            do
            {
                Console.Write("Introduzca su peso: ");
                flag = false;

                try
                {
                    peso = Convert.ToDouble(Console.ReadLine());

                    if (peso < 0)
                    {
                        flag = true;
                    }
                }
                catch (FormatException e)
                {
                    flag = true;
                }

                if (flag)
                {
                    Console.WriteLine("\nEl peso tiene que ser un número decimal positivo.\n");
                }
            } while (flag);

            Console.WriteLine();

            Console.WriteLine("Nombre: {0,12}, Edad: {1,4}\n\tPeso: {2,5:F1}\n\"{0}\" \\{1}\\", nombre, edad, peso);

            Console.ReadLine();
        }
    }
}

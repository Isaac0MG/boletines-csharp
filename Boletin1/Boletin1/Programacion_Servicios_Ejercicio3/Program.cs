namespace Programacion_Servicios_Ejercicio3
{
    internal class Program
    {
        delegate double Calculo(double n);

        static void Main(string[] args)
        {
            Calculo operaciones;

            bool esValido;
            double numeroUsuario;

            do
            {
                esValido = true;

                Console.Write("Introduzca un número positivo mayor que 0: ");
                esValido = double.TryParse(Console.ReadLine(), out numeroUsuario);

                Console.WriteLine();

                if (!esValido || numeroUsuario <= 0)
                {
                    Console.WriteLine("El número introducido no es un número positivo mayor que 0.\n");

                    esValido = false;
                }

            } while (!esValido);

            bool opcionValida;
            int opcionUsuario;

            do
            {
                opcionValida = true;

                Console.WriteLine("¿Qué operación desea realizar?\n");
                Console.WriteLine("1. El cuadrado del número");
                Console.WriteLine("2. El cubo del número\n");

                Console.Write("Escriba el número de la opción que deseas realizar: ");
                opcionValida = int.TryParse(Console.ReadLine(), out opcionUsuario);

                Console.WriteLine();

                if (!opcionValida || opcionUsuario < 1 || opcionUsuario > 2)
                {
                    Console.WriteLine("Opción del menú no válida: \n");

                    opcionValida = false;
                }

            } while (!opcionValida);

            string operacionEscogida;

            if (opcionUsuario == 1)
            {
                operaciones = (numeroUsuario) => numeroUsuario * numeroUsuario;
                operacionEscogida = "cuadrado";
            }
            else
            {
                operaciones = (numeroUsuario) => numeroUsuario * numeroUsuario * numeroUsuario;
                operacionEscogida = "cubo";
            }

            Console.WriteLine($"El {operacionEscogida} de {numeroUsuario} es: {operaciones(numeroUsuario)}");

        }
    }
}

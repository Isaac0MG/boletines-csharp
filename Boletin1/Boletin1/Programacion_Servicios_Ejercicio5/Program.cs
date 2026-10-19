namespace Programacion_Servicios_Ejercicio5
{
    internal class Program
    {
        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            string[] s = { "a", "b", "c" };
            bool a = MenuGenerator(s, new MyDelegate[] { () => Console.WriteLine("A\n"), () => Console.WriteLine("B\n"), () => Console.WriteLine("C\n") });

            Console.WriteLine(a ? "T" : "F");

        }

        public static bool MenuGenerator(string[] opciones, MyDelegate[] funciones)
        {
            if (opciones.Length != funciones.Length)
            {
                return false;
            }
            else
            {
                if (opciones.Length > 0)
                {

                    int indice = 0;
                    int opcionUsuario = 0;
                    bool opcionValida = false;

                    while (indice < opciones.Length)
                    {
                        Console.WriteLine($"{indice + 1}. {opciones[indice]}");
                        indice++;
                    }

                    Console.WriteLine($"{indice + 1}. Salir");

                    Console.WriteLine();

                    do
                    {
                        opcionValida = false;

                        while (!opcionValida)
                        {

                            Console.Write("Introduzca una opción del menú: ");
                            opcionValida = int.TryParse(Console.ReadLine(), out opcionUsuario);

                            Console.WriteLine();

                            if (!opcionValida)
                            {
                                Console.WriteLine("Opción no válida, introduzca una opción válida del menú\n");
                            }
                        }

                        opcionUsuario--;

                        if (opcionUsuario < funciones.Length && opcionUsuario >= 0)
                        {
                            funciones[opcionUsuario]();
                        }
                        else if (opcionUsuario == funciones.Length)
                        {
                            Console.WriteLine("Hasta la próxima.\n");
                        }
                        else
                        {
                            Console.WriteLine("Opción no válida.\n");
                        }

                    } while (opcionUsuario != opciones.Length);

                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

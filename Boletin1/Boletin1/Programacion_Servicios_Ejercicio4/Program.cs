namespace Programacion_Servicios_Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? ruta = Path.Combine(Environment.GetEnvironmentVariable("USERPROFILE"), "archivo.txt");

            int[] numbers;
            string[] words;

            if (ruta != null && File.Exists(ruta))
            {
                
            }
        }
    }
}

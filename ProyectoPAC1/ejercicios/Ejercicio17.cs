using System;

namespace Ejercicios
{
    public class Ejercicio17
    {
        // Programa Principal
        public static void Ejecutar()
        {
            bool salir = false;

            while (!salir)
            {
                Menu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        SerieFibonacci();
                        break;

                    case "0":
                        salir = true;
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" === SERIE DE FIBONACCI === \n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Generar serie de Fibonacci.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para generar la Serie de Fibonacci
        public static void SerieFibonacci()
        {
            Console.Clear();
            Console.Write("Cuantos terminos de la serie Fibonacci desea generar? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 0 : ");
            }

            // Si el usuario pide 0 o 1 término, lo manejamos rápido
            if (n == 1)
            {
                Console.WriteLine("\nSerie: 0");
                Console.WriteLine("Suma total     : 0");
                Console.WriteLine("Promedio       : 0.00");
                Console.Write("\nPresione una tecla para salir ...");
                Console.ReadKey();
                return;
            }

            // Variables para la serie
            long a = 0;          // primer término
            long b = 1;          // segundo término
            long suma = 0;       // suma total de la serie
            long siguiente;

            Console.WriteLine($"\nLos primeros {n} terminos de la serie Fibonacci son:\n");

            // Mostramos el primer término
            Console.Write("0");
            suma += a;

            // Si pide más de 1, mostramos el segundo y empezamos el ciclo
            if (n >= 2)
            {
                Console.Write("  1");
                suma += b;
            }

            // Generamos desde el tercer término en adelante
            for (int i = 3; i <= n; i++)
            {
                siguiente = a + b;
                Console.Write($"  {siguiente}");
                suma += siguiente;

                // Actualizamos los dos números anteriores
                a = b;
                b = siguiente;
            }

            Console.WriteLine("\n");

            // Calculamos el promedio
            double promedio = (double)suma / n;

            // Mostramos resultados
            Console.WriteLine($"Suma total     : {suma}");
            Console.WriteLine($"Promedio       : {promedio:F2}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
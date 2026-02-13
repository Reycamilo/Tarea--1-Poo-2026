using System;

namespace Ejercicios
{
    public class Ejercicio23
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
                        EstadisticasCalificaciones();
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
            Console.WriteLine(" === ESTADISTICAS DE CALIFICACIONES === \n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Ingresar calificaciones y ver estadisticas.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para ingresar calificaciones y calcular estadisticas
        public static void EstadisticasCalificaciones()
        {
            Console.Clear();
            Console.Write("Cuantas calificaciones va a ingresar? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 0 : ");
            }

            double[] calificaciones = new double[n];

            Console.WriteLine($"\nIngrese las {n} calificaciones (0-100):\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Calificacion {i + 1} : ");
                double calif;
                while (!double.TryParse(Console.ReadLine(), out calif) || calif < 0 || calif > 100)
                {
                    Console.Write("Error : Ingrese una valo numerico entre 0 y 100 : ");
                }
                calificaciones[i] = calif;
            }

            // Calculamos las estadisticas
            double suma = 0;
            double max = calificaciones[0];
            double min = calificaciones[0];
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < n; i++)
            {
                suma += calificaciones[i];

                if (calificaciones[i] > max) max = calificaciones[i];
                if (calificaciones[i] < min) min = calificaciones[i];

                if (calificaciones[i] >= 60)
                    aprobados++;
                else
                    reprobados++;
            }

            double promedio = suma / n;

            // Desviacion estandar (formula basica)
            double sumaCuadradosDiff = 0;
            for (int i = 0; i < n; i++)
            {
                double diff = calificaciones[i] - promedio;
                sumaCuadradosDiff += diff * diff;
            }
            double desviacion = Math.Sqrt(sumaCuadradosDiff / n);

            // Mostramos resultados
            Console.WriteLine("\n--- Resultados ---\n");

            Console.WriteLine($"Promedio               : {promedio:F2}");
            Console.WriteLine($"Calificacion maxima    : {max:F2}");
            Console.WriteLine($"Calificacion minima    : {min:F2}");
            Console.WriteLine($"Cantidad de aprobados  : {aprobados}");
            Console.WriteLine($"Cantidad de reprobados : {reprobados}");
            Console.WriteLine($"Desviacion estandar    : {desviacion:F2}");

            Console.WriteLine("\nCalificaciones ingresadas:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(calificaciones[i].ToString("F1") + "  ");
                if ((i + 1) % 10 == 0) Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
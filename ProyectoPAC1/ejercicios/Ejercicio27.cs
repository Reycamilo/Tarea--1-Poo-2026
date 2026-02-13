using System;

namespace Ejercicios
{
    public class Ejercicio27
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
                        RegistrarTemperaturas();
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
            Console.WriteLine(" === REGISTRO DE TEMPERATURAS SEMANAL === \n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Registrar temperaturas de 7 dias y ver estadisticas.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para registrar temperaturas y calcular estadisticas
        public static void RegistrarTemperaturas()
        {
            Console.Clear();
            Console.WriteLine("Registro de temperaturas - 7 dias\n");

            double[] temperaturas = new double[7];
            string[] dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            Console.WriteLine("Ingrese la temperatura de cada dia (en °C):\n");

            for (int i = 0; i < 7; i++)
            {
                Console.Write($"{dias[i],-10} : ");
                while (!double.TryParse(Console.ReadLine(), out temperaturas[i]))
                {
                    Console.Write("Error : Ingrese una valo numerico : ");
                }
            }

            // Calculamos las estadisticas
            double suma = 0;
            double maxTemp = temperaturas[0];
            int diaMasCaluroso = 0;
            double minTemp = temperaturas[0];
            int diaMasFrio = 0;

            for (int i = 0; i < 7; i++)
            {
                suma += temperaturas[i];

                if (temperaturas[i] > maxTemp)
                {
                    maxTemp = temperaturas[i];
                    diaMasCaluroso = i;
                }

                if (temperaturas[i] < minTemp)
                {
                    minTemp = temperaturas[i];
                    diaMasFrio = i;
                }
            }

            double promedio = suma / 7;

            // Contamos dias sobre el promedio
            int diasSobrePromedio = 0;
            for (int i = 0; i < 7; i++)
            {
                if (temperaturas[i] > promedio)
                    diasSobrePromedio++;
            }

            Console.WriteLine("\n--- Estadisticas semanales ---\n");

            Console.WriteLine($"Promedio semanal          : {promedio:F2} °C");
            Console.WriteLine($"Dias sobre el promedio    : {diasSobrePromedio}");
            Console.WriteLine($"Dia mas caluroso          : {dias[diaMasCaluroso],-10} ({maxTemp:F2} °C)");
            Console.WriteLine($"Dia mas frio              : {dias[diaMasFrio],-10} ({minTemp:F2} °C)");

            Console.WriteLine("\nVariacion entre dias consecutivos:\n");

            for (int i = 1; i < 7; i++)
            {
                double variacion = temperaturas[i] - temperaturas[i - 1];
                string signo = variacion >= 0 ? "+" : "";
                Console.WriteLine($"{dias[i-1],-10} → {dias[i],-10} : {signo}{variacion:F2} °C");
            }

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
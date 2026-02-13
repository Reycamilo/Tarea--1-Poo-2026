using System;

namespace Ejercicios
{
    public class Ejercicio28
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
                        MatrizNotasParciales();
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
            Console.WriteLine("MATRIZ DE NOTAS POR PARCIAL\n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Ingresar notas de N estudiantes (3 parciales) y ver estadisticas.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para registrar notas y calcular estadisticas
        public static void MatrizNotasParciales()
        {
            Console.Clear();
            Console.Write("Cuantos estudiantes hay en el grupo? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 0 : ");
            }

            // Matriz: filas = estudiantes, columnas = 3 parciales
            double[,] notas = new double[n, 3];

            Console.WriteLine($"\nIngrese las notas de los {n} estudiantes (0-100):\n");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}:");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"   Parcial {j + 1} : ");
                    double nota;
                    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
                    {
                        Console.Write("Error : Ingrese una valo numerico entre 0 y 100 : ");
                    }
                    notas[i, j] = nota;
                }
                Console.WriteLine();
            }

            // Calculamos promedios por estudiante
            double[] promedioEstudiante = new double[n];
            double mejorPromedio = 0;
            int estudianteMejor = 0;

            for (int i = 0; i < n; i++)
            {
                double suma = 0;
                for (int j = 0; j < 3; j++)
                {
                    suma += notas[i, j];
                }
                promedioEstudiante[i] = suma / 3;

                if (promedioEstudiante[i] > mejorPromedio)
                {
                    mejorPromedio = promedioEstudiante[i];
                    estudianteMejor = i;
                }
            }

            // Promedio por parcial
            double[] promedioParcial = new double[3];
            int parcialMasDificil = 0;
            double menorPromedioParcial = 100;

            for (int j = 0; j < 3; j++)
            {
                double suma = 0;
                for (int i = 0; i < n; i++)
                {
                    suma += notas[i, j];
                }
                promedioParcial[j] = suma / n;

                if (promedioParcial[j] < menorPromedioParcial)
                {
                    menorPromedioParcial = promedioParcial[j];
                    parcialMasDificil = j;
                }
            }

            // Mostramos resultados
            Console.WriteLine("\n--- Resultados ---\n");

            Console.WriteLine("Promedio por estudiante:\n");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Estudiante {i + 1,-2} : {promedioEstudiante[i]:F2}");
            }

            Console.WriteLine($"\nEstudiante con mejor promedio : Estudiante {estudianteMejor + 1} ({mejorPromedio:F2})");

            Console.WriteLine("\nPromedio por parcial:\n");
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Parcial {j + 1} : {promedioParcial[j]:F2}");
            }

            Console.WriteLine($"\nParcial mas dificil (menor promedio) : Parcial {parcialMasDificil + 1} ({menorPromedioParcial:F2})");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
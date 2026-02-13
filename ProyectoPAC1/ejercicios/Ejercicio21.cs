using System;

namespace Ejercicios
{
    public class Ejercicio21
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
                        Triangulo();
                        break;

                    case "2":
                        TrianguloInvertido();
                        break;

                    case "3":
                        Rombo();
                        break;

                    case "4":
                        CuadradoHueco();
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
            Console.WriteLine(" === PATRONES DE ASTERISCOS ===\n");
            Console.WriteLine("Elegir opcion para generar patron : ");
            Console.WriteLine("1. Triangulo.");
            Console.WriteLine("2. Triangulo invertido.");
            Console.WriteLine("3. Rombo.");
            Console.WriteLine("4. Cuadrado hueco.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para generar Triangulo
        public static void Triangulo()
        {
            Console.Clear();
            Console.Write("Ingrese el tamaño del triangulo : ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 0 : ");
            }

            Console.WriteLine("\nTriangulo de tamaño " + n + ":\n");

            for (int i = 1; i <= n; i++)
            {
                // Espacios a la izquierda
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Asteriscos
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }

        // Metodo para generar Triangulo Invertido
        public static void TrianguloInvertido()
        {
            Console.Clear();
            Console.Write("Ingrese el tamaño del triangulo invertido : ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 0 : ");
            }

            Console.WriteLine("\nTriangulo invertido de tamaño " + n + ":\n");

            for (int i = n; i >= 1; i--)
            {
                // Espacios a la izquierda
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Asteriscos
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }

        // Metodo para generar Rombo
        public static void Rombo()
        {
            Console.Clear();
            Console.Write("Ingrese el tamaño del rombo (numero impar recomendado) : ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 0 : ");
            }

            Console.WriteLine("\nRombo de tamaño " + n + ":\n");

            // Parte superior (incluyendo la mitad)
            for (int i = 1; i <= n; i++)
            {
                // Espacios
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Asteriscos
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            // Parte inferior (sin repetir la fila del medio)
            for (int i = n - 1; i >= 1; i--)
            {
                // Espacios
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // Asteriscos
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }

        // Metodo para generar Cuadrado Hueco
        public static void CuadradoHueco()
        {
            Console.Clear();
            Console.Write("Ingrese el tamaño del cuadrado hueco : ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 1)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 1 : ");
            }

            Console.WriteLine("\nCuadrado hueco de tamaño " + n + ":\n");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    // Bordes: primera y ultima fila, o primera y ultima columna
                    if (i == 1 || i == n || j == 1 || j == n)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
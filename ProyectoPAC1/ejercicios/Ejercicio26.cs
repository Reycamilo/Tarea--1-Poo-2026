using System;

namespace Ejercicios
{
    public class Ejercicio26
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
                        FrecuenciaNumerosAleatorios();
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
            Console.WriteLine("=== FRECUENCIA DE ELEMENTOS === \n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Generar 20 numeros aleatorios (1-10) y ver frecuencias.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para generar numeros aleatorios y calcular frecuencias
        public static void FrecuenciaNumerosAleatorios()
        {
            Console.Clear();
            Console.WriteLine("Frecuencia de numeros aleatorios (1-10)\n");

            // Generamos 20 numeros aleatorios entre 1 y 10
            Random rnd = new Random();
            int[] numeros = new int[20];

            Console.WriteLine("Numeros generados:\n");

            for (int i = 0; i < 20; i++)
            {
                numeros[i] = rnd.Next(1, 11);  // 1 a 10 inclusive
                Console.Write(numeros[i].ToString().PadLeft(2) + "  ");
                if ((i + 1) % 10 == 0) Console.WriteLine();
            }
            if (20 % 10 != 0) Console.WriteLine();

            // Arreglo para contar frecuencia
            int[] frecuencia = new int[11];

            for (int i = 0; i < 20; i++)
            {
                frecuencia[numeros[i]]++;
            }

            Console.WriteLine("\n--- Frecuencias ---\n");

            int masFrecuente = 0;
            int valorMasFrecuente = 0;
            int menosFrecuente = 21;  // más grande que cualquier frecuencia posible
            int valorMenosFrecuente = 0;

            for (int num = 1; num <= 10; num++)
            {
                int freq = frecuencia[num];

                Console.WriteLine($"Numero {num,2} : {freq,2} veces");

                // Actualizamos el más frecuente
                if (freq > masFrecuente)
                {
                    masFrecuente = freq;
                    valorMasFrecuente = num;
                }

                // Actualizamos el menos frecuente (solo si apareció al menos una vez)
                if (freq > 0 && freq < menosFrecuente)
                {
                    menosFrecuente = freq;
                    valorMenosFrecuente = num;
                }
            }

            Console.WriteLine("\nResultados finales:\n");

            Console.WriteLine($"Numero mas frecuente   : {valorMasFrecuente} ({masFrecuente} veces)");
            
            if (valorMenosFrecuente != 0)
            {
                Console.WriteLine($"Numero menos frecuente : {valorMenosFrecuente} ({menosFrecuente} veces)");
            }
            else
            {
                Console.WriteLine("Todos los numeros aparecieron la misma cantidad de veces");
            }

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
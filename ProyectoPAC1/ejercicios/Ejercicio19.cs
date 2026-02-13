using System;

namespace Ejercicios
{
    public class Ejercicio19
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
                        JuegoAdivinanza();
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
            Console.WriteLine("JUEGO DE ADIVINANZA\n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Jugar - Adivinar el numero (1-100).");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para el Juego de Adivinanza
        public static void JuegoAdivinanza()
        {
            Console.Clear();
            Console.WriteLine("Juego de Adivinanza\n");
            Console.WriteLine("He pensado en un numero entre 1 y 100.");
            Console.WriteLine("Tienes 7 intentos para adivinarlo.\n");

            // Generamos el numero secreto
            Random rnd = new Random();
            int numeroSecreto = rnd.Next(1, 101);  // 1 a 100 inclusive

            int intentos = 0;
            int maxIntentos = 7;
            bool gano = false;
            int ultimoIntento = 0;

            while (intentos < maxIntentos)
            {
                Console.Write($"Intento {intentos + 1} de {maxIntentos} - Ingresa tu numero : ");
                int numero;
                while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 100)
                {
                    Console.Write("Error : Ingrese una valo numerico entre 1 y 100 : ");
                }

                intentos++;
                ultimoIntento = numero;

                if (numero == numeroSecreto)
                {
                    gano = true;
                    break;
                }
                else if (numero < numeroSecreto)
                {
                    Console.WriteLine("El numero es MAYOR\n");
                }
                else
                {
                    Console.WriteLine("El numero es MENOR\n");
                }
            }

            Console.WriteLine("\n--- Fin del juego ---\n");

            if (gano)
            {
                Console.WriteLine($"¡FELICIDADES! Adivinaste el numero {numeroSecreto} en {intentos} intentos.");
            }
            else
            {
                Console.WriteLine($"Lo siento... No lograste adivinarlo.");
                Console.WriteLine($"El numero secreto era: {numeroSecreto}");
                Console.WriteLine($"Tu ultimo intento fue: {ultimoIntento}");
            }

            // Estadisticas
            Console.WriteLine("\nEstadisticas:");
            Console.WriteLine($"Intentos realizados    : {intentos}");
            Console.WriteLine($"Intentos restantes     : {maxIntentos - intentos}");
            Console.WriteLine($"Gano                   : {(gano ? "SI" : "NO")}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
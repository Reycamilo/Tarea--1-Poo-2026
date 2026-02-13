namespace Ejercicios
{
    public class Ejercicio16
    {
        public static void Ejecutar()
        {
            Console.WriteLine("=== NÚMEROS PRIMOS EN UN RANGO ===\n");

            // 1. Pedimos el inicio y el fin
            Console.Write("Desde qué número quieres empezar? ");
            int inicio;
            while (!int.TryParse(Console.ReadLine(), out inicio) || inicio < 0)
            {
                Console.Write("Ingrese un valor numerico : ");
            }

            Console.Write("Hasta qué número quieres llegar? ");
            int fin;
            while(!int.TryParse(Console.ReadLine(), out fin) || fin <= inicio)
            {
                Console.Write("Error : Ingrese un valor valido :");
            }

            // Aseguramos que inicio sea menor o igual que fin
            if (inicio > fin)
            {
                Console.WriteLine("¡Error! El número inicial debe ser menor o igual al final.");
                return;
            }

            Console.WriteLine($"\nBuscando números primos entre {inicio} y {fin}...\n");

            int contadorPrimos = 0;

            // 2. Revisamos cada número del rango
            for (int numero = inicio; numero <= fin; numero++)
            {
                // Solo números mayores a 1 pueden ser primos
                if (numero <= 1) continue;

                // 3. Preguntamos: ¿es primo este número?
                if (EsPrimo(numero))
                {
                    Console.Write(numero + "  ");
                    contadorPrimos++;
                }
            }

            Console.WriteLine("\n\nSe encontraron " + contadorPrimos + " números primos.");

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }

        // funcion basica para determinar si un numero es primo.
        public static bool EsPrimo(int n)
        {
            if (n == 2) return true;
            
            if (n % 2 == 0) return false;

            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false; 
                }
            }

            return true; 
        }
    }
}
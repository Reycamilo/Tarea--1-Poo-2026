using System.Net.NetworkInformation;

namespace Ejercicios
{
    public class Ejercicio15
    {
        public static void Ejecutar ()
        {
            // Pedimos el número al usuario
            Console.Clear();
            Console.WriteLine("=== TABLA DE MULTIPLICAR ===");
            Console.Write("Ingresa un número: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Error : Ingrese un valor numerico : ");
            }

            Console.WriteLine("\nTabla del " + numero + ":\n");

            // Hacemos un ciclo desde 1 hasta 12
            for (int i = 1; i <= 12; i++)
            {
                // resultado
                int resultado = numero * i;

                Console.WriteLine("{0,2}  ×  {1,2}  =  {2,3}", numero, i, resultado);
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        
        }
    }
}
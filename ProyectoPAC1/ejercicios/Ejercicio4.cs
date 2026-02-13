using System.Diagnostics;

namespace Ejercicios
{
    public class Ejercicio4
    {
        // metodo principal del programa
        public static void Ejecutar()
        {
            // Mostramos la bienvenida para luego inicar el programa.
            Ejercicio4.Bienvenida();
            Console.Clear();
   
            // Pedimos los datos y validamos para evitar errores con TyParse y un while.
            // 1. Validar Capital
            Console.Write("Ingrese el monto del prestamo: ");
            double capital;
            while (!double.TryParse(Console.ReadLine(), out capital) || capital <= 0) // condicion que debe cumpir para ejecutarse.
            {
                Console.Write("Error: Debe ingresar un monto numérico mayor a 0: ");
            }

            // 2. Validar Tasa
            Console.Write("Ingrese la tasa de interes (anual %): ");
            double tasa;
            while (!double.TryParse(Console.ReadLine(), out tasa) || tasa <= 0)
            {
                Console.Write("Error: Ingrese una tasa válida (ejemplo: 5.5): ");
            }

            // 3. Validar Tiempo (como entero)
            Console.Write("Ingrese el tiempo en \"meses\": ");
            int tiempo;
            while (!int.TryParse(Console.ReadLine(), out tiempo) || tiempo <= 0)
            {
                Console.Write("Error: El tiempo debe ser un número entero mayor a 0: ");
            }

            // Ajustamos los datos
            double tasaDecimal = tasa / 100;
            double tiempoAnos = tiempo / 12;



             // Calcular interes simple
            double interes = (capital * tasaDecimal * tiempoAnos);
            double total = capital + interes;

            // Cuota mensual
            double cuotaMensual = total / tiempo;

            Console.WriteLine($"\nCapital inicial: {capital:F2}");
            Console.WriteLine($"Interes generado: {interes:F2}");
            Console.WriteLine($"Total a pagar: {total:F2}");

            Console.WriteLine("\nPresione Enter para finalizar el ejercicio...");
            Console.ReadLine();

        }   

        public static void Bienvenida()
        {
            Console.Clear();
            Console.WriteLine("EJERCICIO 4: CALCULADORA DE PRESTAMO SIMPLE.\n");
            Console.Write("Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }

    }
}
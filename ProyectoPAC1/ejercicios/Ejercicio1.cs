using System.ComponentModel.Design;

namespace Ejercicios
{
    public class Ejercicio1
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("EJERCICIO 1: CALCULADORA DE IMC\n");

            // Pedimos datos al usuario para calcular el IMC.

            // Logica de codigo que estare usando para validar la mayoria de las entradas del usuario.*******
            Console.Write("Ingresa tu peso en kg: ");
            double peso;
            while (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
            {
                Console.Write("Error: Ingrese el peso en kg : ");
            }
            // **********************************************************************************************
            
            
            Console.Write("Ingresa tu altura en metros: ");
            double altura;
            while (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.Write("Error: Ingrese una altura en metros : ");
            }
            double imc = peso / (altura * altura);


            

            // Mostramos el resultado del IMC y su clasificacion segun la OMS.
            if (imc < 18.5)
            {
                Console.WriteLine($"Tu IMC es {imc:F2} - Bajo peso");
            }
            else if (imc >= 18.5 && imc < 25) // usamos operadores logicos para hacer mas facil los rangos de peso
            {
                Console.WriteLine($"Tu IMC es {imc:F2} - Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine($"Tu IMC es {imc:F2} - Sobrepeso");
            }
            else
            {
                Console.WriteLine($"Tu IMC es {imc:F2} - Obesidad");
            }

            Console.WriteLine("\nPresiona cualquier tecla para volver al menu...");
            Console.ReadKey();
        }
    }
}
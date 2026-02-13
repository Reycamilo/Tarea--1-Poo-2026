using System;

namespace Ejercicios
{
    public class Ejercicio18
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
                        CalcularFactorialYCombinacion();
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
            Console.WriteLine(" === FACTORIAL Y COMBINACIONES === \n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Calcular factorial y combinaciones.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para calcular Factorial y Combinaciones
        public static void CalcularFactorialYCombinacion()
        {
            Console.Clear();

            // Pedimos n
            Console.Write("Ingrese el valor de n : ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor o igual a 0 : ");
            }

            // Pedimos r
            Console.Write("Ingrese el valor de r (r <= n) : ");
            int r;
            while (!int.TryParse(Console.ReadLine(), out r) || r < 0 || r > n)
            {
                Console.Write("Error : Ingrese una valo numerico valido : ");
            }

            // Calculamos factorial de n
            long factorialN = CalcularFactorial(n);

            // Calculamos factorial de r
            long factorialR = CalcularFactorial(r);

            // Calculamos factorial de (n-r)
            long factorialNR = CalcularFactorial(n - r);

            // Calculamos la combinacion C(n,r)
            long combinacion = 0;

            if (factorialR != 0 && factorialNR != 0)
            {
                combinacion = factorialN / (factorialR * factorialNR);
            }
            else if (r == 0 || r == n)
            {
                combinacion = 1;
            }

            Console.WriteLine("\nResultados:\n");

            Console.WriteLine($"Factorial de {n}     : {factorialN}");
            Console.WriteLine($"C({n},{r})            : {combinacion}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }

        // Metodo auxiliar para calcular el factorial de un numero
        public static long CalcularFactorial(int numero)
        {
            if (numero == 0 || numero == 1)
            {
                return 1;
            }

            long resultado = 1;

            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
    }
}
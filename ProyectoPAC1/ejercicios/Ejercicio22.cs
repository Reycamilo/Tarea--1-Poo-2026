using System;

namespace Ejercicios
{
    public class Ejercicio22
    {
        // Programa Principal
        public static void Ejecutar()
        {
            bool salir = false;
            double resultadoAnterior = 0;
            bool hayResultadoAnterior = false;

            while (!salir)
            {
                Menu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                    case "5":
                    case "6":
                        resultadoAnterior = CalcularOperacion(opcion, resultadoAnterior, hayResultadoAnterior);
                        hayResultadoAnterior = true;
                        break;

                    case "7":
                        resultadoAnterior = RaizCuadrada(resultadoAnterior, hayResultadoAnterior);
                        hayResultadoAnterior = true;
                        break;

                    case "8":
                        resultadoAnterior = Porcentaje(resultadoAnterior, hayResultadoAnterior);
                        hayResultadoAnterior = true;
                        break;

                    case "0":
                        salir = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }


        // Menu principal para imprimir
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine(" === CALCULADORA BASICA ===\n");
            Console.WriteLine("Elegir operacion : ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Potencia (^)");
            Console.WriteLine("6. Raiz cuadrada (solo del ultimo resultado)");
            Console.WriteLine("7. Porcentaje (del ultimo resultado)");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo principal para operaciones que necesitan dos numeros
        public static double CalcularOperacion(string opcion, double anterior, bool usarAnterior)
        {
            Console.Clear();

            double numero1;
            if (usarAnterior)
            {
                Console.WriteLine($"Resultado anterior : {anterior:F2}");
                numero1 = anterior;
            }
            else
            {
                Console.Write("Ingrese el primer numero : ");
                while (!double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.Write("Error : Ingrese una valo numerico : ");
                }
            }

            double numero2;
            Console.Write("Ingrese el segundo numero : ");
            while (!double.TryParse(Console.ReadLine(), out numero2))
            {
                Console.Write("Error : Ingrese una valo numerico : ");
            }

            double resultado = 0;

            if (opcion == "1")
            {
                resultado = numero1 + numero2;
                Console.WriteLine($"{numero1:F2} + {numero2:F2} = {resultado:F2}");
            }
            else if (opcion == "2")
            {
                resultado = numero1 - numero2;
                Console.WriteLine($"{numero1:F2} - {numero2:F2} = {resultado:F2}");
            }
            else if (opcion == "3")
            {
                resultado = numero1 * numero2;
                Console.WriteLine($"{numero1:F2} × {numero2:F2} = {resultado:F2}");
            }
            else if (opcion == "4")
            {
                if (numero2 == 0)
                {
                    Console.WriteLine("Error : No se puede dividir entre 0");
                    resultado = numero1;
                }
                else
                {
                    resultado = numero1 / numero2;
                    Console.WriteLine($"{numero1:F2} ÷ {numero2:F2} = {resultado:F2}");
                }
            }
            else if (opcion == "5")
            {
                resultado = Math.Pow(numero1, numero2);
                Console.WriteLine($"{numero1:F2} ^ {numero2:F2} = {resultado:F2}");
            }

            Console.Write("\nPresione una tecla para continuar ...");
            Console.ReadKey();

            return resultado;
        }

        // Metodo para Raiz Cuadrada (solo del resultado anterior)
        public static double RaizCuadrada(double anterior, bool usarAnterior)
        {
            Console.Clear();

            if (!usarAnterior)
            {
                Console.WriteLine("Aun no hay resultado anterior para calcular raiz.");
                Console.Write("\nPresione una tecla para continuar ...");
                Console.ReadKey();
                return 0;
            }

            if (anterior < 0)
            {
                Console.WriteLine("Error : No se puede calcular raiz cuadrada de numero negativo");
                Console.Write("\nPresione una tecla para continuar ...");
                Console.ReadKey();
                return anterior;
            }

            double resultado = Math.Sqrt(anterior);
            Console.WriteLine($"√{anterior:F2} = {resultado:F2}");

            Console.Write("\nPresione una tecla para continuar ...");
            Console.ReadKey();

            return resultado;
        }

        // Metodo para Porcentaje (del resultado anterior)
        public static double Porcentaje(double anterior, bool usarAnterior)
        {
            Console.Clear();

            if (!usarAnterior)
            {
                Console.WriteLine("Aun no hay resultado anterior para calcular porcentaje.");
                Console.Write("\nPresione una tecla para continuar ...");
                Console.ReadKey();
                return 0;
            }

            Console.Write("Ingrese el porcentaje (%) : ");
            double porcentaje;
            while (!double.TryParse(Console.ReadLine(), out porcentaje))
            {
                Console.Write("Error : Ingrese una valo numerico : ");
            }

            double resultado = (anterior * porcentaje) / 100;
            Console.WriteLine($"{porcentaje:F2}% de {anterior:F2} = {resultado:F2}");

            Console.Write("\nPresione una tecla para continuar ...");
            Console.ReadKey();

            return resultado;
        }
    }
}
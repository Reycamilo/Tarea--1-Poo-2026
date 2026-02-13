namespace Ejercicios
{
    public class Ejercicio14
    {
        
        private static int saldo = 1000;   

        public static void Ejecutar()
        {
            bool salir = false;

            while (!salir)
            {
                Console.Clear();
                Console.WriteLine(" === CAJERO AUTOMATICO ===");
                Console.WriteLine("\n1. Consultar saldo");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("0. Salir");
                Console.Write("\nSeleccione una opcion: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        ConsultarSaldo();
                        break;

                    case "2":
                        Retirar();
                        break;

                    case "3":
                        Depositar();
                        break;

                    case "0":
                        salir = true;
                        Console.WriteLine("¡Gracias por usar el cajero, tenga buen dia mi estimado ..");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

                Console.Write("\nPresione una tecla para continuar ... ");
                Console.ReadKey();
            }
        }

        // Funcion para consultar el salodo
        static void ConsultarSaldo()
        {
            Console.WriteLine($"\nSaldo actual: {saldo} L");
        }

        // funcion para retirar.
        static void Retirar()
        {
            Console.Write("\nMonto a retirar: ");
            if (!int.TryParse(Console.ReadLine(), out int monto) || monto <= 0)
            {
                Console.WriteLine("Error: Ingrese un número válido mayor que 0.");
                return;
            }

            if (monto % 20 != 0)
            {
                Console.WriteLine("Error: El monto debe ser múltiplo de 20.");
                return;
            }

            if (monto > saldo)
            {
                Console.WriteLine("Error: Saldo insuficiente.");
                return;
            }

            DesglosarBilletes(monto);
            saldo -= monto;                    
            Console.WriteLine($"\nRetiro exitoso. Nuevo saldo: {saldo} L");
        }

        // funcion para depositar.
        static void Depositar()
        {
            Console.Write("\nMonto a depositar: ");
            if (!int.TryParse(Console.ReadLine(), out int monto) || monto <= 0)
            {
                Console.WriteLine("Error: Ingrese un número válido mayor que 0.");
                return;
            }

            saldo += monto;                    
            Console.WriteLine($"\nDepósito exitoso. Nuevo saldo: {saldo} L");
        }

        // Esta es la funcio de desglose, un poco mas compleja.
        static void DesglosarBilletes(int monto)
        {
            int[] denominaciones = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
            int[] cantidades = new int[9];

            int resto = monto;

            for (int i = 0; i < denominaciones.Length; i++)
            {
                cantidades[i] = resto / denominaciones[i];
                resto %= denominaciones[i];
            }

            Console.WriteLine("\nEntregando:");
            for (int i = 0; i < denominaciones.Length; i++)
            {
                if (cantidades[i] > 0)
                {
                    string tipo = (denominaciones[i] >= 10) ? "billete" : "moneda";
                    Console.WriteLine($"{denominaciones[i]} → {cantidades[i]} {tipo}(s)");
                }
            }
        }
    }
}
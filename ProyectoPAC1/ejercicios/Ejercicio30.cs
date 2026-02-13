using System;

namespace Ejercicios
{
    public class Ejercicio30
    {
        // Programa Principal
        public static void Ejecutar()
        {
            bool salir = false;

            // Datos del inventario (5 productos fijos)
            int[] codigos = new int[5];
            string[] nombres = new string[5];
            int[] cantidades = new int[5];
            double[] precios = new double[5];

            // Inicializamos con datos de ejemplo (puedes cambiarlos)
            InicializarInventario(codigos, nombres, cantidades, precios);

            while (!salir)
            {
                Menu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarInventario(codigos, nombres, cantidades, precios);
                        break;

                    case "2":
                        BuscarProducto(codigos, nombres, cantidades, precios);
                        break;

                    case "3":
                        ActualizarCantidad(codigos, nombres, cantidades, precios);
                        break;

                    case "4":
                        CalcularValorTotal(codigos, nombres, cantidades, precios);
                        break;

                    case "0":
                        salir = true;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida...");
                        Console.Write("\nPresione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("INVENTARIO SIMPLE\n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Mostrar todo el inventario");
            Console.WriteLine("2. Buscar producto por codigo");
            Console.WriteLine("3. Actualizar cantidad de un producto");
            Console.WriteLine("4. Calcular valor total del inventario");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Inicializa el inventario con 5 productos de ejemplo
        public static void InicializarInventario(int[] codigos, string[] nombres, int[] cantidades, double[] precios)
        {
            codigos[0] = 101;   nombres[0] = "Laptop HP";          cantidades[0] = 8;   precios[0] = 12500.00;
            codigos[1] = 102;   nombres[1] = "Mouse Inalambrico";  cantidades[1] = 25;  precios[1] = 450.50;
            codigos[2] = 103;   nombres[2] = "Teclado RGB";        cantidades[2] = 12;  precios[2] = 850.00;
            codigos[3] = 104;   nombres[3] = "Monitor 24 pulg";    cantidades[3] = 6;   precios[3] = 4200.75;
            codigos[4] = 105;   nombres[4] = "Cable USB-C";        cantidades[4] = 40;  precios[4] = 120.00;
        }

        // 1. Mostrar todo el inventario
        public static void MostrarInventario(int[] codigos, string[] nombres, int[] cantidades, double[] precios)
        {
            Console.Clear();
            Console.WriteLine("INVENTARIO ACTUAL\n");

            Console.WriteLine("Código  Nombre                  Cantidad   Precio unitario   Subtotal");
            Console.WriteLine("------  ----------------------  --------   ---------------   --------");

            for (int i = 0; i < 5; i++)
            {
                double subtotal = cantidades[i] * precios[i];
                Console.WriteLine($"{codigos[i],-6}  {nombres[i],-22}  {cantidades[i],-8}  {precios[i],12:F2}  {subtotal,12:F2}");
            }

            Console.Write("\nPresione una tecla para volver al menu ...");
            Console.ReadKey();
        }

        // 2. Buscar producto por código
        public static void BuscarProducto(int[] codigos, string[] nombres, int[] cantidades, double[] precios)
        {
            Console.Clear();
            Console.Write("Ingrese el codigo del producto a buscar : ");
            int codigoBuscar;
            while (!int.TryParse(Console.ReadLine(), out codigoBuscar))
            {
                Console.Write("Error : Ingrese una valo numerico : ");
            }

            bool encontrado = false;

            for (int i = 0; i < 5; i++)
            {
                if (codigos[i] == codigoBuscar)
                {
                    Console.WriteLine("\nProducto encontrado:\n");
                    Console.WriteLine($"Codigo     : {codigos[i]}");
                    Console.WriteLine($"Nombre     : {nombres[i]}");
                    Console.WriteLine($"Cantidad   : {cantidades[i]}");
                    Console.WriteLine($"Precio     : {precios[i]:F2}");
                    Console.WriteLine($"Subtotal   : {(cantidades[i] * precios[i]):F2}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nNo se encontro ningun producto con ese codigo.");
            }

            Console.Write("\nPresione una tecla para volver al menu ...");
            Console.ReadKey();
        }

        // 3. Actualizar cantidad
        public static void ActualizarCantidad(int[] codigos, string[] nombres, int[] cantidades, double[] precios)
        {
            Console.Clear();
            Console.Write("Ingrese el codigo del producto a actualizar : ");
            int codigoActualizar;
            while (!int.TryParse(Console.ReadLine(), out codigoActualizar))
            {
                Console.Write("Error : Ingrese una valo numerico : ");
            }

            bool encontrado = false;

            for (int i = 0; i < 5; i++)
            {
                if (codigos[i] == codigoActualizar)
                {
                    Console.WriteLine($"\nProducto encontrado: {nombres[i]} - Cantidad actual: {cantidades[i]}");
                    Console.Write("Nueva cantidad : ");
                    int nuevaCantidad;
                    while (!int.TryParse(Console.ReadLine(), out nuevaCantidad) || nuevaCantidad < 0)
                    {
                        Console.Write("Error : Ingrese una valo numerico mayor o igual a 0 : ");
                    }

                    cantidades[i] = nuevaCantidad;
                    Console.WriteLine("\nCantidad actualizada correctamente!");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("\nNo se encontro ningun producto con ese codigo.");
            }

            Console.Write("\nPresione una tecla para volver al menu ...");
            Console.ReadKey();
        }

        // 4. Calcular valor total del inventario
        public static void CalcularValorTotal(int[] codigos, string[] nombres, int[] cantidades, double[] precios)
        {
            Console.Clear();
            Console.WriteLine("VALOR TOTAL DEL INVENTARIO\n");

            double valorTotal = 0;

            for (int i = 0; i < 5; i++)
            {
                double subtotal = cantidades[i] * precios[i];
                valorTotal += subtotal;
            }

            Console.WriteLine($"Valor total del inventario : {valorTotal:F2}");

            Console.Write("\nPresione una tecla para volver al menu ...");
            Console.ReadKey();
        }
    }
}
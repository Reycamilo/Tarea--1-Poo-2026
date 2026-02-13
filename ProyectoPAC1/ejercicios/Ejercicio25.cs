using System;

namespace Ejercicios
{
    public class Ejercicio25
    {
        // Programa Principal
        public static void Ejecutar()
        {
            bool salir = false;

            // Guardamos el arreglo actual aquí
            int[] arreglo = null;
            bool hayArreglo = false;

            while (!salir)
            {
                Menu(hayArreglo);
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        arreglo = CrearArreglo();
                        hayArreglo = true;
                        break;

                    case "2":
                        if (hayArreglo)
                            RotarIzquierda(arreglo);
                        else
                            MostrarMensajeNoHayArreglo();
                        break;

                    case "3":
                        if (hayArreglo)
                            RotarDerecha(arreglo);
                        else
                            MostrarMensajeNoHayArreglo();
                        break;

                    case "4":
                        if (hayArreglo)
                            InvertirArreglo(arreglo);
                        else
                            MostrarMensajeNoHayArreglo();
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

        public static void Menu(bool hayArreglo)
        {
            Console.Clear();
            Console.WriteLine(" === ROTACION DE ARREGLO === \n");

            if (hayArreglo)
                Console.WriteLine("   *** Hay arreglo cargado ***\n");
            else
                Console.WriteLine("   (Aun no hay arreglo cargado)\n");

            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Crear / cargar nuevo arreglo");
            Console.WriteLine("2. Rotar K posiciones a la IZQUIERDA");
            Console.WriteLine("3. Rotar K posiciones a la DERECHA");
            Console.WriteLine("4. Invertir el arreglo");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Crear nuevo arreglo
        public static int[] CrearArreglo()
        {
            Console.Clear();
            Console.Write("De cuantos elementos quiere el arreglo? ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor a 0 : ");
            }

            int[] nuevo = new int[n];

            Console.WriteLine($"\nIngrese los {n} numeros:\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Posicion {i + 1} : ");
                while (!int.TryParse(Console.ReadLine(), out nuevo[i]))
                {
                    Console.Write("Error : Ingrese una valo numerico : ");
                }
            }

            Console.WriteLine("\nArreglo creado exitosamente!");
            MostrarArreglo(nuevo);

            Console.Write("\nPresione una tecla para continuar...");
            Console.ReadKey();

            return nuevo;
        }

        // Rotar a la izquierda
        public static void RotarIzquierda(int[] arr)
        {
            Console.Clear();
            MostrarArregloActual(arr);

            Console.Write("\nCuantas posiciones quiere rotar a la izquierda? ");
            int k;
            while (!int.TryParse(Console.ReadLine(), out k) || k < 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor o igual a 0 : ");
            }

            if (k == 0)
            {
                Console.WriteLine("\n0 posiciones → no se hizo ningun cambio");
            }
            else
            {
                k = k % arr.Length; // optimizacion importante

                if (k == 0)
                {
                    Console.WriteLine("\nMultiplo del tamaño → no cambia");
                }
                else
                {
                    int[] temp = new int[k];

                    // Guardamos los primeros k elementos
                    for (int i = 0; i < k; i++)
                        temp[i] = arr[i];

                    // Movemos el resto hacia la izquierda
                    for (int i = 0; i < arr.Length - k; i++)
                        arr[i] = arr[i + k];

                    // Ponemos los primeros elementos al final
                    for (int i = 0; i < k; i++)
                        arr[arr.Length - k + i] = temp[i];

                    Console.WriteLine($"\nArreglo rotado {k} posiciones a la izquierda:");
                    MostrarArreglo(arr);
                }
            }

            Console.Write("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        // Rotar a la derecha
        public static void RotarDerecha(int[] arr)
        {
            Console.Clear();
            MostrarArregloActual(arr);

            Console.Write("\nCuantas posiciones rotar a la derecha? ");
            int k;
            while (!int.TryParse(Console.ReadLine(), out k) || k < 0)
            {
                Console.Write("Error : Ingrese una valo numerico mayor o igual a 0 : ");
            }

            if (k == 0)
            {
                Console.WriteLine("\n0 posiciones → no se hizo ningun cambio");
            }
            else
            {
                k = k % arr.Length;

                if (k == 0)
                {
                    Console.WriteLine("\nMultiplo del tamaño → no cambia");
                }
                else
                {
                    int[] temp = new int[k];

                    // Guardamos los últimos k elementos
                    for (int i = 0; i < k; i++)
                        temp[i] = arr[arr.Length - k + i];

                    // Movemos el resto hacia la derecha
                    for (int i = arr.Length - 1; i >= k; i--)
                        arr[i] = arr[i - k];

                    // Ponemos los últimos al principio
                    for (int i = 0; i < k; i++)
                        arr[i] = temp[i];

                    Console.WriteLine($"\nArreglo rotado {k} posiciones a la derecha:");
                    MostrarArreglo(arr);
                }
            }

            Console.Write("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        // Invertir arreglo
        public static void InvertirArreglo(int[] arr)
        {
            Console.Clear();
            MostrarArregloActual(arr);

            // Método simple y clásico
            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }

            Console.WriteLine("\nArreglo invertido:");
            MostrarArreglo(arr);

            Console.Write("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        // Metodo para mostrar el arreglo actual.
        public static void MostrarArregloActual(int[] arr)
        {
            Console.WriteLine("Arreglo actual:\n");
            MostrarArreglo(arr);
        }

        public static void MostrarArreglo(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i].ToString().PadLeft(4) + " ");
                if ((i + 1) % 10 == 0) Console.WriteLine();
            }
            if (arr.Length % 10 != 0) Console.WriteLine();
        }

        public static void MostrarMensajeNoHayArreglo()
        {
            Console.Clear();
            Console.WriteLine("Aun no has creado ningun arreglo!");
            Console.WriteLine("Primero selecciona la opcion 1\n");
            Console.Write("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }
    }
}
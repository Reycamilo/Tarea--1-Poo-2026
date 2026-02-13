using System;

namespace Ejercicios
{
    public class Ejercicio24
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
                        LlenarYProcesarArreglo();
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
            Console.WriteLine(" === BUSQUEDA Y ORDENAMIENTO === \n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Llenar arreglo de 10 enteros y realizar operaciones.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para llenar arreglo y realizar todas las operaciones
        public static void LlenarYProcesarArreglo()
        {
            Console.Clear();
            Console.WriteLine("Arreglo de 10 enteros\n");

            int[] numeros = new int[10];

            Console.WriteLine("Ingrese 10 numeros enteros:\n");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Numero {i + 1} : ");
                while (!int.TryParse(Console.ReadLine(), out numeros[i]))
                {
                    Console.Write("Error : Ingrese una valo numerico : ");
                }
            }

            Console.WriteLine("\nArreglo ingresado:");
            MostrarArreglo(numeros);
            Console.WriteLine();

            // 1. Busqueda lineal
            Console.Write("Ingrese el numero que desea buscar : ");
            int buscar;
            while (!int.TryParse(Console.ReadLine(), out buscar))
            {
                Console.Write("Error : Ingrese un valor numerico : ");
            }

            int posicion = BusquedaLineal(numeros, buscar);
            if (posicion != -1)
            {
                Console.WriteLine($"El numero {buscar} se encuentra en la posicion {posicion + 1} (indice {posicion})");
            }
            else
            {
                Console.WriteLine($"El numero {buscar} NO se encuentra en el arreglo");
            }
            Console.WriteLine();

            // 2. Segundo mayor
            int segundoMayor = EncontrarSegundoMayor(numeros);
            if (segundoMayor != int.MinValue)
            {
                Console.WriteLine($"El segundo numero mayor es : {segundoMayor}");
            }
            else
            {
                Console.WriteLine("No se pudo determinar segundo mayor (hay menos de 2 numeros distintos)");
            }
            Console.WriteLine();

            // 3. Ordenar ascendente (burbuja)
            int[] ordenado = (int[])numeros.Clone();
            OrdenarBurbuja(ordenado);
            Console.WriteLine("Arreglo ordenado ascendente (burbuja):");
            MostrarArreglo(ordenado);
            Console.WriteLine();

            // 4. Elementos en posiciones pares
            Console.WriteLine("Elementos en posiciones pares (indice 0,2,4,6,8):");
            for (int i = 0; i < 10; i += 2)
            {
                Console.Write(numeros[i] + "  ");
            }
            Console.WriteLine("\n");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }

        // Metodo auxiliar - Busqueda lineal
        public static int BusquedaLineal(int[] arr, int valor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == valor)
                {
                    return i;
                }
            }
            return -1;
        }

        // Metodo auxiliar - Encontrar segundo mayor
        public static int EncontrarSegundoMayor(int[] arr)
        {
            int mayor = int.MinValue;
            int segundo = int.MinValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > mayor)
                {
                    segundo = mayor;
                    mayor = arr[i];
                }
                else if (arr[i] > segundo && arr[i] != mayor)
                {
                    segundo = arr[i];
                }
            }

            return segundo;
        }

        // Metodo auxiliar - Ordenamiento burbuja ascendente
        public static void OrdenarBurbuja(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // Intercambio
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // Metodo auxiliar - Mostrar arreglo
        public static void MostrarArreglo(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  ");
                if ((i + 1) % 5 == 0) Console.WriteLine();
            }
            if (arr.Length % 5 != 0) Console.WriteLine();
        }
    }
}
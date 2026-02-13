namespace Ejercicios
{
    public class Ejercicio2
    {
        //  Metodo principal para ejecutar este programa.
        public static void Ejecutar()
        {
            bool volver = false;

            do
            {
            //  Limpiamos la pantalla y mandamos a llamar el metodo del menu.
            Console.Clear();
            Ejercicio2.Menu();
            string opcion = Console.ReadLine();

            switch (opcion)

            {
                case "1":
                    Console.Write("\nIngresa la temperatura en Celsius: ");
                    double celsius;
                    while (!double.TryParse(Console.ReadLine(), out celsius))
                        {
                            Console.Write("Error : Ingrese la temperatura en Celsius :");
                        }
                    double fahrenheit = (celsius * 9 / 5) + 32;  // La operacion de conversion
                    Console.WriteLine($"La temperatura en Fahrenheit es: {fahrenheit:F2}");  // Imprimimos en pantalla.
                    break;

                case "2":
                    Console.Write("\nIngresa la temperatura en Celsius: ");
                    while (!double.TryParse(Console.ReadLine(), out celsius))
                        {
                            Console.Write("Error : Ingrese la temperatura en Celsius :");
                        }
                    double kelvin = celsius + 273.15;
                    Console.WriteLine($"La temperatura en Kelvin es: {kelvin:F2}");
                    break;

                case "3":
                    Console.Write("\nIngresa la temperatura en Fahrenheit: ");
                    while (!double.TryParse(Console.ReadLine(), out fahrenheit))
                        {
                            Console.Write("Error : Ingrese la temperatura en Fahrenheit :");
                        }
                    celsius = (fahrenheit - 32) * 5 / 9;
                    Console.WriteLine($"La temperatura en Celsius es: {celsius:F2}");
                    break;

                case "4":
                    Console.Write("\nIngresa la temperatura en Kelvin: ");
                    while (!double.TryParse(Console.ReadLine(), out kelvin) || kelvin <= 0)
                        {
                            Console.Write("Error : Ingrese la temperatura en Kelvin :");
                        }
                    celsius = kelvin - 273.15;
                    Console.WriteLine($"La temperatura en Celsius es: {celsius:F2}");
                    break;

                case "5":
                    volver = true;
                    break;

                default:
                    Console.WriteLine("Opcion no valida. Por favor selecciona una opcion del menu.");
                    break;

            }

            Console.WriteLine("\nPresiona cualquier tecla para volver al menu...");
            Console.ReadKey();
                
            } while(!volver);
        }
        
        // Metodo para mostrar el menu de este ejercisio.
        public static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("EJERCICIO 2: CONVERSCION DE TEMPERATURAS\n");
            Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
            Console.WriteLine("2. Convertir de Celsius a Kelvin");
            Console.WriteLine("3. Convertir de Fahrenheit a Celsius");
            Console.WriteLine("4. Convertir de Kelvin a Celsius");
            Console.WriteLine("5. Volver al menu principal");
            Console.Write("\nSelecciona una opcion: ");
        }
    }
}
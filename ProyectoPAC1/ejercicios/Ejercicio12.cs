namespace Ejercicios
{
    public class Ejercicio12
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine(" === ANO BISIESTO ==="); 

            // Pedimos los datos al usuario y los validamos
            Console.Write("\nIngrese el año : ");
            int year;
            while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
            {
                Console.Write("Error : Ingrese un año correcto (ej: 2024):  ");
            }

            Console.Write("Ingrese el numemro de mes : ");
            int mes;
            while (!int.TryParse(Console.ReadLine(), out mes) || mes <= 0 || mes > 12)
            {
                Console.Write("Error : Ingrese un numero de me valido : ");
            }

            // validamos si es o no bisiesto
            bool esBisiesto = false;  // Asumimos que no lo es al inicio
            if (year % 4 == 0)  // Si divisible por 4
            {
                if (year % 100 != 0 || year % 400 == 0)  // No divisible por 100 O sí por 400
                {
                    esBisiesto = true;
                }
            }



        // Validamos cuantos dias tiene el mes elegido.
        int dias = 0;  // Variable para guardar los días
        if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
        {
            dias = 31;
        }
        else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
        {
            dias = 30;
        }
        else if (mes == 2)
        {
            if (esBisiesto)
            {
                dias = 29;
            }
            else
            {
                dias = 28;
            }
        }
        

        // Mostramos los  resultados
        Console.WriteLine("\nEl mes " + mes + " en el año " + year + " tiene " + dias + " días.");
        if (esBisiesto)
        {
            Console.WriteLine("El año es bisiesto.");
        }
        else
        {
            Console.WriteLine("El año no es bisiesto.");
        }

        Console.Write("\nPresine cualquier tecla para continuar ...");
        Console.ReadKey();



        }
    }
}
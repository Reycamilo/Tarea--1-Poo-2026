using System.Data.Common;
using System.IO.Pipes;

namespace Ejercicios
{
    public class Ejercicio13
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine(" === VALIDACION DE FECHAS ===");

            //  Pedimos el dia, mes y ano al usuario
            Console.Write("Ingrese el numero de dia : "); 
            int dia;
            while (!int.TryParse(Console.ReadLine(), out dia) || dia <= 0 || dia > 31)
            {   
                Console.Write("Error : Ingrese un dia valido : ");
            }

            Console.Write("Ingrese el numero de mes : ");
            int mes;
            while ( !int.TryParse(Console.ReadLine(), out mes) || mes <= 0 || mes > 12)
            {
                Console.Write("Error : Ingrese un mes valido : ");
            }


            Console.Write("Ingrese el año : ");
            int año;
            while (!int.TryParse(Console.ReadLine(), out año) || año <= 0 )
            {
                Console.Write("Error : Ingrese un año valido : ");
            }


            //  Verificamos la cantidad de dias que tiene el mes
            int diasMaximos;

            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                diasMaximos = 30;
            }
            else if (mes == 2)
            {
                // misma validacion para saber si es bisiesto.
                bool esBisiesto = (año % 4 == 0) && (año % 100 != 0 || año % 400 == 0);

                if (esBisiesto)
                {
                    diasMaximos = 29;
                }
                else
                {
                    diasMaximos = 28;
                }
            }
            else
            {
                // Enero, marzo, mayo, julio, agosto, octubre, diciembre
                diasMaximos = 31;
            }

            // Verificamos si el día está dentro del rango permitido
            if (dia > diasMaximos)
            {
                Console.WriteLine($"¡Error! El mes {mes} solo tiene {diasMaximos} días.");
            }
            else
            {
                Console.WriteLine($"La fecha {dia}/{mes}/{año} **ES VÁLIDA** 🎉");

                // Muestro un mensaje por si elije el 29 de febrero de un bisiesto.
                bool esBisiesto = (año % 4 == 0) && (año % 100 != 0 || año % 400 == 0);
                if (esBisiesto && mes == 2 && dia == 29)
                {
                    Console.WriteLine("¡Y es un 29 de febrero porque el año es bisiesto! 🗓️");
                }
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
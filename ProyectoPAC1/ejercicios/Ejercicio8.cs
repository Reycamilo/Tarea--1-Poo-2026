namespace Ejercicios
{
    public class Ejercicio8
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("=== SALARIO SEMANAL ===");


            //  Pedimos los datos al usuario *************************
            Console.Write("Horas trabajadas : ");
            double horas;
            while (!double.TryParse(Console.ReadLine(), out horas) || horas <= 0)
            {
                Console.Write("Error : Ingres las horas trabajadas : ");
            }


            Console.Write("Tarifa por hora : ");
            double tarifa;
            while (!double.TryParse(Console.ReadLine(), out tarifa) || tarifa <= 0)
            {
                Console.Write("Error : Ingres la tarifa : ");
            }



            // Uso de fuciones Math para acotar el codigo y no hacerlo con condiciones.
            double normales = Math.Min(horas, 44);
            double extras = Math.Max(horas - 44, 0);

            //Calculo final.
            double total = normales * tarifa + extras * tarifa * 1.5;

            //  Mostamos los resultados en lempiras.
            Console.WriteLine($"\nNormales: {normales:F1} × {tarifa:F2} = L.{normales*tarifa:F2}");
            Console.WriteLine($"Extras : {extras:F1} × {tarifa*1.5:F2} = L.{extras*tarifa*1.5:F2}");
            Console.WriteLine($"Total  : L.{total:F2}");

            Console.Write("Presione una tecla para continuar ... ");
            Console.ReadKey();

        }
    }
}
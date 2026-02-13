namespace Ejercicios
{
    public class Ejercicio10
    {
        public static void Ejecutar()
        {

            bool salir = false;

            while(!salir)
            {
                Console.Clear();
                Console.WriteLine(" === SISTEMA DE CALIFICACIONES ===");
                Console.WriteLine("1.Ingresar Calificacion");
                Console.WriteLine("0.Salir");

                Console.Write("\nSeleccione una opcion : ");
                string opcion = Console.ReadLine();

                if( opcion == "1")
                {
                    //  Pedimos la calificacion al usuario
                    Console.Write("Ingrese la calificacion (0-100): ");
                    double calificacion;
                    while (!double.TryParse(Console.ReadLine(), out calificacion) || calificacion > 100)
                    {
                        Console.Write("Error : Ingrese una calificacion valida (0-100) : ");
                    }

                    string letra;
                    string estado;

                    if (calificacion >= 90)
                    {
                        letra = "A";
                        estado = "Excelente";
                    }
                    else if (calificacion >= 80)
                    {
                        letra = "B";
                        estado = "Muy Bueno";
                    }
                    else if (calificacion >= 70)
                    {
                        letra = "C";
                        estado = "Bueno";
                    }
                    else if (calificacion >= 60)
                    {
                        letra = "D";
                        estado = "Satisfactorio";
                    }
                    else
                    {
                        letra = "F";
                        estado = "Reprobado";
                    }

                    Console.WriteLine($"\nCalificacion: {calificacion}");
                    Console.WriteLine($"Letra: {letra}");
                    Console.WriteLine($"Estado: {estado}");




                } else if ( opcion == "0")
                {
                    salir = true;
                } else
                {
                    Console.Write("Error : Ingrese una opcion valida : ");
                }

                Console.Write("\nPresione una tecla para continuar ... ");
                Console.ReadKey();

            }
            
        }



    }
}
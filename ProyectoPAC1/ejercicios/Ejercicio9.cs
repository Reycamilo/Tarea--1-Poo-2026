namespace Ejercicios
{
    public class Ejercicio9
    {
        public static void Ejecutar ()
        {
            Console.Clear();
            Console.WriteLine("=== CLASIFICACION DE TRIANGULOS ===");


            //  Pedimos a los usuarios los lados de los triangulos.
            Console.Write("Lado 1 : ");
            double lado1;
            while(!double.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
            {
                Console.Write("Error : Ingrese un valor numerico positivo para el lado 1 : ");
            }

            Console.Write("Lado 2 : ");
            double lado2;
            while(!double.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
            {
                Console.Write("Error : Ingrese un valor numerico positivo para el lado 2 : ");
            }

            Console.Write("Lado 3 : ");
            double lado3;
            while(!double.TryParse(Console.ReadLine(), out lado3) || lado3 <= 0)
            {
                Console.Write("Error : Ingrese un valor numerico positivo para el lado 3 : ");
            }

            // Usamos la funcion para validar el trianguo.
            bool validar = ValidarTriangulo(lado1, lado2, lado3);

            // Mostramos los resultados si validar es verdadero.
            if(validar)
            {
                Console.Write($"\nSegun sus lados es {PorSuLado(lado1, lado2, lado3)}");
                Console.Write($"\nSegun sus angulso es {PorSuAngulo(lado1, lado2, lado3)}");
            
            } else
            {
                Console.Write("No es trinauglo.");
            }

            Console.Write("\n\nPulse una tecla para continuar ... ");
            Console.ReadKey();

        }

        // Funcion para validar el trinagulo.
        public static bool ValidarTriangulo(double a, double b, double c)
        {
          return a + b > c && a + c > b && b + c > a;
        }

        // Metodo para clasificar el tringulo segun sus lados.
        public static string PorSuLado(double a, double b, double c)
        {
            if( a == b && b == c)
                return "Equilatero";
            if ( a == b || a == c || b == c)
                return "Isoceles";
            
            return "Escaleno";
            
        }

        public static string PorSuAngulo(double a, double b, double c)
        {
            // Cuadrados de los lados.
            double a2 = a * a;
            double b2 = b * b;
            double c2 = c * c;

            // El ángulo opuesto al lado más grande es el que puede ser recto o obtuso
            if (a2 + b2 == c2 || a2 + c2 == b2 || b2 + c2 == a2)
                return "Rectángulo";

            if (a2 + b2 < c2 || a2 + c2 < b2 || b2 + c2 < a2)
                return "Obtusángulo";

            return "Acutángulo";
        }

       
    }
}
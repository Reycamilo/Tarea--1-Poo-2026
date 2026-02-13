using System.Timers;

namespace Ejercicios
{
    public class Ejercicio6
    {
        //  Programa Principal
        public static void Ejecutar()
        {
            bool salir = false;

            while(!salir)
            {
                Menu();
                string opcion = Console.ReadLine();

                switch(opcion)
                {
                    case "1" :
                        Circulo();
                        break;
                    
                    case "2":
                        Triangulo();
                        break;
                    
                    case "3":
                        Rectangulo();
                        break;

                    case "4":
                        Trapecio();
                        break;

                    case "0" :
                        salir = true;
                        break;
                        
                }
            }
        }

        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("AREA Y PERIMETRO\n");
            Console.WriteLine("Elegir opcion para calcular el area de : ");
            Console.WriteLine("1.Circulo.");
            Console.WriteLine("2.Triangulo.");
            Console.WriteLine("3.Rectangulo.");
            Console.WriteLine("4.Trapecio.");
            Console.WriteLine("\n0.Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para calcular el Area del Circulo
        public static void Circulo()
        {
            Console.Clear();
            Console.Write("Ingrese el radio : ");
            double radio;
            while(!double.TryParse(Console.ReadLine(), out radio) || radio <= 0)
            {
                Console.Write("Error : Ingrese un numero valido : ");
            }

            double area = Math.PI * radio * radio;
            double perimetro = 2 * Math.PI * radio;

            Console.WriteLine($"El Area del Circulo es de : {area:F2}");
            Console.WriteLine($"El Perimetro del Ciculo es de : {perimetro:F2}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }


        // Metodo para caulcar el area del Triangulo
        public static void Triangulo()
        {
            Console.Clear();
            Console.Write("Ingrese lado 1 : ");
            double lado1;
            while(!double.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para el lado 1 : ");
            }


            Console.Write("Ingrese lado 2 : ");
            double lado2;
            while(!double.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para el lado 2 : ");
            }


            Console.Write("Ingrese lado 3 : ");
            double lado3;
            while(!double.TryParse(Console.ReadLine(), out lado3) || lado3 <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para el lado 3 : ");
            }


            Console.Write("Ingrese la altura : ");
            double altura;
            while(!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.Write("Error : Ingrese un valor numerico para la altura : ");
            }

            double area = (lado1 * altura) / 2;
            double perimetro = lado1 + lado2 + lado3;

            Console.WriteLine($"El Area del Triangulo es de : {area:F2}");
            Console.WriteLine($"El Perimetro del Triangulo es de : {perimetro:F2}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }


        // Metodo para calcular el area del Rectangulo.
        public static void Rectangulo()
        {
            Console.Clear();
            Console.Write("Ingrese la base : ");
            double @base;
            while(!double.TryParse(Console.ReadLine(), out @base) || @base <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para la base : ");
            }

            Console.Write("Ingrese la altura : ");
            double altura;
            while(!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.Write("Error : Ingrese un valor numerico para la altura : ");
            }

            double area = (@base * altura);
            double perimetro = 2 * (@base + altura);

            Console.WriteLine($"El Area del Rectangulo es de : {area:F2}");
            Console.WriteLine($"El Perimetro del Rectangulo es de : {perimetro:F2}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }


        // metodo par calcular el area y el perimetro del trapecio.
        public static void Trapecio()
        {
            Console.Clear();
            Console.Write("Ingrese la base mayor : ");
            double baseMayor;
            while(!double.TryParse(Console.ReadLine(), out baseMayor) || baseMayor <= 0) //la validcion de siempre.
            {
                Console.Write("Error : Ingrese una valo numerico para la base mayor : ");
            }

            Console.Write("Ingrese la base menor : ");
            double baseMenor;
            while(!double.TryParse(Console.ReadLine(), out baseMenor) || baseMenor <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para la base menor : ");
            }

            Console.Write("Ingrese la altura : ");
            double altura;
            while(!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para la altura : ");
            }

            Console.Write("Ingrese el lado 1 : ");
            double lado1;
            while(!double.TryParse(Console.ReadLine(), out lado1) || lado1 <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para el lado 1 : ");
            }

            Console.Write("Ingrese el lado 2 : ");
            double lado2;
            while(!double.TryParse(Console.ReadLine(), out lado2) || lado2 <= 0)
            {
                Console.Write("Error : Ingrese una valo numerico para el lado 2 : ");
            }


            // calculos de area y perimetro
            double area = (baseMayor + baseMenor) * altura / 2;
            double perimetro = baseMayor + baseMenor + lado1 + lado2;

            Console.WriteLine($"El Area del Trapecio es de : {area:F2}");
            Console.WriteLine($"El Perimetro del Trapecio es de : {perimetro:F2}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();

        }

    }
}
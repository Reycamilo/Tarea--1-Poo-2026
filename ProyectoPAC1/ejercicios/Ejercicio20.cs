using System;

namespace Ejercicios
{
    public class Ejercicio20
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
                        ValidacionContrasena();
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
            Console.WriteLine(" === VALIDACION DE CONTRASEÑA ===\n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Validar contraseña segura.");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo para Validacion de Contraseña
        public static void ValidacionContrasena()
        {
            Console.Clear();
            Console.WriteLine("Validacion de Contraseña Segura\n");
            Console.WriteLine("La contraseña debe cumplir con:\n");
            Console.WriteLine(" - Minimo 8 caracteres");
            Console.WriteLine(" - Al menos 1 letra mayuscula");
            Console.WriteLine(" - Al menos 1 letra minuscula");
            Console.WriteLine(" - Al menos 1 numero");
            Console.WriteLine(" - Al menos 1 caracter especial (!@#$%^&* etc)\n");

            bool esValida = false;
            string contrasena = "";

            while (!esValida)
            {
                Console.Write("Ingrese su contraseña : ");
                contrasena = Console.ReadLine();

                // Validamos cada requisito
                bool tieneMinimo8 = contrasena.Length >= 8;
                bool tieneMayuscula = false;
                bool tieneMinuscula = false;
                bool tieneNumero = false;
                bool tieneEspecial = false;

                foreach (char c in contrasena)
                {
                    if (char.IsUpper(c)) tieneMayuscula = true;
                    if (char.IsLower(c)) tieneMinuscula = true;
                    if (char.IsDigit(c)) tieneNumero = true;
                    if ("!@#$%^&*()-_=+[{]};:'\",<.>/?\\|~`".Contains(c)) tieneEspecial = true;
                }

                // Si todo está correcto, salimos del ciclo
                if (tieneMinimo8 && tieneMayuscula && tieneMinuscula && tieneNumero && tieneEspecial)
                {
                    esValida = true;
                }
                else
                {
                    Console.WriteLine("\nLa contraseña NO cumple con los requisitos. Faltan:\n");

                    if (!tieneMinimo8)
                        Console.WriteLine(" - Minimo 8 caracteres");
                    if (!tieneMayuscula)
                        Console.WriteLine(" - Al menos 1 letra mayuscula");
                    if (!tieneMinuscula)
                        Console.WriteLine(" - Al menos 1 letra minuscula");
                    if (!tieneNumero)
                        Console.WriteLine(" - Al menos 1 numero");
                    if (!tieneEspecial)
                        Console.WriteLine(" - Al menos 1 caracter especial");

                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n¡Excelente! La contraseña es valida y segura.");
            Console.WriteLine($"Contraseña ingresada : {contrasena}");

            Console.Write("\nPresione una tecla para salir ...");
            Console.ReadKey();
        }
    }
}
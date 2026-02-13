using System;
using System.Runtime.InteropServices;

namespace ProgramaPrincipal
{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;

            // ciclo principal del programa que muestra el menu y espera la seleccion del usuario
            while(!salir)
            {
                Console.Clear();
                MostrarMenu();
                
                string opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "0":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    case "1":
                        Ejercicios.Ejercicio1.Ejecutar();
                        break;

                    case "2":
                        Ejercicios.Ejercicio2.Ejecutar();
                        break;
                    
                    case "3": 
                        Ejercicios.Ejercicio3.Ejecutar();
                        break;

                    case "4":
                        Ejercicios.Ejercicio4.Ejecutar();
                        break;

                    case "5":
                        Ejercicios.Ejercicio5.Ejecutar();
                        break;
                    
                    case "6":
                        Ejercicios.Ejercicio6.Ejecutar();
                        break;
                    
                    case "7":
                        Ejercicios.Ejercicio7.Ejecutar();
                        break;
                    
                    case "8":
                        Ejercicios.Ejercicio8.Ejecutar();
                        break;

                    case "9":
                        Ejercicios.Ejercicio9.Ejecutar();
                        break;

                    case "10":
                        Ejercicios.Ejercicio10.Ejecutar();
                        break;

                    case "11":
                        Ejercicios.Ejercicio11.Ejecutar();
                        break;

                    case "12": 
                        Ejercicios.Ejercicio12.Ejecutar();
                        break;

                    case "13":
                        Ejercicios.Ejercicio13.Ejecutar();
                        break;
                    
                    case "14":
                        Ejercicios.Ejercicio14.Ejecutar();
                        break;

                    case "15":
                        Ejercicios.Ejercicio15.Ejecutar();
                        break;

                    case "16":
                        Ejercicios.Ejercicio16.Ejecutar();
                        break;

                    case "17":
                        Ejercicios.Ejercicio17.Ejecutar();
                        break;
                    
                    case "18":
                        Ejercicios.Ejercicio18.Ejecutar();
                        break;

                    case "19":
                        Ejercicios.Ejercicio19.Ejecutar();
                        break;

                    case "20":
                        Ejercicios.Ejercicio20.Ejecutar();
                        break;

                    case "21":
                        Ejercicios.Ejercicio21.Ejecutar();
                        break;
                    
                    case "22":
                        Ejercicios.Ejercicio22.Ejecutar();
                        break;

                    case "23":
                        Ejercicios.Ejercicio23.Ejecutar();
                        break;

                    case "24":
                        Ejercicios.Ejercicio24.Ejecutar();
                        break;

                    case "25":
                        Ejercicios.Ejercicio25.Ejecutar();
                        break;

                    case "26":
                        Ejercicios.Ejercicio26.Ejecutar();
                        break;

                    case "27":
                        Ejercicios.Ejercicio27.Ejecutar();
                        break;

                    case "28":
                        Ejercicios.Ejercicio28.Ejecutar();
                        break;

                    case "29":
                        Ejercicios.Ejercicio29.Ejecutar();
                        break;

                    case "30":
                        Ejercicios.Ejercicio30.Ejecutar();
                        break;


                }
                
            }
        }


            // Funcon para mostrar el menu principal del programa con los 30 ejercicios organizados por bloques tematicos
            static void MostrarMenu()
        {
            Console.WriteLine("========================================");
            Console.WriteLine("  BIENVENIDO A LA TAREA DE CAMILO");
            Console.WriteLine("========================================\n");

            Console.WriteLine("01. Calculadora de IMC");
            Console.WriteLine("02. Conversion de temperatura");
            Console.WriteLine("03. Desglose de billetes");
            Console.WriteLine("04. Calculadora de prestamo simple");
            Console.WriteLine("05. Tiempo transcurrido");
            Console.WriteLine("06. Area y perimetro");
            Console.WriteLine("07. Conversion de unidades de almacenamiento");
            Console.WriteLine("08. Calculo de salario semanal");
            Console.WriteLine("09. Clasificacion de triangulos");
            Console.WriteLine("10. Sistema de calificaciones UNAH");
            Console.WriteLine("11. Calculadora de descuentos");
            Console.WriteLine("12. Anio bisiesto y dias del mes");
            Console.WriteLine("13. Validador de fecha");
            Console.WriteLine("14. Cajero automatico");
            Console.WriteLine("15. Tabla de multiplicar extendida");
            Console.WriteLine("16. Numeros primos en rango");
            Console.WriteLine("17. Serie Fibonacci");
            Console.WriteLine("18. Factorial y combinaciones");
            Console.WriteLine("19. Juego de adivinanza");
            Console.WriteLine("20. Validacion de contrasenia");
            Console.WriteLine("21. Patron de asteriscos");
            Console.WriteLine("22. Calculadora con menu");
            Console.WriteLine("23. Estadisticas de calificaciones");
            Console.WriteLine("24. Busqueda y ordenamiento");
            Console.WriteLine("25. Rotacion de arreglo");
            Console.WriteLine("26. Frecuencia de elementos");
            Console.WriteLine("27. Arreglo de temperaturas");
            Console.WriteLine("28. Matriz de notas por parcial");
            Console.WriteLine("29. Juego de Gato (Tic-Tac-Toe)");
            Console.WriteLine("30. Inventario simple");

            Console.WriteLine("0. SALIR\n");
            Console.Write("Selecciona un numero: ");
        }              
                
        

    }
}


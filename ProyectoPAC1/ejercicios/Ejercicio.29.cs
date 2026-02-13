using System;

namespace Ejercicios
{
    public class Ejercicio29
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
                        JugarGato();
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
            Console.WriteLine("JUEGO DE GATO (TIC-TAC-TOE)\n");
            Console.WriteLine("Elegir opcion : ");
            Console.WriteLine("1. Jugar contra otro jugador (2 jugadores).");
            Console.WriteLine("\n0. Salir");
            Console.Write("Opcion : ");
        }

        // Metodo principal del juego
        public static void JugarGato()
        {
            // Dibujamos el tablero 
            Console.Clear();
            Console.WriteLine("JUEGO DE GATO - 2 Jugadores\n");
            Console.WriteLine("Jugador 1 = X     Jugador 2 = O\n");
            Console.WriteLine("Posiciones del tablero:\n");
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 4 | 5 | 6 ");
            Console.WriteLine("---+---+---");
            Console.WriteLine(" 7 | 8 | 9 \n");

            char[,] tablero = new char[3, 3];
            InicializarTablero(tablero);

            bool juegoActivo = true;
            char jugadorActual = 'X';
            int turnos = 0;

            while (juegoActivo && turnos < 9)
            {
                MostrarTablero(tablero);

                // Pedir posicion al jugador actual
                Console.Write($"Jugador {jugadorActual} - Ingrese posicion (1-9) : ");
                int posicion;
                while (!int.TryParse(Console.ReadLine(), out posicion) || posicion < 1 || posicion > 9)
                {
                    Console.Write("Error : Ingrese una valo numerico entre 1 y 9 : ");
                }

                // Convertir posicion 1-9 a coordenadas fila/columna
                int fila = (posicion - 1) / 3;
                int columna = (posicion - 1) % 3;

                // Validar que la casilla esté libre
                if (tablero[fila, columna] != ' ')
                {
                    Console.WriteLine("\nEsa posicion ya esta ocupada. Intente de nuevo.");
                    Console.Write("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                // Colocar ficha
                tablero[fila, columna] = jugadorActual;
                turnos++;

                // Verificar si hay ganador
                if (HayGanador(tablero, jugadorActual))
                {
                    MostrarTablero(tablero);
                    Console.WriteLine($"\n¡FELICIDADES! El Jugador {jugadorActual} HA GANADO!");
                    juegoActivo = false;
                }
                // Verificar empate
                else if (turnos == 9)
                {
                    MostrarTablero(tablero);
                    Console.WriteLine("\n¡EMPATE! No hay mas movimientos.");
                    juegoActivo = false;
                }
                else
                {
                    // Cambiar jugador
                    jugadorActual = (jugadorActual == 'X') ? 'O' : 'X';
                }
            }

            Console.Write("\nPresione una tecla para volver al menu ...");
            Console.ReadKey();
        }

        // Inicializa el tablero con espacios
        public static void InicializarTablero(char[,] tablero)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tablero[i, j] = ' ';
                }
            }
        }

        // Muestra el tablero actual
        public static void MostrarTablero(char[,] tablero)
        {
            Console.Clear();
            Console.WriteLine("JUEGO DE GATO - 2 Jugadores\n");

            for (int i = 0; i < 3; i++)
            {
                Console.Write(" ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tablero[i, j]);
                    if (j < 2) Console.Write(" | ");
                }
                Console.WriteLine();

                if (i < 2) Console.WriteLine("---+---+---");
            }
            Console.WriteLine();
        }

        // Verifica si el jugador actual ganó
        public static bool HayGanador(char[,] tablero, char jugador)
        {
            // Filas
            for (int i = 0; i < 3; i++)
            {
                if (tablero[i, 0] == jugador && tablero[i, 1] == jugador && tablero[i, 2] == jugador)
                    return true;
            }

            // Columnas
            for (int j = 0; j < 3; j++)
            {
                if (tablero[0, j] == jugador && tablero[1, j] == jugador && tablero[2, j] == jugador)
                    return true;
            }

            // Diagonal principal
            if (tablero[0, 0] == jugador && tablero[1, 1] == jugador && tablero[2, 2] == jugador)
                return true;

            // Diagonal secundaria
            if (tablero[0, 2] == jugador && tablero[1, 1] == jugador && tablero[2, 0] == jugador)
                return true;

            return false;
        }
    }
}
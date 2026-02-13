namespace Ejercicios
{
    public class Ejercicio5
    {
        
        // Programa Principal.
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("CALCULAR TIEMPO TRANSCURRIDO\n");

        // Pedimos las dos horas con su formato.
        string hora1 = PedirHora("Primera hora en formato 24hrs (ej: 14:25:30): ");
        string hora2 = PedirHora("Segunda hora en formato 24hrs (ej: 17:48:12): ");

        if (hora1 == null || hora2 == null) // hacemos una primera validacion de valores.
        {
            Console.WriteLine("\nPrograma terminado por entrada incorrecta.");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
            return;
        }

        // Hago uso del metodo de ConvertirASegundos
        int segundos1 = ConvertirASegundos(hora1);
        int segundos2 = ConvertirASegundos(hora2);

        // Calculamos diferencia y uso valor abosoluto.
        int diferencia = Math.Abs(segundos2 - segundos1);

        // Convertimos a horas, minutos, segundos
        int diff_h = diferencia / 3600;
        int sobrante = diferencia % 3600;
        int diff_m = sobrante / 60;
        int diff_s = sobrante % 60;

        // Mostramos resultado
        Console.WriteLine($"\nHora 1: {hora1}");
        Console.WriteLine($"Hora 2: {hora2}\n");

        Console.WriteLine($"Diferencia: {diff_h} horas, {diff_m} minutos y {diff_s} segundos");

        Console.WriteLine("\nPresiona cualquier tecla para salir...");
        Console.ReadKey();
        }


    // Metodo para pedir la hora, con todas las validaciones.
    static string PedirHora(string mensaje)
    {
        while (true)
        {
            Console.Write(mensaje);
            string entrada = Console.ReadLine()?.Trim();

            if (string.IsNullOrEmpty(entrada)) // Verifico si hay valores adentro.
            {
                Console.WriteLine("→ No puedes dejarlo en blanco. Intenta de nuevo.");
                continue;
            }

            string[] partes = entrada.Split(':'); // separo en un arreglo mediante " : "

            if (partes.Length != 3) // verifico que esten las 3 partes del formato.
            {
                Console.WriteLine("→ Debe tener exactamente 3 partes separadas por : (hora:minuto:segundo)");
                continue;
            }

            // Uso el TryParse para verificar si son numeros y guardalos, y uso operadores logicos para hacer las 3 validaciones.
            if (!int.TryParse(partes[0], out int h) ||
                !int.TryParse(partes[1], out int m) ||
                !int.TryParse(partes[2], out int s))
            {
                Console.WriteLine("→ Las partes deben ser números.");
                continue;
            }

            if (h < 0 || h > 23) // Validacion Para que el usuario no coloque mal las horas
            {
                Console.WriteLine("→ La hora debe estar entre 0 y 23.");
                continue;
            }

            if (m < 0 || m > 59)
            {
                Console.WriteLine("→ Los minutos deben estar entre 0 y 59.");
                continue;
            }

            if (s < 0 || s > 59)
            {
                Console.WriteLine("→ Los segundos deben estar entre 0 y 59.");
                continue;
            }

            return $"{h:D2}:{m:D2}:{s:D2}";  // Retornamos los resultados con el formato.
        }
    }


    // Convierte a sengudos la hora ingresada.
    static int ConvertirASegundos(string hora)
    {
        string[] partes = hora.Split(':');
        int h = int.Parse(partes[0]);
        int m = int.Parse(partes[1]);
        int s = int.Parse(partes[2]);

        return h * 3600 + m * 60 + s;
    }
    }
} 
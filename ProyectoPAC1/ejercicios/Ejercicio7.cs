namespace Ejercicios
{
    public class Ejercicio7
    {
        public static void Ejecutar()
        {

            Bienvenida();
            
            // Pedimos el valor a convertir
            Console.Write("Ingrese un valor a convertir (eje : 1024) :");
            double valor;
            while (!double.TryParse(Console.ReadLine(), out valor) || valor < 0)
            {
                Console.Write("Error : Ingrese un valor validdo (eje : 2048) :");
            }


            //  Pedimos la unidade de origen del valor
            Console.Write("Ingrese la unidad origen (bytes, kb, mb, gb, tb) : ");
            string origen = Console.ReadLine().ToLower();

            while (!(origen == "bytes" || origen == "kb" || origen == "mb" || origen == "gb" || origen == "tb")) // validamos si es una unidad correcta
            {
                Console.Write("Ingrese una unidad corecta de orige(bytes, kb, mb, gb, tb) : ");
                origen = Console.ReadLine().ToLower();
            }


            // Pedimos la unidad de destino del valor
            Console.Write("Ingrese la unidad destino (bytes, kb, mb, gb, tb) : ");
            string destino = Console.ReadLine().ToLower(); while (!(origen == "bytes" || origen == "kb" || origen == "mb" || origen == "gb" || origen == "tb"))
            {
                Console.Write("Ingrese una unidad corecta de orige (bytes, kb, mb, gb, tb) :");
                origen = Console.ReadLine().ToLower();
            }
             while (!(destino == "bytes" || destino == "kb" || destino == "mb" || destino == "gb" || destino == "tb")) // hacemos la misma validacion.
            {
                Console.Write("Ingrese una unidad corecta para el destino (bytes, kb, mb, gb, tb) :");
                destino = Console.ReadLine().ToLower();
            }



            // Usamos el Metodo PasaHaBytes para hacer la conversion mas facil.
            double bytes = PasarHaBytes(valor,origen);
            // Pasamos los bytes ha la unidad de destino.
            double resultado = BytesHaUnidad(destino,bytes);
            
            // Mostrar resultados
            Console.WriteLine($"{valor} {origen.ToUpper()} son : {resultado:F2} {destino.ToUpper()}");

            Console.Write("\nPresione una tecla para continuar");
            Console.ReadKey();

        }

        public static void Bienvenida()
        {
            Console.Clear();
            Console.WriteLine("=== CONVERSION DE UNIDADES DE ALMACENAMIENTO ===");
            Console.Write("\nPresione una tecla para continuar ...");
            Console.ReadKey();
        }

        // Metodo para pasar el valor que nos dieron a bytes.(de cualquier uniada a bytes)
        public static double PasarHaBytes(double valor, string origen)
        {
            double bytes = 0;

            if (origen == "bytes")
                bytes = valor;
            else if (origen == "kb")
                bytes = valor * 1024;
            else if (origen == "mb")
                bytes = valor * 1024 * 1024;
            else if (origen == "gb")
                bytes = valor * 1024 * 1024 * 1024;
            else if (origen == "tb")
                bytes = valor * 1024 * 1024 * 1024 * 1024;

            return bytes;
            
        }


        // Ya en bytes, paso a las unidades correspondientes con este metodo.
        public static double BytesHaUnidad(string destino, double bytes)
        {
            double resultado = 0;

            if (destino == "bytes")
            resultado = bytes;
        else if (destino == "kb")
            resultado = bytes / 1024;
        else if (destino == "mb")
            resultado = bytes / (1024 * 1024);
        else if (destino == "gb")
            resultado = bytes / (1024 * 1024 * 1024);
        else if (destino == "tb")
            {
            resultado = bytes / (1024.0 * 1024 * 1024 * 1024);
                
            }

            return resultado;
        }

       
    }
}
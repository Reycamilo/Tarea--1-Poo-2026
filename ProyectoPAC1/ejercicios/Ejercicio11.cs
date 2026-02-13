namespace Ejercicios
{
    public class Ejercicio11
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine(" === CALCULADORA DE DESCUENTOS ===");


            //  Pedimos el precio al usuario
            Console.Write("Ingrese el monto del articulo : ");
            double precio;
            while (!double.TryParse(Console.ReadLine(), out precio) || precio <= 0){
                Console.Write("Error : Ingrese el precio del articulo : ");
            }

            // validamos que descuento tendra
            double precioFinal;
            string descuento;

            if (precio >= 2500)
            {
                descuento = "15%";
                precioFinal = precio - (precio * 0.15);
            } else if ( precio >= 1000)
            {   
                descuento = "10%";
                precioFinal = precio - (precio * 0.10);
            } else if( precio >= 500)
            {
                descuento = "5%";
                precioFinal = precio - (precio * 0.05);
            } else
            {
                descuento = "0%";
                precioFinal = precio;
            }

            //  Mostramos los resultados.
            Console.WriteLine("\nRESULTADOS ***********");
            Console.WriteLine($"Precio del articulo : {precio:F2}");
            Console.WriteLine($"Con un {descuento} de decuento.");
            Console.WriteLine($"El Precio Final es de : {precioFinal:F2}");

            Console.Write("\nPresione una tecla para continuar ...");
            Console.ReadKey();

        }
    }
}
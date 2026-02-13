namespace Ejercicios
{
    public class Ejercicio3
    {
            public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("EJERCICIO 3: DESGLOSE DE BILLETES\n");

            Console.Write("Ingrese la cantidad de dinero: ");
            int cantidad = int.Parse(Console.ReadLine());

            int billetes100 = cantidad / 100;
            cantidad = cantidad % 100;

            int billetes50 = cantidad / 50;
            cantidad = cantidad % 50;

            int billetes20 = cantidad / 20;
            cantidad = cantidad % 20;

            int billetes10 = cantidad / 10;
            cantidad = cantidad % 10;

            int billetes5 = cantidad / 5;
            cantidad = cantidad % 5;

            int billetes1 = cantidad;

            Console.WriteLine("\n--- Desglose ---");
            if (billetes100 > 0)
                Console.WriteLine($"Billetes de 100: {billetes100}");
            if (billetes50 > 0)
                Console.WriteLine($"Billetes de 50: {billetes50}");
            if (billetes20 > 0)
                Console.WriteLine($"Billetes de 20: {billetes20}");
            if (billetes10 > 0)
                Console.WriteLine($"Billetes de 10: {billetes10}");
            if (billetes5 > 0)
                Console.WriteLine($"Billetes de 5: {billetes5}");
            if (billetes1 > 0)
                Console.WriteLine($"Billetes de 1: {billetes1}");

            Console.WriteLine("\nPresione Enter para finalizar el ejercicio...");
            Console.ReadLine();
        }

        
    }
}
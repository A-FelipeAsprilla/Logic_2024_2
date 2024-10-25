public class Program
{
    private static void Main(string[] args)
    {
        /*11. La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes.Los ingredientes para cada tipo de pizza aparecen a continuación:
         * Ingredientes vegetarianos: Pimiento y tofu.
         * Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
         * Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariano no, y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija. Solo se puede elegir un ingrediente además de la mozzarella y el tomate que están en todas las pizzas. Al final se debe mostrar por pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.*/

        int n, opcion;
        bool continuar = true;


        while (continuar)
        {
            Console.Clear();
            Console.Write("Ingrese el numero de pizzas: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("---Seleccione el ingrediente deseado---");
            Console.WriteLine("--- Vegetarianos:                   ---");
            Console.WriteLine("--- 1.Pimiento                      ---");
            Console.WriteLine("--- 2.Tofu                          ---");
            Console.WriteLine("--- No Vegetarianos:                ---");
            Console.WriteLine("--- 3.Peperoni                      ---");
            Console.WriteLine("--- 4.Jamon                         ---");
            Console.WriteLine("--- 5.Salmon                        ---");
            Console.WriteLine("--- 0.Salir                         ---");
            Console.WriteLine("---------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            if (opcion != 0)
            {

            } 
        }
    }
}
public class Program
{
    private static void Main(string[] args)
    {
        /*11. La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes.Los ingredientes para cada tipo de pizza aparecen a continuación:
         * Ingredientes vegetarianos: Pimiento y tofu.
         * Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
         * Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariano no, y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija. Solo se puede elegir un ingrediente además de la mozzarella y el tomate que están en todas las pizzas. Al final se debe mostrar por pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.*/

        int n, opcion, ingrediente;
        bool continuar = true;


        while (continuar)
        {
            Console.Clear();
            Console.Write("Ingrese el numero de pizzas: ");
            n = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
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
                    Console.WriteLine("Ingrese el ingrediente deseado: ");
                    ingrediente = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Te has salido del programa adios ");
                            continuar = false;
                            break;

                        case 1:
                            ingrediente = 1;
                            Console.WriteLine("El ingrediente seleccionado es Pimiento ");
                            break;

                        case 2:
                            ingrediente = 2;
                            Console.WriteLine("El ingrediente seleccionado es Tofu ");
                            break;

                        case 3:
                            ingrediente = 3;
                            Console.WriteLine("El ingrediente seleccionado es Peperoni ");
                            break;

                        case 4:
                            ingrediente = 4;
                            Console.WriteLine("El ingrediente seleccionado es Jamon ");
                            break;

                        case 5:
                            ingrediente = 5;
                            Console.WriteLine("El ingrediente seleccionado es Salmon ");
                            break;

                        default:
                            Console.WriteLine("El ingrediente no se encuentra en el menu ");
                            break;
                    }
                }
            } 
        }
    }
}
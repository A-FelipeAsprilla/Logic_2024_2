using System.Reflection.Emit;

public class Program
{
    private static void Main(string[] args)
    {
        /*11. La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas a sus clientes.Los ingredientes para cada tipo de pizza aparecen a continuación:
         * Ingredientes vegetarianos: Pimiento y tofu.
         * Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
         * Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariano o no, y en función de su respuesta le muestre un menú con los ingredientes disponibles para que elija. Solo se puede elegir un ingrediente además de la mozzarella y el tomate que están en todas las pizzas. Al final se debe mostrar por pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.*/

        int opcion, ingrediente;
        bool continuar = true;
        string salir;


        do
        {
            Console.Clear();
            Console.WriteLine("\n¡¡Bienvenido a la pizzería Bella Napoli¡¡");
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
            if (continuar)
            {
                if (opcion >= 1 && opcion < 3)
                {
                    Console.WriteLine("La pizza es vegetariana ");
                }
                else if (opcion >= 3 && opcion <= 5)
                {
                    Console.WriteLine("La pizza es No vegetariana");
                }

                if (opcion == 1)
                {
                    Console.WriteLine("Los ingredientes de la pizza son Pimiento,Tomate,Mozzarella ");
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Los ingredientes de la pizza son Tofu,Tomate,Mozzarella");
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Los ingredientes de la pizza son Peperoni,Tomate,Mozzarella");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Los ingredientes de la pizza son Jamon,Tomate,Mozzarella");
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Los ingredientes de la pizza son Salmon,Tomate,Mozzarella");
                }
            }
            if (continuar)
            {
                Console.WriteLine("\n¿Desea realizar otro pedido? (S/N)");
                salir = Console.ReadLine().ToUpper();
                //Metodos para poner un string en Mayus o Minus : ToUpper() ó ToLower()
                if (salir == "N")
                {
                    Console.WriteLine("\nTe has salido del programa! Adios");
                    continuar = false;
                }
            }
        }
        while (continuar);
    }
}
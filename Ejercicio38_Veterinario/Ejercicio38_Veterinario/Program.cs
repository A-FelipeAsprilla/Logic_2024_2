using Ejercicio38_Veterinario;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Ejercicio38_Veterinario
        Crear un programa con POO de un centro veterinario donde me muestre un menú con las siguientes opciones: Comprar, Adoptar, Regalar.
        Si el usuario elige “Comprar”, entonces debe mostrar un menú con 5 razas diferentes para ser elegida por ese comprador, y luego mostrar la raza con su precio.
        (Usted es libre de elegir esas 5 razas y el valor de cada una de ellas)
        Si el usuario elige “Adoptar”, debe pedir la raza y mostrar por pantalla un mensaje de agradecimiento por adoptar una mascota
        Si el usuario elige “Regalar”, entonces pedir por pantalla el nombre de la mascota,edad, raza y peso que va a regalar. Mostrar un mensaje de agradecimiento*/
        int opcion;
        bool continuar = true;
        string salir;

        do
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al centro Veterinario");
            Console.WriteLine("\n------------------------------------");
            Console.WriteLine("---Seleccione una de las opciones---");
            Console.WriteLine("---1. Comprar                    ---");
            Console.WriteLine("---2. Adoptar                    ---");
            Console.WriteLine("---3. Regalar                    ---");
            Console.WriteLine("---0. Salir                      ---");
            Console.WriteLine("------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("\nTe has salido del programa adios");
                    continuar = false;
                    break;

                case 1:
                    Console.WriteLine("\nLa opcion seleccionada es Comprar");
                    Comprar comprar = new Comprar();
                    comprar.raza = 0;
                    comprar.Razas();

                    break;

                case 2:
                    Console.WriteLine("\nLa opcion seleccionada es Adoptar");
                    break;

                case 3:
                    Console.WriteLine("\nLa opcion seleccionada es Regalar");
                    break;

                default:
                    Console.WriteLine("\nLa opcion seleccionada es invalida");
                    break;
            }

            Console.WriteLine("\n¿Desea realizar otra Operacion? (S/N)");
            salir = Console.ReadLine().ToUpper();
            if (salir == "N")
            {
                Console.WriteLine("\nTe has salido del programa! Adios");
                continuar = false;
            }
        }
        while (continuar);
    }
}
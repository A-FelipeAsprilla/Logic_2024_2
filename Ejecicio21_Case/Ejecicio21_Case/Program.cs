internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * Realice un programa que solicite dos números, luego dabe pedirse un número que seleccionará alguna operación aritmética desde un menú. Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen (validar división por cero). Independientemente de la selección, imprima el resultado. Ademas, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa.*/

        //Variables
        double num1, num2;
        int opcion;
        double resultado;
        bool continuar = true;
        string salir;

        do
        {
            Console.Write("Ingresar el primer número: ");
            num1 = double.Parse(Console.ReadLine()); //double.parse es exactamente lo mismo que el convert.ToDouble

            Console.Write("Ingresar el segundo número: ");
            num2 = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---Seleccione una operación aritmética---");
            Console.WriteLine("---1. Sumar                           ---");
            Console.WriteLine("---2. Restar                          ---");
            Console.WriteLine("---3. Multuplicar                     ---");
            Console.WriteLine("---4. Dividir                         ---");
            Console.WriteLine("---0. Salir                           ---");
            Console.WriteLine("-----------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Te has salido del programa! Adios");
                    continuar = false;
                    break;
                
                case 1:
                    //aqui ingresamos la logica para implementar el caso 1 y despues colocamos la palabra "break" !!!!!
                    resultado = num1 + num2;
                    Console.WriteLine($"Suma: {num1} + {num2} = {resultado}");
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"Resta: {num1} - {num2} = {resultado}");
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"Multiplicacion: {num1} * {num2} = {resultado}");
                    break;

                case 4:
                    if
                    {

                    }
            }
        }
    }
}
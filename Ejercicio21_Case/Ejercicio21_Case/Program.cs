using System.ComponentModel.DataAnnotations;
using System.Runtime.ConstrainedExecution;

internal class Program
{
    private static void Main(string[] args)
    {
        /*
         * 21. Realice un programa que solicite dos números, luego dabe pedirse un número que seleccionará alguna operación aritmética desde un menú.Si introduce 1 los números se deben sumar, si introduce 2 los números se deben restar, si es 3 los números se multiplican y si introduce 4 los números se dividen(validar división por cero). Independientemente de la selección, imprima el resultado. Ademas, el programa debe tener la posibilidad de volver al menú para pedir 2 nuevos números y hacer la elección de la operación aritmética o digitar cero para finalizar el programa.*/

        //Variables
        double num1, num2;
        int opcion;
        double resultado;
        bool continuar = true;
        string salir;
        do
        {
            Console.Clear();//Me borra toda la pantalla/consola
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("---Seleccione una operacion aritmetica---");
            Console.WriteLine("---1. Sumar                           ---");
            Console.WriteLine("---2. Restar                          ---");
            Console.WriteLine("---3. Multiplicar                     ---");
            Console.WriteLine("---4. Dividir                         ---");
            Console.WriteLine("---0. Salir                           ---");
            Console.WriteLine("-----------------------------------------");
            opcion = int.Parse(Console.ReadLine());

            if(opcion != 0)
            {
                Console.Write("\nIngrese el primer número: ");
                num1 = double.Parse(Console.ReadLine()); //double.parse es exactamente lo mismo que el Convert.ToDouble

                Console.Write("\nIngrese el segundo número: ");
                num2 = double.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        Console.WriteLine("\nTe has salido del programa! Adios");
                        continuar = false;
                        break;

                    case 1:
                        //aqui ingresamos la logica para implementar el caso 1 y despues colocamos la palabra "break" !!!!
                        resultado = num1 + num2;
                        Console.WriteLine($"\nsuma : {num1} + {num2} = {resultado}");
                        break;

                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine($"\nResta: {num1} - {num2} = {resultado}");
                        break;

                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine($"\nMultiplicacion: {num1} * {num2} = {resultado}");
                        break;

                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                            Console.WriteLine($"\nDivision: {num1} / {num2} =     {resultado}");
                        }
                        else
                        {
                            Console.WriteLine("\nError: No se puede dividir por cero");
                        }
                        break;
                    default:
                        Console.WriteLine("\nOpcion no valida");
                        break;
                }
            }

            if (continuar)
            {
                Console.WriteLine("\n¿Desea realizar otra operacion? (S/N)");
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
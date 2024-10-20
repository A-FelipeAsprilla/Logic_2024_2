internal class Program
{
    private static void Main(string[] args)
    {
        //Construir un programa que pida por pantalla 3 números y luego diga cuál es el mayor de los números ingresados.

        double num1, num2, num3;


        Console.WriteLine("Ingrese el numero 1: ");
        num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el numero 2: ");
        num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el numero 3: ");
        num3 = double.Parse(Console.ReadLine());

        if ((num1 > num2) && (num1 > num3))
        {
            Console.WriteLine($"El numero mayor es el numero {num1} ");
        }
        else if ((num2 > num1) && (num2 > num3))
        {
            Console.WriteLine($"El numero mayor es el numero {num2} ");
        }
        else
        {
            Console.WriteLine($"El numero mayor es el numero {num3} ");
        }
    }
}
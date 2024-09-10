internal class Program
{
    public static void Main(string[] args)
    {
        //contruir un programa que pida por pantalla 3 numeros y luego diga cual es el mayor, el del medio y el menor de los numeros

        //declaremos las variables

        int num1, num2, num3;

        Console.Write("ingrese el numero 1: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("ingrese el numero 2: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("ingrese el numero 3: ");
        num3 = Convert.ToInt32(Console.ReadLine());

        //proceso de validacion

        if ((num1 > num2) && (num1 > num3))
        {
            Console.Write("el numero mayor es num1 ");
            if (num2 > num3)
            {
                Console.Write("el numero del medio es num2 ");
                Console.Write("el numero menor es num3 ");
            }
            else
            {
                Console.Write("el numero del medio es num3 ");
                Console.Write("el numero menor es num2 ");
            }
        }
        else if ((num2 > num3) && (num2 > num1))
        {
            Console.Write("el numero mayor es num2");
            if (num1 > num3)
            {
                Console.Write("el numero del medio es num1 ");
                Console.Write("el numero menor es num3 ");
            }
            else
            {
                Console.Write("el numero del medio es num3 ");
                Console.Write("el numero menor es num1");
            }
        }
        else if ((num3 > num2) && (num3 > num1))
        {
            Console.Write("el numero mayor es num3");
            if (num1 > num2)
            {
                Console.Write("el numero del medio es num1 ");
                Console.Write("el numero menor es num2 ");
            }
            else
            {
                Console.Write("el numero del medio es num2 ");
                Console.Write("el numero menor es num1");
            }
        }
    }
}
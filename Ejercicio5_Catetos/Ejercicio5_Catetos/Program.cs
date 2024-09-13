public class Program
{
    private static void Main(string[] args)
    {
        //Dados los catetos de un triángulo rectángulo, calcular su hipotenusa

        //declaramos los inputs

        double cat1, cat2, hipotenusa;

        Console.Write("ingrese el valor del cateto 1: ");
        cat1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor del cateto 2: ");
        cat2 = Convert.ToDouble(Console.ReadLine());

        //proceso de calculo

        double a = (cat1 * cat1);
        double b = (cat2 * cat2);

        double hipo = a + b ;
    }
}
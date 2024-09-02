public class Program
{
    private static void Main(string[] args)
    {
        //lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos

        //vamos a declarar las variables en este caso son 5
        double x1, x2, y1, y2, d;

        //esta es la forma de escribir en la pantalla

        Console.Write("ingrese el valor de x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        //proceso de calculo de las variables

        double x = (x2 - x1) * (x2 - x1);
        double y = (y2 - y1) * (y2 - y1);

        double suma = x + y;

        d = Math.Sqrt(suma);
        Console.Write(d);
    }
}
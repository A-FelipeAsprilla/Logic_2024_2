public class Program
{
    private static void Main(string[] args)
    {
        //punto1

        //Realizar un algoritmo con C# donde se solucione el siguiente problema:
        //un vendedor recibe un sueldo base de $xxxx. Ademas, recibe una comision del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:

        //-Cuanto dinero obtendra por concepto de comisiones por las tres ventas que realiza en el mes
        //-Cual es el total que recibira en el mes tomando en cuenta su sueldo base y comisiones
        //-Cual fue la venta que le genero la mayor comision
        //-Cual fue el promedio de las comisiones que recibio por cada venta

        //Ademas la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como minimo $1.000.000 en ventas. Mostrar un mensaje donde indique si gano o no el beneficio.


        //declaramos los inputs
        double sueldoBase, venta1, venta2, venta3; 

        Console.Write("ingrese el valor del Sueldo Base: ");
        sueldoBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de la ventas1: ");
        venta1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de la venta2: ");
        venta2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de la venta3: ");
        venta3 = Convert.ToDouble(Console.ReadLine());

        //proceso de calculo

        double comision1 = 0.10 * venta1;
        double comision2 = 0.10 * venta2;
        double comision3 = 0.10 * venta3;

        double comisionestotales = (comision1 + comision2 + comision3);
        Console.Write($"Las comisiones totales son de {comisionestotales} ");


        double sueldoTotal = (sueldoBase + comisionestotales);
        Console.WriteLine($"El sueldo total es de {sueldoTotal} ");


        if ((comision1 > comision2) && (comision1 > comision3))
        {
            Console.WriteLine("la venta1 es la que genero mas comision ");
        }
        else if ((comision2 > comision1) && (comision2 > comision3))
        {
            Console.WriteLine("La venta2 es la que genero mas comision ");
        }
        else if ( (comision3 > comision1) && (comision3 > comision2))
        {
            Console.WriteLine("la venta3 es la que genero mas comision  ");
        }


        double PromedioComisiones = comisionestotales / 3;
        Console.WriteLine($"El promedio de las comisiones es {PromedioComisiones}");


        if ((venta1 + venta2 + venta3) > 1000000)
        {
            Console.WriteLine("El vendedor obtuvo el bono extra ");
        }
        else if ((venta1 + venta2 + venta3) < 1000000)
        {
            Console.WriteLine("El vendedor no obtuvo el bono extra ");
        }
        
        Console.Write("");
        Console.Write("");
        Console.Write("punto 2");
        //punto 2

        //Escriba un programa que pida los coeficientes de una ecuacion de primer grado (ax + b = 0) y muestre la solucion
        //Una ecuacion de primer grado puede no tener solucion, tener una solucion unica, o que todos los numeros sean solucion. La formula de las soluciones es x = -b / a


        //declaramos los inputs

        double coeA, coeB, x;

        Console.Write("Ingrese el valor del coeficiente A: ");
        coeA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el valor del coeficiente B: ");
        coeB = Convert.ToDouble(Console.ReadLine()); 

        Console.Write("ingrese el valor del resultado: ");
        x = Convert.ToDouble(Console.ReadLine());


        //proceso de calculo

        if ((-coeB/coeA) == x)
        {
            Console.Write("La ecuacion tiene unica solucion ");
        }
        else if (((-coeB/coeA) != x) && (x > 0) )
        {
            Console.Write("La ecuacion no tiene solucion ");
        }
        else if ((coeA == 0) && (coeB == 0) && (x == 0))

        {
            Console.Write("La ecuacion tiene infinitas soluciones");
        }
    }
}
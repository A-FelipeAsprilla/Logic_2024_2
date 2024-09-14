public class Program
{
    private static void Main(string[] args)
    {
        //Realizar un algoritmo con C# donde se solucione el siguiente problema:
        //un vendedor recibe un sueldo base de $xxxx. Ademas, recibe una comision del 10% sobre el valor total de cada venta que realiza. El vendedor desea saber:

        //-Cuanto dinero obtendra por concepto de comisiones por las tres ventas que realiza en el mes
        //-Cual es el total que recibira en el mes tomando en cuenta su sueldo base y comisiones
        //-Cual fue la venta que le genero la mayor comision
        //-Cual fue el promedio de las comisiones que recibio por cada venta

        //Ademas la empresa da un beneficio extra de $100.000 si el vendedor supera el objetivo del mes. El objetivo es sumar en las 3 ventas como minimo $1.000.000 en ventas. Mostrar un mensaje donde indique si gano o no el beneficio.


        //declaramos los inputs
        double sueldoBase, ventas;

        Console.Write("ingrese el valor del Sueldo Base: ");
        sueldoBase = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor de las ventas: ");
        ventas = Convert.ToDouble(Console.ReadLine());


    }
}
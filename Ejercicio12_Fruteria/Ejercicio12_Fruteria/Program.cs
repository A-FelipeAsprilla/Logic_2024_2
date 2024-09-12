internal class Program
{
    private static void Main(string[] args)
    {

        //Una fruteria ofrece las manzanas con descuento segun la siguiente tabla:
        //Usted determina el precio del kilo de manzanas como desarrollador. Determinar y mostrar cuanto pagara una persona que compre manzanas en esa fruteria y cual descuento fue el que se le aplico, si fue que se le aplico alguno.

        //Datos de entrada: Cantidad de kilos de manzanas
        //Proceso: Calcular el valor neto de manzanas y luego aplicarle descuento si es que le aplica
        //Datos de salida: Valor total y descuento aplicado


        //Declaracion de constantes:
        const decimal precioKiloManzanas = 5000;
        decimal descuento, precioBruto, precioNeto, precioDescuento;

        Console.Write("Ingrese la cantidad de kilos de manzanas a comprar: ");
        decimal kilosManzanas = Convert.ToDecimal(Console.ReadLine());

        //Calculos

        if (kilosManzanas >= 0 && kilosManzanas <= 2)
        {
            descuento = 0;
        }
        else if (kilosManzanas > 2 && kilosManzanas <= 5)
        {
            descuento = 10;
        }
        else if (kilosManzanas > 5 && kilosManzanas <= 10)
        {
            descuento = 15;
        }
        else
        {
            descuento = 20;
        }

        //Calculo del precio bruto
        precioBruto = precioKiloManzanas * kilosManzanas;

        //Calculo del descuento
        precioDescuento = precioBruto * (descuento / 100);

        //Calculo del precio neto
        precioNeto= precioBruto - precioDescuento;

        //Mostrar los resultados:
        Console.WriteLine($"El total a pagar por {kilosManzanas} es: {precioNeto:c}");
        Console.WriteLine($"Se ha aplicado un descuento del {descuento}% que equivale a {precioDescuento:c}");
    }
}
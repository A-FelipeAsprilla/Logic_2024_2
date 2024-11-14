using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        /*42.Desarrolle un algoritmo donde almacene las ventas que obtuvo mensualmente un almacén durante el año 2024.Mostrar por pantalla el total de ventas.*/

        //Declaramos los nuevos arrays:

        string[] months = { "enero", "febrero", "marzo", "abril", "mayo", "junio", "julio", "agosto", "septiembre", "octubre", "noviembre", "diciembre" };

        decimal[] sales = new decimal[12];
        decimal sum = 0;

        //vamos implementar metodos para trabajar un poco el POO

        StoreSales(months, sales);

        //esto se hace para poder cambiar el valor de la variable sum
        sum = CalculateSalesPerYear(sales,sum);

        ShowSales(sales, months, sum);
    }
    //Parametros del metodo (son los que estan en los parentesis internos)
    private static void StoreSales(string[] months, decimal[] sales)
    {
        //Esta es la manera de pedir datos por pantalla para un array
        for (int i = 0; i < sales.Length; i++)
        {
            Console.WriteLine($"Ingrese las ventas del mes {months[i]}: ");
            sales[i]=Convert.ToDecimal(Console.ReadLine());
        }
    }
    private static decimal CalculateSalesPerYear(decimal[] sales, decimal sum)
    {
        //Necesitamos que retorne parametro decimal para poder cambiar la variable *sum*
        for(int i = 0;i < sales.Length; i++)
        {
            sum+= sales[i];
        }
        return sum;
    }
    private static void ShowSales(decimal[] sales, string[]months, decimal sum)
    {
        for(int i = 0;i < sales.Length; i++)
        {
            Console.WriteLine($"{months[i]}: {sales[i]}");
        }
        Console.WriteLine($"Total = {sum:C2}");
    }
}
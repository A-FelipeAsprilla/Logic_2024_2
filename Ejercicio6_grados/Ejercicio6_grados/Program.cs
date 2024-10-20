internal class Program
{
    private static void Main(string[] args)
    {
        //Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.

        double fahrenheit, Celsius;

        Console.WriteLine("Ingrese la temperatura en grados Farenheit :");
        fahrenheit = double.Parse(Console.ReadLine());

        Celsius = (fahrenheit - 32) / 1.8;
        Console.WriteLine($"La temperatura en grados celsius es {Celsius}");
    }
}
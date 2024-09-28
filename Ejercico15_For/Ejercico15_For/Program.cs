public class Program
{
    private static void Main(string[] args)
    {
        /*15. Programe un algoritmo que pida al usuario 2 números por pantalla y que muestre todos los números comprendidos entre ambos números inclúyendolos.*/

        //Datos de Entrada:

        int num1, num2;
        int mayor, menor;

        Console.Write("Ingrese el primer número: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nIngrese el segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 < num2)
        {
            menor = num1;
            mayor = num2;
        }
        else

        {
            mayor = num1;
            menor = num2;
        }
        Console.WriteLine(" ");
        //Vamos a construir el For:
        Console.Write($"Los números comprendidos entre el {menor} y {mayor} son: \n");

        for (int i = menor; i <= mayor; i++)
        {
            Console.WriteLine($"{i}");
        }
    }
}
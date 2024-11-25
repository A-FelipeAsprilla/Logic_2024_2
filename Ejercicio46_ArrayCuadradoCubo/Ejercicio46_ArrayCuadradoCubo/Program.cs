internal class Program
{
    private static void Main(string[] args)
    {
        /*46.Realizar un programa en C# que declare un array con N enteros, a continuación, lo inicialice con valores aleatorios (del 1 al 10) y posteriormente en otros 2 arrays guardar el cuadrado de cada uno de los números número y cubo de ese número. Muestre en pantalla cada elemento del primer vector de enteros junto con su cuadrado y su cubo.*/

        Console.WriteLine("Ingrese el numero de elementos: ");
        int n = Convert.ToInt32(Console.ReadLine());

        //Declaramos los 3 Arrays
        int[] Numeros = new int[n];
        int[] Cuadrados = new int[n];
        int[] Cubos = new int[n];

        FillArray(n , Numeros);
        CalculateOperations(n, Numeros, Cuadrados, Cubos);
        ShowResults(n, Numeros, Cuadrados, Cubos);


    }

    private static void ShowResults(int n, int[] numeros, int[] cuadrados, int[] cubos)
    {
        //la T se utiliza para poner todos los elementos en fila
        Console.WriteLine("Numero\tCuadrados\tCubos");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{numeros[i]}\t{cuadrados[i]}\t\t{cubos[i]}");
        }
    }

    private static void CalculateOperations(int n, int[] numeros, int[] cuadrados, int[] cubos)
    {
        for (int i = 0; i < n; i++)
        {
            //Se convierte el array ya que el metodo Math.Pow solo recibe y devuelve datos tipo Double
            cuadrados[i] = Convert.ToInt32(Math.Pow(numeros[i], 2));
            cubos[i] = Convert.ToInt32(Math.Pow(numeros[i], 3));
        }
    }

    private static void FillArray(int n, int[] numeros)
    {
        Random random = new Random();

        for (int i = 0; i < n; i++)
        {
            numeros[i]= random.Next(1 , 11);
        }
    }
}
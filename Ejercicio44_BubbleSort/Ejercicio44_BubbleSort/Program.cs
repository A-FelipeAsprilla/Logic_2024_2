internal class Program
{
    private static void Main(string[] args)
    {
        /*44.Realizar un algoritmo que me pida por pantalla la cantidad de números naturales que desea ingresar para guardarlos en un array. Luego de conocer la longitud del array y llenarlo con los números, el algoritmo deberá ordenarlos con el método de bubble sort.Mostrar en pantalla el arreglo ordenado ascendentemente(menor a mayor).*/

        //Declaracion de arrays
        int n;
        Console.Write("Ingrese la cantidad de N: ");
        n = Convert.ToInt32(Console.ReadLine());

        //Declaración y inicialización del Array
        int[] numbers = new int[n];

        //Llenar Array
        FillArray(numbers, n);

        //Ordenar Array con Bubble Sort
        bubbleSort(numbers, n);

        //Mostrar Array ordenado
        ShowArray(numbers, n);
    }

    private static void FillArray(int[] numbers, int n)
    {
        //con este for se llena el array
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el numero en la posición {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    private static void bubbleSort(int[] numbers, int n)
    {
        int aux = 0;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (numbers[j] > numbers[j + 1])
                {
                    aux = numbers[j];
                    numbers[j] = numbers[j + 1];
                    numbers[j + 1] = aux;
                }
            }
        }
    }
    private static void ShowArray(int[] numbers, int n)
    {
        string split = " ";
        Console.Write("Array numbers sorted: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(String.Format("{0} {1}", numbers[i], split));
        }
    }
}
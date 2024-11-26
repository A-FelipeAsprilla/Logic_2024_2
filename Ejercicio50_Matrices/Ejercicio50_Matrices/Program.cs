internal class Program
{
    private static void Main(string[] args)
    {
        /*50.Crear un algoritmo en C# que me declare una matriz de dimensiones 2x4. El programa me debe llenar la primera fila con números naturales aleatorios entre 1 y 10, luego debe llenar la segunda fila con el triple del número ubicado en su misma posición de columna, pero de la primera fila. Mostrar la matriz de 2x4 en pantalla.*/

        //Declaración y iniciación de la matriz
        int[,] matrix = new int[2, 4];

        //Crear objeto del Random
        Random random = new Random();

        //llenemos la primera fila
        for (int i = 0; i < 4; i++)
        {
            matrix[0, i] = random.Next(1, 11);
        }

        //Llenamos la segunda fila
        for (int i = 0; i < 4; i++)
        {
            matrix[1, i] = matrix[0, i] * 3;
        }

        //Con esto mostramos la matriz
        Console.Write("Matrix de 2*4\n");
        for (int f = 0; f < 2; f++) //La F es de filas 
        {
            for (int c = 0; c < 4; c++) //La C es de columnas
            {

                Console.Write($"{matrix[f, c]}\t");
            }
            Console.WriteLine();
        }
    }
}
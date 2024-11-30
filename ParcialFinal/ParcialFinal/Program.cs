using System;
using System.Diagnostics;

internal class Program
{
    static Random random = new Random();
    static int N = random.Next(1, 6);
    static int M = random.Next(1, 6);
    static int[,] board = new int[N, M];
    private static void Main(string[] args)
    {
        FillBoard();
        ShowBoard();
    }

    private static void ShowBoard()
    {
        Console.Clear();
        for (int f = 0; f < N; f++)
        {
            for (int c = 0; c < M; c++)
            {
                Console.Write(board[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void FillBoard()
    {
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < M; j++)
            {
                board[i, j] = random.Next(1, 10);
            }
        }
        board[0, 0] = '0';
        Console.ForegroundColor = ConsoleColor.Green;
    }
}
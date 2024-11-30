using System;
using System.Diagnostics;

internal class Program
{
    static Random random = new Random();
    static int N = random.Next(1, 6);
    static int M = random.Next(1, 6);
    static int[,] board = new int[N, M];
    static int posX = 0, posY = 0;
    static bool escKeyPressed = false;
    static int suma = 0;
    private static void Main(string[] args)
    {
        FillBoard();
        ShowBoard();
        PrintMenu();
    }

    private static void PrintMenu()
    {
        while (!escKeyPressed)
        {
            ConsoleKeyInfo KeyPressed;//Asi declaro una variable para almacenar la tecla que pulse
            Console.WriteLine("Use las teclas de dirección para moverse por el tablero o presione la tecla ´ESC´ para salir");
            Console.WriteLine("Pulse Flecha Derecha");
            Console.WriteLine("Pulse Flecha Izquierda");
            Console.WriteLine("Pulse Flecha Arriba");
            Console.WriteLine("Pulse Flecha Abajo");
            Console.WriteLine("Pulse Esc para salir");
            KeyPressed = Console.ReadKey();//ReadKey para leer la tecla pulsada
            switch (KeyPressed.Key)
            {
                case ConsoleKey.RightArrow:
                    Move("derecha");
                    break;
                case ConsoleKey.LeftArrow:
                    Move("izquierda");
                    break;
                case ConsoleKey.UpArrow:
                    Move("arriba");
                    break;
                case ConsoleKey.DownArrow:
                    Move("abajo");
                    break;
                case ConsoleKey.Escape:
                    escKeyPressed = true;
                    break;
            }
            ShowBoard();
        }
    }
    private static void Move(string diretion)
    {
        
        switch (diretion)
        {
            case "derecha":
                if (posY < N - 1)
                {
                    posY++;
                }
                break;
            case "izquierda":
                if (posY > 0)
                {
                    posY--;
                }
                break;
            case "arriba":
                if (posX > 0)
                {
                    posX--;
                }
                break;
            case "abajo":
                if (posX < N - 1)
                {
                    posX++;
                }
                break;
        }
    }
    private static void ShowBoard()
    {
        Console.Clear();
        for (int f = 0; f < N; f++)
        {
            for (int c = 0; c < M; c++)
            {
                if (f== posX && c == posY)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ResetColor();
                }
                Console.Write(board[f, c] + "\t");
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
        board[0, 0] = 0;
    }


}

internal class Program
{
    //VARIABLES GLOBALES
    static char[,] board = new char[5, 5];
    static int posX = 0, posY = 0;
    static bool escKeyPressed = false;

    /*53.En C# hacer un tablero que en todos sus recuadros contenga un "X" y en la posición [0,0] contenga una "O". Hacer un menú con 5 opciones (derecha, izquierda, arriba, abajo, salir), crear la funcionalidad de poder mover el "O" por todo el tablero usando las teclas de dirección. No está permitido que el “O” se salga del tablero, simplemente el programa debe omitir ese movimiento.*/
    private static void Main(string[] args)
    {
        InitializeBoard();
        ShowBoard();
        PrintMenu();
    }

    private static void PrintMenu()
    {
        while (!escKeyPressed)
        {
            ConsoleKeyInfo KeyPressed;//Asi declaro una variable para almacenar la tecla que pulse

            Console.WriteLine("Use las teclas de dirección para mover la´O´ , o presione la tecla ´ESC´ para salir");
            Console.WriteLine("Pulse Flecha Derecha");
            Console.WriteLine("Pulse Flecha Izquierda");
            Console.WriteLine("Pulse Flecha Arriba");
            Console.WriteLine("Pulse Flecha Abajo");
            Console.WriteLine("Pulse Esc para salir");
            KeyPressed = Console.ReadKey();//ReadKey para leer la tecla pulsada

            switch (KeyPressed.Key)
            {
                case ConsoleKey.RightArrow:
                    MoveO("derecha");
                    break;

                case ConsoleKey.LeftArrow:
                    MoveO("izquierda");
                    break;

                case ConsoleKey.UpArrow:
                    MoveO("arriba");
                    break;

                case ConsoleKey.DownArrow:
                    MoveO("abajo");
                    break;

                case ConsoleKey.Escape:
                    escKeyPressed = true;
                    break;
            }
            ShowBoard();
        }
    }

    private static void MoveO(string diretion)
    {
        board[posX, posY] = 'X';

        switch (diretion)
        {
            case "derecha":
                if (posY < 4) posY++;
                break;

            case "izquierda":
                if (posY > 0)posY--;
                break;

            case "arriba":
                if (posX > 0) posX--;
                break;

            case "abajo":
                if (posX < 4) posX++;
                break;
        }
        board[posX, posY] = 'O';
    }

    private static void ShowBoard()
    {
        Console.Clear();
        Console.WriteLine("¡Mueva la bolita!\n");
        for (int f = 0; f < 5; f++)
        {
            for (int c = 0; c < 5; c++)
            {
                Console.Write(board[f, c] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private static void InitializeBoard()
    {
        //Aquí lleno mi tablero
        for (int f = 0; f < 5; f++)
        {
            for(int c = 0; c < 5; c++)
            {
                board[f, c] = 'X';
            }
        }
        board[posX, posY] = 'O';
    }
}
public class Program
{
    private static void Main(string[] args)
    {
        //declaracion de los inputs
        double seg1, seg2, seg3, suma;
        bool ittriangle;
        string msj;

        //pedir los datos - Inputs
        Console.Write("ingrese el valor del segmento 1: ");
        seg1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el valor del segmento 2: ");
        seg2 = Convert.ToDouble (Console.ReadLine());

        Console.Write("ingrese el valor del segmento 3: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //proceso de validacion

        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg2) > seg3)
            {
                if ((seg2 + seg3) > seg1)
                {
                    ittriangle = true;
                }
                else
                {
                    ittriangle = false;
                }
            }
            else
            {
                ittriangle = false;
            }
        }
        else
        {
            ittriangle = false;
        }
        //mostrar mensaje - outputs
        if (ittriangle)
        {
            Console.Write("se puede construir el triangulo");
        }
        else
        {
            Console.Write("no se puede construir el triangulo");
        }
    }
}
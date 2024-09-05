using System.ComponentModel.Design;

public class Program
{
    private static void Main(string[] args)
    {
        //lea la longitud de tres segmentos y que muestre si se puede construir un triangulo con estos segmentos

        //Declaracion de los inputs
        double seg1, seg2, seg3, suma;
        bool istriangle;
        string msj;

        //Pedir los datos - inputs
        Console.Write("ingrese el primer segmento: ");
        seg1= Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el segundo segmento: ");
        seg2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("ingrese el tercer segmento: ");
        seg3 = Convert.ToDouble(Console.ReadLine());

        //Proceso - Validacion
        if ((seg1 + seg2) > seg3)
        {
            if ((seg1 + seg3) > seg2)
            {
                if ((seg2 + seg3) > seg1)
                {
                    istriangle = true ;
                }
                else
                {
                    istriangle=false ;
                }
            }
            else
            {
                istriangle= false ;
            }
        }
        else
        {
            istriangle = false ;
        }
        //Mostrar mensaje - Output
        if(istriangle)
        {
            Console.Write("Se puede construir el triangulo");
        }
        else
        {
            Console.Write("No se puede construir el triangulo");
        }
    }
}
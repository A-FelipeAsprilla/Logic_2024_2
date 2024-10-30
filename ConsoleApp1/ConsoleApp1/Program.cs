﻿using ConsoleApp1;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Se desea obtener el valor de la matrícula de un estudiante cuyo valor se calcula dela siguiente manera:
        • Si toma 20 o menos créditos, paga el crédito al valor normal.
        • Si toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal.
        • Si el estudiante es de estrato 1, 2 o 3 recibe los siguientes descuentos:
        - Si el estrato es 1, el descuento es del 80%.
        - Si el estrato es 2, el descuento es del 50%.
        - Si el estrato es 3, el descuento es del 30%.
        Además, los estratos 1 y 2 reciben subsidio de alimentación y transporte de la siguiente manera:
        • Para el estrato 1, el subsidio de alimentación y transporte es igual a $200.000.
        • Para el estrato 2, el subsidio de alimentación y transporte es igual a $100.000.
        Se debe informar al usuario sobre el costo de la matrícula y el valor del subsidio.
        La aplicación debe preguntar al usuario si quiere volver al inicio o no para calcular la matrícula de un nuevo estudiante.
        Hacer uso de todos los elementos de programación que hemos visto hasta el momento, incluyendo POO (clases, propiedades, métodos)*/

        int estrato, creditos, valorCredito;
        bool continuar = true;
        string salir;

        do
        {
            Console.Clear();
            Console.WriteLine("Bienvenidos");
            Console.WriteLine("\nSi toma por encima de 20 créditos, se pagarán los créditos extras al doble de valor normal");

            Console.Write("\nIngrese el numero de creditos: ");
            creditos = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el Valor del credito: ");
            valorCredito = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nIngrese el estrato del estudiante: ");
            estrato = Convert.ToInt32(Console.ReadLine());

            CalculoMatricula calculoMatricula = new CalculoMatricula();
            calculoMatricula.creditos = creditos;
            calculoMatricula.valorCredito = valorCredito;
            calculoMatricula.estrato = estrato;

            calculoMatricula.CalcularMatricula();
            calculoMatricula.CalcularSubsidio();

            Console.WriteLine("\n¿Desea realizar otra Matricula? (S/N)");
            salir = Console.ReadLine().ToUpper();
            if (salir == "N")
            {
                Console.WriteLine("\nTe has salido del programa! Adios");
                continuar = false;
            }
        }
        while (continuar);
    }
}
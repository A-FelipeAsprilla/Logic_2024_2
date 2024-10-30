using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CalculoMatricula
    {
        public int creditos {  get; set; }
        public int valorCredito { get; set; }
        public int estrato { get; set; }


        public void CalcularMatricula()
        {
            switch (creditos)
            {
                case int cred when cred <= 20:
                    Console.WriteLine("\nPagaras los creditos al precio normal");
                    break;

                case int cred when cred > 20:
                    Console.WriteLine("\nPagaras los creditos extra al doble del normal");
                    break;
            }


            double valorCreditos = 0;
            if (creditos <= 20)
            {
                valorCreditos = creditos * valorCredito;
                Console.WriteLine($"El valor de los creditos es {valorCreditos} ");
            }
            else
            {
                valorCreditos = (valorCredito * 2) * creditos;
                Console.WriteLine($"El valor de los creditos es {valorCreditos} ");
            }


            double Descuento = 0;
            switch (estrato)
            {
                case 1:
                    Descuento = valorCreditos * 0.8;
                    break;

                case 2:
                    Descuento = valorCreditos * 0.5;
                    break;

                case 3:
                    Descuento = valorCreditos * 0.3;
                    break;
            }

            double valorTotal = valorCreditos - Descuento;
            Console.WriteLine($"El valor de la matricula es de {valorTotal} ");
        }

        public void CalcularSubsidio()
        {
            double subsidio = 0;
            switch (estrato)
            {
                case 1:
                    subsidio = 200000;
                    Console.WriteLine($"El subsidio de transportes y alimentacion es de {subsidio} ");
                    break;

                case 2:
                    subsidio = 100000;
                    Console.WriteLine($"El subsidio de transportes y alimentacion es de {subsidio} ");
                    break;
            }
        }
    }
}

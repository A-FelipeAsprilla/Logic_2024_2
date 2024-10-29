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
                    Console.WriteLine("Pagaras los creditos al precio normal");
                    break;

                case int cred when cred > 20:
                    Console.WriteLine("Pagaras los creditos extra al doble del normal");
                    break;
            }

            double valorCreditos = 0;
            if (creditos <= 20)
            {
                valorCreditos = creditos * valorCredito;
            }
            else
            {
                valorCreditos = (valorCredito * 2) * creditos;
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
        }
    }
}

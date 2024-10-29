using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ValorMatricula
    {
        public int creditos {  get; set; }
        public int valorCredito { get; set; }


        public void RangoCreditos()
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
        }

        public void Pagaras()
        {
            int valorTotal = 0;

            if (creditos <= 20)
            {
                valorTotal = creditos * valorCredito;
            }
            else
            {
                valorTotal = (valorCredito * 2) * creditos;
            }
        }
    }
}

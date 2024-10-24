using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37_PrimerProgramaPOO
{
    internal class Personas
    {
        //Propiedades de mi clase personas:

        public string Nombre { get; set; } //Formas de definir mis propiedades getters and setters

        public int Edad { get; set; }

        //Metodos de mi clase personas:

        //Esta es la forma de crear un metodo en C#:
        //Modificador de accoso + tipo de dato que retorna el motodo + nombre del metodo + seccion de parametros()
        public void presentar() // void significa que el metodo no retorna NADA
        {
            Console.WriteLine($"Hola mi nombre es {Nombre} y tengo {Edad} años. ");
        }

        public void EsMayorDeEdad()
        {
            if (Edad >= 18)
            {
                Console.WriteLine("soy mayor de edad. ");
            }
            else
            {
                Console.WriteLine("soy menor de edad. ");
            }
        }
    }
}

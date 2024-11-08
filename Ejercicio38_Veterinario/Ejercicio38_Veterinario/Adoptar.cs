using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38_Veterinario
{
    internal class Adoptar
    {
        public int raza { get; set; }
        public void Razas()
        {
            int opcion;
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("---Seleccione la raza que desea adquirir---");
            Console.WriteLine("---1. Perro                             ---");
            Console.WriteLine("---2. Gato                              ---");
            Console.WriteLine("---3. Tortuga                           ---");
            Console.WriteLine("---4. Conejo                            ---");
            Console.WriteLine("---5. Loro                              ---");
            Console.WriteLine("-------------------------------------------");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"\nLa raza Adoptada es el Perro");
                    break;

                case 2:
                    Console.WriteLine($"\nLa raza Adoptada es el Gato");
                    break;

                case 3:
                    Console.WriteLine($"\nLa raza Adoptada es la Tortuga");
                    break;

                case 4:
                    Console.WriteLine($"\nLa raza Adoptada es el Conejo");
                    break;

                case 5:
                    Console.WriteLine($"\nLa raza Adoptada es el Loro");
                    break;
            }
            Console.WriteLine("\nGracias por Adoptar esta mascota");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38_Veterinario
{
    internal class Comprar
    {
        public int raza {  get; set; }
        public void Razas()
        {
            int precio = 0;
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
                    precio = 1000000;
                    Console.WriteLine($"\nLa raza comprada es el Perro y su valor es {precio}");
                    break;

                case 2:
                    precio = 800000;
                    Console.WriteLine($"\nLa raza comprada es el Gato y su valor es {precio}");
                    break;

                case 3:
                    precio = 500000;
                    Console.WriteLine($"\nLa raza comprada es la Tortuga y su valor es {precio}");
                    break;

                case 4:
                    precio = 400000;
                    Console.WriteLine($"\nLa raza comprada es el Conejo y su valor es {precio}");
                    break;

                case 5:
                    precio = 300000;
                    Console.WriteLine($"\nLa raza comprada es el Loro y su valor es {precio}");
                    break;
            }
        }
    }
}

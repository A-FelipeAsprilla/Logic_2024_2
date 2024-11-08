using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38_Veterinario
{
    internal class Regalar
    {
        public void Nombre()
        {
            string NombreMascota;
            Console.WriteLine("\nIngrese el Nombre de la Mascota: ");
            NombreMascota = Console.ReadLine();
            Console.WriteLine($"El nombre de la mascota es {NombreMascota}");
        }
        public void edad()
        {
            int EdadMascota;
            Console.WriteLine("\nIngrese la Edad de la Mascota: ");
            EdadMascota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"La edad de la mascota es {EdadMascota}");
        }
        public void Razas()
        {
            int opcion;
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("---Seleccione la raza que desea Regalar ---");
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
                    Console.WriteLine($"\nLa raza es Perro");
                    break;

                case 2:
                    Console.WriteLine($"\nLa raza es Gato");
                    break;

                case 3:
                    Console.WriteLine($"\nLa raza es Tortuga");
                    break;

                case 4:
                    Console.WriteLine($"\nLa raza es Conejo");
                    break;

                case 5:
                    Console.WriteLine($"\nLa raza es Loro");
                    break;
            }
        }
        public void Peso()
        {
            double PesoMascota;
            string salir;
            bool continuar = true;
            Console.WriteLine("\nIngrese el peso de la mascota: ");
            PesoMascota= Convert.ToDouble(Console.ReadLine());
            while (continuar)
            {
                switch (PesoMascota)
                {
                    case double cat when cat > 0 && cat <=5:
                        Console.WriteLine($"El peso de la mascota es: {PesoMascota}");
                        continuar = false;
                        break;

                    case double cat when cat > 5 && cat <= 15:
                        Console.WriteLine($"El peso de la mascota es: {PesoMascota}");
                        continuar = false;
                        break;

                    case double cat when cat > 15 && cat <= 20:
                        Console.WriteLine($"El peso de la mascota es: {PesoMascota}");
                        continuar = false;
                        break;

                    case double cat when cat > 20 && cat <= 25:
                        Console.WriteLine($"El peso de la mascota es: {PesoMascota}");
                        continuar = false;
                        break;

                    case double cat when cat > 25 && cat <= 30:
                        Console.WriteLine($"El peso de la mascota es: {PesoMascota}");
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine($"El peso de la mascota no es valido");
                        break;
                }
            }
        }
    }
}

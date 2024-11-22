internal class Program
{
    private static void Main(string[] args)
    {
        /*18.Realizar un programa en C# que obtenga el promedio de calificaciones de un grupo de N alumnos.*/

        double alumnos, calificaciones, notas, promedio;
        double SumaNotas = 0; 

        Console.WriteLine("Ingrese la cantidad de alumnos que desea calificar: ");
        alumnos = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el numero de notas a calificar");
        calificaciones = Convert.ToDouble(Console.ReadLine());

        for (int i = 0; i < alumnos; i++)
        {
            for (int j = 0; j < calificaciones; j++)
            {
                Console.WriteLine($"Ingrese la nota {j + 1}: ");
                notas = Convert.ToDouble(Console.ReadLine());

                SumaNotas += notas;
            }
            Console.WriteLine($"\nla suma de las notas del alumno {i+1} es {SumaNotas}");
            
            promedio = SumaNotas / calificaciones;
            Console.WriteLine($"El promedio del alumno {i+1} es {promedio} ");
        }
    }
}
using System.Runtime.ConstrainedExecution;

internal class Program
{
    public static void Main(string[] args)
    {
        /*45.Realizar un algoritmo que solicite a un docente de clase ingresar las notas de los parciales de sus 5 estudiantes, que pueden ser valores enteros o con decimales. Adicional sacar el promedio general de las 5 notas y mostrar tanto las notas ordenadas de menor a mayor como el promedio en pantalla.*/

        string[] student = { "estudiante1", "estudiante2", "estudiante3", "estudiante4", "estudiante5" };
        double[] notas = new double[5];
        double[] sum = new double[5];
        double[] promedio = new double[5];
        

        FillNotas(student, notas, sum);
        CalculateNotas(student, notas, sum);
        OrganizeNotas();
        ShowNotas(student, promedio);
    }

    private static void OrganizeNotas()
    {

    }

    private static void ShowNotas(string[] student, double[] promedio)
    {
        for (int i = 0; i < student.Length; i++)
        {
            Console.WriteLine($"El promedio del {student[i]} es {promedio[i]}");
        }
    }

    private static void CalculateNotas(string[] student,double[] promedio, double[] sum)
    {
        for (int i = 0; i < student.Length; i++)
        {
            promedio[i] = sum[i] / 5;
        }
    }

    private static void FillNotas(string[] student , double[] Notas , double[] sum)
    {
        for (int i = 0; i < student.Length; i++)
        {
            Console.Clear();
            Console.WriteLine($"Ingrese las notas del {student[i]}: ");
            for (int j = 0; j < Notas.Length; j++)
            {
                Notas[j] = Convert.ToDouble(Console.ReadLine());
                sum[i] += Notas[j];
            }
        }


    }
}
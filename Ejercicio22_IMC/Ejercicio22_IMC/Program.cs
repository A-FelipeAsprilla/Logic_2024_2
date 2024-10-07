internal class Program
{
    private static void Main(string[] args)
    {
        /*22. Se quiere crear un algoritmo en C# que calcule el IMC de N pacientes y luego lo clasifique dentro de una categoria:
        
        -Si el IMC del paciente es menor a 18.5, entonces tiene peso insuficiente.
        -Si el IMC esta entre 18.5 y 24.9 se encuentra en la categoria de peso saludable.
        -Si el IMC esta entre 25.0 y 29.9 entonces tiene sobrepeso.
        -Si el IMC es mayor de 29.9 entonces tiene obesidad.

        mostrar en pantalla la categoria de cada uno de los pacientes. La aplicacion debe estar en capacidad de pedirle al usuario si quiere volver a calcular*/

        //valores de entrada
        double estatura, peso, imc;
        bool continuar = true;
        int n;
        string respuesta;

        while (continuar)
        {
            Console.Clear();
            Console.Write("Ingrese el numero de pacientes: ");
            n = Convert.ToInt32(Console.ReadLine());

            //El for estara dentro del while....
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nIngrese el peso del paciente # {i + 1} en 'Kg':");
                peso = Convert.ToDouble(Console.ReadLine());

                Console.Write($"Ingrese la estatura del paciente # {i + 1} en 'M':");
                estatura = Convert.ToDouble(Console.ReadLine());

                //calculo del imc

                imc = peso / (estatura * estatura);

                switch (imc)
                {
                    //esta es la forma de validar una variable si existe dentro de un rango

                    case double cat when cat < 18.5:
                        Console.WriteLine($"\nEl paciente con el IMC : {imc:F} esta en la categoria de 'peso insuficiente'");
                        break;

                    case double cat when cat >= 18.5 && cat < 25:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} esta en la categoria de 'peso saludable' ");
                        break;

                    case double cat when cat >= 25 && cat < 30:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} esta en la categoria de 'Sobrepeso' ");
                        break;

                    case double cat when cat >= 30:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} esta en la categoria de 'Obsesidad' ");
                        break;

                    default:
                        Console.WriteLine($"\nEl paciente con el IMC: {imc:F} no se encuentra en ninguna categoria");
                        break;
                }
            }

            //Retorno al While
            Console.WriteLine("\nseñor medico: ¿Desea calcular el IMC de mas paciente? (S/N)");
            respuesta = Console.ReadLine().ToUpper();

            if (respuesta == "N")
            {
                continuar = false;
            }
        }

    }
}
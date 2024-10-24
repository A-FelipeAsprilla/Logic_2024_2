using Ejercicio37_PrimerProgramaPOO;

public class Program
{
    private static void Main(string[] args)
    {
        /*37. Desarrollar un programa en C# utilizando los conceptos básicos de la Programación Orientada a Objetos (POO) y bucles para permitir la creación y presentación de N personas. El programa debe solicitar al usuario el número de personas que desea ingresar, obtener los datos de cada una (nombre y edad),y luego mostrar una presentación de cada persona junto con la verificación de si es mayor de edad.*/

        //solicitar por pantalla cuantas personas quiero presentar y validar su mayoria de edad
        Console.WriteLine("¿Cuantas personas quieres presentar?");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ingrese el nombre de la persona: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingresa la edad de la persona: ");
            int edad = Convert.ToInt32(Console.ReadLine());

            //Vamos a crear una nueva instancia de la clase persona, ESTO SIGNIFICA QUE VAMOS A CREAR UN NUEVO OBJETO DE LA CLASE PERSONA 

            Personas personas = new Personas();//Estamos creando un nuevo objeto de la clase personas

            //Vamos a asignar los valores que el usuario ingreso a las propiedades de la clase personas
            personas.Nombre = nombre;
            personas.Edad = edad;

            //Me falta invocar los metodos de la clase Personas
            personas.presentar();
            personas.EsMayorDeEdad();
        }
    }
}
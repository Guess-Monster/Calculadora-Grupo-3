using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 4: //Mario Ramírez beibeee
                Console.Write("Ingrese el primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = Division(num1, num2);

                Console.WriteLine("El resultado es: " + resultado);
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }

    static double Division(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
            return 0;
        }

        return a / b;
    }
}
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
            case 1:
            Suma();
            break;

            case 2:
            Resta();
            break;

            case 3:
            Multiplicar();
            break;

            case 4:
                Console.Write("Ingrese el primer número: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

                double resultado = Division(num1, num2);

                Console.WriteLine("El resultado es: " + resultado);
            break;
    }
   
    static void Suma()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 + num2;

        Console.WriteLine($"El resultado de la suma es: {resultado}");
    }

    static void Resta()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 - num2;

        Console.WriteLine($"El resultado de la resta es: {resultado}");
    }

    static void Multiplicar()
    {
        Console.Write("Ingrese el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        double resultado = num1 * num2;

        Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
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
    
    // TODO: Implementar funciones de suma, resta y división
}}


using System;

class Program
{
    static void Main(string[] args)
    {
        int n;

        do
        {
            Console.Write("Ingrese un número entero positivo mayor que cero: ");
            n = Convert.ToInt32(Console.ReadLine());
        } while (n <= 0);

        Console.WriteLine($"El número ingresado es: {n}");
    }
}


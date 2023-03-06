using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduzca el valor de N: ");
        int n = int.Parse(Console.ReadLine());

        while (n >= 1)
        {
            Console.Write(n + " ");
            n--;
        }

        Console.WriteLine("\nPresione cualquier tecla para salir.");
        Console.ReadKey();
    }
}
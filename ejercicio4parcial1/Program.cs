int n;
Console.Write("Ingrese un número entero positivo : ");
n = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= n; i++)
{
    if (i % 3 == 0 && i % 5 == 0) 
    {
        Console.WriteLine(i); 
    }
}

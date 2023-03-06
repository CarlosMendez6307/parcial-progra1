
int n ; 
int sumaPares = 0; 
Console.Write("Ingrese un número entero positivo mayor que cero: ");
n = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i <= n; i += 2)
{
    sumaPares += i;
}

Console.WriteLine("La suma de los números enteros positivos pares menores o iguales que {0} es {1}", n, sumaPares);
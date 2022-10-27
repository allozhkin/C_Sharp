// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника



float Factorial(int n)
{
    float i, x = 1;
    for (i = 1; i < n; i++)
    {
        x *= i;
    }
    return x;
}


Console.WriteLine("ВВедите количество строк треугольника: ");
int rows = int.Parse(Console.ReadLine() ?? "0");


for (int i = 0; i < rows; i++)
{
    for (int c = 0; c <= (rows - i); c++)
    {
        Console.Write(" ");
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write(" ");
        Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
    }
    Console.WriteLine();
    Console.WriteLine();
}
Console.WriteLine();
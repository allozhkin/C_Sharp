// Показать натуральные числа от M до N, N и M заданы

void HigherNumbers(int m, int n)
{

    if (m <= n)
    {
        Console.Write(m + " ");
        HigherNumbers(m + 1, n);
    }

}
void LowerNumber(int m, int n)
{
    if (m >= n)
    {
        Console.Write(m + " ");
        LowerNumber(m - 1, n);
    }
}
Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("ВВедите число: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
if (numberA < numberB)
{
    HigherNumbers(numberA, numberB);
}
else if (numberA > numberB)
{
    LowerNumber(numberA, numberB);
}
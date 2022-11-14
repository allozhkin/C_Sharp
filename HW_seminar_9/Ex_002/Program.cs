// Найти сумму элементов от M до N, N и M заданы
int Summ(int m, int n)
{
    if (m == n) return m;
    return m + Summ(m + 1, n);
}

Console.WriteLine("Введите число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");

if (numberA > numberB) Console.Write(Summ(numberB, numberA));
else if (numberB > numberA) Console.Write(Summ(numberA, numberB));
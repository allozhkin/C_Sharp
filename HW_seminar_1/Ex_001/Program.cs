// Задание 1.

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

if (numA == numB * numB)
{
    Console.Write("Первое число является квадратом второго числа");
}
else
{
    Console.Write("Первое число не является квадратом второго числа");
}
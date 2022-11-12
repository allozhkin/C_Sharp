// Показать натуральные числа от 1 до N, N задано

void Num(int number, int num)
{
    if (number <= num)
    {
        Console.Write(number + "");
        Num(number + 1, num);
    }
}
Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Num(1, number);
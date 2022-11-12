// Показать натуральные числа от N до 1, N задано

void Num(int number1, int number2)
{
    if (number1 >= number2)
    {
        Console.Write($"{number1} ");
        Num(number1 - 1, number2);
    }
}

Console.WriteLine("введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Num(number, 1);
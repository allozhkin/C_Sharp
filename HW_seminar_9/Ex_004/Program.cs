// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих.
// Первые два элемента последовательности задаются пользователем
void ShowNumbers(int first, int second, int i, int longg)
{
    if (i <= longg)
    {
        int sum = first + second;
        Console.Write($"{sum} ");
        ShowNumbers(second, sum, i + 1, longg);
    }
}

Console.WriteLine("введите число: ");
int firstNumber = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите число: ");
int secondNumber = int.Parse(Console.ReadLine() ?? "0");

ShowNumbers(firstNumber, secondNumber, 1, 10);
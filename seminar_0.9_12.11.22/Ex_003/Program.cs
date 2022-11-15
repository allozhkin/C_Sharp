// Найти сумму цифр числа

int SummNumbers(int number)
{
    if (number == 0) return 0;
    return (number % 10) + SummNumbers(number / 10);
}
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int summ = SummNumbers(number);
Console.WriteLine(summ);
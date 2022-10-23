// Определить количество цифр в числе

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine() ?? "0");

int num1 = 1;

while (num > 10)
{
    num = num / 10;
    num1++;
}
Console.WriteLine("В данном числе " + num1 + " символа(ов)!");
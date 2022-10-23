// Подсчитать сумму цифр в числе
Console.WriteLine("Введите число!");
int num = int.Parse(Console.ReadLine() ?? "0");

int index = 1;


while (num > 10)
{
    num = num / 10;
    index++;
}
Console.WriteLine(index);
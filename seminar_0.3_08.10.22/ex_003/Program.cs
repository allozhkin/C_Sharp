// Возвести натуральное число в степень
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

int sum = 1;

for(int i = 0; i < b; i++)
{
    sum = sum * b;
}
 Console.WriteLine(sum);
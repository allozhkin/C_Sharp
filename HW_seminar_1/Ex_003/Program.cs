// Найти максимальное из трех чисел


Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите третье число: ");
int numberC= int.Parse(Console.ReadLine() ?? "0");

int max = numberA;

if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.WriteLine("max digit is: ");
Console.Write(max);
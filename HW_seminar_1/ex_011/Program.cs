// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите любое число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
int numberB = 4;

if (numberA % numberB == 0)
{
    Console.WriteLine("Число кратно  " + numberB);
}
else
{
    Console.WriteLine("Остаток от деления числа " + numberA + "  делённое на 4 = " + numberA % numberB);
}
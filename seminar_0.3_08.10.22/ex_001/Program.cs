// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int index = 1;

while (index <= number)
{
    Console.WriteLine( index + "^2 = " + Math.Pow(index, 2));
    index++;
}
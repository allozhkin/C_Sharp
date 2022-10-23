// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число: ");
int digit = int.Parse(Console.ReadLine() ?? "0");
int count = 1;
int summ = 0;

while (count <= digit)
{
    summ = digit + count;
    count++;
}
Console.WriteLine($"summa chisel {summ}");
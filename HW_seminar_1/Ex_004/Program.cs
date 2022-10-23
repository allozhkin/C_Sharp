// Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.Write("Число четное!");
}
else
{
    Console.Write("Число не четное");
}
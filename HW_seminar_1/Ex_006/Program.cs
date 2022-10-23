// Показать четные числа от 1 до N
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());
int start = 0;

while (start <= n)
{
    Console.WriteLine(start);
    start=start+2;
}
Console.WriteLine("Введите число X: ");
int x = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число Y: ");
int y = int.Parse(Console.ReadLine() ?? "0");

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая четыерть");
}
if (x < 0 && y > 0)
{
    Console.WriteLine("Второая четыерть");
}
if (x < 0 && y < 0)
{
    Console.WriteLine("Третья четыерть");
}
if (x > 0 && y < 0 )
{
    Console.WriteLine("Четверть четыерть");
}
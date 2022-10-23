// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Введите первое число: ");
int first = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Вы ввели - " + first);


Console.WriteLine("Введите второе число: ");
int second = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Вы ввели - " + second);

if (first > 0 && second > 0)
{
    Console.WriteLine("Вы в I четверти");
}
else if (first < 0 && second > 0)
{
    Console.WriteLine("Вы в II четверти");
}
else if ( first > 0 && second < 0 )
{
    Console.WriteLine("Вы в III четверти");
}
else if ( first < 0 && second < 0)
{
    Console.WriteLine("Вы в IV четверти");
}
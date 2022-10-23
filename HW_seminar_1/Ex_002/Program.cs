// Задание 2: По заданному номеру дня недели вывести его название


Console.WriteLine("Введите число от одного до семи: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.Write("Понедельник");
}
if (num == 2)
{
    Console.Write("Вторник");
}
if (num == 3)
{
    Console.Write("Среда");
}
if (num == 4)
{
    Console.Write("Четверг");
}
if (num == 5)
{
    Console.Write("Пятница");
}
if (num == 6)
{
    Console.Write("Суббота");
}
if (num == 7)
{
    Console.Write("Воскресенье");
}
else
{
    Console.Write("Вы ввели не верное число!");
}
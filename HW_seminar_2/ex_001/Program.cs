// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine("Введите число от 1 до 7: ");
int day = int.Parse(Console.ReadLine() ?? "0");
int sunday = 7;
int satday = 6;



if (day == sunday)
{
    Console.WriteLine("Воскресенье это выходной день!");
}
else if (day == satday)
{
    Console.WriteLine("Суббота это выходной день!");
}
else 
{
    Console.WriteLine("Это будний день");
}
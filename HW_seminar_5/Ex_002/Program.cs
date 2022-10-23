// Написать программу масштабирования фигуры
Console.WriteLine("Введите координаты: ");
float x1 = float.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите координаты: ");
float x2 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты: ");
float y1 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите координаты: ");
float y2 = float.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Во сколько раз увеличить фигуру? : ");
float k = float.Parse(Console.ReadLine() ?? "0");

float[] array = {x1, x2, y1, y2};
Console.WriteLine($"Фигура была увеличенна в {k} раз(а), новые координаты фигуры: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] *= k;
    Console.Write($"({array[i]}), ");
}
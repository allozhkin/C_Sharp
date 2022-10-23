// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

void Fillmassive(int[] array, int min, int max)
{
    Random random = new Random();
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }
    }
}
void Printmassive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("ВВедите минимальное значение массива: ");
int Min = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("ВВедите максимальное значение массива: ");
int Max = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("ВВедите длинну массива: ");
int longg = int.Parse(Console.ReadLine() ?? "0");
int[] massiv = new int [longg];
Console.WriteLine();

Fillmassive(massiv, Min, Max +1);
Printmassive(massiv);
Console.WriteLine();

for (int i = 0; i <= massiv.Length / 2; i++)
{
    if ((massiv.Length % 2 == 1) && (i == massiv.Length / 2))
    {
        Console.WriteLine($"Длинна массива не четная, у числа {massiv[massiv.Length / 2]} нет пары!");
    }
    else 
    {
        Console.WriteLine($"Произведение чисел {massiv[i]} и {massiv[massiv.Length - 1 - i]} ровняется {massiv[i] * massiv[massiv.Length - 1 - i]}");
    }
}
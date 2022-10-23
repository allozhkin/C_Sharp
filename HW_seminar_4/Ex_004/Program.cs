// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

void FillMassiv (int[] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);
    }
}
void PrintMassiv (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Введите минимальное значение массива: ");
int Min = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите максимальное значение массива: ");
int Max = int.Parse(Console.ReadLine() ?? "0");
int[] massiv = new int [123];
FillMassiv(massiv, Min, Max+2);
PrintMassiv(massiv);
Console.WriteLine();
int amount = 0;
for (int i = 0; i < massiv.Length; i++)
{
    if (massiv[i] > 10 && massiv[i] < 99) amount++;
}
Console.WriteLine();
Console.WriteLine($"минимальное значение массива: {Min} максимальное значение массива: {Max} количество элементов из отрезка [10,99] {amount}");
// Найти сумму чисел одномерного массива стоящих на нечетной позиции
void Fillmassiv (int[] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);
    }
}
void Printmassiv (int[]array)
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
Console.WriteLine("ВВедите длинну массива: ");
int longg = int.Parse(Console.ReadLine() ?? "0");
int[] massive = new int [longg];
Console.WriteLine();
Fillmassiv(massive, Min, Max+1);
Printmassiv(massive);
Console.WriteLine();

int amount = 0;
for (int i = 0; i < massive.Length; i++)
{
    if (massive[i] % 2 != 0) amount += massive[i];
}
Console.WriteLine($"Cумма чисел массива стоящих на нечетной позиции = {amount}");
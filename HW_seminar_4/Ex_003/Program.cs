// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void FillnumA (int[] arr)
{
    Random random = new Random();
    for (int index = 0; index < arr.Length; index++)
    {
        arr[index] = random.Next(100, 1000);
    }
}
void PrintNumA (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


Console.WriteLine();
Console.Write("Введите длинну массива:");
int dlinna = int.Parse(Console.ReadLine() ?? "0");
int[] Array = new int[dlinna];
FillnumA(Array);
PrintNumA(Array);


int even = 0;
int odd = 0;
for (int index = 0; index < Array.Length; index++)
{
    if (Array[index] % 2 == 0 )
    {
        even++;
    }
    else if (Array[index] % 2 != 0)
    {
        odd++;
    }
}
Console.WriteLine();
Console.WriteLine($"Колличество четных чисел: {even}");
Console.WriteLine($"Колличество нечетных чисел: {odd}"); 
// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

void FillnumA (int[] array)
{
    Random random = new Random ();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
}
void PrintNumA (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
}
Console.WriteLine();

int[] numa = new int[12];
FillnumA(numa);
PrintNumA(numa);
int pol = 0;
int otr = 0;
for(int i = 0; i < numa.Length; i++)
{
    if (numa[i] < 0)
    {
        otr += numa[i];
    }
    else if (numa[i] > 0)
    {
        pol += numa[i];
    }
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел: {pol}");
Console.WriteLine($"Сумма отрицательных чисел: {otr}");

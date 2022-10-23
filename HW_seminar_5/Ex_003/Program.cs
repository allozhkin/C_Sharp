// Написать программу копирования массива
void FillArray (int[] array, int min, int max)
{
    Random random = new Random();
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max);
        }
    }
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void CopyArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i];
    }
}
Console.WriteLine("ВВедите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("ВВедите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("ВВедите длинну массива: ");
int longg = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int [longg];
Console.WriteLine();
FillArray(array, min,max);
Console.Write("Ваш массив: ");
PrintArray(array);
Console.WriteLine();
CopyArray(array);
Console.Write("Копия вашего массива: ");
PrintArray(array);
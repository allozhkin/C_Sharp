

void FillMatrix(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 9);
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Введите колличество строк: ");
int stroki = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите колличество столбов: ");
int stolbi = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[stroki, stolbi];
FillMatrix(array);
PrintMatrix(array);


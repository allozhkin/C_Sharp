// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

void FillMasiv(int[,] massiv)
{
    Random E1 = new Random();
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            massiv[i, j] = E1.Next(1, 20);
        }
    }
}
void PrintMassiv(int[,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            Console.Write($"{massiv[i, j]} ");
        }
        Console.WriteLine();
    }
}


string ArithmeticMean(int[,] array)
{
    string result = string.Empty;
    for (int n = 0; n < array.GetLength(1); n++)
    {
        int sum = 0;
        int count = 0;
        double mean = 0;
        for (int m = 0; m < array.GetLength(0); m++)
        {
            sum += array[m, n];
            count++;
        }
        mean = sum / count;
        result += mean.ToString() + " ";
    }
    return result;
}

Console.Write("Введите число строк: ");
int stroki = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите число столбцов: ");
int stolb = int.Parse(Console.ReadLine() ?? "0");

int[,] array = new int[stroki, stolb];

FillMasiv(array);
PrintMassiv(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));
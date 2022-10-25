// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
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
double[] FillArray(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Строка {i + 1} ровна {array[i]} ");
    }
}
int FindMin(double[] array)
{
    int indexRow = 0;
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            indexRow = i;
        }
    }
    return indexRow;
}
Console.WriteLine("Введите количество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);
double[] array = FillArray(matrix);
PrintArray(array);
Console.WriteLine();
int res = FindMin(array) + 1;
Console.WriteLine($"Строка с наименьшей суммой элементов: {res}");